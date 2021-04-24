using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolTest.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }

        [StringLength(100)]
        public string FirstName { get; set; }

        [StringLength(100)]
        public string LastName { get; set; }

        public int ClassId { get; set; }

        [ForeignKey("ClassId")]
        public Class Class { get; set; }
    }
}
