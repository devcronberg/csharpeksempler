namespace CSharpEksempler.OOP.Abstraktion
{
    public class Kunde
    {
        private string? _navn;
        private int _alder;

        public string? Navn
        {
            get { return _navn; }
            set
            {
                if (ErNavnGyldigt(value))
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
                if (ErAlderGyldig(value))
                    _alder = value;
                else
                    throw new ArgumentException("Alder skal være positiv.");
            }
        }

        public void UdskrivInfo()
        {
            Print($"Navn: {Navn}, Alder: {Alder}");
        }

        private void Print(string? tekst)
        {
            Console.WriteLine(tekst);
        }

        private bool ErNavnGyldigt(string? navn)
        {
            return !string.IsNullOrWhiteSpace(navn);
        }

        private bool ErAlderGyldig(int alder)
        {
            return alder > 0;
        }

    }
}
