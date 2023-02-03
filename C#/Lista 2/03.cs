/* Faça um procedimento que recebe 3 valores inteiros por parâmetro e os exiba em ordem
crescente. Faça um programa que leia N conjuntos de 3 valores e acione o procedimento
para cada conjunto. (N deve ser lido do teclado)*/

using System;
 
class Program{

    public static void Main(string[] args){
        
      int num1, num2, num3; //variaveis para armazenar num
      int n = 0; //quantidade de conjuntos

        Console.WriteLine("Digite a quantidade de conjuntos: ");
        n = int.Parse(Console.ReadLine());

        do{
           Console.WriteLine("Digite o primeiro numero: ");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o primeiro numero: ");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o primeiro numero: ");
            num3 = int.Parse(Console.ReadLine()); 
            n--;

            crescente(num1, num2, num3);

        } while (n != 0);
 
    }
 
   static void crescente(int num1, int num2, int num3){
 
        if (num1 > num2 && num2 > num3){
            Console.WriteLine("{0}, {1}, {2}", num3, num2, num1);
            
        }else if(num1 > num3 && num3 > num2){
            Console.WriteLine("{0}, {1}, {2}", num2, num3, num1);

        }else if(num2 > num1 && num1 > num3){ 
            Console.WriteLine("{0}, {1}, {2}", num3, num1, num2);

        }else if(num2 > num3 && num3 > num1){
            Console.WriteLine("{0}, {1}, {2}", num1, num3, num2);

        }else if(num3 > num1 && num1 > num2){    
            Console.WriteLine("{0}, {1}, {2}", num2, num1, num3);

        }else if(num3 > num2 && num2 > num1){
            Console.WriteLine("{0}, {1}, {2}", num1, num2, num3);
        }
    }

}
 