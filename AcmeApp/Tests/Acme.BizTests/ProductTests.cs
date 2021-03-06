﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
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
            var expected = "Hello Xbox (1): Microsoft's gaming console Available on: ";
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
            var expected = "Hello Xbox (1): Microsoft's gaming console Available on: ";
            //Act
            var actual = currentProduct.SayHello();
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void ProductName_Format()
        {
            //Arrange
            var currentProduct = new Product();
            currentProduct.ProductName = "     Xbox     ";
            var expected = "Xbox";
            //Act
            var actual = currentProduct.ProductName;
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CalculateSuggestedPriceTest()
        {
            //Arrange
            var currentProduct = new Product("Xbox", "", 1);
            currentProduct.Cost = 50m;
            var expected = 55m;

            //Act
            var actual = currentProduct.CalculateSuggestedPrice(10m);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}