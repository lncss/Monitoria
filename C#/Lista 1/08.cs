/* Faça um programa que imprima todos os elementos da série de Fibonacci menores que L. */

using System;

class Program {
    public static void Main(string[] args){

        int num = 0;

        // identificar o numero L
        Console.WriteLine("Indique um numero x: ");
        num = int.Parse(Console.ReadLine());

        // os primeiros numeros da sequencia vao ser 0 e 1 respectivamente
        int firstNum = 0, secondNum = 1;

        if(secondNum < num){
            Console.Write(" 0 1");

            while(num > 0){
                int newNum =  secondNum;

                secondNum = firstNum + secondNum;
                firstNum = newNum;
                // sempre que o numero for maior que 1 a sequencia ira continuar aparecendo até que essa afirmação seja falsa

                if(secondNum < num){
                    Console.Write(" " + secondNum);
                }else break;
            }

            Console.WriteLine();
            Console.WriteLine();
        }
    }
} 