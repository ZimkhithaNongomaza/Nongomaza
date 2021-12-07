using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Nongomaza.Models
{
    public class Participant
    {
        public int ParticipantID { get; set; }
        [Required(ErrorMessage = "Please enter the Participant's Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter the Participant's Surname")]
        public string Surname { get; set; }
        [Required(ErrorMessage = "Please enter the Participant's Address")]
        public string Address { get; set; }
        public string Email { get; set; }
        [Required(ErrorMessage = "Please enter the Participant's Roler")]
        public string Role { get; set; }
        [Required(ErrorMessage = "Please enter the Participant's Cellphone Number")]
        public int CellNumber { get; set; }
    }
}
