/* Faça um programa que receba dez números e verifique se eles são divisíveis por 3 e 9 (ao
mesmo tempo), por 2 e por 5. Caso algum número não seja divisível por nenhum desses
números mostre a mensagem “Número não é divisível pelos valores”. Apresente também
ao final a quantidade de números divisíveis por 3 e 9, por 2 e por 5. */

using System;
 
class Program {
  public static void Main (string[] args) {

    double num = 0;
    double resposta = 0;


    do{
        Console.WriteLine ("Digite um numero: "); //pergunta numero ao usuario
        num = double.Parse(Console.ReadLine());

        if(((num%3)==0) && ((num%9)==0)){ //verifica se e divisisel por 3 e 9
            Console.WriteLine ("O numero {0} e divisivel por 3 e 9", num);

        }else if(((num%2)==0) && ((num%5)==0)){ //verifica se e divisivel por 2 e 5
            Console.WriteLine ("O numero {0} e divisivel por 2 e 5", num);

        }else{
            Console.WriteLine("O numero nao e divisivel por nenhum dos numeros"); 
        }
        
    }while(num != 0);
    
  }
}