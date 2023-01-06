using Education_platform.Models;
using Education_platform.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace Education_platform.Repository
{
    public class CoursesRepository : ICoursesRepository
    {
        ProjectDb db;
        public CoursesRepository(ProjectDb _db)
        {
            db = _db;
        }
        public List<Courses> GetAll()
        {
            return db.Courses.ToList();
        }
        public Courses GetById(int id)
        {
            return db.Courses.FirstOrDefault(c => c.Id == id);
        }
        //public Courses GetCrsByIdDept(int id)
        //{
        //    return db.Courses.FirstOrDefault(c => c.IdDept == id);
        //}
        public int Insert(CoursesViewModel CrsView)
        {
            Courses Crs = new Courses();
            Crs.Name = CrsView.NameCourses;
            Crs.Description = CrsView.Description;
            Crs.Degree = CrsView.Degree;
            Crs.MinDegree = CrsView.MinDegree;
            Crs.Image = CrsView.Image.FileName;
            db.Courses.Add(Crs);
            return db.SaveChanges();
        }
        public int Update(int id, CoursesViewModel Crs)
        {
            if (Crs.Image != null)
            {
                Courses OldData = GetById(id);
                OldData.Name = Crs.NameCourses;
                OldData.Degree = Crs.Degree;
                OldData.MinDegree = Crs.MinDegree;
                OldData.Description = Crs.Description;
                OldData.Image = Crs.Image.FileName;
                return db.SaveChanges();
            }
            else
            {
                Courses OldData = GetById(id);
                OldData.Name = Crs.NameCourses;
                OldData.Degree = Crs.Degree;
                OldData.MinDegree = Crs.MinDegree;
                OldData.Description = Crs.Description;
                OldData.Image = Crs.ExistingImage;
                return db.SaveChanges();
            }
        }
        public int Delet(int id)
        {
            db.Courses.Remove(GetById(id));
            return db.SaveChanges();
        }
        public CoursesViewModel Convert(int id)
        {
            Courses Crs = GetById(id);
            CoursesViewModel VCrs = new CoursesViewModel();
            VCrs.Id = Crs.Id;
            VCrs.NameCourses = Crs.Name;
            VCrs.Description = Crs.Description;
            VCrs.Degree = Crs.Degree;
            VCrs.MinDegree = Crs.MinDegree;
            VCrs.ExistingImage = Crs.Image;
            return VCrs;
        }
        public int InsertCrsDept(CoursesDepartmentViewModel CD)
        {
            CoursesDepartment coursesDepartment = new CoursesDepartment();
            coursesDepartment.DeaprtmentId = CD.IdDept;
            coursesDepartment.CoursesId = CD.IdCrs;
            db.coursesDepartments.Add(coursesDepartment);
            return db.SaveChanges();
        }
        public List<CoursesDepartment> GetAllCrsDept()
        {
            return db.coursesDepartments.ToList();
        }
        public int DeletCoursesDepartment(int IdDept, int IdCrs)
        {
           CoursesDepartment CD = db.coursesDepartments.FirstOrDefault(d => d.DeaprtmentId == IdDept && d.CoursesId == IdCrs );
            db.coursesDepartments.Remove(CD);
            return db.SaveChanges();
        }
    }
}
