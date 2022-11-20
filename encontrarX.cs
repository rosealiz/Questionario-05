using System;

public class encontrarX
{
    public static void Main()
    {
    int[,] matrizM = new int[3,5];
    int i, j, X, busca=0;
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
        Console.WriteLine($"o numero foi encontrado na linha {i} e coluna {j}");
        break;
        }
        else{
            busca++;
        }
        }
        }
    if(busca==15){
        Console.WriteLine("O numero nao esta na matriz");
    }
  }
}
