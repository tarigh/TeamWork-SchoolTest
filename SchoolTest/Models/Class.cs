using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolTest.Models
{
    public class Class
    {
        [Key]
        public int ClassId { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        public ICollection<Student> Student { get; set; }
    }
}
