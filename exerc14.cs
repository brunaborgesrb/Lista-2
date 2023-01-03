/* Desenvolva um algoritmo que calcule o IMC de uma determinada pessoa, e
grave os resultados em um arquivo de texto, onde ao acessar a aplicação
será solicitado se quer fazer um novo cadastro ou consultar os existentes.
Cadastrando um novo calculo de IMC, será necessário informar o nome,
idade, peso e altura. O cálculo do IMC é feito dividindo o peso (em
quilogramas) pela altura (em metros) ao quadrado. */ 

string nome;
            int idade;
            double peso, altura, imc;
            Console.Write("informe seu nome: ");
            nome = Console.ReadLine();
            Console.Write("informe sua idade: ");
            idade = Convert.ToInt32(Console.ReadLine());
            Console.Write("informe seu peso: ");
            peso = Convert.ToDouble(Console.ReadLine());
            Console.Write("informe sua altura: ");
            altura = Convert.ToDouble(Console.ReadLine());

            imc = (peso / altura* altura);


            if (imc < 18.5){
                Console.WriteLine("seu IMC é: " + imc + " e você está abaixo do peso");
            }
            else if (imc >= 18.5 && imc < 24.9){
                Console.WriteLine("seu IMC é: " + imc + " e você está normal");
            }
            else if (imc > 25.0 && imc < 29.9){
                Console.WriteLine("seu IMC é: " + imc + " e você está com sobrepeso");
            }
            else if (imc > 30.0 && imc < 39.9){
                Console.WriteLine("seu IMC é: " + imc + " e você está com obesidade");
            }
             else{
                Console.WriteLine("seu IMC é: " + imc + " e você está com obesidade grave");
            }
