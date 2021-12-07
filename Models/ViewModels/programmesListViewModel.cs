using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
namespace Nongomaza.Models.ViewModels


{
    public class programmesListViewModel
    {
        public IEnumerable<Programme> Programmes { get; set; }
        public PagingInfo PagingInfo { get; set; }
      
       
    }
}
