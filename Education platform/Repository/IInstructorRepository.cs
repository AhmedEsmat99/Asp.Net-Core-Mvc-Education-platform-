using Education_platform.Models;
using Education_platform.ViewModels;
using System.Collections.Generic;

namespace Education_platform.Repository
{
    public interface IInstructorRepository
    {
        int Delet(int id);
        List<Instructor> GetAll(); 
        Instructor GetById(int id);
        Instructor GetByEmail(string Email);
        int Insert(InstructorViewModel VInst);
        int Update(int id, InstructorViewModel VInst);
        int CrsInst(InstructorViewModel vInst);
        List<InstructorCourses> GetInstCrsByIdInst(int IdInst);
        int DeletCourse(int IdCourses, int IdInstructor);
        InstructorViewModel Convert(int id);
        List<Instructor> GetAllByIdDept(int id);
        int InsertEvaluation(ResultStudent RS);
        ResultStudent ConvertEvaluation(int IdDept, int IdStd, int IdInst);
    }
}