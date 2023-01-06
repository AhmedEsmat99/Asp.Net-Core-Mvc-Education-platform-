using Education_platform.Models;
using Education_platform.ViewModels;
using System.Collections.Generic;

namespace Education_platform.Repository
{
    public interface IDepartmentRepository
    {
        int Delet(int id);
        List<Department> GetAll();
        Department GetById(int id);
        int Insert(DepartmentViewModel VDept);
        int Update(int id, DepartmentViewModel Dept);
    }
}