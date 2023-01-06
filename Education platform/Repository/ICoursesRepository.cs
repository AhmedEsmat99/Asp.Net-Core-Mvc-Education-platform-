using Education_platform.Models;
using Education_platform.ViewModels;
using System.Collections.Generic;

namespace Education_platform.Repository
{
    public interface ICoursesRepository
    {
        List<Courses> GetAll();
        Courses GetById(int id);
        int Insert(CoursesViewModel CrsView);
        CoursesViewModel Convert(int id);
        int Delet(int id);
        int Update(int id, CoursesViewModel Crs);
        //Courses GetCrsByIdDept(int id);
        int InsertCrsDept(CoursesDepartmentViewModel CD);
        List<CoursesDepartment> GetAllCrsDept();
        int DeletCoursesDepartment(int IdDept, int IdCrs);
    }
}