using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xunit;


    namespace CSharpEksempler.OOP.IMutableObjekter
    {
        public class PersonTest
        {
            [Fact]
            public void Constructor_ShouldInitializeProperties()
            {
                // Arrange
                var navn = "John Doe";
                var by = "Copenhagen";

                // Act
                var person = new Person(navn, by);

                // Assert
                Assert.Equal(navn, person.Navn);
                Assert.Equal(by, person.By);
            }


            [Fact]
            public void ConstructorInit_ShouldInitializeProperties()
            {
                // Arrange
                var navn = "John Doe";
                var by = "Copenhagen";
                // Act
                var person = new Person() { Navn = navn, By = by };
                // Assert
                Assert.Equal(navn, person.Navn);
                Assert.Equal(by, person.By);
            }
        }

    }
