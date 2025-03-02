namespace CSharpEksempler.OOP.Indkapsling
{

    namespace UdenIndkapsling
    {
        public class Kunde
        {
            public string? Navn;
            public int Alder;

            public void UdskrivInfo()
            {
                Print($"Navn: {Navn}, Alder: {Alder}");
            }

            public void Print(string? tekst)
            {
                Console.WriteLine(tekst);
            }
        }
    }

    namespace MedIndkapsling
    {
        public class Kunde
        {
            // Private felter (indkapsling)
            private string? _navn;
            private int _alder;

            // Egenskaber med validering
            public string? Navn
            {
                get { return _navn; }
                set
                {
                    if (!string.IsNullOrWhiteSpace(value))
                        _navn = value;
                    else
                        throw new ArgumentException("Navn kan ikke være tomt.");
                }
            }

            public int Alder
            {
                get { return _alder; }
                set
                {
                    if (value > 0)
                        _alder = value;
                    else
                        throw new ArgumentException("Alder skal være positiv.");
                }
            }

            public void UdskrivInfo()
            {
                Console.WriteLine($"Navn: {Navn}, Alder: {Alder}");
            }

            private void Print(string? tekst)
            {
                Console.WriteLine(tekst);
            }

        }
    }
}