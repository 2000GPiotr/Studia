using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie4
{
    /*
     * W implementacji tego problemu oddziliłem od siebie klasy Rectangle i Square tek że nie są połączone w hierarchii bezpośrednio
     * jednak są spięte klasą abstrakcyjną shape
     */
    public abstract class Shape
    {
        public abstract Decimal CalculateArea();
    }

    public class Rectangle : Shape
    {
        public Decimal Width { get; set; }
        public Decimal Heigh { get; set; }
        public override decimal CalculateArea()
        {
            return this.Width * this.Heigh;
        }
    }
    public class Square : Shape
    {
        public Decimal Length { get; set; }
        public override decimal CalculateArea()
        {
            return this.Length * this.Length;
        }
    }

    public class AreaCalculator
    {
        public Decimal CalculateArea(Shape shape)
        {
            return shape.CalculateArea();
        }
    }
}
