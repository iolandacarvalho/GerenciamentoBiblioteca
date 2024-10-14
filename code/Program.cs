// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System.Collections.Generic;
using System.Diagnostics.Contracts;

List<string> titulo = ["1984", "Orgulho e Preconceito", "O Pequeno Príncipe", "A sutil arte de ligar o f*oda-se"];
List<string> autor = ["George Orwell", "Jane Austen", "Antoine de Saint-Exupéry", "Mark Manson"];
List<string> genero = ["Romance distópico", "Romance", "Literatura infantil", "Autoajuda"];
List<int> unidades = [2, 0, 1, 3];
Console.Clear();

int largura = 50;
Console.ForegroundColor = ConsoleColor.Black;
Console.BackgroundColor = ConsoleColor.White;
Console.WriteLine("=".PadLeft(21,'='));
Console.WriteLine("- Biblioteca Online -");
Console.WriteLine("=".PadLeft(21,'='));
Console.ResetColor();
Console.Write("\n");

Console.WriteLine("- Login -");
Console.Write("\nnome: ");
string nome = Console.ReadLine().ToLower();
if (nome == "admin")
{
    return1:
    Console.Write("senha: ");
    int senha = int.Parse(Console.ReadLine());
    if (senha == 1234)
    {
        Console.Clear();
        int largura2 = 50;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.BackgroundColor = ConsoleColor.White;
        Console.WriteLine("- Bem Vindo! -");
        Console.ResetColor();
        Console.Write("\n");

        return2:
        Console.WriteLine("1 - Catálogo de livros ->");
        Console.WriteLine("2 - Livros emprestados ->");
        Console.WriteLine("3 - Cadastrar novos livros ->\n");
        Console.Write("O que deseja acessar: ");
        if (!int.TryParse(Console.ReadLine(), out int menu))
        {
            Console.Clear();
            Console.WriteLine("- Valor inválido, insira uma das opções: 1, 2 ou 3.");
            Thread.Sleep(1000);
            Console.Clear();
            goto return2;
        }
        else
        {                
            switch (menu)
            {
                case 1:
                    return4:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("- Catálogo de livros -");
                    Console.ResetColor();

                    for (int cont = 0; cont < titulo.Count(); cont ++)
                    {
                        Console.ResetColor();
                        Console.WriteLine("-".PadLeft(30,'-'));
                        Console.WriteLine($"{cont+1})\nLivro: {titulo[cont]}");
                        Console.WriteLine($"Autor: {autor[cont]}");
                        Console.WriteLine($"Gênero: {genero[cont]}");
                        Console.WriteLine("-");
                        if (unidades[cont] > 0)
                        {
                        Console.BackgroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine($"Unidades disponíveis: {unidades[cont]} ");
                        Console.ResetColor();
                        }
                        else
                        {
                            Console.BackgroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine($"Unidades disponíveis: {unidades[cont]} ");
                            Console.ResetColor();
                        }
                    }
                    Console.ResetColor();
                    Console.WriteLine("\nDeseja sair (S) ou voltar (V)?");
                    string SouV = Console.ReadLine().ToLower();
                    if (SouV == "s")
                    {
                        Console.Clear();
                        Console.WriteLine("ok! :)");
                    }
                    else if (SouV == "v")
                    {
                        Console.Clear();
                        goto return2;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("- Valor inválido, tente novamente.");
                        Thread.Sleep(1000);
                        goto return4;

                    }
                    break;
                case 2:
                    return5:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("- Livros emprestados -");
                    Console.ResetColor();

                    Console.WriteLine("-".PadLeft(30,'-'));
                    Console.WriteLine("1)\nLivro: Harry Potter e a Pedra Filosofal");
                    Console.WriteLine("Autor: J.K. Rowling");
                    Console.WriteLine("-".PadLeft(30,'-'));
                    Console.WriteLine("2)\nLivro: Dom Casmurro");
                    Console.WriteLine("Autor: Machado de Assis");
                    Console.WriteLine("-".PadLeft(30,'-'));
                    Console.WriteLine("3)\nLivro: A Biblioteca da Meia-Noite");
                    Console.WriteLine("Autor: Matt Haig");
                    Console.WriteLine("-".PadLeft(30,'-'));
                    Console.WriteLine("4)\nLivro: Orgulho E Preconceito");
                    Console.WriteLine("Autor: Jane Austen");
                    Console.WriteLine("\nDeseja sair (S) ou voltar V?");
                    string SoV = Console.ReadLine().ToLower();
                    if (SoV == "s")
                    {
                        Console.Clear();
                        Console.WriteLine("ok! :)");
                    }
                    else if (SoV == "v")
                    {
                        Console.Clear();
                        goto return2;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("- Valor inválido, tente novamente.");
                        Thread.Sleep(1000);
                        goto return5;
                    }        
                    break;
                case 3:
                    return6:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("- Cadastrar novos livros -");
                    Console.ResetColor();

                    Console.WriteLine("-".PadLeft(30,'-'));
                    Console.Write("Título do livro: ");
                    string t = Console.ReadLine();
                    Console.Write("Autor: ");
                    string a = Console.ReadLine();
                    Console.Write("Gênero: ");
                    string g = Console.ReadLine();
                    return3:
                    Console.Write("Unidades: ");
                    if (!int.TryParse(Console.ReadLine(), out int un))
                    {
                        Console.WriteLine("- Valor inválido, informe novamente. -");
                        goto return3;
                    }
                    Console.WriteLine("-".PadLeft(30,'-'));
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("- Livro Cadastrado -");
                    Console.ResetColor();
                    titulo.Add(t);
                    autor.Add(a);
                    genero.Add(g);
                    unidades.Add(un);
                    return7:
                    Console.WriteLine("\nDeseja sair (S), voltar (V) ou cadastrar um novo livro (C)?");
                    string SouVouC = Console.ReadLine().ToLower();
                    if (SouVouC == "s")
                    {
                        Console.Clear();
                        Console.WriteLine("ok! :)");
                    }
                    else if (SouVouC == "v")
                    {
                        Console.Clear();
                        goto return2;
                    }
                    else if (SouVouC == "c")
                    {
                        Console.Clear();
                        goto return6;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("- Valor inválido, tente novamente.");
                        Thread.Sleep(1000);
                        goto return7;
                    }
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("- Valor inválido, insira uma das opções: 1, 2 ou 3.");
                    Thread.Sleep(1000);
                    Console.Clear();
                    goto return2;
            }
        }
    }
    else
    {
        Console.WriteLine("Senha incorreta. Tente novamente.");
        goto return1;
    }
}
else
{

}