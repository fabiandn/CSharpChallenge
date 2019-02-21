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
        public void Calculate_WhenCircleIsPassed_ThenCalculateAreaAndLenghtWithPI(){
            // Arrange
            var area = 0D;
            var length = 0D;
            var radio = 3D;
            var circle = new Circle {
                Radio = radio
            };

            // Act
            MathHelper.Calculate(circle, out area, out length);

            // Assert
            Assert.AreEqual(Math.PI * Math.Pow(radio, 2), area);
            Assert.AreEqual(2 * Math.PI * radio, length);
        }

        [Test]
        public void TryParsePercentage_WhenStringIsPassed_ThenParseTheNumber(){
            // Arrange
            var percentage = "94.5%";

            // Act
            var result = 0D;
            StringHelper.TryParsePercentage(percentage, out result);

            // Assert
            Assert.AreEqual(0.945D, result);
        }
    }
}