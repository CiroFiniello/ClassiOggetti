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
    }
}