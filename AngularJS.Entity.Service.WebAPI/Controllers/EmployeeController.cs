using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AngularJS.Entity.Domain;
using AngularJS.Entity.RepositoryService.DataFactory.UnitOfWork;

namespace AngularJS.Entity.Service.WebAPI.Controllers
{
    public class EmployeeController : ApiController
    {
        private readonly IUnitOfWork _unitOfWork;
        public EmployeeController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/Employee
        [HttpGet]
        public IEnumerable<Employee> Get()
        {
            var customers = _unitOfWork.EmployeeRepository.GetAll().AsEnumerable();
            return customers;
        }

        // GET: api/Employee/5
        [HttpGet]
        public IHttpActionResult Get(int id)
        {
            var employee = _unitOfWork.EmployeeRepository.GetById(id);
            if (employee == null)
            {
                return BadRequest("No Employee found");
            }
            return Ok(employee);
        }

        // GET: api/Employee/5
        [HttpGet]
        public IHttpActionResult RetrieveById(int id)
        {
            var employee = _unitOfWork.EmployeeRepository.GetById(id);
            if (employee == null)
            {
                return BadRequest("No Employee found");
            }
            return Ok(employee);
        }

        // POST: api/Employee
        [HttpPost]
        public HttpResponseMessage Post(Employee employee)
        {

            _unitOfWork.EmployeeRepository.Add(employee);
            var response = Request.CreateResponse(HttpStatusCode.Created);
            response.StatusCode = HttpStatusCode.Created;
            var uri = Url.Link("DefaultApi", new { id = employee.EmployeeId });
            response.Headers.Location = new Uri(uri);
            return response;
        }

        // PUT: api/Employee/5
        [HttpPut]
        public HttpResponseMessage Put(int id, Employee employee)
        {
            employee.EmployeeId = id;
            _unitOfWork.EmployeeRepository.Update(employee);
            var response = Request.CreateResponse(HttpStatusCode.NoContent);
            var uri = Url.Link("DefaultApi", new { id = employee.EmployeeId });
            response.Headers.Location = new Uri(uri);
            return response;
        }

        // DELETE: api/Employee/5
        [HttpDelete]
        public HttpResponseMessage Delete(int id)
        {
            var employee = _unitOfWork.EmployeeRepository.GetById(id);
            _unitOfWork.EmployeeRepository.Delete(employee);
            var response = Request.CreateResponse(HttpStatusCode.NoContent);
            return response;
        }
    }
}
