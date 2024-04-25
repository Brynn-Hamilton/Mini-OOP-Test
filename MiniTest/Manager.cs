using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniTest
{
    public class Manager : Employee
    {
        public int ManagerId { get; set; }
        public bool IsManager { get; set; }

        public Manager(int id, string name, Department department, string position, int managerId, bool isManager): base(id, name, department, position)
        {
            ManagerId = id;
            IsManager = isManager;
        }
    }
}
