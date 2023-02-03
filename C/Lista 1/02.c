/* Adaptar o programa acima para que ele calcule o percentual dos valores positivos,
negativos e zeros em relação ao total de valores fornecidos. */

#include <stdio.h>
#include <stdlib.h>
#include <math.h>

/*----- Função main ------*/
int main(){

    //saber o tamanho da sequencia
    int tam;
    printf("\nDigite o tamanho da sequencia de numeros: ");
    scanf("%i",&tam);

    //declarar variaveis
    int num[tam];
    int pos = 0;
    int neg = 0;
    int zero = 0;
    float porctPos = 0;
    float porctNeg = 0;
    float porctZero = 0;

    printf("\nDigite uma sequencia de numeros:\n");
    for(int i = 0; i < tam; i++){ //loop para adicionar os valores ao vetor
        scanf(" %i", &num[i]);
    }

    for(int j = 0; j < tam; j++){ //loop para percorrer os valores do vetor
        if(num[j] > 0){ //verifica se o numero e positivo
            pos++;
        }else if(num[j] < 0){ //verifica se o numero e negativo
            neg++;
        }else{ //caso o numero seja zero
            zero++;
        }
    }

    porctPos = (pos * 100)/tam;
    porctNeg = (neg * 100)/tam;
    porctZero = (zero * 100)/tam; 

    printf("\n------- Resutados -------");
    printf("\nNa sequencia ha:\n%.1f%% de numeros positivos\n%.1f%% de numeros negativos\n%.1f%%  de numeros zeros.", porctPos, porctNeg, porctZero);

    return 0;

}