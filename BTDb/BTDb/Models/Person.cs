using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BTDb.Models
{
    [Table("Persons")]
    public class Person
    {
        [Key]
        public string PersonID { get; set; }
        [Required( ErrorMessage ="id khong duoc de trong!")]
        public string PersonName { get; set; }
        [Required(ErrorMessage = "Ten khong duoc de trong!")]
        public string PersonAddress { get; set; }
    }
}