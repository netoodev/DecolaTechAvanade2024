using exemplo_fundamentos.Models;


Calculadora calc = new Calculadora();

calc.Somar(10,30);
calc.Subtrair(10,50);
calc.Multiplicar(15,45);
calc.Dividir(2,2);















// bool choveu = false;
// bool estaTarde = true;

// if (!choveu && !estaTarde)
// {
//     Console.WriteLine("Vou pedalar.");
// }
// else
// {
//     Console.WriteLine("Vou pedalar outro dia");
// }















// bool presencaMinima = false;
// double media = 7.5;

// if (presencaMinima && media >= 7)
// {
//     Console.WriteLine("Aprovado!");
// }
// else
// {
//     Console.WriteLine("Reprovado!");
// }


















// bool maiorIdade = false;
// bool autorizacaoResponsavel = true;

// if (maiorIdade || autorizacaoResponsavel)
// {
//     Console.WriteLine("Entrada liberada!");
// }
// else
// {
//     Console.WriteLine("Entrada não liberada!"); 
// }





















// Console.WriteLine("Digite uma letra: ");
// string? letra = Console.ReadLine();

// switch (letra)
// {
//     case "a":
//     case "e":
//     case "i":
//     case "o":
//     case "u":
//         Console.WriteLine($"A letra {letra} é vogal");
//         break;
//     default:
//         Console.WriteLine("Não é uma vogal.");
//         break;
// }

















// if (letra == "a" ||
//     letra == "e" ||
//     letra == "i" || 
//     letra == "o" ||
//     letra == "u")
// {
//     Console.WriteLine("Vogal.");
// }
// else
// {
//     Console.WriteLine("Não é vogal.");
// }






















// int quantidadeEmEstoque = 10;
// int quantidadeCompra = 0;
// bool possivelVenda = quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra;
// string resposta;

// if (possivelVenda)
// {
//     resposta = "Sim.";
// }
// else
// {
//     resposta = "Não.";
// }

// Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
// Console.WriteLine($"Quantidade compra: {quantidadeCompra}");
// Console.WriteLine($"É possível realizar a venda? {resposta}");

// if (quantidadeCompra == 0)
// {
//     Console.WriteLine("Venda inválida");
// }
// else if (possivelVenda)
// {
//     Console.WriteLine("Venda Realizada.");
// }
// else
// {
//     Console.WriteLine("Desculpe, não temos a quantidade desejada em estoque.");
// }








// string a = "15-";
// //int b = 0;

// int.TryParse(a, out int b); // tenta converter o "a", se não conseguir, exibe "b" como resultado

// Console.WriteLine(b);







// double a = 4 / (2 + 2);

// Console.WriteLine(a);







//cast implícito

//  int a = 5;
//  double b = a;

// long a = 5;
// int b = Convert.ToInt32(a);

// Console.WriteLine(b);














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