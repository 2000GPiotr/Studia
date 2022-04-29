using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace After
{
    public interface ITax
    {
        public Decimal Tax();
    }
    public class Tax1 : ITax
    {
        public decimal Tax()
        {
            return 0.1m;
        }
    }
    public class Tax2 : ITax
    {
        public decimal Tax()
        {
            return 0.2m;
        }
    }

    public class TaxCalculator
    {
        public Decimal CalculateTax(Item item)
        {
            return item.Price * item.Tax.Tax();
        }
    }
    public class Item
    {
        public Decimal Price { get; set; }
        public string Name { get; set; }
        public ITax Tax { get; set; }
    }

    public interface IBillPrinter
    {
        public string PrintBill(Item[] items);
    }

    public class StandartBillPrinter : IBillPrinter
    {
        public string PrintBill(Item[] Items)
        {
            string bill = "";

            foreach (var item in Items)
                bill += String.Format("towar {0} : cena {1} + podatek {2} \n",
                item.Name, item.Price, item.Tax.Tax() * item.Price);
            return bill;
        }
    }

    public class AlphabeticalBillPrinter : IBillPrinter
    {
        public string PrintBill(Item[] Items)
        {
            Array.Sort(Items, delegate (Item a, Item b) 
            { 
                return a.Name.CompareTo(b.Name); 
            });

            string bill = "";

            foreach (var item in Items)
                bill += String.Format("towar {0} : cena {1} + podatek {2} \n",
                item.Name, item.Price, item.Tax.Tax() * item.Price);
            return bill;
        }
    }

    public class CashRegister
    {
        public TaxCalculator taxCalc = new TaxCalculator();
        public IBillPrinter billPrinter;

        public CashRegister(IBillPrinter billPrinter)
        {
            this.billPrinter = billPrinter;
        }
        public Decimal CalculatePrice(Item[] Items)
        {
            Decimal _price = 0;
            foreach (Item item in Items)
            {
                _price += item.Price + taxCalc.CalculateTax(item);
            }
            return _price;
        }

        public string PrintBill(Item[] Items)
        {
            return billPrinter.PrintBill(Items);
        }
    }
}
