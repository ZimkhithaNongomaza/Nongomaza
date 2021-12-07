using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Nongomaza.Models;

namespace Nongomaza.Component
{
    public class NavigationMenuzViewComponent:ViewComponent
    {
        private IParticipant repository;
        private IProgram Prepository;
        public NavigationMenuzViewComponent(IParticipant repo, IProgram Prepo)
        {
            repository = repo;
            Prepository = Prepo;

        }

        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedCategory = RouteData?.Values["role"];
            return View(repository.Participants
            .Select(x => x.Role)
            .Distinct()
            .OrderBy(x => x));


        }
        public IViewComponentResult PInvoke()
        {
            ViewBag.SelectedCategory = RouteData?.Values["name"];
            return View(Prepository.Programmes
            .Select(x => x.Name)
            .Distinct()
            .OrderBy(x => x));
        }
    }
}
