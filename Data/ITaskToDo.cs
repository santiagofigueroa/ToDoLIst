using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NovaFori.Data
{
    public interface ITaskToDo
    {
        IEnumerable<TaskToDo> getAllTask { get; }

        TaskToDo getTaskById(int id);

        IEnumerable<List<TaskToDo>> getCompletedTask();

        IEnumerable<List<TaskToDo>> getPendingTask();
    }
}
