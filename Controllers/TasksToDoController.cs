using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NovaFori.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NovaFori.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [EnableCors("GlobalAccess")]
    public class TasksToDoController : ControllerBase
    {
        // Remember that is always and extension here.   
        private readonly ITaskToDo _context;

        public TasksToDoController(ITaskToDo context)
        {
            _context = context;
        }


        [HttpGet]
        [EnableCors("GlobalAcess")]
        public ActionResult<IEnumerable<TaskToDo>>   getALlTasks()
        {
            var result = _context.getAllTask;
            // if is ok then add display them
            return Ok(result);
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
