using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LapTrinhQuanLyDb.Models
{
    public class Employee : person
    {
        [AllowHtml]
        public string Company { get; set; }

    }
}