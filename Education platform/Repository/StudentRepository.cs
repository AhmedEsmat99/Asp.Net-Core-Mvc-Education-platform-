using Education_platform.Models;
using Education_platform.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace Education_platform.Repository
{
    public class StudentRepository : IStudentRepository
    {
        //CURD
        ProjectDb db;
        public StudentRepository(ProjectDb db)
        {
            this.db = db;
        }
        public List<Student> GetAll()
        {
            return db.Students.ToList();
        }
        public Student GetById(int id)
        {
            return db.Students.FirstOrDefault(s => s.Id == id);
        }
        public Student GetByEmil(string Email)
        {
            return db.Students.FirstOrDefault(s=>s.Email == Email);
        }
        public int Insert(StudentViewModel std )
        {
            Student student = new Student();
            student.Name = std.Name;
            student.Adress= std.Adress;
            student.Image = std.photo.FileName;
            student.Gender = std.Gender;
            student.Age = std.Age;
            student.Phone = std.Phone;
            student.Email = std.Email;

            db.Students.Add(student);
            return db.SaveChanges();
        }
        public int Update(StudentViewModel Vstd)
        {
            Student OldData = GetById(Vstd.Id);
			if (Vstd.photo == null)
			{
            OldData.Name = Vstd.Name;
            OldData.Adress = Vstd.Adress;
            OldData.Age = Vstd.Age;
            OldData.Image = Vstd.ExistingImage;
            OldData.Phone = Vstd.Phone;
            OldData.Gender = Vstd.Gender;
            }
			else
			{
                OldData.Name = Vstd.Name;
                OldData.Adress = Vstd.Adress;
                OldData.Age = Vstd.Age;
                OldData.Image = Vstd.photo.FileName;
                OldData.Phone = Vstd.Phone;
                OldData.Gender = Vstd.Gender;
            }
            return db.SaveChanges();
        }
        public int Delet(int id)
        {
            db.Students.Remove(GetById(id));
            return db.SaveChanges();
        }
        public StudentViewModel Convert(int id)
		{
            Student student =GetById(id);
            StudentViewModel vstd = new StudentViewModel();
            vstd.Name = student.Name;
            vstd.Adress = student.Adress;
            vstd.Age = student.Age;
            vstd.Gender = student.Gender;
            vstd.Email = student.Email;
            vstd.ExistingImage = student.Image;
            vstd.Phone = student.Phone;
            vstd.Id = student.Id;
            return vstd;
        }
        public int RegisCrs(int IdDept, int IdStd, int IdInst)
        {
            StudentCourse StdCrs = new StudentCourse();
            StdCrs.StudentId = IdStd;
            StdCrs.DepratmentId = IdDept;
            StdCrs.InstructorId= IdInst;
            db.studentCourses.Add(StdCrs);
            return db.SaveChanges();
        }
    }
}
