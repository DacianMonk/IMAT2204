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

        public void ProductNoOK()
        {
            clsProduct AProduct = new clsProduct();
            Int32 SomeProduct = 1;
            AProduct.ProductNo = SomeProduct;
            Assert.AreEqual(AProduct.ProductNo, SomeProduct);
        }
    }
}
