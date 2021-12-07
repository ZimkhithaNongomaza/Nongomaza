using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Nongomaza.Models;
using Nongomaza.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;

namespace Nongomaza.Controllers
{
    
    public class ParticipantController:Controller
    {
        private IParticipant repository;
        public int PageSize = 4;
        public ParticipantController(IParticipant repo)
        {
            repository = repo;
        }
        public ViewResult List(string role, int participantPage = 1)
            => View(new participantsListViewModel
            {
                Participants = repository.Participants
                .Where(p => role == null || p.Role == role)
 .OrderBy(p => p.ParticipantID)
 .Skip((participantPage - 1) * PageSize)
 .Take(PageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = participantPage,
                    ItemsPerPage = PageSize,
                    TotalItems = role == null ?
 repository.Participants.Count() :
repository.Participants.Where(e =>
 e.Role == role).Count()
                },
                CurrentRole = role
            });

    }
}
