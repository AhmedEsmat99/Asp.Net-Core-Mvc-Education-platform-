using Education_platform.Models;
using Education_platform.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace Education_platform.Repository
{
    public class InstructorRepository : IInstructorRepository
    {
        ProjectDb db;
        public InstructorRepository(ProjectDb _db)
        {
            db = _db;
        }
        public List<Instructor> GetAll()
        {
            return db.Instructors.ToList();
        }
        public Instructor GetById(int id)
        {
            return db.Instructors.FirstOrDefault(i => i.Id == id);
        }
        public List<Instructor> GetAllByIdDept(int id)
        {
            return db.Instructors.Where(i => i.IdDept == id).ToList();
        }
        public Instructor GetByEmail(string Email)
        {
            return db.Instructors.FirstOrDefault(i => i.Email == Email);
        }
        public int Insert(InstructorViewModel VInst)
        {
            Instructor Inst = new Instructor();
            Inst.Name = VInst.Name;
            Inst.Age = VInst.Age;
            Inst.Adress = VInst.Adress;
            Inst.Gender = VInst.Gender;
            Inst.Image = VInst.Image.FileName;
            Inst.Phone = VInst.Phone;
            Inst.Email = VInst.Email;
            Inst.IdDept = VInst.Idept;
            db.Instructors.Add(Inst);
            return db.SaveChanges();
        }
        public int Update(int id, InstructorViewModel VInst)
        {
            if (VInst.Image != null)
            {
            Instructor OldData = GetById(id);
            OldData.Name = VInst.Name;
            OldData.Age = VInst.Age;
            OldData.Adress = VInst.Adress;
            OldData.Gender = VInst.Gender;
            OldData.Image = VInst.Image.FileName;
            OldData.Phone = VInst.Phone;
            OldData.IdDept = VInst.Idept;
                return db.SaveChanges();
            }
            else
            {
                Instructor OldData = GetById(id);
                OldData.Name = VInst.Name;
                OldData.Age = VInst.Age;
                OldData.Adress = VInst.Adress;
                OldData.Gender = VInst.Gender;
                OldData.Image = VInst.ExistingImage;
                OldData.Phone = VInst.Phone;
                OldData.IdDept = VInst.Idept;
                return db.SaveChanges();
            }
        }
        public int Delet(int id)
        {
            
            db.Instructors.Remove(GetById(id));
            return db.SaveChanges();
        }
        public int CrsInst(InstructorViewModel Iview)
        {
            InstructorCourses instructorCourses = new InstructorCourses();
            instructorCourses.InstructorId = Iview.IdInst;
            instructorCourses.CoursesId = Iview.IdCrs;
            db.InstructorCourses.Add(instructorCourses);
            return db.SaveChanges();
        }
        public List<InstructorCourses> GetInstCrsByIdInst(int IdInst)
        {
            return db.InstructorCourses.Where(I=>I.InstructorId == IdInst).ToList();
        }
        public int DeletCourse(int IdCrs, int IdInst)
        {
            InstructorCourses result = db.InstructorCourses.FirstOrDefault(I=>I.CoursesId == IdCrs &&I.InstructorId == IdInst);
            db.InstructorCourses.Remove(result);
            return db.SaveChanges(); 
        }
        public InstructorViewModel Convert(int id)
        {
            Instructor Inst = GetById(id);
            InstructorViewModel VInst = new InstructorViewModel();
            VInst.Id = Inst.Id;
            VInst.Name = Inst.Name;
            VInst.Age = Inst.Age;
            VInst.Adress = Inst.Adress;
            VInst.Phone = Inst.Phone;
            VInst.Gender = Inst.Gender;
            VInst.ExistingImage = Inst.Image;
            VInst.Idept = Inst.IdDept;
            return VInst;
        }
		public int InsertEvaluation(ResultStudent RS)
		{
            db.ResultStudents.Add(RS);
            return db.SaveChanges();
		}
        public ResultStudent ConvertEvaluation(int IdDept, int IdStd, int IdInst)
        {
            ResultStudent resultStudent =new ResultStudent();
            resultStudent.DpartmentId = IdDept;
            resultStudent.IdStudent = IdStd;
            resultStudent.InstructorId = IdInst;
            return resultStudent ;

        }
    }
}
