using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cadastro_de_funcionarios_e_aumento_de_salario {
    internal class Porcentagem_de_aumento_do_salario {
        public static decimal aumento(decimal salario_atual)
        {
            // Solicita ao usuário que digite a porcentagem de aumento desejada
            Console.Write("Digite a porcentagem: ");
            decimal porcentagem_do_aumento = decimal.Parse(Console.ReadLine());

            // Calcula o valor do aumento multiplicando o salário atual pela porcentagem do aumento dividida por 100
            decimal aumento = salario_atual * (porcentagem_do_aumento / 100);

            // Retorna o novo valor do salário com o aumento
            return salario_atual + aumento;
        }
    }
}

