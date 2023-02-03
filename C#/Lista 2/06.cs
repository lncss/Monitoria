
/* Faça uma função que recebe um valor inteiro e verifica se o valor é positivo ou negativo.
A função deve retornar um valor lógico (true ou false). Faça um programa que lê N
números e para cada um deles exibe uma mensagem informando se ele é positivo ou não,
dependendo se foi retornado verdadeiro ou falso pela função.*/
using System;
 
class Program{

    public static void Main(string[] args){
        
        int y;
        int n;
        Console.WriteLine("Digite a quantidade de números");
        y = int.Parse(Console.ReadLine());
 
        for (int k = 0; k < y; k++){
            Console.WriteLine("Digite seu número");
            n = int.Parse(Console.ReadLine());
            if (valor(n) == true){
                Console.WriteLine("O número é positivo");
            }
            else if (valor(n) == false){
                Console.WriteLine("O número é negativo");
            }
            Console.WriteLine(valor(y));
        }
    }
 
    static bool valor(int x){
 
        if (x >= 0){
            //Console.WriteLine("O número é positivo");
            return true;
        }else{    
            //Console.WriteLine("O número é negativo");
            return false;

        }
    }
}
