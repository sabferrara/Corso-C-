// See https://aka.ms/new-console-template for more information
using System;

namespace ConsoleApp1
{
    internal class Program
    {
        public static void Main(string[] args)

        {
            int numero; //inializzazione
            Console.WriteLine("Inserisci un numero da 1 a 3");
            numero = Convert.ToInt32(Console.ReadLine());

            switch (numero)
            {
                case 1:
                    Console.WriteLine("Hai scelto il numero 1");
                    break;
                case 2:
                    Console.WriteLine("Hai scelto il numero 2");
                    break;
                case 3:
                    Console.WriteLine("Hai scelto il numero 3");
                    break;
            }
            //ESERCIZIO 1: Attraverso uno switch chiedere all'utente di scrivere un numero e restiruitre l'analogo giorno della settimana
            int giorno; 
            Console.WriteLine("Inserisci un numero da 1 a 7");
            giorno = Convert.ToInt32(Console.ReadLine());

            switch (giorno)
            {
                case 1: Console.WriteLine("Lunedi");
                    break;
                case 2: Console.WriteLine("Martedì");
                    break;
                case 3: Console.WriteLine("Mercoledì");
                    break;
                case 4: Console.WriteLine("Giovedì");
                    break;
                case 5: Console.WriteLine("Venerdì");
                    break;
                case 6: Console.WriteLine("Sabato");
                    break;
                case 7: Console.WriteLine("Domenica");
                    break;
            }
            //ESERCZIO 2: Creare una mini-calcolatrice partendo da due variabili numeriche.
            //Attraverso uno switch case, chiedere all'utente il tipo di operazione e svolgerla

            int numb1;
            Console.WriteLine("Inserisci il primo numero: ");
            numb1 = Convert.ToInt32(Console.ReadLine());
            
            int numb2;
            Console.WriteLine("Inserisci il primo numero: ");
            numb2 = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Scegli l'operazione: 1 per Somma, 2 per Sottrazione, 3 per Moltiplicazione, 4 per Divisione");
            int operazione = Convert.ToInt32(Console.ReadLine());
            
            switch (operazione)
            {
                case 1: int somma = numb1 +numb2; 
                    Console.WriteLine("Risultato Somma: " +somma);
                    break;
                case 2: int sottrazione = numb1 - numb2;
                    Console.WriteLine("Risultato Differenza: " + sottrazione);
                    break;
                case 3: int moltiplicazione = numb1 * numb2;
                    Console.WriteLine("Risultato Moltiplicazione: " + moltiplicazione);
                    break;
                case 4: int divisione = numb1 / numb2; 
                    Console.WriteLine("Risultato Divisione: "+ divisione);
                    break;
            }
        }
     
            
            

    } 
}