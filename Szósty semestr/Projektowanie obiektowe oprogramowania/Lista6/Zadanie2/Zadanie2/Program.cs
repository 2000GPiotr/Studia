using System;

namespace Zadanie2
{
    class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context();
            context.setValue("a", true);
            context.setValue("b", false);
            context.setValue("c", true);

            // a | (!c & b)
            AbstractExpression exp = new BinaryExpression()
            {
                Operator = "or",
                Left = new ConstExpression("a"),
                Right = new BinaryExpression()
                {
                    Operator = "and",
                    Left = new UnaryExpression()
                    {
                        Operator = "not",
                        Expression = new ConstExpression("c")
                    },
                    Right = new ConstExpression("b")
                }
            };

            bool value = exp.Interpret(context);
            Console.WriteLine(value);

            context.setValue("a", false);
            Console.WriteLine(exp.Interpret(context));
        }
    }
}
