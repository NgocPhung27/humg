﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace LapTrinhQuanLyDb.Models
{
    public partial class Role
    {
        [StringLength(10)]
        public string RoleID { get; set; }
        [StringLength(10)]
        public string RoleName { get; set; }
    }
}