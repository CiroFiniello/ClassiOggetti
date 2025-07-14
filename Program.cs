//✅ classi, metodi, costruttori

//Crea una classe Persona con Nome, Età, Parla()

//Classe ContoBancario con Deposita() e Preleva()

//Classe Studente con lista di voti e CalcolaMedia()

using ClassiOggetti;
using System;
using System.Collections;
class Program
{
    static void Main()
    {
        Console.WriteLine("Classi e Oggetti");
        // Creazione di un oggetto Persona
        Persona persona1 = new Persona();
        Console.WriteLine("Inserisci il nome della persona:");
        persona1.Nome = Console.ReadLine();
        Console.WriteLine("Inserisci l'età della persona:");
        persona1.Eta = int.Parse(Console.ReadLine());
        persona1.Parla();
        Console.WriteLine("testiamo il getter");
        Console.WriteLine(persona1.Nome);

        // Conto Bancario Deposita e Preleva
        ContoBancario conto = new ContoBancario();
        Console.WriteLine("Vuoi depositare , prelevare o verificare il saldo?");
        Console.WriteLine("Digita 'deposito' per depositare, 'prelievo' per prelevare, 'saldo' per verificare il saldo. ");
        Console.WriteLine("Digita 'exit' se vuoi uscire dal menù");
        string scelta = Console.ReadLine().ToLower();

       while( scelta != "exit")
        {
            switch (scelta)
            {
                case "deposito":
                    Console.WriteLine("Inserisci l'importo da depositare:");
                    decimal deposito = decimal.Parse(Console.ReadLine());
                    conto.Deposita(deposito);
                    break;
                case "prelievo":
                    Console.WriteLine("Inserisci l'importo da prelevare:");
                    decimal prelievo = decimal.Parse(Console.ReadLine());
                    conto.Preleva(prelievo);
                    break;
                case "saldo":
                    Console.WriteLine($"Il saldo attuale è: {conto.Saldo:C}");
                    break;
                default:
                    Console.WriteLine("Scelta non valida. Riprova.");
                    break;
            }
            Console.WriteLine("Vuoi depositare , prelevare o verificare il saldo?");
            Console.WriteLine("Digita 'deposito' per depositare, 'prelievo' per prelevare, 'saldo' per verificare il saldo. ");
            Console.WriteLine("Digita 'exit' se vuoi uscire dal menù");
            scelta = Console.ReadLine().ToLower();
        }
        Console.WriteLine("Uscita dal programma.");

        // Creazione di un oggetto Studente
        Console.WriteLine("Inserisci il numero di voti dello studente:");
        int[] array1 = new int[5];

        for (int i = 0; i < array1.Length; i++)
        {
            Console.WriteLine("Inserisci un numero:");
            array1[i] = Convert.ToInt32(Console.ReadLine());
        }
        Studente studente1 = new Studente(array1);

        Console.WriteLine("Voti inseriti:");
        for (int i = 0; i < studente1.Voti.Length; i++)
        {
            Console.Write(studente1.Voti.GetValue(i)+ " " );
        }
       
        Console.WriteLine($"\nLa media dei voti è: {studente1.CalcolaMedia()}");
    }
}