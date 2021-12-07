using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Nongomaza.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Nongomaza.Models.ViewModels
{
    public class participantsListViewModel
    {
        public IEnumerable<Participant> Participants { get; set; }
        public PagingInfo PagingInfo { get; set; }
        public string CurrentRole { get; set; }
        
        
    }
}
