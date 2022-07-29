using System.Globalization;
using System;
namespace Encapsulamento.Models
{
    public class Conta
    {

        
        public int Numero { get; private set; }
        public string Nome { get; set; }
        public double Saldo { get; private set; }

        public Conta()
        {
            
        }
      

        public Conta(int numero, string nome, double saldo)
        {
            Numero = numero;
            Nome =  nome;   
            Saldo = saldo;
        }

      

        public Conta(int numero, string nome)
        {
            Numero = numero;
            Nome = nome;
            Saldo = 0.0;
        }

        public void Quantia(double quantia) 
        => Saldo+= quantia;

        public void Saque(double quantia) 
        {               
            Saldo= (Saldo - quantia) - 5.00;            
        }
        public override string ToString()
        {
            return "Conta "
            + Numero
            + " Titular: "
            + Nome
            + ", "            
            + "Saldo: "
            + "$ "
            + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
        

    }
}