using System;
using System.Collections.Generic;
using System.Text;

namespace Company
{
    public class Director : IEmployee
    {
        public Director(string name, string jobResponsibilities)
        {
            Name = name;
            JobResponsibilities = jobResponsibilities;
        }

        public string Name { get; set; }
        public string JobResponsibilities { get; set; }
        public uint Salary { get; set; }

        public IList<Manager> Managers { set; get; } = new List<Manager>();

        public bool TakeTT(Order order)
        {
            Console.WriteLine("Руководитель отдела " + Name + " принял ТЗ на исполнение.");
            foreach (var m in Managers)
                if (!SetTT(m, order))
                    return false;
            return true;
        }
        public bool SetTT(Manager manager, Order order)
        {
            return manager.TakeTT(order);
        }
    }
}
