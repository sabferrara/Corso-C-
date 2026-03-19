
using System;
using System.IO;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string path = "studenti.txt";   //definiamo il percorso del file: permette di richiamare il file-->nome del file.estensione del file

        Console.WriteLine("1 Inserisci");
        Console.WriteLine("2 Visualizza");
        Console.WriteLine("3 Aggiorna");
        Console.WriteLine("4 Elimina");

        int scelta = int.Parse(Console.ReadLine());  //parsizzato in uno switch

        List<string> righe = new List<string>();  //creiamo lista di stringhe per leggere il file

        if (File.Exists(path))           //se l file esiste nel path principale
            righe.AddRange(File.ReadAllLines(path));    //leggimi e salvati tutte le righe del file

        switch (scelta)     //apertura switch
        {
            // CREATE
            case 1:
                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("Cognome: ");
                string cognome = Console.ReadLine();

                Console.Write("Eta: ");
                string eta = Console.ReadLine();

                righe.Add($"{nome},{cognome},{eta}");  
                File.WriteAllLines(path, righe);     //write all lines: scrivimi tutte le righe delle colonne, dove all'interno delle righe e della lista 

                Console.WriteLine("Studente inserito");
                break;

            // READ: stampa a video i nomi contenuti nel file
            case 2:
                Console.WriteLine("\n--- Elenco studenti---");
                foreach (string r in righe)
                    Console.WriteLine(r);
                break;

            // UPDATE
            case 3:
                Console.Write("Indice riga da modificare: ");
                int index = int.Parse(Console.ReadLine());

                Console.Write("Nuova riga (nome,cognome,eta): ");    //cambiare uno o piu dati all'interno della riga
                string nuova = Console.ReadLine();

                righe[index] = nuova;
                File.WriteAllLines(path, righe);

                Console.WriteLine("Aggiornato");
                break;

            // DELETE
            case 4:
                Console.Write("Indice riga da eliminare: ");
                int delete = int.Parse(Console.ReadLine());

                righe.RemoveAt(delete);  //rimuovi solo quello che ti sto chiedendo 
                File.WriteAllLines(path, righe);

                Console.WriteLine("Eliminato");
                break;
            
            // COUNT: Conta quante righe (studenti) ci sono nel file
            case 5:
                int totale = righe.Count; // la dimensione della lista corrisponde alle righe
                Console.Write("Totale: {totale}");
                break;
        }
        Console.WriteLine("\nPremi un tasto per uscire...");
        Console.ReadKey();
    }
}
