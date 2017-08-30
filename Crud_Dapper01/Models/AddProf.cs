using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Crud_Dapper01.Models
{
    public class AddProf
    {

        [Key]
        public int id { get; set; }
        public string Name { get; set; }
        public int RegisterId { get; set; }
        public int Mobile { get; set; }
    }
}