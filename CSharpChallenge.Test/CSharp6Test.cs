using NUnit.Framework;
using CSharpChallenge;

namespace Tests
{
    public class CSharp6Test
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void FullName_WhenTheLastNameIsNull_ThenReplaceWithEmptyString()
        {
            // Arrange
            var person = new Person {
                FirstName = "Fabian",
                LastName = null
            };

            // Act
            var result = person.GetFullName();

            // Assert
            Assert.AreEqual("Fabian, Endava", result);
        }
    }
}