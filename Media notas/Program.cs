using System.Security.Cryptography;

Console.WriteLine("informe a primeira nota:");
double nota1=double.Parse(Console.ReadLine());

Console.WriteLine("informe a segunda nota:");
double nota2 = double.Parse(Console.ReadLine());

Console.WriteLine("informe a terceira nota:");
double nota3 = double.Parse(Console.ReadLine());

Console.WriteLine("informe a quarta nota:");
double nota4 = double.Parse(Console.ReadLine());

Console.WriteLine("informe a quinta nota:");
double nota5 = double.Parse(Console.ReadLine());

double media=(nota1+ nota2+nota3+nota4+nota5) / 5;

Console.WriteLine(media);

Console.WriteLine($" a media das 5 notas e de :{media.ToString")


