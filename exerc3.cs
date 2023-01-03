/* Leia um caractere e informe se ele é vogal ou consoante. */

 char letra;
            Console.WriteLine("digite um caractere");
            Char.TryParse (Console.ReadLine(),out letra);
            if (letra == 'a' || letra == 'A' || letra == 'e' || letra == 'E' || letra == 'i'
                || letra == 'I' || letra == 'o' || letra == 'O' || letra == 'u' || letra == 'U')
            {
                Console.WriteLine("é uma vogal");
            }
            else
            {
                Console.WriteLine("é uma consoante");
            }


       }
    }
}
