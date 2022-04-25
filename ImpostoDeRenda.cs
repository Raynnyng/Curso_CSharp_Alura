using System;

namespace AliquotaIR
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira o valor do seu salário.");
            double salario = Convert.ToDouble(Console.ReadLine());
            //double deducao;
            if (salario < 1903.98){
                Console.WriteLine("Você está isento do Imposto de Renda");
            }
            else if(salario >= 1903.99 && salario <= 2826.65){
                Console.WriteLine("A sua alíquota é 7,5% e o valor que você deve deduzir é: R$142.80");
            }
            else if(salario >= 2826.66 && salario <= 3751.05){
                Console.WriteLine("A sua alíquota é 15% e o valor que você deve deduzir é: R$354,80");
            }
            else if(salario >= 3751.06 && salario <= 4664.68){
                Console.WriteLine("A sua alíquota é 22,5% e o valor que você deve deduzir é: R$636,13");
            }
            else Console.WriteLine("A sua alíquota é 27,5% e o valor que você deve deduzir é: R$869,36");
        }
    }
}
