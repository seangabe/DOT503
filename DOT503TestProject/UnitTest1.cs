using DOT503;
using DOT503.Controllers;
using DOT503.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DOT503TestProject
{
    [TestClass]
    public class HomeControllerTests
    {
        [TestMethod]
        public void Calculate_Addition_ReturnsCorrectResult()
        {
            // Arrange
            var controller = new HomeController();
            var model = new CalculatorModel { FirstNumber = 5, SecondNumber = 3, Operator = "+" }; 


            var result = controller.Calculate(model);
            // Act            
            if (result is ViewResult viewResult)
            {
                // Handle ViewResult scenario (e.g., ModelState errors)
                var modelResult = viewResult.Model as CalculatorModel;
                Assert.AreEqual("Index", viewResult.ViewName);
                Assert.AreEqual(8, modelResult.Result);
            }
        }


        [TestMethod]
        public void Calculate_Subtraction_ReturnsCorrectResult()
        {
            // Arrange
            var controller = new HomeController();
            var model = new CalculatorModel { FirstNumber = 5, SecondNumber = 3, Operator = "-" };


            var result = controller.Calculate(model);
            // Act            
            if (result is ViewResult viewResult)
            {
                // Handle ViewResult scenario (e.g., ModelState errors)
                var modelResult = viewResult.Model as CalculatorModel;
                Assert.AreEqual("Index", viewResult.ViewName);
                Assert.AreEqual(2, modelResult.Result);
            }
        }


        [TestMethod]
        public void Calculate_Multiplication_ReturnsCorrectResult()
        {
            // Arrange
            var controller = new HomeController();
            var model = new CalculatorModel { FirstNumber = 5, SecondNumber = 3, Operator = "*" };


            var result = controller.Calculate(model);
            // Act            
            if (result is ViewResult viewResult)
            {
                // Handle ViewResult scenario (e.g., ModelState errors)
                var modelResult = viewResult.Model as CalculatorModel;
                Assert.AreEqual("Index", viewResult.ViewName);
                Assert.AreEqual(15, modelResult.Result);
            }
        }

        [TestMethod]
        public void Calculate_Division_ReturnsCorrectResult()
        {
            // Arrange
            var controller = new HomeController();
            var model = new CalculatorModel { FirstNumber = 15, SecondNumber = 3, Operator = "/" };


            var result = controller.Calculate(model);
            // Act            
            if (result is ViewResult viewResult)
            {
                // Handle ViewResult scenario (e.g., ModelState errors)
                var modelResult = viewResult.Model as CalculatorModel;
                Assert.AreEqual("Index", viewResult.ViewName);
                Assert.AreEqual(8, modelResult.Result);
            }
        }


        [TestMethod]
        public void Calculate_Modulo_ReturnsCorrectResult()
        {
            // Arrange
            var controller = new HomeController();
            var model = new CalculatorModel { FirstNumber = 5, SecondNumber = 3, Operator = "%" };


            var result = controller.Calculate(model);
            // Act            
            if (result is ViewResult viewResult)
            {
                // Handle ViewResult scenario (e.g., ModelState errors)
                var modelResult = viewResult.Model as CalculatorModel;
                Assert.AreEqual("Index", viewResult.ViewName);
                Assert.AreEqual(0, modelResult.Result);
            }
        }
    }
}