using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Before
{
    public class TaxCalculator
    {
        public Decimal CalculateTax(Decimal Price) 
        { 
            return  Price * 0.22m; 
        }
    }
    public class Item
    {
        public Decimal Price { get; set; }
        public string Name { get; set; }
    }
    
    public class CashRegister
    {
        public TaxCalculator taxCalc = new TaxCalculator();
        public Decimal CalculatePrice(Item[] Items)
        {
            Decimal _price = 0;
            foreach (Item item in Items)
            {             
                _price += item.Price + taxCalc.CalculateTax(item.Price);
            }
            return _price;
        }

        public void PrintBill(Item[] Items)
        {
            foreach (var item in Items)
                Console.WriteLine("towar {0} : cena {1} + podatek {2}",
                item.Name, item.Price, taxCalc.CalculateTax(item.Price));
        }
    }

}
