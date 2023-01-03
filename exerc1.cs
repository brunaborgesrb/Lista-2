/* Leia três números entrados pelo usuário e mostre na tela qual deles é o
maior. */

int num1, num2, num3;
    Console.WriteLine ("Informe um número");
    num1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine ("Informe outro número");
    num2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine ("Informe outro número");
    num3 = Convert.ToInt32(Console.ReadLine());

    if (num1 > num2) {
      Console.WriteLine ("O primeiro número é o maior");
    }
    else if (num1 > num3) {
      Console.WriteLine ("O primeiro número é o maior");
    } 
    else if (num2 > num1){
      Console.WriteLine ("O segundo número é o maior");
    }
    else if (num2 > num3) {
      Console.WriteLine ("O segundo número é o maior");
    }
    else if (num3 > num1) {
      Console.WriteLine("O terceiro número é o maior");
    }
    else if (num3 > num2){
      Console.WriteLine ("O terceiro número é o maior");
    }
    else{
      Console.WriteLine ("Os três números são iguais");
    }
  }
}
