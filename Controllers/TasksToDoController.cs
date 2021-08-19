using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NovaFori.Controllers
{
    [ApiController]
    [Route("api/Tasks")]
    public class TasksToDoController : ControllerBase
    {
      
        private readonly ILogger<TasksToDoController> _logger;

        public TasksToDoController(ILogger<TasksToDoController> logger)
        {
            _logger = logger;
        }

    }
}
