using System;
using System.Collections.Generic;
using System.Text;

namespace Company
{
    public class HeadOfDepartment : IEmployee
    {
        public HeadOfDepartment(string name, string jobResponsibilities)
        {
            Name = name;
            JobResponsibilities = jobResponsibilities;
        }
        public string Name { get; set; }
        public string JobResponsibilities { get; set; }
        public uint Salary { get; set; }
        public IList<Director> Directors { get; } = new List<Director>();
        public bool TakeTT(Order order)
        {
            Console.WriteLine("Руководитель Департамента " + Name + " принял ТЗ на исполнение.");
            foreach (var d in Directors)
                if (!SetTT(d, order))
                    return false;
            return true;
        }
        public bool SetTT(Director director, Order order)
        {
            return director.TakeTT(order);
        }
    }
}
