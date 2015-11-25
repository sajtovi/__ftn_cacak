/* 13. Kreirati klasu Telefon sa privatnim poljima tip, cena i kolicina.
 * Napisati svojstva za pristup privatnim podacima clanovima klase.
 * Formirati metodu za unos objekta tipa klase Telefon 
 */

using System.Collections.Generic;


public class Telefon {
	
	private string tip;
	private double cena;
	private int kolicina;
			
	public string Tip {
		get{ return tip;}
		set{ tip = value;}
	}
	
	public double Cena {
		get{ return cena; }
		set{ cena = value; }
	}
	
	public int Kolicina {
		get{ return kolicina; }
		set{ kolicina = value; }
	}
	
	static void unos(Telefon tel) {
				
		Console.WriteLine("Unesite tip telefona");
		tel.tip = Console.ReadLine();
		
		Console.WriteLine("Unesite cenu telefona");
		tel.cena = Convert.ToDouble(Console.ReadLine());
		
		Console.WriteLine("Unesite kolicinu");
		tel.kolicina = Convert.ToInt32(Console.ReadLine());
			
	}
}
