/* Escreva um algoritmo que lê um valor n inteiro e positivo e que calcula a seguinte soma:
S = 1 + 1/2 + 1/3 + 1/4 + ... + 1/n
O algoritmo deve escrever cada termo gerado e o valor final de S. */

#include <stdio.h>
#include <stdlib.h>
#include <math.h>

int main(){
 
    int n;
    float soma = 0;
    float aux = 0;
    printf("\nDigite um valor inteiro: ");
    scanf(" %i", &n);

    while(n > 0){
       soma += 1/(aux++);
       n--;
    }    
    printf("\nO valor da soma e: %.2f", soma);
    
    return 0;
}
