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

        //IF DATABASE DOESNT WORK USE THIS
        //List<JuraTask> taskList = new List<JuraTask>();
        public TasksController(DataContext context)
        {
            _context = context;
            //IF DATABASE DOESNT WORK USE THIS
            // taskList.Add(new JuraTask {Id=1, Title="Get out of bed", Description="7:30 sharp", DueDate="21/05/2022"});
            // taskList.Add(new JuraTask {Id=2, Title="Shower", Description="With new shampoo", DueDate="21/05/2022"});
            // taskList.Add(new JuraTask {Id=3, Title="Brush Teeth", Description="30 seconds each side", DueDate="21/05/2022"});
            // taskList.Add(new JuraTask {Id=4, Title="Hair routine", Description="HairBrush + tie", DueDate="21/05/2022"});
            // taskList.Add(new JuraTask {Id=5, Title="Get Changed", Description="Drippiest clothes", DueDate="21/05/2022"});
            // taskList.Add(new JuraTask {Id=6, Title="Make sandwich for lunch", Description="Ham and cheese", DueDate="21/05/2022"});
            // taskList.Add(new JuraTask {Id=7, Title="grab your keys", Description="This will take longer than expected", DueDate="21/05/2022"});
            // taskList.Add(new JuraTask {Id=8, Title="go back to bedd", Description="Just not feeling it today", DueDate="21/05/2022"});
        }

        [HttpGet]
        public ActionResult<IEnumerable<JuraTask>> GetTasks(){
            var tasks = _context.Notes.ToList();
            return tasks;

            //IF DATABASE DOESNT WORK USE THIS
            // return taskList;
            
        }
        
        [HttpGet("{id}")]
        public ActionResult<JuraTask> GetTask(int id){
            var task = _context.Notes.Find(id);
            return task;

            //IF DATABASE DOESNT WORK USE THIS
            // var altTask = taskList.Find(t => t.Id == id);
            // return altTask;
            
        }
        [HttpGet("search/{search}")]
        public ActionResult<JuraTask> GetTask(string search){
            var task = _context.Notes.FirstOrDefault(t => t.Title.ToLower().Trim().Contains(search.ToLower().Trim()));
            return task;

            //IF DATABASE DOESNT WORK USE THIS
            // var altTask = taskList.FirstOrDefault(t => t.Title.ToLower().Trim().Contains(search.ToLower().Trim()));
            // return altTask;
            
        }
    }
}