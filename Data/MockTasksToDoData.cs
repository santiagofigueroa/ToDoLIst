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

            new TaskToDo{Id = 24, Date =  DateTime.Today.AddDays(-7) , Completed =  true,  Pending = false,  Description = "Accept offer from  Nova", Status = "Completed"},
            new TaskToDo{Id = 34,  Date =  DateTime.Today.AddDays(-4), Completed =  false,  Pending = true,  Description = "Get the test done ", Status = "Pending"},
            new TaskToDo {Id = 39,  Date =  DateTime.UtcNow, Completed =true,  Pending = false,  Description = "Meeting with mates", Status = "Pending" },
            new TaskToDo { Id = 36,  Date =  DateTime.Today.AddDays(-7), Completed =  false,  Pending = true,  Description = "Accept offer fromm Barclay's ", Status = "Completed" },
            new TaskToDo { Id = 30,  Date =  DateTime.Today.AddDays(-7), Completed =  false ,  Pending = true,  Description = "1st Phone interview", Status = "Completed"},
            new TaskToDo { Id = 57 ,  Date =  DateTime.Today.AddDays(-4), Completed =  false,  Pending = true,  Description = "Accept offer PG", Status = "Completed"},
            new TaskToDo { Id = 56 ,  Date =  DateTime.Today.AddDays(-5), Completed =  false ,  Pending = true,  Description = "Meeting with Client", Status = "Completed"},
            new TaskToDo { Id = 67 ,  Date =  DateTime.Today.AddDays(-1), Completed =  true,  Pending = false,  Description = "Time off", Status = "Completed"},
            new TaskToDo { Id = 58 ,  Date =  DateTime.Today.AddDays(-1), Completed =  true,  Pending = false,  Description = "Get some time off", Status = "Completed"}
             };

        public bool AddToDoTask(TaskToDo task) 
        {

            var result = getAllTask.Where(x => x.Equals(task)).FirstOrDefault();
            if (result != null)
            {
                // Task is being already added
                return false; 
            }
            // Some of this 
            // Then it was succesfully added.
            getAllTask.Append(result);

            return true; 
        }

        public List<TaskToDo> getCompletedTask()
        {
            var result = getAllTask.Where(x => x.Completed == true).ToList();
            // 
            return result;
        }

        public List<TaskToDo> getPendingTask()
        {
            var result = getAllTask.Where(x => x.Pending == true).ToList();
            // 
            return result;
        }


        public TaskToDo getTaskById(int id)
        {
            //
            var result = getAllTask.Where(x => x.Id == id).FirstOrDefault();
            // 
        return result;
        }
    } 
}
    