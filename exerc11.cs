/* Desenvolva um algoritmo que solicite a entrada da idade de um determinado
usuário, se for menor que 18 anos exiba na cor vermelha “Sem permissão”,
caso seja maior ou igual a 18 anos exiba na cor verde “Permissão
concedida”. */

 int idade;
    Console.WriteLine ("informe sua idade: ");
     idade = Convert.ToInt32(Console.ReadLine());

      if (idade > 18){
      Console.WriteLine("cor verde: PERMISSÃO CONCEDIDA");
      }
      else {
      Console.WriteLine("cor vermelha : PERMISSÃO NEGADA");
      }
    
  }
}
