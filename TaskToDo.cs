using System;

namespace NovaFori
{
    public class TaskToDo
    {
        public int Id { get; set; }
        public string Date { get; set; }

        public bool  Completed  { get; set; }

        public bool  Pending { get; set;  }

        public string Description { get; set; }

        public string  Status { get; set; }
    }
}
