using System;

namespace XMRHSimple
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomersService customersService = new CustomersService();

            var customers = customersService.GetAllItems<VMCustomer>();
            Console.ReadKey();
        }
    }
}
