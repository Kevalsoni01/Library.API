using Application;
using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;
using Services.Services;

namespace Library.UI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LibraryController : Controller
    {

        private readonly ILibrary_Student _library_Student;

        public LibraryController(ILibrary_Student library_Student )
        {
            _library_Student = library_Student;
        }

        [HttpPost]
        public async Task<IActionResult> AddStudent(Library_Student student)
        {
           return Ok( _library_Student.AddLibStud(student));
        }

        [Route("GetAll")]
        [HttpPost]

        public async Task<IActionResult> GetAll()
        {
            try
            {
                var result = _library_Student.GetAllStudents();
                return Ok(result);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        [Route("UpdateStudent")]
        [HttpPost]
        public async Task<IActionResult> UpdateStudent(int id,  Library_Student onjStudent)
        {
            _library_Student.UpdateStudent(onjStudent);
            return Ok();
        }
        [Route("DeleteStudent")]
        [HttpDelete]

        public async Task<IActionResult> DeleteStudent(int id)
        {
            _library_Student.DelStudent(id);
            return Ok();
        }
    }
}
