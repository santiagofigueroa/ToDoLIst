using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using static System.Console;
using NovaFori.Data;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace NovaFori.Controllers
{
    [ApiController]
    [Route("api/tasks")]
    [EnableCors("GlobalAccess")]
    public class TasksToDoController : ControllerBase
    {
        // Remember that is always and extension here.   
        private readonly ITaskToDo _context;

        public TasksToDoController(ITaskToDo context)
        {
            _context = context;
        }

        /// <summary>
        /// Get all tasks from API we will see how i
        /// </summary>
        /// <returns></returns>

        [HttpGet]
        [EnableCors("GlobalAccess")]
        public ActionResult<IEnumerable<TaskToDo>> getALlTasks()
        {


            var result = _context.getAllTask;


            // 
            List<TaskToDo> sortedTasks = result.GroupBy(x => x.Date).Select(x => x.First()).ToList();
            foreach (TaskToDo task in sortedTasks)
            Console.WriteLine(task.Date + ": " + task.Pending + " Pedding tasks stil to be done");

            //  Schedule to make a Schedule.
            WriteLine(sortedTasks);
            return Ok(sortedTasks);
        }


        /// <summary>
        ///  Will be Implemted after Fron-end is done.
        /// </summary>
        /// <param name="taskPayload"></param>
        /// <returns></returns>
        [HttpPost]
        [EnableCors("GlobalAccess")]
        public ActionResult<TaskToDo> PostTaskToDo(TaskToDo taskPayload)
        {
            return null;
        }
    }
}
