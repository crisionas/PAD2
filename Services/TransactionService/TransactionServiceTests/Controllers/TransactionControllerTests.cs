using Microsoft.VisualStudio.TestTools.UnitTesting;
using TransactionService.Controllers;
using System;
using System.Collections.Generic;
using System.Text;
using BusinessLayer.Models;

namespace TransactionService.Controllers.Tests
{
    [TestClass()]
    public class TransactionControllerTests
    {
        [TestMethod()]
        public void PostTest()
        {
            var controller = new TransactionController();

            var transaction = new TransactionMessage
            {
                AccountOwnerId = "0",
                AccountReceiverId = "0",
                Currency = "EUR",
                Amount=1000
            };

            var response = controller.Post(transaction);
            Assert.IsNotNull(response);
        }
    }
}