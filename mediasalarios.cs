using System;

public class mediasalarios
{
    public static void Main()
    {
    double[] salarios = new double[50];
    int i=0;
    double soma=0, media, quantidade=0;
    //lendo o vetor
    Console.WriteLine("digite os salarios dos funcionarios");
    for(i=0; i<50; i++){
        salarios[i] = int.Parse(Console.ReadLine());
    //somando as informações recebidas por respectivos indices
        soma = soma + salarios[i];
    }
    media = soma/i;
    //for para incrementar a quantidade usando o if
    for(i=0; i<50; i++){
    if(salarios[i]>media){
        quantidade++;
    }
    }
    Console.WriteLine($"quantidade de funcionarios com salario acima da media e {quantidade}");
  }
}
