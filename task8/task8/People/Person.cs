﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task8
{
    [Serializable]
    public abstract class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Person()
        {
        }

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
