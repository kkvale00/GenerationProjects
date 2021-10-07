using System;
using System.IO;
namespace _08___Ristorante
{
	class Program
	{
		static void Main(string[] args)
		{
			StreamReader file = null;
			string riga;
			int index = 0;

			Piatto[] piatti;

			string path = @"C:\Users\kkvale\source\repos\SecondaSettimana\08 - Ristorante\Piatti.txt";

			//Metodo che controlla se il path passato esiste
			if(File.Exists(path))
			{
				file = new StreamReader(path);
			}
			else
			{
				Console.WriteLine("Percorso errato");
			}

			piatti = new Piatto[int.Parse(file.ReadLine())];

			while((riga = file.ReadLine()) != null)
			{
				string[] info = riga.Split(":");

				Piatto p = new Piatto();

				p.nome = info[0];
				p.prezzo = double.Parse(info[1]);
				p.portata = info[2];
				p.vegano = info[4] == "s";
				p.allergeni = info[3].Split("-");

				piatti[index] = p;
				index++;
			}
			//creazione menu utente
			string legenda;
			string comando;
			string risposta;

			legenda = "=== LEGENDA ====\n"                                       +
					  "\n1 -> Lista di tutte le schede dei piatti disponibili\n" +
					  "\n2 -> Nomi dei piatti più costosi del menu\n"            +
					  "\nHELP -> Legenda dei comandi\n"                          +
					  "\nExit -> Termina sessione\n";

			

            Console.WriteLine($"INSERISCI IL COMANDO\n\n{legenda}");
			do
			{
				Console.WriteLine("Inserisci il comando da eseguire:");
				comando = Console.ReadLine();
				risposta = "";
				switch(comando.ToLower())
                {
					case "1":
						//lista completa dei piatti
						string listaPiatti = "";
						for (int i = 0; i < piatti.Length; i++)
						{
							listaPiatti += piatti[i].Scheda();
						}

						risposta = listaPiatti;
						break;

					case "2":
						//i piatti più cari
						double max = 0;
						string nomePiattoCaro = "";

						for (int i = 0; i < piatti.Length; i++)
						{
							if (piatti[i].prezzo > max)
							{
								max = piatti[i].prezzo;
								nomePiattoCaro = piatti[i].nome;
							}
							else if (piatti[i].prezzo == max)
							{
								nomePiattoCaro += "\n> " + piatti[i].nome;
							}
						}

						risposta = $"\n\nPiatti più cari:\n >{nomePiattoCaro}, che costano {max} euro";
						break;
					case "help":
						risposta = "\n\n" + legenda;
						break;
					case "exit":
						risposta = "Termino programma.";
						break;
					case "default":
						risposta = "Comando non riconosciuto, premere HELP per legenda";
						break;
				}

                Console.WriteLine(risposta);

			} while (comando.ToLower() != "exit");

            Console.WriteLine("END");










			

			

		}
	}
}
