/* Faça um programa que imprima os L primeiros elementos da série de Fibonacci. Por
exemplo, se o usuário digitou o número 40, deverão ser apresentados os 40 números da
sequência na tela. */

#include <stdio.h>
#include <stdlib.h>
#include <math.h>
 
int main(){
    
    int qtde;

    printf("\nDigite a quantidade L de numeros da serie Fibonacci: ");
    scanf("%i", &qtde);

    /* O primeiro e o segundo numero sempre vao ser 0 e 1 respectivamente*/
    int primeiroNum = 0, segundoNum = 1;

    if(qtde >= 2){
        printf(" 0 1");
    }else if(qtde == 1){
        printf("0");
    }

    //imprimir elementos da sequencia
    for(int i = 0; i != qtde - 2; i++){
        int novoNum = segundoNum;

        segundoNum += primeiroNum;
        primeiroNum = novoNum;

        printf(" %i",segundoNum);
    }

    printf("\n\n");
    return 0;
}
