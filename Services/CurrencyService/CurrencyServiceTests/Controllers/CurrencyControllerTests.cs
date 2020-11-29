using Microsoft.VisualStudio.TestTools.UnitTesting;
using CurrencyService.Controllers;
using System;
using System.Collections.Generic;
using System.Text;
using BusinessLayer.BLModels;

namespace CurrencyService.Controllers.Tests
{
    [TestClass()]
    public class CurrencyControllerTests
    {
        [TestMethod()]
        public void PostTest()
        {
            var controller = new CurrencyController();

            var response = controller.Get();
            Assert.IsNotNull(response);
        }
    }
}