using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssemblyLevel
{
    [TestClass]
    public class UnitTest2
    {
        [ClassInitialize]
        public static void ClassInitialize(TestContext testContext)
        {
            Debug.WriteLine("Running UnitTest2 ClassInitialize");
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            Debug.WriteLine("Running UnitTest2 ClassCleanup");
        }

        [TestInitialize]
        public void TestInitialize()
        {
            Debug.WriteLine("Running UnitTest2 TestInitialize");
        }

        [TestCleanup]
        public static void TestCleanup()
        {
            Debug.WriteLine("Running UnitTest2 TestCleanup");
        }

        [TestMethod]
        public void TestMethod3()
        {
            Debug.WriteLine("Running TestMethod3");
        }

        [TestMethod]
        public void TestMethod4()
        {
            Debug.WriteLine("Running TestMethod4");
        }
    }
}
