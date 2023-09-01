using CodeFirstApproach.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CodeFirstApproach.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private IRepo _repo;
        public EmployeeController(IRepo repo)
        {
            _repo = repo;


        }
        // GET: api/<EmployeeController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_repo.Get());
        }

        // GET api/<EmployeeController>/5
        [HttpGet("{id}")] 
        public IActionResult Get(int id)
        {
            return Ok(_repo.GetEmployee(id));   
        }

        // POST api/<EmployeeController>
        [HttpPost]
        public IActionResult Post([FromBody] Employee employee)
        {
            
            return Created("OK", _repo.AddEmployee(employee));
        }
        

        // PUT api/<EmployeeController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Employee employee)
        {
            return Ok(_repo.UpdateEmployee(id, employee)); ; }


        // DELETE api/<EmployeeController>/5
        [HttpDelete("{id}")]

        public IActionResult Delete(int id)
        {
            return Ok(_repo.DeleteEmployee(id));
        }
    }
}
