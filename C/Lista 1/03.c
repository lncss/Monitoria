/* Faça um programa que receba dez números e verifique se eles são divisíveis por 3 e 9 (ao
mesmo tempo), por 2 e por 5. Caso algum número não seja divisível por nenhum desses
números mostre a mensagem “Número não é divisível pelos valores”. Apresente também
ao final a quantidade de números divisíveis por 3 e 9, por 2 e por 5. */

#include <stdio.h>
#include <stdlib.h>
#include <math.h>
#define TAM 10

int main(){

    //declarar variaveis
    int num[TAM];
    int qtd1 = 0;
    int qtd2 = 0;

    printf("\nDigite um sequencia de 10 numeros: \n");
    for(int i = 0; i < TAM; i++){ //loop para salvar os valores
        scanf(" %i", &num[i]);
    }

    for(int i =0; i < TAM; i++){ //loop que acessa os valores do vetor
        if((num[i] % 3 == 0) && (num[i] % 9 == 0)){ // verifica se e divisivel por 3 e 9
            qtd1++; 
        }else if((num[i] % 2 == 0) && (num[i] % 5 == 0)){ // verfica se e divisivel por 2 e 5
            qtd2++;
        }else{
            printf("\n%i nao e divisivel pelos valores!", num[i]); //retorna os numeros que nn sao divisiveis pelos valores
        }
    }

    printf("\n\n------ RESULTADO ------");
    printf("\n\nQuantidade de numeros divisiveis por 3 e 9: %i", qtd1);
    printf("\nQuantidade de numeros divisiveis por 2 e 5: %i", qtd2);
    
    return 0;
}
