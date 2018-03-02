using Microsoft.VisualStudio.TestTools.UnitTesting;
using Acme.Biz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.Biz.Tests
{
    [TestClass()]
    public class ProductTests
    {
        [TestMethod()]
        public void SayHelloTest()
        {
            //Arrange
            var currentProduct = new Product();
            currentProduct.ProductId = 1;
            currentProduct.ProductName = "Xbox";
            currentProduct.Description = "Microsoft's gaming console";
            currentProduct.ProductVendor.CompanyName = "ABC Corp";
            var expected = "Hello Xbox (1): Microsoft's gaming console";
            //Act
            var actual = currentProduct.SayHello();
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SayHelloParameterisedTest()
        {
            //Arrange
            var currentProduct = new Product("Xbox", "Microsoft's gaming console", 1);
            var expected = "Hello Xbox (1): Microsoft's gaming console";
            //Act
            var actual = currentProduct.SayHello();
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}