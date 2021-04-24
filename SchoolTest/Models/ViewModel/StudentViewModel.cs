using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolTest.Models.ViewModel
{
    public class StudentViewModel
    {
        public int StudentId { get; set; }
        [Display(Name = "نام")]
        [StringLength(100)]
        public string FirstName { get; set; }
        [Display(Name = "نام خانوادگی")]
        [StringLength(100)]
        public string LastName { get; set; }
        public int ClassId { get; set; }

        [Display(Name = "نام کلاس")]
        public string ClassName { get; set; }
    }
}
