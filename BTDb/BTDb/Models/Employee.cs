using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BTDb.Models
{
    public class Employee : Person
    {
        public string Company { get; set; }
    }
}