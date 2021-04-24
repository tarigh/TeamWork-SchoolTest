using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SchoolTest.Models;
using SchoolTest.Models.ViewModel;
using SchoolTest.Service.IRepository;

namespace SchoolTest.Service.Repository
{
    public class StudentRepository : IStudentRepository

    {
        SchoolContext _context;
        public StudentRepository(SchoolContext content)
        {
            _context = content;
        }
        public void Delete(int studentId)
        {
            var itemModel = _context.Student.Find(studentId);
            _context.Student.Remove(itemModel);
            _context.SaveChanges();
        }

        public StudentViewModel Get(int studentId)
        {
            var item = _context.Student.Find(studentId);
            StudentViewModel studentView = new StudentViewModel()
            {
                StudentId = item.StudentId,
                FirstName = item.FirstName,
                LastName = item.LastName,
                ClassId = item.ClassId,
            };
            return studentView;
        }

        public IEnumerable<StudentViewModel> GetAll()
        {
            var itemStudentList = _context.Set<Student>().ToList();
            //var itemClass = _context.Set<Class>().ToList();

            var q = (from s in itemStudentList
                select new StudentViewModel()
                {
                    StudentId = s.StudentId,
                    FirstName = s.FirstName,
                    LastName = s.LastName,
                    ClassId = s.ClassId,


                }).ToList();


            //var q = (from c in itemClass
            //         join s in itemStudentList on c.ClassId equals s.ClassId
            //    select new StudentViewModel()
            //    {
            //        StudentId = s.StudentId,
            //        FirstName = s.FirstName,
            //        LastName = s.LastName,
            //        ClassName = c.Name,
            //        ClassId = s.ClassId,
            //    }).ToList();

            return q;
        }

        public void Set(StudentViewModel model)
        {
            Student studentModel = new Student()
            {
                StudentId = model.StudentId,
                FirstName = model.FirstName,
                LastName = model.LastName,
                ClassId = model.ClassId,
            };
            _context.Student.Add(studentModel);
            _context.SaveChanges();
        }

        public void Update(StudentViewModel model)
        {
            Student studentModel = new Student()
            {
                StudentId = model.StudentId,
                FirstName = model.FirstName,
                LastName = model.LastName,
                ClassId = model.ClassId,
            };

            _context.Student.Update(studentModel);
            _context.SaveChanges();
        }
    }
}
