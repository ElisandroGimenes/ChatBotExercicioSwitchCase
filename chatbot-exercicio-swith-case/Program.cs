using System;
using System.Linq.Expressions;

//ChatBot

int opcao;

Console.WriteLine("                            ****Digite a opção desejada:****                      ");
Console.WriteLine("                            --------------------------------                      ");
Console.WriteLine("                            1 - Atendimento Pessoa Física                         ");
Console.WriteLine("                            --------------------------------                      ");
Console.WriteLine("                            2 - Atendimento Pessoa Jurídica                       ");
Console.WriteLine("                            --------------------------------                      ");
Console.WriteLine("                            3 - Novo cliente                                      ");
Console.WriteLine("                            --------------------------------                      ");
Console.WriteLine("                            4 - Sair do sistema                                   ");
Console.WriteLine("                            --------------------------------                      ");

opcao = int.Parse(Console.ReadLine());

switch (opcao)
{
    case 1:
        {
            Console.WriteLine("Digite o número do CPF:");
            break;
        }
    case 2:
        {
            Console.WriteLine("Digite o número do CNPJ:");
            break;
        }
    case 3:
        {
            Console.WriteLine("Selecione o serviço desejado:");
            break;
        }
    case 4:
        {
            Console.Clear();
            Console.WriteLine("                     -------------------------------------                        ");
            Console.WriteLine("                     Obrigado por usar os nossos serviços!                        ");
            Console.WriteLine("                     -------------------------------------                        ");
            break;
        }
    default: 
        {
            Console.WriteLine("Opção incorreta! Tente novamente.");
            break;
        }
}


