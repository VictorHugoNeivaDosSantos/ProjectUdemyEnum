using System;
using ProjectUdemyEnum.Entities.Enums;
using ProjectUdemyEnum.Entities;


namespace ProjectUdemyEnum
{
    class Program
    {
        static void Main(string[] args)
        {


            Order order = new Order(150,DateTime.Now,"PagamentConfirmed");

            Console.WriteLine(order);

          
        }
    }
}
