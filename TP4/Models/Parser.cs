using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4.Models
{
    public class Parser
    {
        public  (Operator,string) readInput(string input)
        {

            if (input[0] == '+')
            {
                return (Operator.add, input.Remove(0, 2));
            }
            else if (input[0] == '-')
            {
                return (Operator.remove, input.Remove(0, 2));
            }
            else if (input[0] == 'x')
            {
                return (Operator.statusDone, input.Remove(0, 2));
            }
            else if (input[0] == 'o')
            {
                return (Operator.statusTodo, input.Remove(0, 2));
            }
            else
            {
                return (Operator.exit, "");
            }
        }
    }

    public enum Operator
    {
        add,
        remove,
        statusTodo,
        statusDone,
        exit
    }

}
