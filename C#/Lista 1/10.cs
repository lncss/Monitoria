/* Em uma eleição presidencial existem quatro candidatos. Os votos são informados através
de códigos. Os dados utilizados para a contagem dos votos obedecem à seguinte
codificação:
1,2,3,4 = voto para os respectivos candidatos;
5 = voto nulo;
6 = voto em branco;
Elabore um algoritmo que leia o código do candidado em um voto. Calcule e escreva:
- total de votos para cada candidato;
- total de votos nulos;
- total de votos em branco.

Como finalizador do conjunto de votos, tem-se o valor 0. */

using System;

class Program {
    public static void Main(string[] args){
        
        //declarar variaveis
        int candidato1 = 0, candidato2 = 0, candidato3 = 0, candidato4 = 0, branco = 0, nulo = 0;
        int voto;

        Console.WriteLine(" ---------- CANDIDATOS -----------");
        Console.WriteLine("\t1 - Jose \n\t2 - Lucia \n\t3 - Mario \n\t4 - Elisangela \n\t5 - Nulo \n\t6 - Branco \n\t7 - Digite 0 para encerrar a votação\n\n");

        
        do{
            //pedir voto do usuario
            Console.WriteLine("Digite o seu voto: ");
            voto = int.Parse(Console.ReadLine());

            if(voto == 1){
                candidato1++;
            }else if(voto == 2){
                candidato2++;
            }else if(voto == 3){
                candidato3++;
            }else if(voto == 4){
                candidato4++;
            }else if(voto == 5){
                nulo++;
            }else if(voto == 6){
                branco++;
            }else if(voto != 0){
                Console.WriteLine("Esse candidato não existe!\nDigite outro número...");
            }

        }while(voto != 0); //quando voto for zero a votação se encerra.
        
        Console.WriteLine("Votação Encerrada\n\n");
        Console.WriteLine("----------RESULTADOS----------");
        Console.WriteLine("\tJose: " + candidato1 + "\n\tLucia: " + candidato2 + "\n\tMario:" + candidato3 + "\n\tElisangela: " + candidato4);
        Console.WriteLine("\tNulos: " + nulo + "\n\tBranco: " + branco);

    }
} 