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

        [Test]
        public void FullName_WhenTheFirstNameIsNull_ThenReplaceWithEmptyString()
        {
            // Arrange
            var person = new Person {
                FirstName = null,
                LastName = "Diaz"
            };

            // Act
            var result = person.GetFullName();

            // Assert
            Assert.AreEqual("Diaz, Endava", result);
        }

        [Test]
        public void FullName_WhenTheCompanyIsNull_ThenReplaceWithEndava()
        {
            // Arrange
            var person = new Person(null) {
                FirstName = "Fabian",
                LastName = "Diaz"
            };

            // Act
            var result = person.GetFullName();

            // Assert
            Assert.AreEqual("Fabian Diaz, Endava", result);
        }

        [Test]
        public void FullName_WhenTheFirstNameAndLastNameIsNull_ThenReplaceWithEmptyString()
        {
            // Arrange
            var person = new Person(null) {
                FirstName = null,
                LastName = null
            };

            // Act
            var result = person.GetFullName();

            // Assert
            Assert.AreEqual(", Endava", result);
        }
    }
}