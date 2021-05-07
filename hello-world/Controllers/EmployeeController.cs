using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using hello_world.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace hello_world.Controllers
{

    public class EmployeeController : ControllerBase
    {
        [HttpGet("api/employees")]
        public ActionResult GetEmployees() {
            List<Employee> employees = new List<Employee>();
            List<string> names = new List<string>{ "Michael", "Vince", "Lizet", "Ivette", "Jimy", "Bob", "Tom"};
            for (int i = 0; i < names.Count; i++) {
                Employee employee = new Employee {
                    Name = names[i],
                    Number = i
                };

                employees.Add(employee);
            }

            return Ok(employees);
        }
    }
}
