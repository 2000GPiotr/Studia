using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zadanie2;
using static Zadanie2.ShapeFactory;

namespace TestProject1
{
    public class Rectangle : IShape
    {
        public double High;
        public double Width;
    }
    public class RectangleWorker : IFactoryWorker
    {
        public bool AcceptParameters(string ShapeName, params object[] parameters)
        {
            return ShapeName == "Rectangle";
        }

        public IShape Create(params object[] parameters)
        {
            return new Rectangle() { High = (double)parameters[0], Width = (double)parameters[1] };
        }
    }
   
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void BasicWorker()
        {
            IShape shape = new ShapeFactory().CreateShape("Square", 2.3);
            Assert.IsNotNull(shape);
        }
        [TestMethod]
        public void ClientWorker()
        {
            var factory = new ShapeFactory();
            factory.RegisterWorker(new RectangleWorker());
            var shape = factory.CreateShape("Rectangle", 1.4, 2.3);
            Assert.IsNotNull(shape);
        }

    }
}
