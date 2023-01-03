/*Crie um algoritmo para fazer o reajuste salarial de um funcionário. Caso ele
receba menos que 1.700, calcule um aumento de 10%, caso ele receba mais
que 1.700, o ajuste é de 5%.*/

double salario, aumento;
    Console.WriteLine ("informe seu salário atual");
     salario = Convert.ToDouble32(Console.ReadLine());

      if (salario < 1700.0){
        aumento = salario*0.10;
        Console.WriteLine("reajuste salarial: " + aumento);
      }
    else {
      aumento = salario*0.05;
      Console.WriteLine("reajuste salarial: " + aumento);
    }
  }
}
