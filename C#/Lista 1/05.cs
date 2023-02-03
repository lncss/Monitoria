/* A prefeitura de uma cidade fez uma pesquisa entre seus habitantes, coletando dados sobre o
salário e número de filhos de cada habitante. A prefeitura deseja saber:
a) média do salário da população;
b) média do número de filhos;
c) maior salário;
d) percentual de pessoas com salário até R$100,00.
O final da leitura de dados se dará com a entrada de um salário negativo. */

using System;
 
class Program {
  public static void Main (string[] args) {

    double salario = 0;
    int filhos; 
    double soma = 0, somaf = 0, media = 0, mediaf = 0, perctSal = 0, maior = 0;
    int c = 0, aux = 0; 

    do{
      Console.WriteLine ("Digite seu salário, por favor!");
      salario = double.Parse(Console.ReadLine());
      if(salario < 0) {
        break;
      }else if(salario > 100){
        aux++;
      } 

      if(salario > maior){
         maior = salario;
      }

      Console.WriteLine ("Quantos filhos você tem?");
      filhos = int.Parse(Console.ReadLine());
      while(filhos < 0 ){
        Console.WriteLine("Numero de filhos invalido");
        Console.WriteLine ("Quantos filhos você tem?");
        filhos = int.Parse(Console.ReadLine());
      }
            
      soma += salario;
      somaf += filhos; 
      c++;  
   
    }while(salario > 0);

    media = soma / c;
    mediaf = somaf / c;
    perctSal = (aux * 100)/ c; 
 
    Console.WriteLine ("media dos salarios = {0}", media);
    Console.WriteLine ("media dos filhos = {0}", mediaf);
    Console.WriteLine("maior salario = {0}", maior);
    Console.WriteLine("percentual de pessoas com salario maior que 100 = {0}", perctSal);
 
  }
}