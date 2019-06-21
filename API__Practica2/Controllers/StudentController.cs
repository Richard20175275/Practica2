using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Service;
using Model;

namespace API__Practica2.Controllers
{
    [Route("controller")]
    public class StudentController : Controller
    {

        private readonly IStudentService _studentService;

        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        
        // GET api/values
        [HttpGet]
        public IActionResult Get()
        {
            return OK(_studentService.GetAll());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return OK(_studentService.Get());
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody] Student model)
        {
            return OK(_studentService.Add(model));
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public IActionResult Put([FromBody] Student model)
        {
            return OK(_studentService.Add(model));
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return OK(_studentService.Delete(model));
        }
    }
}
