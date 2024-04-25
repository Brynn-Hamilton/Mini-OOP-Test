using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MiniTest
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Department Department { get; set; }
        public string Position { get; set; }

        public Employee(int id, string name, Department department, string position)
        {
            Id = id;
            Name = name;
            Department = department;
            Position = position;
        }

        public Employee() 
        { 

        }

        public override string ToString()
        {
            return $"{Id}: {Name}, {Department.Name}, {Position}";
        }
    }
}
