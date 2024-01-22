using Microsoft.AspNetCore.Mvc;
using University.Group.Models.Faculties;

namespace University.Group.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UniversityController : Controller
    {
        private Models.University _myUniversity;


        public UniversityController(Models.University newUniwersity)
        {
            _myUniversity = newUniwersity;
        }
        

        [HttpGet]
        public IActionResult GetResult()
        {
            return View("~/Views/University/University.cshtml", _myUniversity);
        }


        [HttpGet("GetFaculty/{name}")]
        public IActionResult GetFaculties(string name)
        {
            return View("~/Views/University/Faculty.cshtml", _myUniversity.Faculties.Find(n => n.Name == name));
        }


        [HttpGet("PostFaculty")]
        public IActionResult PostFaculty()
        {
            return View("~/Views/University/FacultiForm.cshtml");
        }


        [HttpPost("PostFaculty")]
        public string PostFaculty(Faculty newFaculty)
        {
            _myUniversity.Faculties.Add(newFaculty);
            return "Add faculty";
        }


        [HttpPut("{id}")]
        public void PutFaculty(int id, [FromBody] Faculty newFaculty)
        {
            _myUniversity.Faculties[id] = newFaculty;
        }


        [HttpDelete("DeleteFaculty/{id}")]
        public void DeleteFaculty(int id)
        {
            _myUniversity.Faculties.RemoveAt(id);
        }
    }
}
