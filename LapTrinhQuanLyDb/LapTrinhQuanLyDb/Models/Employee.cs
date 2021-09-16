using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LapTrinhQuanLyDb.Models
{
    public class Employee : person
    {
        [Key]
        public string Company { get; set; }
    }
}