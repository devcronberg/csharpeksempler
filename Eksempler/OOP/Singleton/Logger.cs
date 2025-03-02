using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEksempler.OOP.Singleton
{
    using System;

    /// <summary>
    /// Logger-klassen implementerer Singleton-mønsteret for at sikre, at der kun er én instans af Logger.
    /// Denne klasse bruges til at logge beskeder med tidsstempler.
    /// Man kunne overveje at bruge Lazy<T> til at udskyde oprettelsen af instansen til første kald.
    /// </summary>
    public sealed class Logger
    {

        private static readonly Logger _instance = new();

        // Privat konstruktør for at forhindre
        // instansiering af Logger.
        private Logger()
        { }

        // Egenskab til at hente instansen af Logger.
        public static Logger Instance => _instance;

        /// <summary>
        /// Logger en besked med et tidsstempel.
        /// </summary>
        /// <param name="message">Beskeden der skal logges.</param>
        public void Log(string message)
        {
            Console.WriteLine($"[{DateTime.Now:HH:mm:ss}] {message}");
        }
    }

}
