using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Http;

namespace Nongomaza.Models
{
    public class Programme
    {
        public int ProgrammeID { get; set; }
        [Required(ErrorMessage = "Please enter the Programmes Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter the Programmes Age Category")]
        public string AgeCategory { get; set; }
        [Required(ErrorMessage = "Please enter the Programmes Description")]
        public string Description { get; set; }
        public string Picture { get; set; }
    }
}
