using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TasksController : ControllerBase
    {
        private readonly DataContext _context;
        public TasksController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<JuraTask>> GetTasks(){
            var tasks = _context.Notes.ToList();

            return tasks;
        }
        // example: api/tasks/3 
        [HttpGet("{id}")]
        public ActionResult<JuraTask> GetTask(int id){
            var task = _context.Notes.Find(id);

            return task;
        }
        [HttpGet("search/{search}")]
        public ActionResult<JuraTask> GetTask(string search){
            var task = _context.Notes.FirstOrDefault(t => t.Title.ToLower().Trim().Contains(search.ToLower().Trim()));
            
            return task;
        }
    }
}