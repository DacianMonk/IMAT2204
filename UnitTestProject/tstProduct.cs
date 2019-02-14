using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class tstProduct
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsProduct AProduct = new clsProduct();
            Assert.IsNotNull(AProduct); 
        }

        public void ProductNameOK()
        {
            clsProduct AProduct = new clsProduct();
            string SomeProduct = "Toaster";
            AProduct.ProductName = SomeProduct;
            Assert.AreEqual(AProduct.ProductName, SomeProduct); 
        }
    }
}
