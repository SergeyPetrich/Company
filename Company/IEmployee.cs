using System;
using System.Collections.Generic;
using System.Text;

namespace Company
{
    public interface IEmployee
    {
        public string Name{ get; set; }
        public string JobResponsibilities { get; set; }
        public uint Salary { get; set; }
    }
}
