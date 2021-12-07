

using System.Collections.Generic;

namespace TP4.Models
{
    public class TaskList
    {
        public List<Task> Tasks { get; set; }

        public TaskList()
        {
            Tasks = new List<Task>();
        }
    }
}
