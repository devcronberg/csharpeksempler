using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xunit;

namespace CSharpEksempler.OOP.Polymorfi
{
    public class PersonTest
    {
        [Fact]
        public void Navn_SetValidName_ShouldSetName()
        {
            // Arrange
            var person = new Person();
            var validName = "John Doe";

            // Act
            person.Navn = validName;

            // Assert
            Assert.Equal(validName, person.Navn);
        }

        [Fact]
        public void By_SetValidCity_ShouldSetCity()
        {
            // Arrange
            var person = new Person();
            var validCity = "Copenhagen";

            // Act
            person.By = validCity;

            // Assert
            Assert.Equal(validCity, person.By);
        }



        [Fact]
        public void DanskPerson_SetValidCPR_ShouldSetCPR()
        {
            // Arrange
            var danskPerson = new DanskPerson();
            var validCPR = "123456-7890";

            // Act
            danskPerson.CPR = validCPR;

            // Assert
            Assert.Equal(validCPR, danskPerson.CPR);
        }



        [Fact]
        public void SpanskPerson_SetValidNIE_ShouldSetNIE()
        {
            // Arrange
            var spanskPerson = new SpanskPerson();
            var validNIE = "X1234567A";

            // Act
            spanskPerson.NIE = validNIE;

            // Assert
            Assert.Equal(validNIE, spanskPerson.NIE);
        }





    }

}

