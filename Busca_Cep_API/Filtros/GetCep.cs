using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuscaCep.Filtros
{
    internal class GetCep
    {
        public static void localizarCep() 
        {
            Console.WriteLine("Insira o seu cep: ");
            int cep = int.Parse(Console.ReadLine());
            string CepString = cep.ToString();
            if(CepString.Length < 8 || CepString.Length >8)
            {
                Console.WriteLine("Invalido! O cep digitado é menor do que 8 digitos!!");
                Console.ReadKey();
            }
        }
    }
}
