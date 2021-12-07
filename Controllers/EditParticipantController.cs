using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Nongomaza.Models;
using Microsoft.EntityFrameworkCore;
using Nongomaza.Models.ViewModels;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Authorization;



namespace Nongomaza.Controllers
{
    
    public class EditParticipantController:Controller
    {
        private IParticipant repository;
        private ApplicationDbContext context;
        public EditParticipantController(IParticipant repo)
        {
            repository = repo;
        }
        public ViewResult Index() => View(repository.Participants);
         //to search for a participant
        


        public ViewResult Edit(int participantId) =>
 View(repository.Participants
 .FirstOrDefault(p => p.ParticipantID == participantId));

        [HttpPost]
        public IActionResult Edit(Participant participant)
        {
            if (ModelState.IsValid)
            {
                repository.SaveParticipant(participant);
                TempData["message"] = $"{participant.Name} {participant.Surname} has been saved";
                return RedirectToAction("Index");
            }
            else
            {
                // there is something wrong with the data values
                return View(participant);
            }
        }
        public ViewResult Create() => View("Edit", new Participant());
        [HttpPost]
        public IActionResult Delete(int participantId)
        {
            Participant deletedParticipant = repository.DeleteParticipant(participantId);
            if (deletedParticipant != null)
            {
                TempData["message"] = $"{deletedParticipant.Name} was deleted";
            }
            return RedirectToAction("Index");
        }
        
    }

    }

