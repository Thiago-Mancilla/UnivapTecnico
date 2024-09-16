/* *******************************************************************
* Colegio Técnico Antônio Teixeira Fernandes (Univap)
* Curso Técnico em Informática - Data de Entrega: 26/03/2024
* Autores do Projeto: Rodrigo Roda Oliveto Alves
*                     Thiago Alexander Moreira Mancilla
* Turma: 2H
* Atividade Proposta em aula
* Observação: Para médias e percentuais coloquei todas as variáveis em float para que o número fosse mais exato e pudesse aparecer no console 
*             quando a operação não fosse exata
* 
* problema_aula.cs
* ************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace projetowagner
{
    class problema_aula
    {
        static void Main(string[] args)
        {
            int id, id_maior = 0, id_menor = 0, gr, gr_maior = 0, gr_menor = 0, pessoas = 0;
            string nome, resp, nome_maior = "0", nome_menor = "0";
            float sal, salr, cot, c = 0.0f, ci = 0.0f, cp = 0.0f, sal_maior = 0.0f, sal_menor = 0.0f, soma = 0.0f, dg1 = 0.0f, dg3 = 0.0f;
            int a = 0, b = 0;
            do
            {
                pessoas++;
                Console.WriteLine("Digite seu nome:");
                nome = Console.ReadLine();
                Console.WriteLine("Digite sua idade:");
                id = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o valor do seu salário (U$$):");
                sal = float.Parse(Console.ReadLine());
                Console.WriteLine("Digite o valor da cotação do dólar:");
                cot = float.Parse(Console.ReadLine());
                do
                {
                    Console.WriteLine("Digite o grau da sua formação (1) - Primário, (2) - Segundo Grau e (3) - Superior:");
                    gr = int.Parse(Console.ReadLine());
                } while ((gr != 1) && (gr != 2) && (gr != 3));

                //letra h)
                do
                {
                    Console.WriteLine("Deseja continuar (APENAS S/N)?:");
                    resp = Console.ReadLine();
                } while ((resp != "S") && (resp != "N"));
                salr = sal * cot;

                //letra a)
                if ((salr > 500.00) && (gr == 3))
                {
                    a++;
                }
                if (id > 25)
                {
                    b++;
                }
                else
                {
                    b--;
                }
                //letra c)
                if (gr == 2)
                {
                    cp++;
                    ci += id;
                }
                // letra d)
                if (gr == 1)
                {
                    dg1++;
                }
                else if (gr == 3)
                {
                    dg3++;
                }
                //letra e)
                if (sal >= sal_maior)
                {
                    sal_maior = sal;
                    nome_maior = nome;
                    gr_maior = gr;
                    id_maior = id;
                }
                if(pessoas == 1) 
                {
                    sal_menor = sal;
                    nome_menor = nome;
                    gr_menor = gr;
                    id_menor = id;
                }
                if (sal <= sal_menor)
                {
                    sal_menor = sal;
                    nome_menor = nome;
                    gr_menor = gr;
                    id_menor = id;
                }
                //letra f)
                soma += sal;

            } while (resp == "S");
            //letra a
            Console.WriteLine("Pessoas com curso superior e salário maior que 500 reais: " + a);
            Console.WriteLine("=======================================================================================");
            Console.WriteLine("=======================================================================================");
            //letra b
            Console.WriteLine("A diferença entre a quantidade de pessoas com mais de 25 anos e menos de 25 anos: " + b);
            Console.WriteLine("=======================================================================================");
            Console.WriteLine("=======================================================================================");
            //letra c - continuação:
            c = ci / cp;
            Console.WriteLine("Idade média das pessoas que possuem formação de 2° grau: " + c);
            Console.WriteLine("=======================================================================================");
            Console.WriteLine("=======================================================================================");
            //letra d - continuação:
            Console.WriteLine("Pessoas Com Curso Primario: " + dg1);
            Console.WriteLine("Pessoas Com Curso Superior: " + dg3);
            dg1 = (dg1 / pessoas) * 100;
            dg3 = (dg3 / pessoas) * 100;
            Console.WriteLine("Percentual de pessoas com curso primário: " + dg1);
            Console.WriteLine("Percentual de pessoas com curso superior: " + dg3);
            Console.WriteLine("=======================================================================================");
            Console.WriteLine("=======================================================================================");
            //letra e
            Console.WriteLine("Dados da pessoa com maior Salário: ");
            Console.WriteLine("Grau de instrução: " + gr_maior);
            Console.WriteLine("Idade: " + id_maior);
            Console.WriteLine("Salário: " + sal_maior);
            Console.WriteLine("Nome: " + nome_maior);
            Console.WriteLine("=======================================================================================");
            Console.WriteLine("=======================================================================================");
            Console.WriteLine("Dados da pessoa com menor Salário: ");
            Console.WriteLine("Grau de instrução: " + gr_menor);
            Console.WriteLine("Idade: " + id_menor);
            Console.WriteLine("Salário: " + sal_menor);
            Console.WriteLine("Nome: " + nome_menor);
            Console.WriteLine("=======================================================================================");
            Console.WriteLine("=======================================================================================");
            //letra g - 2° possibilidade:
            Console.WriteLine("Somatória dos salário (sem os acréscimos) = " + (soma * cot));
            //letra f - continuação)
            if ((soma > 20000) && (soma <= 35000))
            {
                soma = soma + soma / 100 * 20;
            }
            if ((soma > 35000) && (soma <= 45000))
            {
                soma = soma + soma / 100 * 10;
            }
            if ((soma > 45000) && (soma <= 50000))
            {
                soma = soma + soma / 100 * 5;
            }
            if (soma > 50000)
            {
                soma = soma + soma / 100 * 3;
            }
            //letra g)
            soma *= cot;
            Console.WriteLine("Somatória dos salário (com os acréscimos) = " + soma);
            Console.WriteLine("=======================================================================================");
            Console.WriteLine("=======================================================================================");

        }
    }
}