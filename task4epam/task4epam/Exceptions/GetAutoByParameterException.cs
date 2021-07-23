using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4epam
{
    public class GetAutoByParameterException : Exception
    {
        public GetAutoByParameterException() { }
        public GetAutoByParameterException(string message) : base(message) { }
    }
}
