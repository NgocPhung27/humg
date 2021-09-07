using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace baitap3.Models
{
    [Table("Student")]
    public class Student
    {
        [Key]
        public int StudentID { get; set; }
        public int StudentName { get; set; }
    }
}