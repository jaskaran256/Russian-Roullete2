using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Russian_Roullete;

// below coding is for unit testing 
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        loadspin unitTestObj = new loadspin(); // testing is for loadspin 

        [TestMethod]
        public void Testslectnumber()
        {
            var jas = unitTestObj.slectnumber();
            Assert.AreEqual(expected: 6, actual: jas); // testing is for random number 
        }

        public void Testselectnumber()
        {
            var jas = unitTestObj.slectnumber();
            Assert.AreNotEqual(notExpected: 5, actual: jas);  // testing is for random number 
        }
    }
}
