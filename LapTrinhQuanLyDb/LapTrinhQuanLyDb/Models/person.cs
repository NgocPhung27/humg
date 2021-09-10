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

        public string PersonName { get; set; }
        public string PersonAddress { get; set; }
    }
}
