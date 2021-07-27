using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4epam
{
    public class RemoveAutoException : Exception
    {
        public RemoveAutoException() { }
        public RemoveAutoException(string message) : base(message) { }
    }
}
