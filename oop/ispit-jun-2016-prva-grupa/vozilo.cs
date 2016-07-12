/* Fakultet tehnickih nauka Cacak
 * I grupa
 * prvi racunarski kolokvijum iz 
* OBJEKTNO ORIJENTISANOG PROGRAMIRANJA
* 
 * Definisati klasu Vozilo sa javnim atributima:
 * - marka - marka vozila
 * - potrosnja - prosecna potrosnja vozila na 100km
 * - cena - cena litra goriva
 * 
 * Podrazumevani konstruktor koji inicijalizuje vrednosti atributa
 * 
 * UpisVozila() - upisuje vrednosti atributa koje korisnik unosi sa tastature
 * 
 * KolicinaGoriva() - izracunava kolicinu potrebnog goriva za planirani put, pri cemu se broj kilometara
 * unosi sa tastature (jedan argument je planirani put).
 * 
 * Ispis() - ispisuje sva uneta vozila
 * 
 * 
 * 
 * Definisati izvedenu klasu Kopnena koja nasledjuje klasu Vozila i ima dodatni atribut:
 * - kubikaza - broj kubika (kolicina goriva koje staje u rezervoar u litrima):
 * 
 * Konstruktor - koji inicijalizuje vrednosti atributa.
 * 
 * Metode izvan klase:
 * Upis() - koja upisuje kubikazu i ostale atribute koje korisnik unosi sa tastature
 * 
 * BrTocenja() - ispisuje koliko puta treba natociti pun rezervoar da bi se presla predvidjena kilometraza.
 * 
 * CenaPutovanja() - odredjuje koliko je novca potrebno da bi se presao zadati put.
 * 
 * 
 * U glavnoj funkciji izvrsiti unos n vozila, uneti podatke o vozilima i ispisati koliko puta
 * treba vrsiti tocenje goriva i kolika je ukupna cena puta za svako vozilo

*/



using System;

public class Vozilo
{
	public string marka;
	public double potrosnja;
	public double cena;
	
// podrazumevani konstruktor
public Vozilo() {
	marka = String.Copy("");
	potrosnja = 0.0;
	cena = 0.0;
}
// konstruktor inicijalizacije
public Vozilo(string m, double p, double c) {
	marka = String.Copy(m);
	potrosnja = p;
	cena = c;
}

// svojstva za pristup podacima
public string GetSetMarka {
	get { return marka; }
	set { marka = value; }
}

public double GetSetPotrosnja {
	get { return potrosnja; }
	set { potrosnja = value; }
}

public double GetSetCena {
	get { return cena; }
	set { cena = value; }
}

// upis vozila
static void UpisVozila(Vozilo v) {
	Console.WriteLine("Unesite marku vozila: ");
	v.GetSetMarka = Console.ReadLine();
	Console.WriteLine("Prosecna potrosnja goriva na 100km: ");
	v.GetSetPotrosnja = Convert.ToDouble(Console.ReadLine());
	Console.WriteLine("Cena litre goriva: ");
	v.GetSetCena = Convert.ToDouble(Console.ReadLine());
}

// kolicina goriva
public double KolicinaGoriva(double cena) {
	double brKilometara;
	Console.WriteLine("Unesite broj kilometara:");
	brKilometara = Convert.ToDouble(Console.ReadLine());
	KolicinaGoriva = brKilometara * cena;
	return KolicinaGoriva;
}

// metoda za Ispis
static void Ispis(Vozilo v) {
	Console.WriteLine("Marka vozila: " + v.marka);
	Console.WriteLine("Prosecna potrosnja na 100km: " + v.potrosnja);
	Console.WriteLine("cena litra goriva: " + v.cena);
}



public class Kopnena: Vozilo {
	public double kubikaza;
	
	// podrazumevani konstruktor
	public Kopnena() {
		kubikaza = 0.0;
	}
	
	// konstruktor inicijalizacije
	public Kopnena(double kb) {
		kubikaza = kb;
	}
	
	public double GetSetKubikaza {
		get { return kubikaza; }
		set { kubikaza = value; }
	}
	
	static void Upis(Vozilo V) {
		Console.WriteLine("Unesite marku vozila:");
		V.GetSetMarka = Console.ReadLine();
		Console.WriteLine("Prosecna potrosnja na 100km:");
		V.GetSetPotrosnja = Convert.ToDouble(Console.ReadLine());
		Console.WriteLine("Cena litra goriva:");
		V.GetSetCena = Convert.ToDouble(Console.ReadLine());
		Console.WriteLine("Broj kubika:");
		V.GetSetKubikaza = Convert.ToDouble(Console.ReadLine());
	}
	
	/* U zadatku se ne trazi da ova funkcija ima argument kilometraza, ali ako se bolje razmisli da bismo
 	* uopste radili sa ovom funkcijom moramo da joj damo podatak o kilometrazi da bismo mogli da izracunamo
	* koliko puta treba tociti gorivo */  
	public int BrTocenja(double kilometraza) {
		int kolikoPutaTrebaTociti;
		
		// (potrosnja / 100) nam daje kolika je potrosnja goriva na 1km puta
		double brLitaraDaBiSePreslaDataKilometraza = kilometraza * (potrosnja / 100);
		
		// ovde broj litara koji nam trebaju za putovanje delimo sa brojem litara koji mogu da stanu u
		// rezervoar i kada taj broj dobijemo prebacimo ga u ceo broj i to je broj tocenja koji nam treba
		// da bismo presli zadati put
		kolikoPutaTrebaTociti = Convert.ToInt32(brLitaraDaBiSePreslaDataKilometraza / kubikaza);
		
		return kolikoPutaTrebaTociti;
	}
	
	/* slicno i za ovu funkciju da bismo izracunali cenu putovanja moramo uneti kao argument koliko
	 * kilometara se putuje. */
	public double CenaPutovanja(double brojKilometara) {
		double cenaPutovanja;
		
		// (potrosnja / 100) nam daje kolika je potrosnja goriva na 1km puta
		cenaPutovanja = (brojKilometara * (potrosnja / 100) * cena;
		
		return cenaPutovanja;
	}
} // kraj klase Kopnena

// Glavna funkcija
/*"U glavnoj funkciji izvrsiti unos n vozila, uneti podatke o vozilima
   i ispisati koliko puta treba vrsiti tocenje goriva i kolika je ukupna cena puta
   za svako vozilo."
*/
static void Main(string[] args){
	
	// posto nam u zadatku nije dato koliko ima vozila jedna od ideja je da
	// definisemo promenljivu brojVozila i da korisnik unese taj podatak sa tastature
	int brojVozila;
	
	Console.WriteLine("Unesite broj vozila: ");
	brojVozila = int.Parse(Console.ReadLine());
	
	// kada korisnik unese broj vozila, potrebno je da definisemo niz u kome ce se cuvati
	// sve informacije o nasim vozilima
	Vozilo[] vozila;
	
	// nas niz koji je iako je definisan i dalje prazan punimo sa kopnenim vozilima i to sa onolikim
	// brojem vozila koliko je korisnik zadao i taj broj je smesten unutar promenljive brojVozila
	vozila = new Kopnena[brojVozila];
	
	// Ulazimo u petlju koja ide od prvog do poslednjeg (kopnenog) vozila
	for(int i = 0; i < brojVozila; i++) {

		// za svako (kopneno) vozilo vrsimo upis podataka pozivanjem funkcije Upis
		vozila[i].Upis();

		// u zadatku to nije navedeno (skriveno da zbuni) ali da bi se radilo sa funkcijom
		// BrTocenja i funkcijom CenaPutovanja neophodno je da imamo podatak koji nam govori
		// kolika je kilometraza naseg puta. Jedna od ideja je da to unosimo ponaosob za svako vozilo.
		// dakle pored gomile informacija za nase trenutno vozilo unosimo i informaciju brojKilometara
		// jer nam treba da bismo radili sa funkcijama BrTocenja i CenaPutovanja		
		Console.WriteLine("Unesite broj kilometara puta: ");
		brojKilometara = int.Parse(Console.ReadLine());

		// pozivamo funkcije za BrTocenja i CenuPutovanja i stampamo njihove rezultate na ekran.
		Console.WriteLine(vozila[i].BrTocenja(brojKilometara));
		Console.WriteLine(vozila[i].CenaPutovanja(brojKilometara));
	} // kraj glavne funkcije
	// Main funkcija nije teska ali su skrivena dva podatka da bi student smislio neko svoje resenje.
	// Prvi skriveni podatak je broj vozila. Taj podatak moze da se dobije na vise nacina. Ovde je to reseno
	// tako da korisnik unese pomocu tastature taj podatak.
	// Drugi skriveni podatak je brojKilometara, jer nemogu da se koriste funkcije BrTocenja i CenaPutovanja
	// ako se ne uoci da njima treba dati informaciju o brojuKilometara da bi mogle da vrse dalja izracunavanja.
	
} // kraj klase Vozilo