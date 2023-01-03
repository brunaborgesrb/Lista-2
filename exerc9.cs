/* Faça um algoritmo que exiba quantas pessoas possuem mais de 18 anos. O
algoritmo deverá ler a idade de 10 pessoas. */ 

 int idade;
        int cont = 0;
 
        for (int i = 1; i <= 10); {
 
            idade = Convert.ToInt32(Console.ReadLine());
          
          Console.WriteLine("Informe a idade da pessoa");
 
            if (idade >= 18) {
                cont = cont + 1;
            }
        }
 
        Console.WriteLine ("A quantidade de pessoas com idade maior ou igual a 18 anos é de " + cont);
    }
 
}
