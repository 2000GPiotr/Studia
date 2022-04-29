using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie2
{
    public interface IShape{}
    public class Square : IShape
    {
        public double Size;
    }

    public interface IFactoryWorker
    {
        bool AcceptParameters(string ShapeName, params object[] parameters);
        IShape Create(params object[] parameters);
    }
    
    public class SquareWorker : IFactoryWorker
    {
        public bool AcceptParameters(string ShapeName, params object[] parameters)
        {
            return ShapeName == "Square";
        }

        public IShape Create(params object[] parameters)
        {
            return new Square() { Size = (double)parameters[0] };
        }
    }

    public class ShapeFactory
    {
        public List<IFactoryWorker> _workers = new List<IFactoryWorker>();

        public ShapeFactory()
        {
            this._workers.Add(new SquareWorker());
        }

        public void RegisterWorker(IFactoryWorker worker)
        {
            this._workers.Add(worker);
        }

        public IShape CreateShape(string ShapeName, params object[] parameters)
        {
            foreach (IFactoryWorker worker in _workers)
            {
                if(worker.AcceptParameters(ShapeName, parameters))
                    return worker.Create(parameters);
            }

            throw new ArgumentNullException();
        }
    }

}
