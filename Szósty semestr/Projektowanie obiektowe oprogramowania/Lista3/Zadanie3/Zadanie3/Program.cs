using System;

namespace Zadanie3
{
    class Program
    {
        static void Main(string[] args)
        {
            Before.Item[] items = new Before.Item[3];
            items[0] = new Before.Item { Name = "długopis", Price = 1.23m };
            items[1] = new Before.Item { Name = "zeszyt", Price = 10.37m };
            items[2] = new Before.Item { Name = "książka", Price = 41.23m };

            Before.CashRegister cashRegister = new Before.CashRegister();
            cashRegister.PrintBill(items);

            Console.WriteLine("================");

            After.Item[] items1 = new After.Item[3];
            items1[0] = new After.Item { Name = "długopis", Price = 1.23m, Tax=new After.Tax1() };
            items1[1] = new After.Item { Name = "zeszyt", Price = 10.37m, Tax = new After.Tax2() };
            items1[2] = new After.Item { Name = "książka", Price = 41.23m, Tax = new After.Tax1() };

            After.CashRegister cashRegister1 = new After.CashRegister(new After.StandartBillPrinter());
            Console.WriteLine(  cashRegister1.PrintBill(items1));
            
            Console.WriteLine("================");
            
            After.CashRegister cashRegister2 = new After.CashRegister(new After.AlphabeticalBillPrinter());
            Console.WriteLine(cashRegister2.PrintBill(items1));

        }
    }
}
