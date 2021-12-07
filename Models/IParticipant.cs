using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nongomaza.Models
{
   public  interface IParticipant
    {
        IQueryable<Participant> Participants { get; }
        void SaveParticipant(Participant participant);
        Participant DeleteParticipant(int participantID);
    }
}
