using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MongoKingmaker.Models
{
    public class Alignment
    {
        [Required]
        [Display(Name = "Name")]
        public string name { get; set; }

        [Required]
        [Display(Name = "Kingdom Attributes")]
        public Kingdom_Attributes kingdom_attributes { get; set; }
    }
}