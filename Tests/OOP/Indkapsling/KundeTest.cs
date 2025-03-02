
using CSharpEksempler.OOP.Indkapsling.UdenIndkapsling;
using CSharpEksempler.OOP.Indkapsling.MedIndkapsling;
using Xunit;
using System;
using System.IO;

namespace CSharpEksempler.OOP.Indkapsling.Tests
{
    public class KundeTest
    {
        [Fact]
        public void TestUdenIndkapslingKunde()
        {
            var kunde = new UdenIndkapsling.Kunde
            {
                Navn = "John Doe",
                Alder = 30
            };

            Assert.Equal("John Doe", kunde.Navn);
            Assert.Equal(30, kunde.Alder);
        }

        [Fact]
        public void TestMedIndkapslingKunde()
        {
            var kunde = new MedIndkapsling.Kunde
            {
                Navn = "Jane Doe",
                Alder = 25
            };

            Assert.Equal("Jane Doe", kunde.Navn);
            Assert.Equal(25, kunde.Alder);
        }

        [Fact]
        public void TestMedIndkapslingKundeInvalidNavn()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                var kunde = new MedIndkapsling.Kunde
                {
                    Navn = "",
                    Alder = 25
                };
            });
        }

        [Fact]
        public void TestMedIndkapslingKundeInvalidAlder()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                var kunde = new MedIndkapsling.Kunde
                {
                    Navn = "Jane Doe",
                    Alder = -5
                };
            });
        }

        [Fact]
        public void TestUdenIndkapslingUdskrivInfo()
        {
            var kunde = new UdenIndkapsling.Kunde
            {
                Navn = "John Doe",
                Alder = 30
            };

            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                kunde.UdskrivInfo();
                var result = sw.ToString().Trim();
                Assert.Equal("Navn: John Doe, Alder: 30", result);
            }
        }

        [Fact]
        public void TestMedIndkapslingUdskrivInfo()
        {
            var kunde = new MedIndkapsling.Kunde
            {
                Navn = "Jane Doe",
                Alder = 25
            };

            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                kunde.UdskrivInfo();
                var result = sw.ToString().Trim();
                Assert.Equal("Navn: Jane Doe, Alder: 25", result);
            }
        }
    }
}
