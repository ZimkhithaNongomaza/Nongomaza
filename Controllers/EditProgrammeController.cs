using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Nongomaza.Models;
using Nongomaza.Models.ViewModels;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;

namespace Nongomaza.Controllers
{
   
    public class EditProgrammeController:Controller
    {
        private IProgram repository;
        public EditProgrammeController(IProgram repo)
        {
            repository = repo;
        }
        public ViewResult Index() => View (repository.Programmes);
        public ViewResult Edit(int programmeId) =>
 View(repository.Programmes
 .FirstOrDefault(p => p.ProgrammeID == programmeId));
        [HttpPost]
        public IActionResult Edit(Programme programme)
        {
            if (ModelState.IsValid)
            {
               
                repository.SaveProgramme(programme);
                TempData["message"] = $"{programme.Name} has been saved";
                return RedirectToAction("Index");
              
            }
            else
            {
                // there is something wrong with the data values
                return View(programme);
            }
        }
        public ViewResult Create() => View("Edit", new Programme());
        [HttpPost]
        public IActionResult Delete(int programmeId)
        {
            Programme deletedProgramme = repository.DeleteProgramme(programmeId);
            if (deletedProgramme != null)
            {
                TempData["message"] = $"{deletedProgramme.Name} was deleted";
            }
            return RedirectToAction("Index");
        }
    }

    }

