using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace studentcofirst.Models
{
    [Table("Tablestudent")]
    public class StudentInfo
    {
        [Key]
        public int stdid { get; set; }
        public int ID { get; set; }
        public string Name { get; set; }
        public string city { get; set; }
        public string Branch { get; set; }
        public int Percentage { get; set; }
    }
}