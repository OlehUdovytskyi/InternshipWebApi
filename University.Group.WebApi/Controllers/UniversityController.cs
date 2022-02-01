using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using University.Group.Models.Faculties;
using System.Collections.Generic;

namespace University.Group.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UniversityController : ControllerBase
    {
        private Models.University _myUniversity;

        public UniversityController(Models.University newUniwersity) => _myUniversity = newUniwersity;


        [HttpGet]
        public Models.University GetUniversity() => _myUniversity;


        [HttpGet("GetFaculties")]
        public IEnumerable<Faculty> GetFaculties() => _myUniversity.Faculties;


        [HttpGet("GetDepartments/{id}")]
        public IEnumerable<Models.Departments.Department> GetDepartments(int id) => _myUniversity.Faculties[id].GetDepartment;


        [HttpPost("PostFaculty")]
        public void PostFaculty([FromBody]Faculty newFaculty) => _myUniversity.Faculties.Add(newFaculty);


        [HttpPut("{id}")]
        public void PutFac(int id, [FromBody] Faculty newFaculty) => _myUniversity.Faculties[id] = newFaculty;


        [HttpDelete("DeleteFaculty/{id}")]
        public void DeleteFaculty(int id) => _myUniversity.Faculties.RemoveAt(id);
    }
}
