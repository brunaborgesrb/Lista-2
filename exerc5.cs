/* Crie um algoritmo que pergunte ao usuário seu nome e sua idade. Em
seguida verifique se a idade é maior ou menor de 18*/

char nome;
    int idade;
    Console.WriteLine ("informe seu nome");
     Char.TryParse (Console.ReadLine(),out nome);
    Console.WriteLine ("informe sua idade");
     idade = Convert.ToInt32(Console.ReadLine());

      if (idade >18){
        Console.WriteLine("você tem mais de 18 anos");
      }
    else {
      Console.WriteLine("você tem menos de 18 anos");
    }
  }
}
