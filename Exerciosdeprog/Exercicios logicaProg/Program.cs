//Nivel facil
using System.IO.Pipes;

Console.WriteLine("Digite um numero inteiro:");
int numero = int.Parse(Console.ReadLine());
int dobro = (numero * 2);
Console.WriteLine(dobro);

//soma simples
Console.WriteLine("digite o primeiro numero");
int numero1 = int.Parse(Console.ReadLine());

Console.WriteLine("digite o segundo numero");
int numero2 = int.Parse(Console.ReadLine());

int soma = numero1 + numero2;

Console.WriteLine("a soma e:" + soma);

// par ou impar
Console.Write("Digite um número: ");
int par = int.Parse(Console.ReadLine());

if (par % 2 == 0)
    Console.WriteLine("O número é par.");
else
    Console.WriteLine("O número é ímpar.");

// Maior numero
Console.Write("Digite o primeiro número: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Digite o segundo número: ");
int b = int.Parse(Console.ReadLine());

if (a > b)
    Console.WriteLine("Maior número: " + a);
else if (b > a)
    Console.WriteLine("Maior número: " + b);
else
    Console.WriteLine("Os números são iguais.");


// idade minima
Console.Write("Digite sua idade: ");
int idade = int.Parse(Console.ReadLine());

if (idade >= 18)
    Console.WriteLine("Maior de idade.");
else
    Console.WriteLine("Menor de idade.");
                    Console.WriteLine("Exercício inválido.");

// nivel medio

// media notas 
Console.Write("Digite a primeira nota: ");
double nota1 = double.Parse(Console.ReadLine());
Console.Write("Digite a segunda nota: ");
double nota2 = double.Parse(Console.ReadLine());

double media = (nota1 + nota2) / 2;
Console.WriteLine("Média: " + media);

if (media >= 6)
    Console.WriteLine("Aluno aprovado.");
else
    Console.WriteLine("Aluno reprovado.");

// intervalo numerico

Console.Write("Digite um número: ");
int valor = int.Parse(Console.ReadLine());

if (valor >= 50 && valor <= 100)
    Console.WriteLine("Está entre 50 e 100.");
else
    Console.WriteLine("Não está entre 50 e 100.");


// desconto em produto
Console.Write("Digite o valor do produto: ");
double produto = double.Parse(Console.ReadLine());

if (produto > 100)
    produto = produto * 0.90;

Console.WriteLine("Valor final: R$ " + produto.ToString("F2"));


// postivo, negativo, ou zero

Console.Write("Digite um número: ");
int.Parse(Console.ReadLine());

if (numero > 0)
    Console.WriteLine("Número positivo.");
else if (numero < 0)
    Console.WriteLine("Número negativo.");
else
    Console.WriteLine("O número é zero.");


//pode votar

Console.Write("Digite sua idade: ");
 int.Parse(Console.ReadLine());

if (idade >= 16)
    Console.WriteLine("Pode votar.");
else
    Console.WriteLine("Não pode votar.");
                    Console.WriteLine("Exercício inválido.");


// nivel dificil
// sitema de login simples
Console.Write("Digite o usuário: ");
string usuario = Console.ReadLine() ?? string.Empty;

Console.Write("Digite a senha: ");
string senha = Console.ReadLine() ?? string.Empty;

if (usuario == "admin" && senha == "1234")
    Console.WriteLine("Login bem-sucedido!");
else
    Console.WriteLine("Usuário ou senha incorretos.");

//maior de tres numeros
Console.Write("Digite o primeiro número: ");
int n1 = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Digite o segundo número: ");
int n2 = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Digite o terceiro número: ");
int n3 = int.Parse(Console.ReadLine() ?? "0");

int maior = n1;

if (n2 > maior)
    maior = n2;

if (n3 > maior)
    maior = n3;

Console.WriteLine("Maior número: " + maior);


// calculo de salario com bonus
Console.Write("Digite o salário: ");
double salario = double.Parse(Console.ReadLine() ?? "0");

if (salario > 2000)
    salario = salario * 1.10;
else
    salario = salario * 1.20;

Console.WriteLine("Novo salário: R$ " + salario.ToString("F2"));

// ano bissexto
Console.Write("Digite um ano: ");
int ano = int.Parse(Console.ReadLine() ?? "0");

if (ano % 4 == 0)
    Console.WriteLine("Ano bissexto pelo critério simplificado.");
else
    Console.WriteLine("Não é bissexto pelo critério simplificado.");

// validacao de acesso
Console.Write("Digite sua idade: ");
int idade2 = int.Parse(Console.ReadLine() ?? "0");

Console.Write("Possui convite? (true/false): ");
bool convite = bool.Parse(Console.ReadLine() ?? "false");

if (idade >= 18 && convite)
    Console.WriteLine("Acesso permitido!");
else
    Console.WriteLine("Acesso negado.");
                    Console.WriteLine("Exercício inválido.");

// tartaruga
Console.WriteLine("1) Tartarugas");
int distanciaPrimeira = 30 * 16;
int diasSegunda = distanciaPrimeira / 20;
int espera = diasSegunda - 16;
Console.WriteLine($"Primeira tartaruga percorreu {distanciaPrimeira} metros em 16 dias.");
Console.WriteLine($"Segunda tartaruga percorreu {distanciaPrimeira} metros em {diasSegunda} dias.");
Console.WriteLine($"Tempo de espera: {espera} dias.");

// monte cartas Enem
Console.WriteLine();
Console.WriteLine("2) Monte de cartas");
int cartasUsadas = 1 + 2 + 3 + 4 + 5 + 6 + 7;
int monte = 52 - cartasUsadas;
Console.WriteLine($"Cartas no monte: {monte}");

// Pizzaria
Console.WriteLine();
Console.WriteLine("3) Pizzaria");
int sabores = 3;
int bordas = 2;
int tamanhos = 2;
int combinacoes = sabores * bordas * tamanhos;
Console.WriteLine($"Combinações diferentes: {combinacoes}");


// sequencia
Console.WriteLine();
Console.WriteLine("4) Sequências");
Console.WriteLine("I) Próximo número: 9");
Console.WriteLine("II) Próximo número: 128");
Console.WriteLine("III) Próximo número: 49");
Console.WriteLine("IV) Próximo número: 100");
Console.WriteLine("V) Próximo número: 13");
Console.WriteLine("VI) Próximo número: 20");
    





