public class Nekretnina {
	private string vrsta;
	private int brojKvadrata;
	private double cenaPoKvadratu;
		
		
	// podrazumevani konstruktor
	public Nekretnina()
	{
		vrsta = String.Copy("");
		kvadratura = 0;
		cenaPoKvadratu = 0;
	}
	
	// konstruktor inicijalizacije
	public Nekretnina(string vrsta1, int brojKvadrata1, double cenaPoKvadratu1) {
		vrsta = String.Copy(vrsta1);
		brojKvadrata = brojKvadrata1;
		cenaPoKvadratu = cenaPoKvadratu1;
	}
	
	// Svojstva za pristup privatnim podacima
	public string GetSetVrsta {
		get { return vrsta; }
		set { vrsta = value; }
	}
		
	public int GetSetBrojKvadrata {
		get { return brojKvadrata; }
		set { brojKvadrata = value; }
	}
	
	public double GetSetCenaPoKvadratu {
		get { return cenaPoKvadratu; }
		set { cenaPoKvadratu = value; }
	}
	
	public virtual double IzracunajProdajnuCenuNekretnine() {
		
		vrednost = brojKvadrata * cenaPoKvadratu;
		return vrednost;
   	}
	
	


	public class Kuca : Nekretnina {
		private string adresa;
		private int brojAri;
		private double cenaAra;
			
		//
		Kuca() {
			adresa = String.Copy("");
			brojAri = 0;
			cenaAra = 0;
		}
			
		Kuca(string adresa1, int brojAri1, double cenaAra1) {
			adresa = String.Copy(adresa1);
			brojAri = brojAri1;
			cenaAra = cenaAra1;
		}
		
		public string GetSetAdresa {
			get { return adresa; }
			set { adresa = value; }
		}		
		public int GetSetBrojAri {
			get { return brojAri; }
			set { brojAri = value; }
		}
		
		public double GetSetCenaAra {
			get { return cenaAra; }
			set { cenaAra = value; }
		}
	
			
	    public override double IzracunajProdajnuCenuNekretnine(double GetSetBrojKvadrata, double GetSetCenaPoKvadratu) {
			
			vrednost = base.GetSetBrojKvadrata * base.GetSetCenaPoKvadratu + brojAri * cenaAra;
			return vrednost;
	   	}
	} // Kraj klase Kuca



static void UnosPodataka(Kuca kuca) {
	Console.WriteLine("Unesite vrstu nekretnine: ");
    kuca.GetSetVrsta = Console.ReadLine();
    Console.WriteLine("Unesite broj kvadrata: ");
    kuca.GetSetBrojKvadrata = int.Parse(Console.ReadLine());
    Console.WriteLine("Unesite cenu po jednom kvadratu: ");
    kuca.GetSetCenaPoKvadratu = double.Parse(Console.ReadLine());
    
    Console.WriteLine("Unesite broj ari: ");
    kuca.GetSetBrojAri = int.Parse(Console.ReadLine());
    Console.WriteLine("Unesite cenu po jednom aru: ");
    kuca.GetSetCenaAra = double.Parse(Console.ReadLine());
}

// Ispis
static void IspisPodatakaKuca(Kuca[] kuca)
{
	foreach (Kuca k in kuca) {
		Console.WriteLine("Broj ari: {0}", k.GetSetBrojAri);
	    Console.WriteLine("Cena po aru: {0:F2}", k.GetSetCenaAra);
	}
}

static void IspisPodatakaIVrednostiKuca(Kuca[] kuca, int brojAriPlaca) {
	foreach (Kuca k in kuca) {
		if (brojAriPlaca == k.GetSetBrojAri) {
			Console.WriteLine("Broj ari: {0}", k.GetSetBrojAri);
	    	Console.WriteLine("Cena po aru: {0:F2}", k.GetSetCenaAra);
	    	Console.WriteLine("Adresa kuce: " + k.GetSetAdresa);
	    	Console.WriteLine("Prodajna cena nekretnine: {0:F2}", k.IzracunajProdajnuCenuNekretnine());
		}
	}
}


// Glavna funkcija
static void Main(string[] args){

	int n;
	
	Console.WriteLine("Unesite broj kuca: ");
	n = int.Parse(Console.ReadLine());
	
	Kuca[] kuca;
	
	kuca = new Kuca[n];
	
	for(int i = 0; i < n; i++) {
		UnosPodataka(kuca[i]);
	}
	
	foreach (Kuca k in kuca) {
		k.IzracunajProdajnuCenuNekretnine();
	}
	
	IspisPodatakaKuca(kuca);
	IspisPodatakaIVrednostiKuca(kuca);
	

}






} // kraj klase Nekretnina



