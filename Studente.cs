using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassiOggetti
{

    internal class Studente
    {
        public Studente(Array voti)
        {
            Voti = voti;
        }

        public Array Voti { get; set; }

        public double CalcolaMedia()
        {
            if (Voti.Length == 0) return 0;
            double somma = 0;
            foreach (var voto in Voti)
            {
                somma += Convert.ToDouble(voto);
            }
            return somma / Voti.Length;
        }
    }
}
