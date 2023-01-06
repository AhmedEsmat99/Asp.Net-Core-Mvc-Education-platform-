using Education_platform.Models;
using Education_platform.Repository;
using Education_platform.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Education_platform.Controllers
{
    public class StudentController : Controller
    {
        private readonly UserManager<IdentityUser> userManger;
        private readonly SignInManager<IdentityUser> signInManager;
        private readonly IHostingEnvironment hosting;
        private readonly IStudentRepository StdRepo;
        private readonly IDepartmentRepository IDept;
        ProjectDb db;

        public StudentController(ProjectDb _db,IHostingEnvironment _hosting,
            UserManager<IdentityUser> _userManager, SignInManager<IdentityUser> _signInManager,
            IStudentRepository _StdRepo,
            IDepartmentRepository _IDept)
        {
            userManger = _userManager;
            signInManager = _signInManager;
            hosting = _hosting;
            StdRepo = _StdRepo;
            db=_db;
            IDept=_IDept;
        }
        public IActionResult Index()
        {
            ViewBag.DataDept = IDept.GetAll();
            var user = userManger.FindByIdAsync(userManger.GetUserId(HttpContext.User));
            if (user.Result != null) { 
                var email = user.Result.Email;
                if( email != null)
                {
                    Student student = StdRepo.GetByEmil(email);
                    StudentViewModel vstd = StdRepo.Convert(student.Id);
                    return View(vstd);
                }
            }
            return View();
        }
        public IActionResult Profile(int id , StudentViewModel VStd)
        {
            if(id == 0)
            {
                ViewBag.AllCoursesStd= db.studentCourses.Where(s=>s.StudentId == id).ToList();
                StudentViewModel vstd = StdRepo.Convert(VStd.Id);
                return View(vstd);
            }
            else
            {
                ViewBag.AllCoursesStd= db.studentCourses.Where(s=>s.StudentId == id).ToList();
                StudentViewModel vstd = StdRepo.Convert(id);
                return View(vstd);
            }
        }
        [HttpGet]
        public IActionResult DetailsEvaluation(int id,int iddept, int idinst)
        {
            ViewBag.dept=iddept;
            ViewBag.inst = idinst;
            ViewBag.AllCoursesStd = db.studentCourses.Where(s => s.StudentId == id).ToList();
            StudentViewModel vstd = StdRepo.Convert(id);
            return View(vstd);
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            StudentViewModel vstd = StdRepo.Convert(id);
            return View(vstd);
        }
		[HttpPost]
		[ValidateAntiForgeryToken]
        public IActionResult Edit(StudentViewModel VStd)
		{
			if (ModelState.IsValid)
			{
				if (VStd.photo != null)
				{
                    string path = Path.Combine(hosting.WebRootPath, "Image/Student/", VStd.ExistingImage);
                    System.IO.File.Delete(path);
                    path = Path.Combine(hosting.WebRootPath, "Image/Student", VStd.photo.FileName);
                    FileStream fs;
                    VStd.photo.CopyTo(fs = new FileStream(path, FileMode.Create));
                    fs.Dispose();
                    VStd.ExistingImage = VStd.photo.FileName;
                }
                StdRepo.Update(VStd);
                return RedirectToAction("Profile", VStd);
			}
            return View(VStd);
		}
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(StudentViewModel Std)
        {
            if (ModelState.IsValid)
            {
                IdentityUser user = new IdentityUser();
                user.UserName = Std.Name;
                user.Email = Std.Email;
                IdentityResult result = await userManger.CreateAsync(user, Std.Password);
                if (result.Succeeded)
                {
                    //addStudentRole
                    await userManger.AddToRoleAsync(user, "Student");
                    //Creat Cookie
                    await signInManager.SignInAsync(user, false);

                }
                else
                {
                    foreach (var Error in result.Errors)
                    {
                        ModelState.AddModelError("", Error.Description);
                    }
                }
                if (Std.photo != null)
                {
                        var path = Path.Combine(hosting.WebRootPath, "Image/Student", Std.photo.FileName);
                    FileStream fs; Std.photo.CopyTo(fs = new FileStream(path, FileMode.Create));
                    fs.Dispose();
                }

                StdRepo.Insert(Std);
                return RedirectToAction("Index");

            }
            return View(Std);
        }
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Login" ,"Account");
        }
    }
}
