using System;

public class encontrarN
{
    public static void Main()
    {
    int[,] matrizM = new int[3,5];
    int i, j, X, posicao=0;
    Console.WriteLine("digite numeros consecutivamente");
    for(i=0; i<3; i++){
        for(j=0; j<5; j++){
        matrizM[i,j] = int.Parse(Console.ReadLine());
        }
    }
    Console.WriteLine("digite o numero desejado");
    X = int.Parse(Console.ReadLine());
    for(i=0; i<3; i++){
        for(j=0; j<5; j++){
        if(X==matrizM[i,j]){
        posicao = i;
        Console.WriteLine($"o numero foi encontrado na linha {i} e coluna {j}");
        break;
        }
        }
     }
     if(posicao != i){
        Console.WriteLine("N nao esta presente no vetor");
        }
  }
}
