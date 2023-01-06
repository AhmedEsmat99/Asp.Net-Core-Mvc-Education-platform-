using Education_platform.Models;
using Education_platform.Repository;
using Education_platform.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace Education_platform.Controllers
{
	public class CoursesController : Controller
	{
		private readonly SignInManager<IdentityUser> signInManager;
		private readonly IDepartmentRepository IDept ;
		private readonly IStudentRepository IStd;
		private readonly IInstructorRepository IInst;
		ProjectDb db;
		public CoursesController(SignInManager<IdentityUser> _signInManager,
            IDepartmentRepository _IDept,
            IStudentRepository _IStd,
            IInstructorRepository _iInst,
            ProjectDb _db)
        {
            signInManager = _signInManager;
            IDept = _IDept;
            IStd = _IStd;
            IInst = _iInst;
            db = _db;
        }
        public IActionResult Index(int id)
		{
            if (id != 0)
            {
				ViewBag.AllDept = IDept.GetAll();
				StudentViewModel VStd = IStd.Convert(id);
				return View(VStd);
            }
            else
            {
				ViewBag.AllDept = IDept.GetAll();
				return View();
            }

		}
        [HttpGet]
		public IActionResult AllInst(int idDept, int idStd)
        {
			if(idStd != 0)
            {
				ViewBag.AllInstInDept= IInst.GetAllByIdDept(idDept);
				StudentViewModel VStd = IStd.Convert(idStd);
				return View(VStd);
            }
            else
            {
				ViewBag.AllInstInDept = IInst.GetAllByIdDept(idDept);
			    return View();
			}
		}
		[HttpGet]
		public IActionResult DetailsDepartment(int idDept, int idStd, int idInst)
		{
			if(idStd != 0)
            {
				var cheack = db.studentCourses.FirstOrDefault(s=>s.InstructorId == idInst && s.DepratmentId == idDept && s.StudentId == idStd);
				if (cheack != null)
				{
					ViewData["exsist"] = "exsist";
					ViewBag.idInst = idInst;
					ViewBag.idDept = idDept;
					StudentViewModel VStd = IStd.Convert(idStd);
					return View(VStd);
				}
				else
				{
					ViewBag.idInst = idInst;
					ViewBag.idDept = idDept;
					StudentViewModel VStd = IStd.Convert(idStd);
					return View(VStd);
				}
            }
            else
            {
				ViewBag.idInst = idInst;
				ViewBag.idDept = idDept;
				return View();
			}
		}
		public IActionResult RegisterCourses(int IdDept, int IdStd, int IdInst)
        {
			IStd.RegisCrs(IdDept, IdStd, IdInst);
			StudentViewModel VStd =IStd.Convert(IdStd);
			return RedirectToAction("Profile", "Student",VStd);
        }
		public async Task<IActionResult> Logout()
		{
			await signInManager.SignOutAsync();
			return RedirectToAction("Login");
		}
	}
}
