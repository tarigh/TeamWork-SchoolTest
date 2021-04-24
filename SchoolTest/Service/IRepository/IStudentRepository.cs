using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SchoolTest.Models.ViewModel;

namespace SchoolTest.Service.IRepository
{
    public interface IStudentRepository
    {
        IEnumerable<StudentViewModel> GetAll();
        StudentViewModel Get(int studentId);
        void Update(StudentViewModel model);
        void Delete(int studentId);
        void Set(StudentViewModel model);
    }
}
