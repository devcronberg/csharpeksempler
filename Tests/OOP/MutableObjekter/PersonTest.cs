using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xunit;

    namespace CSharpEksempler.OOP.MutableObjekter
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
            public void Navn_ChangeName_ShouldUpdateName()
            {
                // Arrange
                var person = new Person { Navn = "John Doe" };
                var newName = "Jane Doe";

                // Act
                person.Navn = newName;

                // Assert
                Assert.Equal(newName, person.Navn);
            }

            [Fact]
            public void By_ChangeCity_ShouldUpdateCity()
            {
                // Arrange
                var person = new Person { By = "Copenhagen" };
                var newCity = "Aarhus";

                // Act
                person.By = newCity;

                // Assert
                Assert.Equal(newCity, person.By);
            }
        }
    }
