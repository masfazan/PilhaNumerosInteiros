namespace PilhaNumerosInteiros
{
    internal class Pilhas
    {
        Numero topo;
        int pares;
        int impares;
        int quantidade;

        public Pilhas()
        {
            topo = null;
            pares = 0;
            impares = 0;
            quantidade = 0;
        } //pilha

        Boolean PilhaVazia()
        {
            if (topo == null) //quando o topo for null está vazia
                return true;
            else
                return false;
        }

        public void push(Numero aux)
        {
            if (PilhaVazia() == true)
            {
                topo = aux;
            }

            else
            {
                aux.setNanterior(topo);//set porque atribui valor
                topo = aux;
            }
        }

        public void pop()
        {
            if (PilhaVazia() == false)
            { }
            else
                topo = topo.getNanterior();
        }

        public int tamanho()
        {
            Numero aux = topo;
            int cont = 0;
            if (PilhaVazia())
            {
                return 0;
            }
            else
            {
                do
                {
                    cont++;
                    aux = aux.getNanterior();
                } while (aux != null);
            }
            return cont;
        }

        public void Par()
        {
            Numero aux = topo;
            int par = 0;
            while (aux != null)
            {
                {
                    if (aux.getNumero() % 2 == 0) ; //resto zero = par
                    {
                        par++;
                        Console.WriteLine($"Número par: {aux.getNumero()}");

                    }
                }
                aux = aux.getNanterior();//vai receber o valor do anterior
            }
            Console.WriteLine("Quantidade de números pares: "+ par);
        }

        public void Impar()
        {
            Numero aux = topo;
            int impar = 0;
            while (aux != null)
            {
                {
                    if (aux.getNumero() % 2 != 0) ; //resto diferente de zero = impar
                    {
                        impar++;
                        Console.WriteLine($"Número ímpar: {aux.getNumero()}");

                    }
                }
                aux = aux.getNanterior();//vai receber o valor do anterior
            }
            Console.WriteLine("Quantidade de números ípares: " + impar);
        }
        public void print()
        {
            Numero aux = topo;

            if (PilhaVazia())
            {
                Console.WriteLine("Pilha vazia");

            }
            else
            {
                do
                {
                    Console.WriteLine(aux.ToString());
                    aux = aux.getNanterior();
                } while (aux != null);
                Console.ReadKey();
            }
        }
        public Pilhas CopiarPilha()
        {
            Numero aux = topo;
            Pilhas pilhaaux = new Pilhas();
            if (PilhaVazia())
            {
                Console.WriteLine("A pilha selecionada está vazia.");
            }
            else
            {
                for (; aux != null; aux = aux.getNanterior()) ;
            }
            {
                // Adiciona o valor atual de aux à nova pilha
                pilhaaux.push(new Numero(aux.getNumero()));
            }
            return pilhaaux;
        }

        
    }
}

