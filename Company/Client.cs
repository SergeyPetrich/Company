using System;
using System.Collections.Generic;
using System.Text;

namespace Company
{
    public class Client
    {
        public Client(string name, string phoneNumber)
        {
            Name = name;
            PhoneNumber = phoneNumber;
        }
        public string Name { set; get; }
        public string PhoneNumber { set; get; }
        public void Order(Company company, string order)
        {
            company.GetOrder(this, order);
        }

        public string PayForOrder(Company company, int sum)
        {
            return company.GiveCheck(this, sum);
        }

        public string Appeal(Company company, string appeal)
        {
            return company.GetAppeal(appeal);
        }
    }
}
