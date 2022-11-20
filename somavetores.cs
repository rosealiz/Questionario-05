using System;

public class somavetores
{
    public static void Main()
    {
    int[] numero = new int[8];
    int[] numero1 = new int[8];
    double[] vetorsoma = new double[8];
    int i=0;
    double soma=1;
    //lendo o primeiro vetor
    Console.WriteLine("digite numeros consecutivamente");
    for(i=0; i<8; i++){
        numero[i] = int.Parse(Console.ReadLine());
    }
    //lendo o segundo vetor
     for(i=0; i<8; i++){
        numero1[i] = int.Parse(Console.ReadLine());
    }
     Console.WriteLine("Vetor C:");
    for(i=0; i<8; i++){
    soma = numero1[i] + numero[i];
    vetorsoma[i] = soma;
    }
     for(i=0; i<8; i++){
    Console.WriteLine(vetorsoma[i]);
    }
    }
}
