using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NovaFori.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TasksToDoController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<TasksToDoController> _logger;

        public TasksToDoController(ILogger<TasksToDoController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<TaskToDo> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new TaskToDo
            {
                Date = DateTime.Now.AddDays(index),
                
            })
            .ToArray();
        }
    }
}
