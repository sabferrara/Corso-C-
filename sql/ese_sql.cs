using System;
using MySql.Data.MySqlClient;

class Program
{
    static void Main()
    {
        string connStr = "server=localhost;database=cd_musicali;user=root;password=ROOT;";

        using (MySqlConnection conn = new MySqlConnection(connStr))
        {
            conn.Open();

            Console.WriteLine("1 Inserisci cd");
            Console.WriteLine("2 Visualizza cd");
            Console.WriteLine("3 Aggiorna cd");
            Console.WriteLine("4 Elimina cd");

            Console.Write("Scelta: ");
            int scelta = int.Parse(Console.ReadLine());

            switch (scelta)
            {
                case 1:
                    Console.Write("Titolo: ");
                    string titolo = Console.ReadLine();

                    Console.Write("Cantante: ");
                    string cantante = Console.ReadLine();

                    Console.Write("Data_uscita: ");
                    int data = int.Parse(Console.ReadLine());

                    string insert = "INSERT INTO cd (titolo,cantante,data_uscita) VALUES (@titolo,@cantante,@data)";
                    MySqlCommand cmdInsert = new MySqlCommand(insert, conn);

                    cmdInsert.Parameters.AddWithValue("@titolo", titolo);
                    cmdInsert.Parameters.AddWithValue("@cantante", cantante);
                    cmdInsert.Parameters.AddWithValue("@data", data);

                    cmdInsert.ExecuteNonQuery();

                    Console.WriteLine("CD inserito");
                    break;

                case 2:

                    string select = "SELECT * FROM cd";
                    MySqlCommand cmdSelect = new MySqlCommand(select, conn);

                    using (MySqlDataReader reader = cmdSelect.ExecuteReader())
                    {
                        Console.WriteLine("\nLista cd:");

                        while (reader.Read())
                        {
                            Console.WriteLine(
                                reader["id"] + " " +
                                reader["titolo"] + " " +
                                reader["cantante"] + " " +
                                reader["data"]
                            );
                        }
                    }

                    break;

                case 3:

                    Console.Write("ID cd da modificare: ");
                    int idUpdate = int.Parse(Console.ReadLine());

                    Console.Write("Nuova data uscita: ");
                    int nuovaEta = int.Parse(Console.ReadLine());

                    string update = "UPDATE cd SET data_uscita=@data WHERE id=@id";
                    MySqlCommand cmdUpdate = new MySqlCommand(update, conn);

                    cmdUpdate.Parameters.AddWithValue("@data", data);
                    cmdUpdate.Parameters.AddWithValue("@id", idUpdate);

                    cmdUpdate.ExecuteNonQuery();

                    Console.WriteLine("CD aggiornato");

                    break;

                case 4:

                    Console.Write("ID CD da eliminare: ");
                    int idDelete = int.Parse(Console.ReadLine());

                    string delete = "DELETE FROM cd WHERE id=@id";
                    MySqlCommand cmdDelete = new MySqlCommand(delete, conn);

                    cmdDelete.Parameters.AddWithValue("@id", idDelete);

                    cmdDelete.ExecuteNonQuery();

                    Console.WriteLine("CD eliminato");

                    break;

                default:
                    Console.WriteLine("CD non valido");
                    break;
            }
        }
    }
}
