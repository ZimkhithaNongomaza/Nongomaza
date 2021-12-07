using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;


namespace Nongomaza.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            ApplicationDbContext context = app.ApplicationServices
            .GetRequiredService<ApplicationDbContext>();
            context.Database.Migrate();
            if (!context.Participants.Any())
            {
                context.Participants.AddRange(
                new Participant
                {
                    Name = "imkhitha",
                    Surname = "Nongomaza",
                    Role = "Teacher",
                    Address = "Central, Port Elizabeth",
                    Email = " zimkhitha.nongomaza@gmail.com",
                    CellNumber = 0636085954

                },
                 new Participant
                 {
                     Name = "Lupho",
                     Surname = "Nongomaza",
                     Role = "Pupil",
                     Address = "Motherwell, Port Elizabeth",
                     Email = " ",
                     CellNumber = 0781312206

                 }


               );

                if (!context.Programmes.Any())
                {
                    context.Programmes.AddRange(
                        new Programme
                        {
                            Name = "Pre School",
                            AgeCategory = "2 to 3 years",
                            Description = " I will desc later",
                            Picture = " "
                        },
                        new Programme
                        {
                            Name = "High School",
                            AgeCategory = "2 to 3 years",
                            Description = " I will add desc later",
                            Picture = " "
                        }


                        );



                    if (!context.Events.Any())
                    {
                        context.Events.AddRange(
                        new SchedulerEvent
                        {
                            Name = "Event 1",
                            StartDate = new DateTime(2019, 1, 15, 2, 0, 0),
                            EndDate = new DateTime(2019, 1, 15, 4, 0, 0),

                        },
                    new SchedulerEvent
                    {
                        Name = "Event 2",
                        StartDate = new DateTime(2019, 1, 17, 3, 0, 0),
                        EndDate = new DateTime(2019, 1, 17, 6, 0, 0),

                    },
                    new SchedulerEvent
                    {
                        Name = "Multiday event",
                        StartDate = new DateTime(2019, 1, 15, 0, 0, 0),
                        EndDate = new DateTime(2019, 1, 20, 0, 0, 0),

                    }
                );


                        context.SaveChanges();
                    }
                }
            }
        }
    }
}
