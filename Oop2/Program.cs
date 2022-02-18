using System;

namespace Oop2
{
    class Program
    {
        static void Main(string[] args)
        {
            Individual customer1 = new Individual();
            customer1.CustomerNo = "12345";
            customer1.Id = 1;
            customer1.Name = "Batuhan";
            customer1.SurName = "Kaynarcalidan";
            customer1.TcNo = "123124124123";

            Coorporate customer2 = new Coorporate();
            customer2.CustomerNo = "12345";
            customer2.Id = 1;
            customer2.CompanyName = "BatuhanKaynarcalidan";
            customer2.TaxNo = "12312312";

            Customer customer3 = new Individual();
            Customer customer4 = new Coorporate();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
        }
    }
}
