using System;
using System.Collections.Generic;
using System.Text;

namespace _01___Negozio
{   

	//Con la parola abstract vado a togliere la possibilita di creare oggetti
	//di tipo Prodotto. Quindi Prodottto potra essere utilizzato solo come tipo formale.


	abstract class Prodotto 
	{
		private int id;
		private string nome;
		private double prezzo;
		private int quantita;

		public Prodotto(int id, string nome, double prezzo, int quantita)
		{
			this.Id = id;
			this.Nome = nome;
			this.Prezzo = prezzo;
			this.Quantita = quantita;
		}

		public int Id { get => id; set => id = value; }
		public string Nome { get => nome; set => nome = value; }
		public double Prezzo { get => prezzo; set => prezzo = value; }
		public int Quantita { get => quantita; set => quantita = value; }

		public override string ToString()
		{
			return $"id: {id} + \n" +
				   $"nome: {nome}\n" +
				   $"Prezzo: {prezzo}\n" +
				   $"quantita: {quantita}\n";
		}

		//i metodi astratti hanno solo la firma, niente corpo.
		//saervono ad OBBLIGARE le classi figlie concrete a fare override del metodo
		//sto solo comunicnaod che tutti i prodotti hanno un PrezzoScontato,
		//non ho ancora gli strumenti per calcolarlo.
		//tutte la classi figlie avranno l'OBBLIGO a PrezzoScontato()

		public abstract double PrezzoScontato();



		//i metodi void non hanno return:
		//vengono utilizzati per modificare lo stato dell'oggetto
		//lo stato dell'oggetto consiste nell'insieme di valori dei campi
		//in un dato istante
		
		public void Vendi() //metodi senza return
        {
			if (this.Quantita == 0)
				return;
			//il metodo si interrompe grazie al return, (possono averli) 
			//ES: in caso di quantita 0, non vendo nessun prodotto.
			
			this.Quantita--;

        }
		public void Vendi(int q) //metodi senza return
		{
			this.Quantita -= q;

        }















	}//fine classe
}
