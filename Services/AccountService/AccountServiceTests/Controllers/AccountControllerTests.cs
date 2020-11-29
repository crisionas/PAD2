using Microsoft.VisualStudio.TestTools.UnitTesting;
using AccountService.Controllers;
using System;
using System.Collections.Generic;
using System.Text;
using BusinessLayer;
using Microsoft.AspNetCore.Http.Connections;
using System.Net.Http;
using System.Web.Http.Routing;
using System.Web.Http;

namespace AccountService.Controllers.Tests
{
    [TestClass()]
    public class AccountControllerTests
    {
        [TestMethod()]
        public void PostTest()
        {
            var controller = new AccountController();
           



            var data = new AccountMessage();
            data.Balance = 2;
            data.FirstName = "Tiora";
            data.LastName = "Alexandru";


            var response = controller.Post(data);
            Assert.IsNotNull(response);
        }


    }
}

namespace AccountServiceTests.Controllers
{
    class AccountControllerTests
    {
    }
}
