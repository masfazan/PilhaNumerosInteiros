using PilhaNumerosInteiros;

internal class Program
{
    private static void Main(string[] args)
    {
        Pilhas pilha1 = new Pilhas();
        Pilhas pilha2 = new Pilhas();
        Pilhas pilhaaux = new Pilhas();
        int opcmenu;
        int opcpilha;
        int numero;
        int opccopia = 0;

        do
        {
            Console.Clear();
            Console.WriteLine("MENU PRINCIPAL");
            Console.WriteLine();
            Console.WriteLine("1-Inserir número na(s) pilha(s)");
            Console.WriteLine("2-Imprimir pilha(s)");
            Console.WriteLine("3-Verificar tamanho das pilhas");
            Console.WriteLine("4-Tranferir elementos da pilha para pilha auxiliar");
            Console.WriteLine("5-Imprimir números ímpares");
            Console.WriteLine("6-Imprimir números pares");
            Console.WriteLine("0-Sair");
            Console.Write("Informar a opção desejada:< >\b\b");
            opcmenu = int.Parse(Console.ReadLine());

            switch (opcmenu)
            {
                case 1:
                    Console.WriteLine("Informe em qual pilha deseja adicionar números inteiros, pilha 1 ou pilha 2? ");
                    opcpilha = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o número que deseja incluir na pilha: ");
                    while (!int.TryParse(Console.ReadLine(), out numero)) //TryParse converte pra bool, melhora cód verificação
                    {
                        Console.WriteLine("Por favor, insira um número inteiro válido:");
                    }

                    if (opcpilha == 1)
                    {
                        pilha1.push(new Numero(numero));
                    }
                    else if (opcpilha == 2)
                    {
                        pilha2.push(new Numero(numero));
                    }
                    else
                    {
                        Console.WriteLine("Opção inválida.");
                    }
                    break;
                case 2:
                    Console.WriteLine("Pilha 1");
                    pilha1.print();
                    Console.WriteLine("Pilha 2");
                    pilha2.print();
                    break;
                case 3:
                    {
                        int qtdpilha1 = pilha1.tamanho();
                        int qtdpilha2 = pilha2.tamanho();
                        if (qtdpilha1 == qtdpilha2)
                        {
                            Console.WriteLine("As pilhas são iguais de tamanho!\n");
                        }
                        else if (qtdpilha1 > qtdpilha2)
                        {
                            Console.WriteLine("A pilha 1 é maior!\n");
                        }
                        else
                        {
                            Console.WriteLine("A pilha 2 é maior!\n");
                        }
                    }
                    Console.ReadKey();
                   break;
                case 4:
                    Console.WriteLine("Deseja tranferir os valores da pilha 1 ou da pilha 2? Digite 1 ou 2.");
                    while (!int.TryParse(Console.ReadLine(), out numero)) //TryParse converte pra bool, melhora cód verificação
                    {
                        Console.WriteLine("Por favor, insira um número inteiro válido:");
                    }

                    if (opccopia == 1)
                    {
                        pilha1.CopiarPilha();
                        pilhaaux.print();
                    }
                    else
                    {
                        pilha2.CopiarPilha();
                        pilhaaux.print();
                    }
                    break;
            
                case 5:
                    pilha1.Par();
                    pilha2.Par();
                    break;
                case 6:
                    pilha1.Impar();
                    pilha2.Impar();
                    break;
                case 0:
                    Console.WriteLine("Sair");
                    break;
                default:
                    Console.WriteLine("Opção não existe");
                    break;
            }

        } while (opcmenu != 0);
    }


}