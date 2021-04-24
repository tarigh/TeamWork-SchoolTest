using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis.Differencing;
using SchoolTest.Models;
using SchoolTest.Models.ViewModel;
using SchoolTest.Service.IRepository;

namespace SchoolTest.Controllers
{
    public class ClassController : Controller
    {
        private readonly IClassRepository _icr;

        public ClassController(SchoolContext context, IClassRepository icr)  // ctorf
        {
            _icr = icr;  // icr == interface class repository
        }
     
        public IActionResult Index()
        {
            var cl = _icr.GetAll();

            return View(cl);
        }
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(ClassViewModel model)
        {
            _icr.Set(model);
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int classId) /*man kodam kelas ra Edit konam*/
        {

            var cl = _icr.Get(classId);

            return View(cl);
        }
        
        [HttpPost]
        public IActionResult Edit(ClassViewModel model)
        {
           _icr.Update(model);
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int classId) /*man kodam kelas ra Edit konam*/
        {
            _icr.Delete(classId);
            return RedirectToAction("Index");
        }
    }
}
