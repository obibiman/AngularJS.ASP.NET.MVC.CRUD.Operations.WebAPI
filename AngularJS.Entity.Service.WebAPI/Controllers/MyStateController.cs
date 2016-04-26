using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Mvc;
using AngularJS.Entity.RepositoryService.DataFactory.UnitOfWork;

namespace AngularJS.Entity.Service.WebAPI.Controllers
{
    public class MyStateController : ApiController
    {
        private readonly IUnitOfWork _unitOfWork;
        public MyStateController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/State
        [System.Web.Http.HttpGet]
        public IEnumerable<SelectListItem> GetStates()
        {
            var statesList = _unitOfWork.StateRepository.GetAll().AsEnumerable();
            return statesList.Select(state => new SelectListItem
            {
                Value = state.StateCode, Text = state.StateName
            }).ToList();
        }
    }
}