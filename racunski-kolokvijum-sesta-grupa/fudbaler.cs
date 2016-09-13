using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

namespace fudbaler {
	

	public class Fudbaler
	{
		public int brojDresa;
		public string imePrezime;
		public int brojGolova;
		public double plata;
		
		public Fudbaler() {}
		
		public Fudbaler(int brojDresa, string imePrezime, int brojGolova, double plata) {
			this.brojDresa = brojDresa;
			this.imePrezime = String.Copy(imePrezime);
			this.brojGolova = brojGolova;
			this.plata = plata;
		}
		
		public int GetSetBrojGolova {
			get { return brojGolova; }
			set { brojGolova = value; }
		}
	}

	class Program
	{
		public static void Main(string[] args)
		{
			
			List<Fudbaler> fudbaleri = new List<Fudbaler>();
			List<Fudbaler> fudbaleriSort = new List<Fudbaler>();

			fudbaleri.Add(new Fudbaler(11, "Zunior Bajano", 12, 324000.00));
			fudbaleri.Add(new Fudbaler(10, "Jurij Djorkaef", 8, 432432));
			fudbaleri.Add(new Fudbaler(9, "Edgard Davids", 1, 432231));
			fudbaleri.Add(new Fudbaler(5, "Marko Van Basten", 4, 231));
			
			/* Deo koda koji sortira fudbalere u opadajucem poretku */
			fudbaleriSort.AddRange(fudbaleri.OrderByDescending(x => x.brojGolova));
			/* kraj dela koda koji sortira fudbalere u opadajucem poretku */
			
			
			foreach (Fudbaler fudbaler in fudbaleriSort)
			{
            	Console.WriteLine(fudbaler.brojDresa + " " + fudbaler.imePrezime + " " + fudbaler.brojGolova + " " + fudbaler.plata);
        	}
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}