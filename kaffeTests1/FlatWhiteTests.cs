using Microsoft.VisualStudio.TestTools.UnitTesting;
using kaffe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kaffe.Tests
{
    [TestClass()]
    public class FlatWhiteTests
    {
        [TestMethod()]
        public void MlMælkTest()
        {
            var fw = new FlatWhite();

            int result = fw.MlMælk();

            Assert.AreEqual(160, result);
            
        }

        [TestMethod()]
        public void PrisTest()
        {
            var fw = new FlatWhite();

            int result = fw.Pris();

            Assert.AreEqual(45, result);
        }

        [TestMethod()]
        public void StyrkeTest()
        {
            var fw = new FlatWhite();

            string result = fw.Styrke();

            Assert.AreEqual("Mild", result);
        }
    }
}