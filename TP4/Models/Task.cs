using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4.Models
{
    public class Task
    {
        public string Description { get; set; }
        public int Id { get; set; }
        public TaskStatus Status { get; set; }
    }
    public enum TaskStatus
    {
        todo,
        done
    }
}
