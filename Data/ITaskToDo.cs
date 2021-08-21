using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NovaFori.Data
{
    public interface ITaskToDo
    {
        public  IEnumerable<TaskToDo> getAllTask { get; }


        public bool AddToDoTask(TaskToDo task);

        public TaskToDo getTaskById(int id);

        public List<TaskToDo> getCompletedTask();

        public List<TaskToDo> getPendingTask();
    }
}
