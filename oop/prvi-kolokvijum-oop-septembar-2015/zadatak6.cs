class Student {
	private string ime;
	private int br_indeksa;
	private int god_studija;
	
	// podrazumevani konstruktor
	public Student() {
		ime = "";
		br_indeksa = 0;
		god_studija = 0;
	}
	
	//konstruktor inicijalizacije
	public Student(string ime1, int br_indeksa1, int god_studija1) {
		ime = ime1;
		br_indeksa = br_indeksa1;
		god_studija = god_studija1;
	}
	
	// metod za odredjivanje broja studenata druge godine studija
	// metod brojStudenata kao parametar uzima Listu studenata
	int brojStudenata(List<Student> studenti) {
		int brojStudenataDrugeGodine = 0;

		// petljom prolazimo kroz listu studenata
		foreach(Student student in studenti) {
			// pitamo sa if da li je student kod koga smo trenutno student druge godine
			if(student.god_studija == 2)
				// ako je trenutni student student druge godine onda povecavamo brojStudenataDrugeGodine za jedan
				brojStudenataDrugeGodine = brojStudenataDrugeGodine + 1;
		}
		
		return brojStudenataDrugeGodine;
	}
}