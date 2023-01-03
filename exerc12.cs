/* Desenvolva um algoritmo que calcule o reajuste salarial. Se o salário for
abaixo de 1.700 o ajuste é de R$300.00, se maior de R$ 200.00. Para
finalizar, exiba o novo salário na tela. */

int salario, aumento;
    Console.WriteLine ("informe seu salário atual");
     salario = Convert.ToInt32(Console.ReadLine());

      if (salario < 1700.0){
        aumento = salario+300;
        Console.WriteLine("reajuste salarial: " + aumento);
      }
    else {
      aumento = salario+200;
      Console.WriteLine("reajuste salarial: " + aumento);
    }
  }
}
