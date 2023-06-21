using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cadastro_de_funcionarios_e_aumento_de_salario {
    internal class Program {
        static void Main(string[] args)
        {
            Console.WriteLine("Iniciado");
            Console.WriteLine();

            Console.Write("Quantos funcionários serão cadastrados?: ");
            int quantidade_de_funcionarios = int.Parse(Console.ReadLine());
            Console.WriteLine();

            List<Dados_do_funcionario> funcionario = new List<Dados_do_funcionario>();

            int numero_do_registro = 1;
            for (int i = 0; i < quantidade_de_funcionarios; i++)
            {
                Dados_do_funcionario usuario_cadastrado = new Dados_do_funcionario();

                Console.WriteLine("Registro N: " + numero_do_registro);
                usuario_cadastrado.Numero_do_registro = numero_do_registro;

                Console.Write("Qual o numero do Rg?: ");
                usuario_cadastrado.Rg = int.Parse(Console.ReadLine());

                Console.Write("Qual o nome do funcionario?: ");
                usuario_cadastrado.Nome = Console.ReadLine();

                Console.Write("Digite o valor do salario: ");
                usuario_cadastrado.Salario = decimal.Parse(Console.ReadLine());

                funcionario.Add(usuario_cadastrado);
                numero_do_registro++;
                Console.WriteLine();
            }

            bool busca = false;
            while (!busca) 
            {
                Console.WriteLine("Digite o numero do Rg que recebera o aumento: ");
                int rg_digitado = int.Parse(Console.ReadLine());

                foreach(Dados_do_funcionario rg in funcionario) 
                {
                    if(rg.Rg == rg_digitado) 
                    {
                        busca = true;
                        break;
                    }
                }
                if (!busca) { Console.WriteLine("Rg não encontrado, digite novamente"); }
            }

            Console.ReadKey();
        }
    }
}
