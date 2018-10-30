using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace MVC.Models
{
    public class User
    {
        [StringLength(2)]
        public string Name { get; set; }
        public string Password { get; set; }
    }
}