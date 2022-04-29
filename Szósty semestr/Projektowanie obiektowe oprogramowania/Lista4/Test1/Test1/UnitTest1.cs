using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading;

namespace Zadanie1
{
    [TestClass]
    public class ProcessSingletonTests
    {
        [TestMethod]
        public void CreateTest()
        {
            var s1 = ProcessSingleton.Instance();
            Assert.IsNotNull(s1);
        }

        [TestMethod]
        public void EqualTest()
        {            
            var s1 = ProcessSingleton.Instance();
            var s2 = ProcessSingleton.Instance();

            Assert.AreEqual(s1, s2);
        }
    }

    [TestClass]
    public class ThreadSingletonTests
    {
        [TestMethod]
        public void CreateTest()
        {
            var s = ThreadSingleton.Instance();
            Assert.IsNotNull(s);
        }
        [TestMethod]
        public void EqualTest()
        {
            Thread t1, t2;
            ThreadSingleton s1 = null,s2 = null, s3 = null;

            t1 = new Thread(() =>
            {
                s1 = ThreadSingleton.Instance();
                s2 = ThreadSingleton.Instance();
            }
                );
            t2 = new Thread(() =>
            {
                s3 = ThreadSingleton.Instance();
            }
                );

            t1.Start();
            t2.Start();
            t1.Join();
            t2.Join();

            Assert.AreEqual(s1, s2);
            Assert.AreNotEqual(s1, s3);
        }
        
    }

    [TestClass]
    public class FiveSecondSingletonTests
    {
        [TestMethod]
        public void CreateTest()
        {
            var s = FiveSecondSingleton.Instance();
            Assert.IsNotNull(s);
        }
        
        [TestMethod]
        public void UnderFiveSecondTest()
        {
            var s1 = FiveSecondSingleton.Instance();
            var s2 = FiveSecondSingleton.Instance();
            Assert.AreEqual(s1, s2);
        }

        [TestMethod]
        public void OverFiveSecondTest()
        {
            var s1 = FiveSecondSingleton.Instance();
            var s2 = FiveSecondSingleton.Instance();
            Thread.Sleep(5100);
            var s3 = FiveSecondSingleton.Instance();
            Assert.AreEqual(s1, s2);
            Assert.AreNotEqual(s1, s3);
        }
    }
}
