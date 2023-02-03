/* Faça um programa que imprima os L primeiros elementos da série de Fibonacci. Por
exemplo, se o usuário digitou o número 40, deverão ser apresentados os 40 números da
sequência na tela. */

using System;

class Program {
    public static void Main(string[] args){
        int qtde;

        Console.WriteLine("Digite a quantidade de numeros da serie Fibonacci:");
        qtde = int.Parse(Console.ReadLine());

        // O primeiro e o segundo numero sempre vão ser 0 e 1 respctivamente
        int firstNum = 0, secondNum = 1;

        if(qtde >= 2){
            Console.Write(" 0 1");
        }else if(qtde == 1){
            Console.Write(" 0");
        }

        // inserir elementos da sequencia
        for(int i = 0; i != qtde - 2; i++){
            int newNum = secondNum;

            secondNum += firstNum;
            firstNum = newNum;

            Console.Write(" " + secondNum); 
        }

        Console.WriteLine();
        Console.WriteLine();

    }
} 