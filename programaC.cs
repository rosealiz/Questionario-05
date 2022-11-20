using System;

public class programaC
{
    public static void Main()
    {
    int[,] matrizA = new int[4,4];
    int i, j, soma=0;
    Console.WriteLine("digite numeros consecutivamente");
    for(i=0; i<4; i++){
        for(j=0; j<4; j++){
        matrizA[i,j] = int.Parse(Console.ReadLine());
        }
    }
    for(i=0; i<4; i++){
        for(j=0; j<4; j++){
        if(i==j){
        soma = soma + matrizA[i,j];
        }
        }
    }
     Console.WriteLine("Matriz A:");
    for(i=0; i<4; i++){
        for(j=0; j<4; j++){
        Console.Write(matrizA[i,j]+" ");
        }
    Console.WriteLine();
    }
    Console.WriteLine($"a soma da diagonal principal é {soma}");
    }
}
