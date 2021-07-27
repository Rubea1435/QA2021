using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4epam
{
    public class UpdateAutoException : Exception
    {
        public UpdateAutoException() { }
        public UpdateAutoException(string message) : base(message) { }
    }
}
