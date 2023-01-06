using Education_platform.Models;
using Education_platform.Repository;
using Education_platform.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Linq;

namespace Education_platform.Controllers
{
    [Authorize(Roles = "Instructor")]
    public class InstructorController : Controller
    {
        private readonly UserManager<IdentityUser> userManager;
        private readonly IInstructorRepository IInst;
        private readonly IStudentRepository IStd;
        private readonly IDepartmentRepository IDept;
        private readonly IHostingEnvironment hosting;
        private readonly ProjectDb db;
        public InstructorController(UserManager<IdentityUser> _userManager,
            ProjectDb _db,
            IInstructorRepository _instructorRepository,
            IDepartmentRepository _iDept,
            IHostingEnvironment _hosting,
            IStudentRepository _iStd)
        {
            userManager = _userManager;
            db = _db;
            IInst = _instructorRepository;
            IDept = _iDept;
            hosting = _hosting;
            IStd = _iStd;
        }
        [Authorize(Roles = "Instructor")]
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.iduser = userManager.GetUserId(HttpContext.User);
            var user =userManager.FindByIdAsync(userManager.GetUserId(HttpContext.User));
            var email =user.Result.Email;
            if (email != null)
            {
                Instructor Inst = IInst.GetByEmail(email);
                ViewBag.InstCourse = IInst.GetInstCrsByIdInst(Inst.Id);
                return View(Inst);
            }
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddCoursesInstructor(int IdInst, int IdCrs)
        {
            if (IdCrs != 0 && IdInst != 0)
            {
                InstructorViewModel instCrs = new InstructorViewModel();
                instCrs.IdCrs = IdCrs;
                instCrs.IdInst = IdInst;

                IInst.CrsInst(instCrs);
                return RedirectToAction("Index");
            }
            return View("Index");
        }
        public IActionResult DeletCourse(int IdInst, int IdCrs)
        {
            if (IdCrs != 0 && IdInst != 0)
            {
                IInst.DeletCourse(IdCrs, IdInst);
                return RedirectToAction("Index");
            }
        return View("Index");
        }
        public IActionResult DeletAllCrs(int Id)
        {
            var a = db.InstructorCourses.Where(I => I.InstructorId == Id).ToList();
            db.InstructorCourses.RemoveRange(a);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        #region Profile
        //Profile
        [HttpGet]
        public IActionResult Profile(int id)
        {
            var Idinst =ViewBag.Data = TempData["idinst"];
            if (id != 0)
            {
                var Inst = IInst.GetById(id);
                return View(Inst);
            }
            else
            {
                var Inst = IInst.GetById(Idinst);
                return View(Inst);
            }

        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            Instructor Inst = IInst.GetById(id);
            ViewBag.img = Inst.Image;
            InstructorViewModel VInst = IInst.Convert(id);
            ViewBag.ListDepart = IDept.GetAll();
            return View(VInst);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(InstructorViewModel Inst,int ExistIdDept)
        {
            if (ModelState.IsValid)
            {
                TempData["idinst"] = Inst.Id;
                if (ExistIdDept != Inst.Idept)
                {
                    var DeletAll = db.InstructorCourses.Where(I => I.InstructorId == Inst.Id).ToList();
                    db.InstructorCourses.RemoveRange(DeletAll);
                    db.SaveChanges();
                }
                if (Inst.Image != null)
                {
                    string path = Path.Combine(hosting.WebRootPath, "Image/Instructor/", Inst.ExistingImage);
                    System.IO.File.Delete(path);
                    path = Path.Combine(hosting.WebRootPath, "Image/Instructor", Inst.Image.FileName);
                    FileStream fs;
                    Inst.Image.CopyTo(fs = new FileStream(path, FileMode.Create));
                    fs.Dispose();
                    IInst.Update(Inst.Id, Inst);
                    return RedirectToAction("Profile");
                }
                else
                {
                    IInst.Update(Inst.Id, Inst);
                    return RedirectToAction("Profile");
                }
            }
            return View(Inst);
        }
        #endregion
        #region Student
        [HttpGet]
        public IActionResult Student(int id)
        {
            Instructor inst = IInst.GetById(id);
            ViewBag.AllStudent = db.studentCourses.Where(I => I.InstructorId == inst.Id).ToList();
            return View(inst);
        }
		[HttpGet]
        public IActionResult EvaluationStudent(int IdDept, int IdStd, int IdInst,ResultStudent RS)
		{
            if ( IdDept ==0 && IdStd == 0 && IdInst == 0)
            {
                ResultStudent RSs = IInst.ConvertEvaluation(RS.DpartmentId, RS.IdStudent, RS.InstructorId);
                var ins = IInst.GetInstCrsByIdInst(RS.InstructorId);
                var std = IStd.GetById(RS.IdStudent);
                ViewBag.AllCourses = ins;
                ViewBag.Count = db.InstructorCourses.Where(I => I.InstructorId == RS.InstructorId).Count();
                ViewBag.NameStd = std.Name;
                return View(RSs);
            }
            else
            {

                ResultStudent RSs = IInst.ConvertEvaluation(IdDept, IdStd, IdInst);
                var ins = IInst.GetInstCrsByIdInst(IdInst);
                var std=IStd.GetById(IdStd);
                ViewBag.AllCourses = ins;
                ViewBag.NameStd = std.Name;
                ViewBag.Count = db.InstructorCourses.Where(I => I.InstructorId == IdInst).Count();
            return View(RSs);
            }
        }
		[HttpPost]
        public IActionResult EvaluationStudent(ResultStudent RS)
		{
			if (RS.Degree != null)
			{
                IInst.InsertEvaluation(RS);
			}
            Instructor inst = IInst.GetById(RS.InstructorId);
            return RedirectToAction("Student", inst);
		}
        [HttpGet]
        public IActionResult EditEvaluation(int idcrs, int iddept, int idinst, int idstd)
        {
            var Result = db.ResultStudents.FirstOrDefault(r => r.IdStudent == idstd && r.DpartmentId == iddept && r.InstructorId == idinst && r.IdCourse == idcrs);
            return View(Result);
        }
        [HttpPost]
        public IActionResult EditEvaluation(ResultStudent rs)
        {
            var Result = db.ResultStudents.FirstOrDefault(r => r.IdStudent == rs.IdStudent && r.DpartmentId == rs.DpartmentId && r.InstructorId == rs.InstructorId && r.IdCourse == rs.IdCourse);
            Result.Degree = rs.Degree;
            db.ResultStudents.Update(Result);
            db.SaveChanges();
            return RedirectToAction("EvaluationStudent", Result);
        }
        #endregion
    }
}
