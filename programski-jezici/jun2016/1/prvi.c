/* Programski jezici 2.2.2016.
 * 1. Dat je celobrojni niz A dimenzije n. Sortirati niz A i formirati niz B od
 * elemenata niza A izbacivanjem sredisnjeg elementa. Zameniti prvi i poslednji element
 * niza B i ispisati formiran niz B na standardnom izlazu
 */


#include <stdio.h>
#include <stdlib.h>

// funkcija uporedi nam omogucuje da odredimo da li cemo sortirati
// elemente u rastucem ili opadajucem poretku
int uporedi(const void *a, const void *b) {
  return (*(int*)a - *(int*)b);
}

int main() {
  int *A, *B; // nizovi A i B
  int n; // dimenzija niza
  int i;
  int index_srednjeg_elementa; // promenljiva ce nam cuvati koji je indeks srednjeg elementa u nizu
  int temp; // promenljiva koja ce nam sluziti da prvi element postavimo na poslednje i poslednji na prvo mesto
  
  printf("Unesite dimenziju niza n:");
  scanf("%d", &n);
  
  // ovde definisemo funkcijom calloc u memoriji nizove A i B od n elemenata i sve elemente postavljamo na nule
  A = (int*)calloc(n, sizeof(int)); 
  B = (int*)calloc(n, sizeof(int));
  
  // unosimo niz A
  printf("Unesite elemente niza A: ");
  for(i = 0; i < n; i++)
    scanf("%d", &A[i]);
  
    // sortiramo niz A funkcijom qsort
    qsort(A, n, sizeof(int), uporedi);
  
  // kopiramo sortirani niz A u niz B
  for(i = 0; i < n; i++)
    B[i] = A[i];
  
  
    // izbacujemo srednji element iz niza B
    index_srednjeg_elementa = n/2;
  // kada u petlji dodjemo do srednjeg elementa mi na njegovo mesto stavimo sledeci element, a na mesto sledeceg njegov sledeci itd.
  // i na taj nacin je srednji element odbacen. U petlji idemo do n-1 jer cemo n-ti element staviti na poziciju n-1
    for(i = index_srednjeg_elementa; i < n-1; i++) { 
    *(B+i)=*(B+i+1);
    
    // menjamo prvi i poslednji element niza
    temp = *(B+n-2);
    *(B+n-2) = *(B);
    *(B) = temp;
 
    // stampamo niz
    for(i = 0; i < n-1; i++)
    printf("%d ", B[i]);
 
  return 0;
}