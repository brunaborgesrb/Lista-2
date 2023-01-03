/* Desenvolva um algoritmo que solicite a entrada de nome, e-mail, telefone e
RG de um determinado usuário e grave em um arquivo de texto. */

string nome, email;
            int tel, rg;
            Console.Write("informe seu nome: ");
            nome = Console.ReadLine();
            Console.Write("informe seu e-mail: ");
            email = Console.ReadLine();
            Console.Write("informe seu telefone: ");
            tel = Convert.ToInt32(Console.ReadLine());
            Console.Write("informe seu rg: ");
            rg = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("nome: " + nome + " ; email: " + email + " ; telefone: " + tel + " ; rg: " + rg);
        }
