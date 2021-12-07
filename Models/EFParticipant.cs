using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nongomaza.Models
{
    public class EFParticipant:IParticipant
    {
        private ApplicationDbContext context;
        public EFParticipant(ApplicationDbContext ctx)
        {
            context = ctx;
        }
        public IQueryable<Participant> Participants => context.Participants;
        public void SaveParticipant(Participant participant)
        {
            if (participant.ParticipantID == 0)
            {
                context.Participants.Add(participant);
            }
            else
            {
                Participant dbEntry = context.Participants
                .FirstOrDefault(p => p.ParticipantID == participant.ParticipantID);
                if (dbEntry != null)
                {
                    dbEntry.Name = participant.Name;
                    dbEntry.Surname = participant.Surname;
                    dbEntry.Address = participant.Address;
                    dbEntry.Email = participant.Email;
                    dbEntry.CellNumber = participant.CellNumber;
                    dbEntry.Role = participant.Role;
                }
            }
            context.SaveChanges();
        }
        public Participant DeleteParticipant(int participantID)
        {
            Participant dbEntry = context.Participants
            .FirstOrDefault(p => p.ParticipantID == participantID);
            if (dbEntry != null)
            {
                context.Participants.Remove(dbEntry);
                context.SaveChanges();
            }
            return dbEntry;
        }
    }
}
