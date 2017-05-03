using Microsoft.VisualStudio.TestTools.UnitTesting;
using IsPrimeNumber;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsPrimeNumber.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void IsPrimeTest()
        {
            int max = 1000000;

            for (int i = 0; i <= max; i++)
            {
                Assert.IsTrue(Program.IsPrime(i) == Program.IsPrime3(i));
            }
        }

        [TestMethod()]
        public void IsPrimeTest2()
        {
            int max = 1000000;

            for (int i = 0; i <= max; i++)
            {
                Assert.IsTrue(Program.IsPrime2(i) == Program.IsPrime3(i));
            }
        }
    }
}