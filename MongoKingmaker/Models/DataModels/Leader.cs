using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MongoKingmaker.Models
{
    public class Leader
    {
        [Required]
        [Display(Name = "Name")]
        public string name { get; set; }

        [Required]
        [Display(Name = "Role")]
        public string role { get; set; }

        [Required]
        [Display(Name = "Leadership Feat")]
        public bool leadership { get; set; }

        [Required]
        [Display(Name = "Vacancy")]
        public bool vacancy { get; set; }

        [Required]
        [Display(Name = "Attribute Value")]
        public float attribute { get; set; }

        [Required]
        [Display(Name = "Ocupancy Statistics")]
        public Kingdom_Attributes present { get; set; }

        [Required]
        [Display(Name = "Vacancy Penalty")]
        public Kingdom_Attributes vacant { get; set; }
    }
}