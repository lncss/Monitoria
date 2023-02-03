/* Escreva um algoritmo que lê um valor n inteiro e positivo e que calcula a seguinte soma:
S = 1 + 1/2 + 1/3 + 1/4 + ... + 1/n
O algoritmo deve escrever cada termo gerado e o valor final de S. */

using System;

class Program {
    public static void Main(string[] args){
        int n = 0;
        float soma = 0;
        float aux = 0;

        Console.WriteLine("Digite um valor inteiro: ");
        n = int.Parse(Console.ReadLine());

        while(n >= 0){
            float aux2 = 0;
            aux2 = aux++;
            soma += (float)1/aux2;
            n--;
        }

        Console.WriteLine("O valor da soma é: " + soma);
    }
}