/*ta incompleto*/
using System;

public class questao9
{
    public static void Main()
    {
    int[] A = new int[3];
    int[] B = new int[3];
    int[] C = new int[10];
    int i,j,numero;
    Console.WriteLine("digite os elementos do primeiro vetor");
    for(i=0; i<3; i++){
        numero = int.Parse(Console.ReadLine());
        A[i] = numero;
    }
    Console.WriteLine("digite os elementos do segundo vetor");
    for(i=0; i<3; i++){
        numero = int.Parse(Console.ReadLine());
        B[i] = numero;
    }
    for(i=0; i<3; i++){
        for(j=0; j<3; j++){
        if(A[i]==B[j]){
        C[i]=A[i];
        }
      }
    }
    //DUVIDA: depois desse for o C fica igual o 0 (tentei imprimir, mas tava saindo 0) Não sei pq ele zera aqui se eu to dizendo que é igual a A[i]
      Console.WriteLine("Vetor C: ");
    for(i = 0; i < 10; i++){
        if(C[i] == 0){
            continue;
        }else{
        Console.Write("{0}\t", C[i]);
        }
    }
   //depois desse for o C toma o valor que eu preciso, e nele prevê o C = 0 que eu falo no começo, mas eu não entendo o motivo 
}
}
