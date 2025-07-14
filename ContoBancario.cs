using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassiOggetti
{
    internal class ContoBancario
    {
        public ContoBancario() {
        
        Saldo = 0; // Inizializza il saldo a zero
        input = 0;
        }
        public decimal Saldo { get; set; }
        private decimal input { get; set; }

        public void Deposita(decimal input)
        {
            if (input > 0)
            {
                Saldo += input;
                Console.WriteLine($"Deposito di {input:C} effettuato. Saldo attuale: {Saldo:C}");
            }
            else
            {
                Console.WriteLine("L'importo del deposito deve essere positivo.");
            }
        }

        public void Preleva(decimal input)
        {
            if (input > 0 && input <= Saldo)
            {
                Saldo -= input;
                Console.WriteLine($"Prelievo di {input:C} effettuato. Saldo attuale: {Saldo:C}");
            }
            else if (input > Saldo)
            {
                Console.WriteLine("Fondi insufficienti per il prelievo.");
            }
            else
            {
                Console.WriteLine("L'importo del prelievo deve essere positivo.");
            }
        }


    }
}
