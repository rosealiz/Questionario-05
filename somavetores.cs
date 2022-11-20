using System;

public class multiplicacaovetor
{
    public static void Main()
    {
    int[] numero = new int[8];
    int[] numero1 = new int[8];
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
     Console.WriteLine("esse é o produto dos dois vetores");
    for(i=0; i<8; i++){
    soma = numero1[i] + numero[i];
    Console.WriteLine(soma);
    }
    }
}
