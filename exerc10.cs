/* Desenvolva uma calculadora, onde será necessário entrar com a operação,
primeiro e segundo valor, exiba o resultado na tela. */

 double a1, a2, adicao, subtracao, div, mult;

            Console.WriteLine("Informe a opção desejada");
            Console.WriteLine("1 para ADIÇÃO");
            Console.WriteLine("2 para SUBTRAÇÃO");
            Console.WriteLine("3 para MULTIPLICAÇÃO");
            Console.WriteLine("4 para DIVISÃO");
            

           
            Console.Write("qual operação voce deseja realizar? ");
            int operacao = Convert.ToInt32(Console.ReadLine());
            Console.Write("digite o primeiro número: ");
            a1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("digite o segundo número: ");
            a2 = Convert.ToDouble(Console.ReadLine());

            switch (operacao)
            {

                case 1:
                    adicao = a1 + a2;
                    Console.WriteLine("o resultado é " + adicao);
                    break;

                case 2:
                    subtracao = a1 - a2;
                    Console.WriteLine("o resultado é " + subtracao);
                    break;

                case 3:
                    mult = a1 * a2;
                    Console.WriteLine("o resultado é " + mult);
                    break;

                default:
                    div = a1 / a2;
                    Console.WriteLine("o resultado é " + div);
                    break;
            }
    
