using Microsoft.AspNetCore.Mvc;
using myMVC.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace mymvc.test.Controller
{
    public class TestHomeController
    {
        [Fact]
        public void TestIndexMethod()
        {
            var controller = new HomeController();
            var result = controller.Index() as ViewResult;
            Assert.Equal("Index", result.ViewName);
        }

        [Fact]
        public void TestAboutMethod()
        {
            var controller = new HomeController();
            var result = controller.About() as ViewResult;
            Assert.Equal("About", result.ViewName);
        }
    }
}
