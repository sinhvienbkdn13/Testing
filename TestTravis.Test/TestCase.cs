using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using

namespace TestTravis.Test
{
    public class TestCase
    {
        [TestFixture]
        class MyTestCase
        {
            [TestCase]
            public void Add()
            {
                MyMath math = new MyMath();
                Assert.AreEqual(31, math.Add(20, 11));
            }

            [TestCase]
            public void Sub()
            {
                MyMath math = new MyMath();
                Assert.AreEqual(10, math.Sub(20, 10));
            }
        }
    }
}
