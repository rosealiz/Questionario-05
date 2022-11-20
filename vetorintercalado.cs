using System;

public class mediasalarios
{
    public static void Main()
    {
   int[] vet1 = new int[5];
   int[] vet2 = new int[5];
   int[] vet3 = new int[10];
   int i, j
   
   for(i=0; i<5; i++){
   Console.WriteLine("digite o elemento {i=1}");
   vet1[i] = int.Parse(Console.ReadLine());
   for(j=0; j<5; j++){
   if(vet1[i]<vet1[j]){
       Console.WriteLine("digite um numero maior que o anterior");
   vet1[i] = int.Parse(Console.ReadLine());
       }
     }
   }
   
   for(i=0; i<5; i++){
   Console.WriteLine("digite o elemento {i=1}");
   vet2[i] = int.Parse(Console.ReadLine());
   for(j=0; j<5; j++){
   if(vet1[i]<vet1[j]){
       Console.WriteLine("digite um numero maior que o anterior");
   vet2[i] = int.Parse(Console.ReadLine());
       }
     }
   }
    }
}

