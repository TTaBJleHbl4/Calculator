namespace TestProject1
{


    [TestFixture]
            public class CalculatorTests
        {
            [Test]
            public void Add_TwoPositiveNumbers_ReturnsCorrectResult()
            {
                // Arrange
                double a = 5;
                double b = 3;
                string operation = "+";

                // Act
                double result = PerformOperation(a, b, operation);

                // Assert
                Assert.AreEqual(8, result, 0.001);
            }

            [Test]
            public void Subtract_TwoPositiveNumbers_ReturnsCorrectResult()
            {
                // Arrange
                double a = 10;
                double b = 4;
                string operation = "-";

                // Act
                double result = PerformOperation(a, b, operation);

                // Assert
                Assert.AreEqual(6, result, 0.001);
            }

            [Test]
            public void Multiply_TwoPositiveNumbers_ReturnsCorrectResult()
            {
                // Arrange
                double a = 7;
                double b = 2;
                string operation = "*";

                // Act
                double result = PerformOperation(a, b, operation);

                // Assert
                Assert.AreEqual(14, result, 0.001);
            }

            [Test]
            public void Divide_TwoPositiveNumbers_ReturnsCorrectResult()
            {
                // Arrange
                double a = 8;
                double b = 2;
                string operation = "/";

                // Act
                double result = PerformOperation(a, b, operation);

                // Assert
                Assert.AreEqual(4, result, 0.001);
            }

            [Test]
            public void Divide_ByZero_ThrowsDivideByZeroException()
            {
                // Arrange
                double a = 8;
                double b = 0;
                string operation = "/";

                // Act и Assert
                Assert.ThrowsException<DivideByZeroException>(() => PerformOperation(a, b, operation));
            }

            // Метод, который выполняет операцию (аналогично логике калькулятора)
            private double PerformOperation(double a, double b, string operation)
            {
                switch (operation)
                {
                    case "+":
                        return a + b;
                    case "-":
                        return a - b;
                    case "*":
                        return a * b;
                    case "/":
                        if (b == 0)
                        {
                            throw new DivideByZeroException("Division by zero is not allowed.");
                        }
                        return a / b;
                    default:
                        throw new ArgumentException("Invalid operation", nameof(operation));
                
            }
        }
    }
}
