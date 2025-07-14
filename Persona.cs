using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassiOggetti
{
    internal class Persona
    {
        public string Nome { get; set; }
        public int Eta { get; set; }

        public void Parla()
        {
            Console.WriteLine($"Ciao, mi chiamo {Nome} e ho {Eta} anni.");
        }
    }
}
