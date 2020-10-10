using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace IUAv2.Models
{
    public class Team
    {
        [Key]
        public int ID { get; set; }

        [Required, Display(Name = "Team Name")]
        public string TeamName { get; set; }

        [Required, EmailAddress, Display(Name = "Email Address")]
        public string Email { get; set; }

        [Display(Name = "Date Team Established")]
        public DateTime EstablishedDate { get; set; }

    }
}
