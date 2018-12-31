using ByteBank.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaInterno
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(456, 456789);
            Console.WriteLine("Número: " + conta.Numero + "\nAgencia: " + conta.Agencia + "\nSaldo: " + Format.FormatDouble(conta.Saldo));


            Console.ReadLine();
        }
    }
}
