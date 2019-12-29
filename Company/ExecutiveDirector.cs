using System;
using System.Collections.Generic;
using System.Text;

namespace Company
{
    public class ExecutiveDirector : IEmployee
    {
        public ExecutiveDirector(string name, string jobResponsibilities)
        {
            Name = name;
            JobResponsibilities = jobResponsibilities;
        }
        public string Name { get; set; }
        public string JobResponsibilities { get; set; }
        public uint Salary { get; set; }

        public IList<HeadOfDepartment> HeadOfDepartments = new List<HeadOfDepartment>();
        public bool GetOrder(Order order)
        {
            Console.WriteLine("Исполнительный директор " + Name + ": заказ получен.");
            foreach (var h in HeadOfDepartments)
            {
                if (!SetTT(h, order))
                    return false;
            }
                
            return true;
        }

        public bool SetTT(HeadOfDepartment headOfDepartment, Order order)
        {
            return headOfDepartment.TakeTT(order);
        }
    }
}
