using System;
using Xunit;
using Microsoft.AspNetCore.Mvc;
using ControllersAndActions.Controllers;


namespace ControllersAndActions.Tests
{
    public class ActionTests
    {
        [Fact]
        public void NotFoundActionMethod()
        {
            ExampleController controller = new ExampleController();
            StatusCodeResult result = controller.Index();
            Assert.Equal(404, result.StatusCode);

        }
    }
}
