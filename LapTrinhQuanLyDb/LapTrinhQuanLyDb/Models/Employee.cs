using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LapTrinhQuanLyDb.Models
{
    public class Employee : person
    {
        public string Company { get; set; }
    }
}