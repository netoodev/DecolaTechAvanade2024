﻿using exemplo_explorando.models;
using System.Globalization;

Queue<int> fila = new Queue<int>();

fila.Enqueue(2);
fila.Enqueue(4);
fila.Enqueue(6);
fila.Enqueue(8);

foreach (int item in fila)
{
    Console.WriteLine(item);
}

Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}");
fila.Enqueue(10);

foreach (int item in fila)
{
    Console.WriteLine(item);
}











// new ExemploExcecao().Metodo1();

















// try 
// {

// string[] linhas = File.ReadAllLines("arquivos/arquivo_Leitura.txt");

// foreach (string linha in linhas)
// {
//     Console.WriteLine(linha);
// }

// } 

// catch(FileNotFoundException ex)
// {
//     Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Arquivo não encontrado. {ex.Message}");
// }

// catch(DirectoryNotFoundException ex)
// {
//     Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Caminho da pasta não encontrado. {ex.Message}");
// }

// catch(Exception ex)
// {
//     Console.WriteLine($"Ocorreu uma exceção genérica. {ex.Message}");
// }

// finally
// {
//     Console.WriteLine("Chegou até aqui.");
// }




















// string dataString = "2023-12-08 21:00";

// bool conversao = DateTime.TryParseExact(dataString, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime data);

// if (conversao)
// {
//     Console.WriteLine($"Conversão com sucesso! Data: {data}");
// }
// else 
// {
//     Console.WriteLine($"{dataString} não é uma data válida!");
// }















// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

// decimal valorMonetario = 1582.40M;

// Console.WriteLine(valorMonetario.ToString("C3")); //Formatando casa decimal


// double porcentagem = .3421; 

// Console.WriteLine(porcentagem.ToString("P")); // Formatando porcentagem

// int numero = 123456;

// Console.WriteLine(numero.ToString("##-##-##")); // Formatando personalizado















// string numero1 = "10";
// int numero2 = 20;

// string resultado = numero1 + numero2;

// Console.WriteLine(resultado);

















// Pessoa p1 = new Pessoa(nome: "José", sobrenome: "Neto");

// Pessoa p2 = new Pessoa(nome: "Eduardo", sobrenome: "Neves Queiroz");

// Curso cursoDeIngles = new Curso();
// cursoDeIngles.Nome = "Inglês";
// cursoDeIngles.Alunos = new List<Pessoa>();

// cursoDeIngles.AdicionarAluno(p1);
// cursoDeIngles.AdicionarAluno(p2);
// cursoDeIngles.ListarAlunos();