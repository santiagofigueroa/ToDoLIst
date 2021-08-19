using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NovaFori.Data
{
    public class MockTasksToDoData : ITaskToDo
    {

        public IEnumerable<TaskToDo> getAllTask =>
              new List<TaskToDo>
            {

            new TaskToDo{Id = 24},
            new TaskToDo{Id = 34},
            new TaskToDo {Id = 39  },
            new TaskToDo { Id = 36 },
            new TaskToDo { Id = 30},
            new TaskToDo { Id = 57 },
            new TaskToDo { Id = 56 },
            new TaskToDo { Id = 67 },
            new TaskToDo { Id = 58 }
             };

        public IEnumerable<List<TaskToDo>> getCompletedTask()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<List<TaskToDo>> getPendingTask()
        {
            throw new NotImplementedException();
        }

        public TaskToDo getTaskById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
