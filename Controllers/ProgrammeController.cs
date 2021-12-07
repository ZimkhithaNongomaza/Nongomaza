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
   
    public class ProgrammeController:Controller
    {
        private IProgram repository;
        public int PageSize = 4;
        public ProgrammeController(IProgram repo)
        {
            repository = repo;
        }
        public ViewResult List(int programmePage = 1)
            => View(new programmesListViewModel
            {
                Programmes = repository.Programmes
 .OrderBy(p => p.ProgrammeID)
 .Skip((programmePage - 1) * PageSize)
 .Take(PageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = programmePage,
                    ItemsPerPage = PageSize,
                    TotalItems = repository.Programmes.Count()
                }
            });

    }
}
