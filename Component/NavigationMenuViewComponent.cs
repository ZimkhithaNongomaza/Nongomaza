using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Nongomaza.Models;

namespace Nongomaza.Component
{
    public class NavigationMenuViewComponent:ViewComponent
    {
        private IParticipant repository;
        public NavigationMenuViewComponent(IParticipant repo)
        {
            repository = repo;
        }
        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedCategory = RouteData?.Values["role"];
            return View(repository.Participants
            .Select(x => x.Role)
            .Distinct()
            .OrderBy(x => x));
        }
    }
}
