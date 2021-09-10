using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LapTrinhQuanLyDb.Models
{
    [Table("Persons")]
    public class person
    {
        [Key]
        public string PersonID { get; set; }
        [Required(ErrorMessage = "ID sinh viên không được để trống!")]
        public string PersonName { get; set; }
        [Required(ErrorMessage = "Tên sinh viên không được để trống!")]
        public string PersonAddress { get; set; }
    }
}
