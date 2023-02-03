/* Fazer um programa leia uma sequência de valores inteiros fornecida pelo usuário em uma
linha de entrada e conte o número de valores positivos, negativos e zeros. */

using System;

class Program {
  public static void Main (string[] args) {
    int[] numeros; //aramzenar sequencia de numeros
    int tam = 0;

    Console.WriteLine("Digite a quantidade de numeros: ");
    tam = int.Parse(Console.ReadLine()); // ler quantidade de numeros da sequencia
            
    numeros = new int[tam];
            
    Console.WriteLine("Digite a sequencia de numeros: ");
    for(int i = 0; i < tam; i++){
        numeros[i] = int.Parse(Console.ReadLine()); //armazenar os numeros em cada posicao do vetor 
    }
       
    int pos = 0, neg = 0, zero = 0; //variaveis para fazer a contagem 

    for(int i = 0; i < tam ; i++){
        if(numeros[i] > 0){ //verifica se o numero e positivo
            pos++;
        }else if(numeros[i] < 0){ //verifica se o numero e negativo
            neg++;
        }else{ // qunado o numero nn se encaixa em nenhuma das verificações
            zero++;
        }
    }

    Console.WriteLine("A quamtidade de numeros positivos é " + pos + " , de negativos é " + neg + " e de zeros é " + zero); // imprimir a quantidade de numeros positivos, negativos e de zeros da sequencia

  }
}