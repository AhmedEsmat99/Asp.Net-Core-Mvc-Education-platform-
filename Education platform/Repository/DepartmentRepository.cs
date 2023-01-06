using Education_platform.Models;
using Education_platform.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace Education_platform.Repository
{
    public class DepartmentRepository : IDepartmentRepository
    {
        ProjectDb db;
        public DepartmentRepository(ProjectDb _db)
        {
            db = _db;
        }
        public List<Department> GetAll()
        {
            return db.Departments.ToList();
        }
        public Department GetById(int id)
        {
            return db.Departments.FirstOrDefault(d => d.Id == id);
        }
        public int Insert(DepartmentViewModel VDept)
        {
            Department dept = new Department();
            dept.Name = VDept.NameDepratment;
            dept.NameManger = VDept.NameManger;
            dept.image = VDept.Image.FileName;
            dept.Description = VDept.Description;
            db.Departments.Add(dept);
            return db.SaveChanges();
        }
        public int Update(int id, DepartmentViewModel Dept)
        {
            if (Dept.Image != null)
            {
                Department OldData = GetById(id);
                OldData.Name = Dept.NameDepratment;
                OldData.NameManger = Dept.NameManger;
                OldData.Description = Dept.Description;
                OldData.image = Dept.Image.FileName;
                return db.SaveChanges();
            }
            else
            {
                Department OldData = GetById(id);
                OldData.Name = Dept.NameDepratment;
                OldData.NameManger = Dept.NameManger;
                OldData.Description = Dept.Description;
                OldData.image = Dept.ExistingImage;
                return db.SaveChanges();
            }
            
        }
        public int Delet(int id)
        {
            db.Departments.Remove(GetById(id));
            return db.SaveChanges();
        }
    }
}
