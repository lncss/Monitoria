/* Fazer um programa leia uma sequência de valores inteiros fornecida pelo usuário em uma
linha de entrada e conte o número de valores positivos, negativos e zeros. */

#include <stdio.h>
#include <locale.h>
//#define TAM 10 //define tamanho do vetor

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

    printf("\n------- Resutados -------");
    printf("\nNa sequencia ha:\n%i numeros positivos\n%i numeros negativos\n%i numeros zeros.", pos, neg, zero);

    return 0;

}