/*Leia um caractere e informe na tela se ele é um número ou letra */

char letra, numero;
    Console.WriteLine ("digite um caractere");
    letra = Convert.ToChar16(Console.ReadLine());
    numero = Convert.ToChar16(Console.ReadLine());
    
    if(numero == 1 || numero == 2 || numero == 3 || numero == 4 || numero == 5|| numero == 6 || numero == 7 || numero == 8 || numero == 9 || numero == 0){
        Console.WriteLine("é um número");
   }
    else {
        Console.WriteLine("é uma letra");
}
    
    
  }
