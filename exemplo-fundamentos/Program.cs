using exemplo_fundamentos.Models;

//cast implícito

//  int a = 5;
//  double b = a;

 long a = 5;
 int b = Convert.ToInt32(a);

Console.WriteLine(b);














// int inteiro = 5;
// string a = inteiro.ToString();
// Console.WriteLine(a);






//cast - casting
// int a = Convert.ToInt32(null); //mais indicado para casting, pois caso o valor venha nulo a aplicação não para 

// // int a = int.Parse(null);


// Console.WriteLine(a);











// int a = 10;
// int b = 20;

// int c = a + b;

// // c = c + 5; //30 + 5

// // c += 5;

// //c = c - 5;

// // c -= 5;

// Console.WriteLine(c);










// DateTime dataAtual = DateTime.Now.AddDays(5);

// Console.WriteLine(dataAtual.ToString("dd/MM/yyyy HH:mm"));


// string apresentacao = "Olá, seja bem vindo!";

// int quantidade = 1;

// double altura = 1.80;

// decimal preco = 1.80M;

// bool condicao = true;

// Console.WriteLine(apresentacao);

// Console.WriteLine("Valor da variável quantidade: " + quantidade);
// Console.WriteLine("Valor da variável altura: " + altura.ToString("0.00"));
// Console.WriteLine("Valor da variável preco: " + preco);
// Console.WriteLine("Valor da variável condicao: " + condicao);



// Pessoa p = new Pessoa();

// p.Nome = "Neto";
// p.Idade = 18;
// p.Apresentar();