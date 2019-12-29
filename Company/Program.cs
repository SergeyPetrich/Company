using System;

namespace Company
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager m1 = new Manager("Петя", " ");
            Manager m2 = new Manager("Саша", " ");
            Director d1 = new Director("Сергей", " ");
            d1.Managers.Add(m1);
            Director d2 = new Director("Дмитрий", " ");
            d2.Managers.Add(m2);
            HeadOfDepartment h1 = new HeadOfDepartment("Дмитрий Андреевич", " ");
            h1.Directors.Add(d1);
            HeadOfDepartment h2 = new HeadOfDepartment("Алексей Сергеевич", " ");
            h2.Directors.Add(d2);
            ExecutiveDirector e = new ExecutiveDirector("Дмитрий Сергеевич Васильев", " ");
            e.HeadOfDepartments.Add(h1);
            e.HeadOfDepartments.Add(h2);
            GeneralDirector g = new GeneralDirector("Сергей Валерьевич", " ");
            Company company = new Company("NewCompany", 56743, e, g);

            Client client = new Client("Том", "88005353535");
            client.Order(company, "ОЧЕНЬ ВАЖНЫЙ ЗАКАЗ НОМЕР 1");
            Console.WriteLine(client.Appeal(company, "все очень плохо"));
        }
    }
}
