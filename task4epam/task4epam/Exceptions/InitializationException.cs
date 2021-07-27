using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4epam
{
    public class InitializationException : Exception
    {
        public InitializationException() { }
        public InitializationException(string message) : base(message) { }
    }
}
