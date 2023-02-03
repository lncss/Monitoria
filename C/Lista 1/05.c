/* A prefeitura de uma cidade fez uma pesquisa entre seus habitantes, coletando dados sobre o
salário e número de filhos de cada habitante. A prefeitura deseja saber:
a) média do salário da população;
b) média do número de filhos;
c) maior salário;
d) percentual de pessoas com salário até R$100,00.
O final da leitura de dados se dará com a entrada de um salário negativo. */

#include <stdio.h>
#include <stdlib.h>
#include <math.h>

int main(){

    int numFilhos = 0, maiorSalario = 0, somaFilho = 0;
    int aux1 = 0, aux2 = 0;
    float salarios = 0, mediaSlr = 0,  mediaFilho = 0, somaSlr = 0, percentual = 0 ;

    do{
        printf("\nDigite o salario: ");
        scanf(" %i", &salarios);
        if(salarios < 0){ break; }
        
        if(salarios > 100){
            aux1++; //pessoas com salarios maiores que 100
        }

        if(salarios > maiorSalario){ maiorSalario = salarios;} //pega o maior salario

        printf("\nDigite a quantidade de filhos: ");
        scanf(" %i",&numFilhos);
        while(numFilhos < 0){
            printf("\nNumero de filhos invalidos!");
            printf("\nDigite a quantidade de filhos: ");
            scanf(" %i",&numFilhos);
        }

        somaSlr += salarios;
        somaFilho += numFilhos;
        aux2++; //contador do numero total de habitantes
    }while(salarios > 0);

    mediaFilho = somaFilho / aux2;
    mediaSlr = somaSlr / aux2;
    percentual = (aux1 * 100)/ aux2;  //percentual de pessoas com salario maior que 100

    printf("\n--------- DADOS ----------");
    printf("\na) Media do salario da populacao: %.2f", mediaSlr);
    printf("\nb) Media de filhos: %.2f", mediaFilho);
    printf("\nc) Maior salario: %i", maiorSalario);
    printf("\nd) Percentual de pessoas com salario maior que R$100,00: %.2f", percentual);
    
    return 0;
}
