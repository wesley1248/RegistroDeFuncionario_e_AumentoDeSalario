using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cadastro_de_funcionarios_e_aumento_de_salario {
    internal class Program {
        static void Main(string[] args)
        {
            // Imprime uma mensagem indicando o início do programa
            Console.WriteLine("Iniciado");
            Console.WriteLine();

            // Solicita ao usuário a quantidade de funcionários que serão cadastrados
            Console.Write("Quantos funcionários serão cadastrados?: ");
            int quantidade_de_funcionarios = int.Parse(Console.ReadLine());
            Console.WriteLine();

            // Cria uma lista vazia para armazenar os dados dos funcionários
            List<Dados_do_funcionario> funcionarios = new List<Dados_do_funcionario>();

            // Variável para armazenar o número do registro de cada funcionário
            int numero_do_registro = 1;

            // Loop para cadastrar os funcionários
            for (int i = 0; i < quantidade_de_funcionarios; i++)
            {
                // Cria uma instância da classe Dados_do_funcionario
                Dados_do_funcionario usuario_cadastrado = new Dados_do_funcionario();

                // Imprime o número do registro atual
                Console.WriteLine("Registro N: " + numero_do_registro);

                // Atribui o número do registro ao objeto usuario_cadastrado
                usuario_cadastrado.Numero_do_registro = numero_do_registro;

                // Solicita ao usuário o número do RG e atribui ao objeto usuario_cadastrado
                Console.Write("Qual o número do Rg?: ");
                usuario_cadastrado.Rg = int.Parse(Console.ReadLine());

                // Solicita ao usuário o nome do funcionário e atribui ao objeto usuario_cadastrado
                Console.Write("Qual o nome do funcionário?: ");
                usuario_cadastrado.Nome = Console.ReadLine();

                // Solicita ao usuário o valor do salário e atribui ao objeto usuario_cadastrado
                Console.Write("Digite o valor do salário: ");
                usuario_cadastrado.Salario = decimal.Parse(Console.ReadLine());

                // Adiciona o objeto usuario_cadastrado à lista de funcionários
                funcionarios.Add(usuario_cadastrado);

                // Incrementa o número do registro
                numero_do_registro++;

                Console.WriteLine();
            }

            // Variável para indicar se a busca pelo RG foi encontrada
            bool busca = false;

            // Loop para buscar o funcionário pelo RG e realizar o aumento de salário
            while (!busca)
            {
                // Solicita ao usuário o número do RG que receberá o aumento
                Console.Write("Digite o número do RG que receberá o aumento: ");
                int rg_digitado = int.Parse(Console.ReadLine());

                // Loop para percorrer a lista de funcionários
                foreach (Dados_do_funcionario rg in funcionarios)
                {
                    // Verifica se o RG digitado é igual ao RG do funcionário atual
                    if (rg.Rg == rg_digitado)
                    {
                        // Indica que a busca foi encontrada
                        busca = true;

                        // Loop para buscar o funcionário pelo RG novamente e realizar o aumento de salário
                        foreach (Dados_do_funcionario busca_do_salario in funcionarios)
                        {
                            // Verifica se o RG buscado é igual ao RG do funcionário atual
                            if (busca_do_salario.Rg == rg_digitado)
                            {
                                // Chama o método "aumento" da classe Porcentagem_de_aumento_do_salario para realizar o aumento de salário
                                busca_do_salario.Salario = Porcentagem_de_aumento_do_salario.aumento(busca_do_salario.Salario);

                                Console.WriteLine();
                            }
                        }

                        // Encerra o loop após encontrar o funcionário
                        break;
                    }
                }

                // Se a busca não foi encontrada, imprime uma mensagem de erro
                if (!busca) { Console.WriteLine("RG não encontrado, digite novamente"); }
            }

            // Imprime os dados dos funcionários cadastrados
            funcionarios.ForEach(funcionarios_cadastrados =>
            {
                Console.WriteLine(funcionarios_cadastrados.Rg + "," + funcionarios_cadastrados.Nome + "," + funcionarios_cadastrados.Salario.ToString("F2"));
                Console.WriteLine("--------------------------------");
            });

            // Aguarda o usuário pressionar uma tecla para encerrar o programa
            Console.ReadKey();
        }
    }
}

