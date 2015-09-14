#include <stdio.h>
#include <stdlib.h>

/* funkcija uporedi koja vrsi uporedjivanje dva broja i vraca 
 * manji od njih. Ovu funkciju pisemo jer nam je potrebna prilikom
 * sortiranja (u opadajucem poretku) niza pomocu C funkcije iz stdlib.h koja se zove
 * brzosortiranje tj. quicksort */
int uporedi(const void *a, const void *b) {
  return (*(int*)a - *(int*)b);
}

int main() {
  int i, n;
  int *niz;
  /* promenljiva temp ce cuvati privremene vrednosti, a sluzice nam
   * kao pomocna promenljiva pri premestanju prvog i poslednjeg clana niza */
  int temp;
  
  printf("Unesite broj elemenata niza: ");
  scanf("%d", &n);
  
  niz = (int*)malloc(n * sizeof(int));
  for (i = 0; i < n; i++)
    scanf("%d", (niz+i));
  
  /* Na niz koji smo uneli primenjujemo funkciju sortiranja quicksort */
  qsort(niz, n, sizeof(int), uporedi);
  
  /* Sada kada je sortiran niz zelimo da premestimo prvi clan niza na zadnje mesto,
   * i zadnji clan niza na prvo mesto. Prilikom premestanja koristimo pomocnu
   * promenljivu temp */
  temp = *(niz+n-1);
  *(niz+n-1) = *(niz);
  *(niz) = temp;
  
  /* Stampamo niz koji se trazio u zadatku */
  printf("Elementi naseg niza su: ");
  for(i = 0; i < n; i++)
    printf("%d ", *(niz+i));
return 0;
}
