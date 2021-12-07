using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nongomaza.Models
{
   public interface IProgram
    {
        IQueryable<Programme> Programmes { get; }
        void SaveProgramme(Programme programme);
        Programme DeleteProgramme(int programmeID);
    }
}
