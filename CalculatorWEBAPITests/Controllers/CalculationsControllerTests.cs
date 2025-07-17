using CalculatorWEBAPI.Context;

using CalculatorWEBAPI.Controllers;

using CalculatorWEBAPI.Model;

using Microsoft.AspNetCore.Http.HttpResults;

using Microsoft.AspNetCore.Mvc;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

namespace CalculatorWEBAPI.Controllers.Tests

{

    [TestClass()]

    public class CalculationsControllerTests1

    {

        private CalculationsController _controller;



        [TestInitialize]

        public void Inint()

        {

            OperationContext context = new OperationContext();

            _controller = new CalculationsController(context);

        }

        [TestMethod()]

        public async Task PostCalculationsTest()

        {

            // Arrange

            int expected = 10;

            // Act

            var actionResult = await _controller.PostCalculations(3, 7, "+");

            // Assert - check the type of the ActionResult

            Assert.IsInstanceOfType(actionResult.Result, typeof(CreatedAtActionResult));

            var createdResult = actionResult.Result as CreatedAtActionResult;

            Assert.IsNotNull(createdResult);

            var calculation = createdResult.Value as Calculations;

            Assert.IsNotNull(calculation, "Returned value is not of type Calculations");

            // Final result check

            Assert.AreEqual(expected, calculation.Result);

        }

        [TestMethod()]

        public async Task PostCalculationsTest1()

        {

            // Arrange

            int expected = 6;

            // Act

            var actionResult = await _controller.PostCalculations(13, 7, "-");

            // Assert - check the type of the ActionResult

            Assert.IsInstanceOfType(actionResult.Result, typeof(CreatedAtActionResult));

            var createdResult = actionResult.Result as CreatedAtActionResult;

            Assert.IsNotNull(createdResult);

            var calculation = createdResult.Value as Calculations;

            Assert.IsNotNull(calculation, "Returned value is not of type Calculations");

            // Final result check

            Assert.AreEqual(expected, calculation.Result);

        }

        [TestMethod()]

        public async Task PostCalculationsTest2()

        {

            // Arrange

            int expected = 21;

            // Act

            var actionResult = await _controller.PostCalculations(3, 7, "*");

            // Assert - check the type of the ActionResult

            Assert.IsInstanceOfType(actionResult.Result, typeof(CreatedAtActionResult));

            var createdResult = actionResult.Result as CreatedAtActionResult;

            Assert.IsNotNull(createdResult);

            var calculation = createdResult.Value as Calculations;

            Assert.IsNotNull(calculation, "Returned value is not of type Calculations");

            // Final result check

            Assert.AreEqual(expected, calculation.Result);

        }

    }

}
