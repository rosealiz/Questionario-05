using System;

public class menoremaiornumero
{
    public static void Main()
    {
    int[,] matrizZ = new int[3,4];
    int i, j, maior=0, menor=10000;
    Console.WriteLine("digite numeros consecutivamente");
    for(i=0; i<3; i++){
        for(j=0; j<4; j++){
        matrizZ[i,j] = int.Parse(Console.ReadLine());
        if(matrizZ[i,j]>maior){
            maior = matrizZ[i,j];
        }
        if(matrizZ[i,j]<menor){
            menor = matrizZ[i,j];
        }
        }
    }
    for(i=0; i<3; i++){
        for(j=0; j<4; j++){
        if(maior==matrizZ[i,j]){
    Console.WriteLine($"o maior numero e {matrizZ[i,j]} encontrado na linha {i} e coluna {j}"); 
    break;
    }
    }
    }
    
     for(i=0; i<3; i++){
        for(j=0; j<4; j++){
        if(menor==matrizZ[i,j]){
    Console.WriteLine($"o menor numero e {matrizZ[i,j]} encontrado na linha {i} e coluna {j}"); 
    break;
    }
    }
    }
}
}
