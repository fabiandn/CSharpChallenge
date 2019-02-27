using System;
using NUnit.Framework;
using CSharpChallenge;

namespace Tests
{
    public class CSharp7Test
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Calculate_WhenCircleIsPassed_ThenCalculateAreaAndLenght(){
            // Arrange
            var radio = 3D;
            var circle = new Circle {
                Radio = radio
            };

            // Act
            var result = MathHelper.Calculate(circle);

            // Assert
            Assert.AreEqual(Math.PI * Math.Pow(radio, 2), result.Area);
            Assert.AreEqual(2 * Math.PI * radio, result.Length);
        }

        [Test]
        public void Calculate_WhenShapeIsPassed_ThenCalculateTupleZero(){
            // Arrange
            var circle = new Shape();

            // Act
            var result = MathHelper.Calculate(circle);

            // Assert
            Assert.AreEqual(0, result.Area);
            Assert.AreEqual(0, result.Length);
        }

        [Test]
        public void TryParsePercentage_WhenPercentageStringIsPassed_ThenParseTheNumber(){
            // Arrange
            var value = "94.5%";

            // Act
            var result = StringHelper.TryParsePercentage(value, out double percentage);

            // Assert
            Assert.True(result);
            Assert.AreEqual(0.945D, percentage);
        }

        [Test]
        public void TryParsePercentage_WhenNullIsPassed_ThenReturnFalse(){
            // Act
            var result = StringHelper.TryParsePercentage(null, out double percentage);

            // Assert
            Assert.False(result);
            Assert.AreEqual(0D, percentage);
        }

        [Test]
        public void TryParsePercentage_WhenSomeStringIsPassed_ThenReturnFalse(){
            // Arrange
            var value = "test";

            // Act
            var result = StringHelper.TryParsePercentage(value, out double percentage);

            // Assert
            Assert.False(result);
            Assert.AreEqual(0, percentage);
        }
    }
}