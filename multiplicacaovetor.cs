using System;

public class multiplicacaovetor
{
    public static void Main()
    {
    int[] numero = new int[8];
    int i=0;
    double multiplicacao=1;
    Console.WriteLine("digite numeros consecutivamente");
    for(i=0; i<8; i++){
        numero[i] = int.Parse(Console.ReadLine());
    }
     Console.WriteLine("esse é o produto dos numeros digitados");
    for(i=0; i<8; i++){
    multiplicacao = multiplicacao * numero[i];
    }
    Console.WriteLine(multiplicacao);
    }
}
