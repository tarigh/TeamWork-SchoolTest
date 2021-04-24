using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SchoolTest.Models;
using SchoolTest.Models.ViewModel;
using SchoolTest.Service.IRepository;

namespace SchoolTest.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentRepository _isr;

        public StudentController(SchoolContext context, IStudentRepository isr)  // ctorf
        {
            _isr = isr;  // icr == interface class repository
        }

        public IActionResult Index()
        {
            var cl = _isr.GetAll();

            return View(cl);
        }

        public IActionResult Add(int classId)
        {
            ViewBag.ClassId = classId;
            return View();
        }
        [HttpPost]
        public IActionResult Add(StudentViewModel model)
        {
            _isr.Set(model);
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int studentId) /*man kodam kelas ra Edit konam*/
        {
            var cl = _isr.Get(studentId);

            return View(cl);
        }

        [HttpPost]
        public IActionResult Edit(StudentViewModel model)
        {
            _isr.Update(model);
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int studentId) /*man kodam kelas ra Edit konam*/
        {
            _isr.Delete(studentId);
            return RedirectToAction("Index");
        }
    }
}
