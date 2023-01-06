using Education_platform.Models;
using Education_platform.ViewModels;
using System.Collections.Generic;

namespace Education_platform.Repository
{
    public interface IStudentRepository
    {
        int Delet(int id);
        List<Student> GetAll();
        Student GetById(int id);
        Student GetByEmil(string id);
        int Insert(StudentViewModel std);
        int Update(StudentViewModel Vstd);
        StudentViewModel Convert(int id);
        int RegisCrs(int IdDept, int IdStd, int IdInst);
    }
}