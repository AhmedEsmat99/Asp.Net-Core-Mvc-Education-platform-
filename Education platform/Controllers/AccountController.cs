using Microsoft.AspNetCore.Authorization;
using Education_platform.ViewModels;
using Microsoft.AspNetCore.Identity;
using Education_platform.Repository;
using Microsoft.AspNetCore.Hosting;
using Education_platform.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.Dynamic;
using System.Linq;
using System.IO;
namespace Education_platform.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<IdentityUser> userManager;
        private readonly SignInManager<IdentityUser> signInManager;
        private readonly IHostingEnvironment hosting;
        private readonly IDepartmentRepository IDept;
        private readonly ICoursesRepository ICrs;
        private readonly IInstructorRepository IInst;
        private readonly ProjectDb db;
        public AccountController(UserManager<IdentityUser> _userManager,
			SignInManager<IdentityUser> _signInManager,
			IHostingEnvironment _hosting,
			IDepartmentRepository _IDept,
            IInstructorRepository _IInst,
            ICoursesRepository _ICrs,
            ProjectDb db)
		{
			userManager = _userManager;
			signInManager = _signInManager;
			hosting = _hosting;
			IDept = _IDept;
            ICrs = _ICrs;
            IInst = _IInst;
			this.db = db;
		}

		[Authorize(Roles ="Admin")]
        public IActionResult Index()
        {
            return View();
        }

        #region Department

        //----------- Department  
        [Authorize(Roles = "Admin")]

        public IActionResult Department()
		{
            return View();
		}
        //Add
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddDept(DepartmentViewModel Dept)
        {
            if (ModelState.IsValid)
            {
                if (Dept.Image != null)
                {
                    string Folder = "image/Department/";
                    string uploads = Path.Combine(hosting.WebRootPath, Folder);
                    string FileName = Dept.Image.FileName;
                    string FullPath = Path.Combine(uploads, FileName);
                    FileStream FS;
                    Dept.Image.CopyTo(FS =new FileStream(FullPath, FileMode.Create));
                    FS.Dispose();
				}
				IDept.Insert(Dept);
                return RedirectToAction("Department");
			}
            else
                return View("Department", Dept);
        }
        //Delet
        public IActionResult DeletDept(int id)
		{
            Department DEPT = IDept.GetById(id);
            string FullPath = Path.Combine(hosting.WebRootPath, "image/Department/", DEPT.image);
            System.IO.File.Delete(FullPath);
            IDept.Delet(id);
            return RedirectToAction("Department");
		}
		//Edit
		[Authorize(Roles ="Admin")]
		[HttpGet]
        public IActionResult EditDepartment(int id)
		{
            DepartmentViewModel vdept = new DepartmentViewModel();
            Department Dept = IDept.GetById(id);
            vdept.Id = Dept.Id;
            vdept.NameDepratment = Dept.Name;
            vdept.Description = Dept.Description;
            vdept.NameManger = Dept.NameManger;
            vdept.ExistingImage = Dept.image;
            ViewBag.img = Dept.image;
            return View(vdept);
		}

        [HttpPost]
		[ValidateAntiForgeryToken]
        public IActionResult EditDepartment(int id ,DepartmentViewModel dept)
        {
            if (ModelState.IsValid)
            {
                if (dept.Image != null)
                {

                    string Folder = "image/Department/";
                    string filePath = Path.Combine(hosting.WebRootPath,Folder);
                    string FileName = dept.ExistingImage;
                    string FullPath = Path.Combine(filePath,FileName);
                    System.IO.File.Delete(FullPath);
                    string uploads = Path.Combine(hosting.WebRootPath, Folder);
                    FileName = dept.Image.FileName;
                    FullPath = Path.Combine(uploads, FileName);
                    FileStream fs;
                    dept.Image.CopyTo( fs = new FileStream(FullPath, FileMode.Create));
                    fs.Dispose();
                    IDept.Update(id, dept); 
                    return RedirectToAction("Department");
                }
                else
                {
                    
                    IDept.Update(id, dept);
                    return RedirectToAction("Department");
                }
            }
			return View(dept);
        }
        #endregion

        #region Course
        //Course
        //AddCourses
		[Authorize(Roles ="Admin")]
        [HttpGet]
        public IActionResult Courses()
        {
            ViewBag.ListCourses = ICrs.GetAll();
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddCourses(CoursesViewModel Crs)
        {
            if (ModelState.IsValid)
            {
                if(Crs.Image != null)
                {
                    string path = Path.Combine(hosting.WebRootPath, "Image/Courses");
                    string FullPath = Path.Combine(path, Crs.Image.FileName);
                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                    }
                    FileStream fs;
                    Crs.Image.CopyTo(fs = new FileStream(FullPath, FileMode.Create));
                    fs.Dispose();
                }
                ICrs.Insert(Crs);
                return RedirectToAction("Courses");
            }
            return View("Courses", Crs);
        }
        //Edit Course
		[Authorize(Roles ="Admin")]
        [HttpGet]
        public IActionResult EditCourse(int id)
        {
            Courses Crs = ICrs.GetById(id);
            ViewBag.img = Crs.Image;
            CoursesViewModel VCrs = ICrs.Convert(id);
            return View(VCrs);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditCourse(CoursesViewModel Crs )
        {
            if (ModelState.IsValid)
            {
                if (Crs.Image != null)
                {
                    string path = Path.Combine(hosting.WebRootPath, "Image/Courses/", Crs.ExistingImage);
                    System.IO.File.Delete(path);
                    path = Path.Combine(hosting.WebRootPath, "Image/Courses", Crs.Image.FileName);
                    FileStream fs;
                    Crs.Image.CopyTo(fs = new FileStream(path, FileMode.Create));
                    fs.Dispose();
                    ICrs.Update(Crs.Id, Crs);
                    return RedirectToAction("Courses");
                }
                ICrs.Update(Crs.Id, Crs);
                return RedirectToAction("Courses");
            }
            return View();
        }
        //DeletCourse
        public IActionResult DeletCourse(int id)
        {
            Courses courses = ICrs.GetById(id);
            string FullPath = Path.Combine(hosting.WebRootPath, "Image/Courses/", courses.Image);
            System.IO.File.Delete(FullPath);
            ICrs.Delet(id);
            return RedirectToAction("Courses");
        }
        //CoursesDept
        [HttpGet]
        public IActionResult CoursesDept(CoursesDepartmentViewModel Dept)
        {
            ViewBag.AllDept = IDept.GetAll();
            ViewBag.AllCrs = ICrs.GetAll();
            if (Dept.IdDept != 0)
            {
                Department department = IDept.GetById(Dept.IdDept);
                Dept.NameDept = department.Name;
            }
            ViewBag.AllCrsDept = ICrs.GetAllCrsDept();
            return View(Dept);
        }
        [HttpPost]
        public IActionResult Dept(int Id)
        {
            if (Id == 0)
                return RedirectToAction("CoursesDept");
            else
            {
            Department Dept = IDept.GetById(Id);
            CoursesDepartmentViewModel VDept = new CoursesDepartmentViewModel();
            VDept.IdDept = Dept.Id;
            VDept.NameDept = Dept.Name;
            return RedirectToAction("CoursesDept", VDept);
            }
        }
        [HttpPost]
        public IActionResult InsertCrsDept(CoursesDepartmentViewModel Dept)
        {
            if (Dept.IdDept == 0 || Dept.IdCrs == 0)
            {
                return RedirectToAction("CoursesDept");
            }
            ICrs.InsertCrsDept(Dept);
            return RedirectToAction("CoursesDept",Dept);
        }
        public IActionResult DeletCrsDept(int IdDept,int IdCrs)
        {
            if(IdDept != 0 && IdCrs != 0)
            {
                ICrs.DeletCoursesDepartment(IdDept, IdCrs);
            }
            return RedirectToAction("CoursesDept");
        }
        #endregion

        #region Instructor

        [Authorize(Roles ="Admin")]
        public IActionResult Instructor()
        {
            ViewBag.ListInst = IInst.GetAll();
            ViewBag.ListDept = IDept.GetAll();
            return View();
        }
        //Add Instructor
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddInstructor(InstructorViewModel Inst)
        {
            if (ModelState.IsValid)
            {
                if (Inst.Email != null)
                {
                    IdentityUser user = new IdentityUser();
                    user.Email = Inst.Email;
                    user.UserName = Inst.Name;
                    IdentityResult result = await userManager.CreateAsync(user, Inst.Password);
                    if (result.Succeeded)
                    {
                        await userManager.AddToRoleAsync(user, "Instructor");
                        await signInManager.SignInAsync(user, false);
                    }
                    else
                    {
                        foreach (var error in result.Errors)
                        {
                            ModelState.AddModelError("", error.Description);
                        }
                    }
                }
                if (Inst.Image != null)
                {
                    string path = Path.Combine(hosting.WebRootPath, "Image/Instructor/");
                    string FullPath = Path.Combine(path, Inst.Image.FileName);
                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                    }
                    FileStream fs;
                    Inst.Image.CopyTo(fs = new FileStream(FullPath, FileMode.Create));
                    fs.Dispose();
                    IInst.Insert(Inst);
                    return RedirectToAction("Instructor");
                }
            }
            return View("Instructor", Inst);
        }
		[Authorize(Roles ="Admin")]
        [HttpGet]
        public IActionResult EditInstructor(int id )
        {

            Instructor Inst = IInst.GetById(id);
            ViewBag.img = Inst.Image;
            InstructorViewModel VInst = IInst.Convert(id);
            ViewBag.ListDepart = IDept.GetAll();
            TempData["idinst"] = Inst.IdDept;
            return View(VInst);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditInstructor(InstructorViewModel Inst)
        {
            if (ModelState.IsValid)
            {
                int ExistIdDept = ViewBag.Data =TempData["idinst"] ;
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
                    return RedirectToAction("Instructor");
                }
                else
                {
                    IInst.Update(Inst.Id, Inst);
                    return RedirectToAction("Instructor");
                }
            }
            return View();
        }
        public async Task<IActionResult>DeletInstructor(int id)
        {
            Instructor I = IInst.GetById(id);
            string FullPath = Path.Combine(hosting.WebRootPath, "image/Instructor/", I.Image);
            System.IO.File.Delete(FullPath);
            Instructor Inst = IInst.GetById(id);
            IdentityUser user = new IdentityUser();
            user.UserName = Inst.Name;
            user = await userManager.FindByNameAsync(user.UserName);
            if (user != null)
            {
                var result = await userManager.DeleteAsync(user);
                if (result.Succeeded == false)
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }
            }
            var AllCoursesInst = db.InstructorCourses.Where(I => I.InstructorId == id).ToList();
            if (AllCoursesInst != null)
            {
                db.InstructorCourses.RemoveRange(AllCoursesInst);
                db.SaveChanges();
            }
            if (id != 0)
            {
                IInst.Delet(id);
                return RedirectToAction("Instructor");
            }
            return RedirectToAction("Instructor");
        }
		[Authorize(Roles ="Admin")]
        [HttpGet]
        public IActionResult AddCoursesInstructor(int id , InstructorViewModel In )
        {
            if(id != 0)
			{
            Instructor Instv = IInst.GetById(id);
            InstructorViewModel model = new InstructorViewModel();
            model.IdInst = Instv.Id;
            model.Idept = Instv.IdDept;
            model.Name = Instv.Name;
            return View(model);
			}
			else
			{
                Instructor Instv = IInst.GetById(In.IdInst);
                InstructorViewModel model = new InstructorViewModel();
                model.IdInst = Instv.Id;
                model.Idept = Instv.IdDept;
                model.Name = Instv.Name;
                return View(model);
            }
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddCoursesInstructor(InstructorViewModel Inst)
        {
            if(Inst.IdCrs != 0 && Inst.Id !=0 )
            {   
                IInst.CrsInst(Inst);
                return RedirectToAction("AddCoursesInstructor");
            }
            return View(Inst);
        }
        public IActionResult DeletInstructorCourse(int IdCrs ,int IdInst)
        {
            IInst.DeletCourse(IdCrs, IdInst);
            ViewBag.IdInst=IdInst;
            InstructorViewModel instructorViewModel = new InstructorViewModel();
            Instructor INs = IInst.GetById(IdInst);
            instructorViewModel.IdInst = INs.Id;
            instructorViewModel.Idept = INs.IdDept;
            return RedirectToAction("AddCoursesInstructor", instructorViewModel);
        }
        public IActionResult DeletAllCoursesInstructtor(int Id)
        {
            var a =  db.InstructorCourses.Where(I=>I.InstructorId ==Id).ToList() ;
            db.InstructorCourses.RemoveRange(a);
            db.SaveChanges();
            return RedirectToAction("Instructor");
        }
        #endregion
        //CheckName
        public async Task<IActionResult> CheckEmail(string Email)
        {
            if(Email != null)
			{
                IdentityUser user = new IdentityUser();
                user.Email = Email;
                user = await userManager.FindByEmailAsync(user.Email);
                if (user == null)
					return Json(true);
                else
				return Json(false);
			}
			else
			{
                IdentityUser user = new IdentityUser();
                user.Email = Email;
                user = await userManager.FindByEmailAsync(user.Email);
				if (user == null)
					return Json(true);
				else
				{
					if (user.Email == Email)
						return Json(true);
					else
						return Json(false);
				}
			}
        }
        //Admin Register
        [Authorize(Roles = "Admin")]
        [HttpGet]
        public IActionResult RegisterAdmin()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [AllowAnonymous]
        public async Task<IActionResult> RegisterAdmin(AdminViewModel Account)
        {
            if (ModelState.IsValid)
            {
                IdentityUser user = new IdentityUser();
                user.Email = Account.Email;
                user.UserName = Account.UserName;
                user.PhoneNumber = Account.Phone;
               IdentityResult result = await userManager.CreateAsync(user ,Account.Password);
                if (result.Succeeded)
                {
                    //addStudentRole
                    await userManager.AddToRoleAsync(user, "Admin");
                    //Creat Cookie
                    await signInManager.SignInAsync(user, false);
                    return View("Login");
                }
                else
                {
                    foreach(var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
            }
            return View(Account);
        }
        //------------Login 
        [HttpGet]
        public IActionResult Login(string ReturnUrl = "Index")
        {
            ViewData["RedirectURL"] = ReturnUrl;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel LoginUser, string ReturnUrl = "Index")
        {
            if (ModelState.IsValid)
            {
                IdentityUser user = await userManager.FindByEmailAsync(LoginUser.Email);
                if (user != null)
                {
                    ////Creat Cookie
                    Microsoft.AspNetCore.Identity.SignInResult result =
                        await signInManager.PasswordSignInAsync(user, LoginUser.Password, LoginUser.RememberMe, false);
                    if (result.Succeeded)
                    {
                        var rolename = await userManager.GetRolesAsync(user);
                        if (rolename[0] == "Admin")
                            return RedirectToAction("Index");
                        else if (rolename[0] == "Student")
                            return RedirectToAction(ReturnUrl,"Student");
                        else if (rolename[0] == "Instructor")
                            return RedirectToAction("Index", "Instructor");
                        else
                                    return View();
                    }
                    else
                    {
                        ModelState.AddModelError("", "inCorrect UserName ,Password ");
                    }
                }
                else
                {
                    ModelState.AddModelError("", "IsValid username , password ");
                }
            }
            return View(LoginUser);
        }
        //Logout
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Login");
        }
    }
}
