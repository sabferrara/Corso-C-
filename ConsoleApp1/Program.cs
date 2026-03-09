// See https://aka.ms/new-console-template for more information
using System;

namespace ConsoleApp1
{
    internal class Program
    {
        public static void Main(string[] args)

        {
            string nome = "Sabrina";
            Console.WriteLine("Ciao "+nome);
            
            int a = 5;
            int b = 10;
            
            int moltiplicazione = a * b;
            int somma = a + b;
            int sottrazione = a - b;
            int divisione = a / b;
            Console.WriteLine("La somma è: "+ somma);
            Console.WriteLine("La sottrazione è: "+ sottrazione);
                    Console.WriteLine("La moltiplicazione è: "+ moltiplicazione);
                    Console.WriteLine("La divisione è: "+divisione);
                    
            //Esercizio 2: calcola area e perimetro di un rettangolo
            int ba = 4;
            int altezza = 2;
            int area =  ba * altezza;
            int perimetro = 2 * (ba + altezza);
            Console.WriteLine("L'area del rettangolo è: " + area);
            Console.WriteLine("La perimetro del retangolo: " + perimetro);
            
            //Esercizio 3: un triangolo ha base=8 e altezza=6. Calcola area.
            int bas = 8;
            int alt = 6;
            int ar = (bas * alt) / 2;
                        Console.WriteLine("L'area del triangolo è: " + ar);
                        
            //Esercizio 4: Un cerchio ha raggio= 8 e pi= 3.14, Calcola area e circonferenza
            int raggio = 8;
            float pi = 3.14f;
            float arecerchio = pi * (raggio * raggio);
            float circonferenza = 2 * pi * raggio;
            Console.WriteLine("L'area del cerchio è: " + arecerchio );
            Console.WriteLine("La circonferenza è: " + circonferenza);
            
            Console.WriteLine("Inserisci il primo numero: ");
            string numero1 = Console.ReadLine();
            
            Console.WriteLine("Inserisci il secondo numero: "); 
            string numero2 = Console.ReadLine();

            int num1 = 0; //0 è il valore di partenza
            int num2 = 0;
            
            num1 = int.Parse(numero1);
            num2 = int.Parse(numero2);
            
            int sommax = num1 + num2;
            Console.WriteLine("Ecco la somma: " + sommax);
            
            //controllo sui numeri 
            if (num1 > num2) 
            {
                Console.WriteLine("numero1 maggiore");
            } else if (num1 < num2)
            {
                Console.WriteLine("numero2 maggiore");
            }
            else
            {
                Console.WriteLine("I numeri sono uguali");
            }
            //se volessi dire che num1 e num2 sono maggiore di num3, && è equivalente dell'and.
            // if (num1 && num2 > num3)
            // num 1 e num2 devono essere uguali ma diversi da num3, !
            //if (num1 && num2 ! num3)
            // o uno o laltro ||
            // if (num1 && num2 || num3)
            
            
            
            //ESERCIZIO 1: Il programma legge 3 numeri e controllla se tutti i casi di if-else come nell'esempio
            Console.WriteLine("Inserisci il primo numero: ");
            string numer1 = Console.ReadLine();
            
            Console.WriteLine("Inserisci il secondo numero: "); 
            string numer2 = Console.ReadLine();
            
            Console.WriteLine("Inserisci il terzo numero: ");
            string numer3 = Console.ReadLine();
            
            int nume1 = 0; //0 è il valore di partenza
            int nume2 = 0;
            int nume3 = 0;
            
            nume1 = int.Parse(numer1);
            nume2 = int.Parse(numer2);
            nume3 = int.Parse(numer3);

            if (nume1 >= nume2 && nume1 >= nume3)
            {
                Console.WriteLine("Il primo numero è il più grande.");
            }
            else if (nume2 >= nume1 && nume2 >= nume3)
            {
                Console.WriteLine("Il secondo numero è il più grande.");
            }
            else
            {
                Console.WriteLine("Il terzo numero è il più grande.");
            }

//ESERCIZIO 2: L'utente inserisce la propria età e il programma dice se è maggiorenne(età>=18)

        Console.WriteLine("Inserisci età utente: ");
        string eta =  Console.ReadLine();

        int anni = 0;

        anni = int.Parse(eta);

        if (anni >= 18)
        {
            Console.WriteLine("Maggiorenne");
        }
        else
        {
            Console.WriteLine("Minorenne");
        }
//ESERCIZIO 3: Dati 3 numeri da input, stabilire se è un triangolo equilatero, isoscele o scaleno.
         
        Console.WriteLine("Inserisci numeri in input:");
        string lato1 =  Console.ReadLine();
        string lato2 = Console.ReadLine();
        string lato3 = Console.ReadLine();

        int lat1 = 0;
        int lat2 = 0;
        int lat3 = 0;
        
        lat1 = int.Parse(lato1);
        lat2 = int.Parse(lato2);
        lat3 = int.Parse(lato3);

        if (lat1 == lat2 && lat2 == lat3)
        {
            Console.WriteLine("Triangolo Equilatero");
        }
        else if (lat1 == lat2 || lat1 == lat3 || lat2 == lat3)
        {
            Console.WriteLine("Triangolo Isoscele");
        }
        else
        {
            Console.WriteLine("Triangolo Scaleno");
        }
// ESERCIZIO 4: La prima volta che l'uomo è andato sulla Luna è stato il 1969, creare un programma che chiede l'anno di nascita
// all'utente e gli risponde se è nato l'anno in cui l'uomo èeandato sulla luna o quanti anni primo o dopo. 
        
        Console.WriteLine("Inserisci anno di nascita: ");
        string anno =  Console.ReadLine();
        int annoluna = 1969;
        
        int anno1 = int.Parse(anno);

        if (anno1 == annoluna)
        {
            Console.WriteLine("Stesso anno uomo sulla luna");
        } 
        else if (anno1 > annoluna)
        {
            int differenza = anno1 - annoluna;
            Console.WriteLine("Sei nato " + differenza+ "anni dopo la prima volta sulla luna.");
        }
        else
        {
            int diff = annoluna - anno1;
            Console.WriteLine("Sei nato " +diff+ "anni dopo la prima volta sulla luna");
        }
        }
    }
}
