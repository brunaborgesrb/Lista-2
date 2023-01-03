/* Elabore um algoritmo que calcule a idade média de 5 alunos.*/

 int idade1, idade2, idade3, idade4, idade5;
    double idadeMedia;
    Console.WriteLine ("informe a idade do 1 aluno");
     idade1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine ("informe a idade do 2 aluno");
     idade2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine ("informe a idade do 3 aluno");
     idade3 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine ("informe a idade do 4 aluno");
     idade4 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine ("informe a idade do 5 aluno");
     idade5 = Convert.ToInt32(Console.ReadLine());

    idadeMedia = (idade1+idade2+idade3+idade4+idade5)/5;
    
    Console.WriteLine("a idade média dos alunos é " + idadeMedia);
  }
