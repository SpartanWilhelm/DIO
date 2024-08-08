using System.ComponentModel.Design.Serialization;
using Dio.Models;

int numero = 5;
int contador = 0;

while (contador <= 10)
{
    Console.WriteLine($"{numero} x {contador} = {numero * contador}");
    contador ++;
}

// int numero = 3;

// for (int contador = 0; contador <= 10; contador ++)
// {
//     Console.WriteLine($"{numero} x {contador} = {numero * contador}");
// }

// Calculadora calc = new Calculadora();

// calc.Somar(10, 5);
// calc.Subtrair(10, 5);
// calc.Multiplicar(10, 5);
// calc.Dividir(10, 5);
// calc.Potencia(2, 3);
// calc.Seno(120);
// calc.Coseno(120);
// calc.Tangente(120);
// calc.RaizQuadrada(121);


// Console.WriteLine("Digite uma letra");
// string letra = Console.ReadLine();

// switch (letra)
// {
//     case "a":
//     case "e":
//     case "i":
//     case "o":
//     case "u":
//         Console.WriteLine("Vogal");
//         break;

//     default:
//         Console.WriteLine("Não é vogal.");
//         break;

// }

// int quantidadeEmEstoque = 10;
// int quantidadeCompra = 4;
// bool possivelVenda = quantidadeEmEstoque >= quantidadeCompra;

// Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
// Console.WriteLine($"Quantidade em compra: {quantidadeCompra}");
// Console.WriteLine($"Quantidade em estoque: {possivelVenda}");

// if (possivelVenda)
// {
//     Console.WriteLine("Venda realizada.");
// }
// else
// {
//     Console.WriteLine("Desculpe. Não temos a quantidade desejada em estoque.");
// }


// int a = 1;
// int b = 0;
// int c = a + b;

// Console.WriteLine(c);

// DateTime dataAtual = DateTime.Now.AddDays(5);

// Console.WriteLine(dataAtual.ToString("dd/MM/yyyy HH:mm"));

// string apresentacao = "Olá, seja bem vindo";

// int quantidade = 1;

// quantidade = 10;

// double altura = 1.80;

// decimal preco = 1.80M;

// bool condicao = true;



// Console.WriteLine(apresentacao);
// Console.WriteLine("O valor da variável quantidade: " + quantidade);
// Console.WriteLine("O valor da variável altura: " + altura.ToString("0.00")); // utilizando altura.ToString("0.00") para deixar o número com duas casas decimais
// Console.WriteLine("O valor da variável preço: " + preco);
// Console.WriteLine("O valor da variável condição: " + condicao);







// Pessoa p = new Pessoa();

// p.Nome = "César";
// p.Idade = 41;
// p.Apresentar();