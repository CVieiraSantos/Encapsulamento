using System.Globalization;
using System;
using Encapsulamento.Models;

namespace Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {            
                Console.Clear();
                Console.Write("Entre o número da conta: ");
                int numero = int.Parse(Console.ReadLine());
                Console.Write("Entre o titular da conta: ");
                string nome = Console.ReadLine();
                Console.Write("Haverá depósito inicial (s/n)? ");
                char caractere = char.Parse(Console.ReadLine());   
                                
                
                if(caractere == 's' || caractere == 'S')
                {          
                    Console.Write("Entre o valor de depósito inicial: ");                                                   
                    double saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); 
                    Conta conta = new Conta(numero, nome, saldo);                                                                                                                  
                    Console.WriteLine("Dados da conta:");
                    Console.WriteLine(conta);
                    Console.WriteLine();
                    Console.Write("Entre um valor para depósito: ");
                    double depósito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    conta.Quantia(depósito);
                    Console.WriteLine("Dados da conta atualizados:");
                    Console.WriteLine(conta);
                    Console.WriteLine();
                    Console.Write("Entre um valor para saque: ");
                    double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.WriteLine("Dados da conta atualizados:");
                    conta.Saque(saque);
                    Console.WriteLine(conta);                    

                }

                else if(caractere == 'n' || caractere == 'N')
                
                {               
                    Conta conta = new Conta(numero, nome);
                    Console.WriteLine("Dados da conta:");
                    Console.WriteLine(conta);
                    Console.WriteLine();
                    Console.Write("Entre um valor para depósito: ");
                    double depósito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);  
                    Conta conta1 = new Conta(numero, nome, depósito);
                    Console.WriteLine("Dados da conta atualizados:");
                    Console.WriteLine(conta1);                    
                    Console.WriteLine();
                    Console.Write("Entre um valor para saque: ");
                    double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.WriteLine("Dados da conta atualizados:");
                    conta1.Saque(saque);
                    Console.WriteLine(conta1);
                    
                    
                }                    
                
            

                

            
        }
    }
}
