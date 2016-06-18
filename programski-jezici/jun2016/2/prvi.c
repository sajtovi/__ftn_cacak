/* Programski jezici 2.2.2016.
 * Zadatak: 1. Dat je realni niz A dimenzije n. Formirati niz B od pozitivnih
 * elemenata niza A koji se nalaze na neparnim pozicijama. Ispisati formiran 
 * niz B na standardnom izlazu
 */

#include <stdio.h>
#include <stdlib.h> // potrebno je da ukljucimo stdlib zbog funkcije calloc

int main() {
  int *A, *B; // nizovi A i B
  int n; // dimenzija niza
  int i, j=0; // j ce biti promenljiva za elemente niza B
  
  printf("Unesite dimenziju niza n:");
  scanf("%d", &n);
  
  A = (int*)calloc(n, sizeof(int)); // Funkcija calloc rezervise u memoriji mesto za niz od n elemenata i svakom elementu da pocetnu vrednost nula.
  B = (int*)calloc(n, sizeof(int));
  
  printf("Unesite elemente niza A: ");
  for(i = 0; i < n; i++)
    scanf("%d", &A[i]);
  
  // Petljom idemo po neparnim clanovima niza
  for(i = 0; i < n; i+=2)
    // postavljamo pitanje da li je broj na neparnom mestu u nizu veci od nule ako jeste ubacujemo ga u niz B
    if(A[i] > 0) {
      B[j]= A[i];
      j++; // povecavamo broj elemenata niza B za 1
    }
  
  // Stampamo niz B pomocu while petlje koja je drugi zapis za for petlju.
  // U ovom slucaju nam vise odgovara while od for petlje jer ne znamo koliko
  // imamo clanova u nizu B ali znamo da svi oni moraju biti po uslovu u zadatku veci od nule pa kad naidjemo
  // na nulu u nizu tu prekidamo petlju i ne stampamo tu nulu. A znamo da cemo na kraju naleteti na nulu jer
  // smo sa calloc funkcijom definisali u pocetku niz B koji ima n clanova koji su svi jednaki nuli.
  i = 0;
  while(B[i]!=0){
    printf("%d ", B[i]);
    i++;
  }
  
  return 0;
}