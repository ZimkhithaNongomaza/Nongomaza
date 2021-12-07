using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nongomaza.Models
{
    public class EFProgramme:IProgram
    {
        private ApplicationDbContext context;
        public EFProgramme(ApplicationDbContext ctx)
        {
            context = ctx;
        }
        public IQueryable<Programme> Programmes => context.Programmes;
        public void SaveProgramme(Programme programme)
        {
           
            if (programme.ProgrammeID == 0)
            {
                context.Programmes.Add(programme);
            }
            else
            {   
                Programme dbEntry = context.Programmes
                .FirstOrDefault(p => p.ProgrammeID == programme.ProgrammeID);
                if (dbEntry != null)
                {

                    dbEntry.Name = programme.Name;
                    dbEntry.AgeCategory = programme.AgeCategory;
                    dbEntry.Description = programme.Description;
                    dbEntry.Picture = programme.Picture;
                    

                }
            }
            context.SaveChanges();
        }
        public Programme DeleteProgramme(int programmeID)
        {
            Programme dbEntry = context.Programmes
            .FirstOrDefault(p => p.ProgrammeID == programmeID);
            if (dbEntry != null)
            {
                context.Programmes.Remove(dbEntry);
                context.SaveChanges();
            }
            return dbEntry;
        }
    }
}
