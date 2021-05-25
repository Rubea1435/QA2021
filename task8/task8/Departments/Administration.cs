using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task8
{
    class Administration : Department
    {
        public Administration(Chief chief, List<Person> staff) : base(chief, staff)
        {
        }

    }
}
