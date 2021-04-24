using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SchoolTest.Models;
using SchoolTest.Models.ViewModel;
using SchoolTest.Service.IRepository;

namespace SchoolTest.Service.Repository
{

    public class ClassRepository : IClassRepository
    {
        SchoolContext _context;
        public ClassRepository(SchoolContext content)
        {
            _context = content;
        }

        public ClassViewModel Get(int classId)
        {
            var item = _context.Class.Find(classId);
            ClassViewModel classView = new ClassViewModel()
            {
                ClassId = item.ClassId,
                Name = item.Name,
            };
            return classView;
        }

        public IEnumerable<ClassViewModel> GetAll()
        {
            var itemList = _context.Set<Class>().ToList();
            var classViewModels = (from i in itemList
                select new ClassViewModel()
                {
                    ClassId = i.ClassId,
                    Name = i.Name
                }).ToList();

            return classViewModels;
        }

        public void Update(ClassViewModel model)
        {
            Class classModel = new Class()
            {
                ClassId = model.ClassId,
                Name = model.Name,
            };

            _context.Class.Update(classModel);
            _context.SaveChanges();
        }
        public void Delete(int classId)
        {
            var itemModel = _context.Class.Find(classId);
            _context.Class.Remove(itemModel);
            _context.SaveChanges();
        }

        public void Set(ClassViewModel model)
        {
            Class classModel = new Class()
            {
                ClassId = model.ClassId,
                Name = model.Name,
            };
            _context.Class.Add(classModel);
            _context.SaveChanges();
        }

        //public IEnumerable<ClassViewModel> SetAll()
        //{
        //    return ClassViewModel;
        //}
    }
}
