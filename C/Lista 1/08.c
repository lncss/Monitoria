/* Faça um programa que imprima todos os elementos da série de Fibonacci menores que L. */

#include <stdio.h>
#include <stdlib.h>
#include <math.h>

int main(){

    int num;

    //identificar um numero
    printf("\nIndique um numero L: "); 
    scanf(" %i", &num);

    //os primeiros num da sequencia vao ser 0 e 1 respectivamente
    int primeiroNum = 0, segundoNum = 1;

    if(segundoNum < num){
        printf(" 0 1");

        while(num > 0){
            int novoNum = segundoNum;

            segundoNum = primeiroNum + segundoNum;
            primeiroNum = novoNum;
            //sempre que o num for maior que 1, entt a sequencia vai continuar aparecendo, ate se tornar falso

            if(segundoNum < num){
                printf(" %i", segundoNum);
            }else break;
        }

       

        printf("\n\n");
    }

    return 0;
}