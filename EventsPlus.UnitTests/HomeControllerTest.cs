using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Web.Mvc;

namespace EventsPlus.UnitTests
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            //Arrange
            HomeController controller = new HomeController();

            //Act
            var result = controller.Index();

            //Assert
            Assert.IsNotNull(result);
            Assert.IsNotNull(result.Model); // add additional checks on the Model
            Assert.IsTrue(string.IsNullOrEmpty(result.ViewName) || result.ViewName == "Index");
        }
    }
}

    
   
