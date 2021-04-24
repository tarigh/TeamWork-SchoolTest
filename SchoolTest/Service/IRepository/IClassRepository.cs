using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SchoolTest.Models.ViewModel;

namespace SchoolTest.Service.IRepository
{
    public interface IClassRepository
    {
        IEnumerable<ClassViewModel> GetAll();
        ClassViewModel Get(int classId);
        void Update(ClassViewModel model);
        void Delete(int classId);
        void Set(ClassViewModel model);
        //IEnumerable<ClassViewModel> SetAll();

    }
}
