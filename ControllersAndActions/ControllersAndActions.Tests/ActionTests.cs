using System;
using Xunit;
using Microsoft.AspNetCore.Mvc;
using ControllersAndActions.Controllers;


namespace ControllersAndActions.Tests
{
    public class ActionTests
    {

        /*
        [Fact]
        public void ModelObjectType()
        {

            ExampleController controller = new ExampleController();
            ViewResult result = controller.Index();
            Assert.IsType<string>(result.ViewData["Message"]);
            Assert.Equal("Hello", result.ViewData["Message"]);
            Assert.IsType<System.DateTime>(result.ViewData["Date"]);

        }
        
        
        [Fact]
        public void Redirect()
        {
            ExampleController controller = new ExampleController();
            RedirectResult result = controller.Redirect();
            Assert.Equal("/Example/Index", result.Url);
            Assert.True(result.Permanent);
        }
        
        
        [Fact]
        public void Redirection()
        {
            ExampleController controller = new ExampleController();
            RedirectToActionResult result = controller.Redirect();

            Assert.False(result.Permanent);
            Assert.Equal("Index", result.ActionName);
        }
        */

        [Fact]
        public void NotFoundActionMethod()
        {
            ExampleController controller = new ExampleController();
            StatusCodeResult result = controller.Index();

            Assert.Equal(404, result.StatusCode);
        }
    } 
}
