using System;

using Xunit;

namespace CSharpEksempler.OOP.Abstraktion
{
    public class KundeTest
    {
        [Fact]
        public void Navn_SetValidName_ShouldSetName()
        {
            // Arrange
            var kunde = new Kunde();
            var validName = "John Doe";

            // Act
            kunde.Navn = validName;

            // Assert
            Assert.Equal(validName, kunde.Navn);
        }

        [Fact]
        public void Navn_SetInvalidName_ShouldThrowArgumentException()
        {
            // Arrange
            var kunde = new Kunde();

            // Act & Assert
            Assert.Throws<ArgumentException>(() => kunde.Navn = "");
        }

        [Fact]
        public void Alder_SetValidAge_ShouldSetAge()
        {
            // Arrange
            var kunde = new Kunde();
            var validAge = 30;

            // Act
            kunde.Alder = validAge;

            // Assert
            Assert.Equal(validAge, kunde.Alder);
        }

        [Fact]
        public void Alder_SetInvalidAge_ShouldThrowArgumentException()
        {
            // Arrange
            var kunde = new Kunde();

            // Act & Assert
            Assert.Throws<ArgumentException>(() => kunde.Alder = -1);
        }

        
    }

    
}
