using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using D02_UnitTest_MVC_Client.Controllers;
using System.Web.Mvc;

namespace D02_UnitTest_MVC_Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AboutAction_ShouldReturnAboutView_Error()
        {

            var controller = new HomeController();
            
            var result = controller.About() as ViewResult;

            Assert.AreEqual("About" , result.ViewName);

        }
    }
}
