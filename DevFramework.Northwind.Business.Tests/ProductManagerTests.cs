﻿//using System;
//using DevFramework.Northwind.Business.Concrete.Managers;
//using DevFramework.Northwind.DataAccess.Abstract;
//using DevFramework.Northwind.Entities.Concrete;
//using DevFramework.Core.CrossCuttingConcerns.Validation.FluentValidation;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using Moq;

//namespace DevFramework.Northwind.Business.Tests
//{
//    [TestClass]
//    public class ProductManagerTests
//    {
//        //[ExpectedException(typeof(ValidationException))]
//        [TestMethod]
//        public void Product_validation_check()
//        {
//            Mock<IProductDal> mock = new Mock<IProductDal>();
//            ProductManager productManager = new ProductManager(mock.Object);

//            productManager.Add(new Product());

//        }
//    }
//}
