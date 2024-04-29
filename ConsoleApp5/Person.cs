using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    public class Person
    {
        private static int _id;
        public int Id { get;  }
        public string Name { get; set; }
        public string Surname { get; set; }
        public byte Age { get; set; }

        public Person()
        {
            _id++;
            Id = _id;
        }
    }
}
