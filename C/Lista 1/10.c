/* Em uma eleição presidencial existem quatro candidatos. Os votos são informados através
de códigos. Os dados utilizados para a contagem dos votos obedecem à seguinte
codificação:
1,2,3,4 = voto para os respectivos candidatos;
5 = voto nulo;
6 = voto em branco;
Elabore um algoritmo que leia o código do candidado em um voto. Calcule e escreva:
- total de votos para cada candidato;
- total de votos nulos;
- total de votos em branco.

Como finalizador do conjunto de votos, tem-se o valor 0. */

#include <stdio.h>
#include <stdlib.h>
#include <math.h>

int main(){
 
    //declarar variaveis
    int votos[100];
    int candidatos[4];
    int branco;
    int nulo;
    

    printf("Digite os votos sendo 1, 2, 3 e 4 para os respectivos candidatos \n5 - Branco \n6 - Nulo \n0 - Finalizar conjunto de votos:\n");
        for(int i = 0; i < 100; i++){
            scanf(" %i",&votos[i]);

            if(votos[i] < 0 || votos[i] > 6) printf("Voto invalido!\n");
            if(votos[i] == 0) break;
        }

    return 0;
}