using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using AngularJS.Entity.Domain;
using AngularJS.Entity.RepositoryService.DataFactory.UnitOfWork;

namespace AngularJS.Entity.Service.WebAPI.Controllers
{
    public class MyCountryController : ApiController
    {
        private readonly IUnitOfWork _unitOfWork;
        public MyCountryController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/Country
        [System.Web.Http.HttpGet]
        public IEnumerable<SelectListItem> GetCountries()
        {
            var countriesList = _unitOfWork.CountryRepository.GetAll().AsEnumerable();
            return countriesList.Select(country => new SelectListItem
            {
                Value = country.CountryCode,
                Text = country.CountryName
            }).ToList();
        }
    }
}
