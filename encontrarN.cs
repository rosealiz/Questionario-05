using System;

public class encontrarN
{
    public static void Main()
    {
    int[] numero = new int[10];
    int i, N, posicao=0;
    Console.WriteLine("digite numeros consecutivamente");
    for(i=0; i<10; i++){
        numero[i] = int.Parse(Console.ReadLine());
    }
    Console.WriteLine("digite o numero desejado");
    N = int.Parse(Console.ReadLine());
    for(i=0; i<10; i++){
        if(N==numero[i]){
        posicao = i;
        Console.WriteLine($"o numero foi encontrado no indice {posicao}");
        break;
        }
     }
     if(posicao != i){
        Console.WriteLine("N nao esta presente no vetor");
        }
  }
}
