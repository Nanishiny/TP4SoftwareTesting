using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4.Models
{
    class Task
    {
        private string description { get; set; }
        private int id { get; set; }
        private Status status { get; set; }

    }

    enum Status
    {
        todo,
        done
    }
}
