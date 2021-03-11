using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6Vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string[] statusQuarto = new string[10];

            Locatario[] quarto  = new Locatario[10];

            for(int i = 0; i < 10; i++)
            {
                statusQuarto[i] = "Vazio";

            }
            Console.WriteLine("Digite a quantidade de quartos a serem alugados (0 a 9): ");
            int quant = int.Parse(Console.ReadLine());

            for(int i = 0; i < quant; i++)
            {
                Console.Write("Digite o numero do " + (i+1) + "º quarto a ser alugado (0 a 9): " );
                int numQuarto = int.Parse(Console.ReadLine());
                statusQuarto[numQuarto] = "Cheio";
                Console.Write("Digite o Nome do Morador: ");
                string nome = Console.ReadLine();
                Console.Write("Digite o Email do Morador: ");
                string email = Console.ReadLine();
                Console.WriteLine("------------------------------------");
                

                quarto[numQuarto] = new Locatario { Nome = nome, Email = email };
            }
            for(int i = 0; i < 10; i++)
            {
                if(statusQuarto[i] == "Vazio")
                {
                    quarto[i] = new Locatario { Nome = "Vazio", Email = "Vazio" };
                }
                else
                {
                    Console.WriteLine("Quarto " + i + " Ocupado\n" + quarto[i]);
                }
            }
            Console.WriteLine("------------------------------------");
            
            Console.ReadKey();
        
        }
    }
}
