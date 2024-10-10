// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System.Collections.Generic;
using System.Diagnostics.Contracts;

List<string> titulo = new List<string>();
List<string> autor = new List<string>();
List<string> genero = new List<string>();
List<int> unidades = new List<int>();
titulo.Add("1984");
autor.Add("George Orwell");
genero.Add("Romance distópico");
unidades.Add(2);

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
        int menu = int.Parse(Console.ReadLine());

                
        switch (menu)
        {
            case 1:
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("- Catálogo de livros -");
                Console.ResetColor();

                // Console.WriteLine("-".PadLeft(30,'-'));
                // Console.WriteLine("1)\nLivro: 1984");
                // Console.WriteLine("Autor: George Orwell");
                // Console.WriteLine("Gênero: Romance distópico");
                // Console.WriteLine("-");
                // Console.BackgroundColor = ConsoleColor.DarkGreen;
                // Console.WriteLine("Unidades disponíveis: 2");
                // Console.ResetColor();
                // Console.WriteLine("-".PadLeft(30,'-'));
                // Console.WriteLine("2)\nLivro: Orgulho E Preconceito");
                // Console.WriteLine("Autor: Jane Austen");
                // Console.WriteLine("Gênero: Romance");
                // Console.WriteLine("-");
                // Console.BackgroundColor = ConsoleColor.DarkRed;
                // Console.WriteLine("Unidades disponíveis: 0");
                // Console.ResetColor();
                // Console.WriteLine("-".PadLeft(30,'-'));
                // Console.WriteLine("3)\nLivro: O Pequeno Príncipe");
                // Console.WriteLine("Autor: Antoine de Saint-Exupéry");
                // Console.WriteLine("Gênero: Literatura infantil");
                // Console.WriteLine("-");
                // Console.BackgroundColor = ConsoleColor.DarkGreen;
                // Console.WriteLine("Unidades disponíveis: 1");
                // Console.ResetColor();
                // Console.WriteLine("-".PadLeft(30,'-'));
                // Console.WriteLine("4)\nLivro: A sutil arte de ligar o f*da-se");
                // Console.WriteLine("Autor: Mark Manson");
                // Console.WriteLine("Gênero: Autoajuda");
                // Console.WriteLine("-");
                // Console.BackgroundColor = ConsoleColor.DarkGreen;
                // Console.WriteLine("Unidades disponíveis: 3");
                // Console.ResetColor();
                for (int cont = 0; cont < titulo.Count(); cont ++)
                {
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
                Console.WriteLine("\nDeseja sair ou voltar?");
                string SouV = Console.ReadLine();
                if (SouV == "sair")
                {
                    Console.Clear();
                    Console.WriteLine("ok! :)");
                }
                else
                {
                    Console.Clear();
                    goto return2;
                }
                break;
            case 2:
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
                Console.WriteLine("\nDeseja sair ou voltar?");
                string SoV = Console.ReadLine();
                if (SoV == "sair")
                {
                    Console.Clear();
                    Console.WriteLine("ok! :)");
                }
                else
                {
                    Console.Clear();
                    goto return2;
                }         
                break;
            case 3:
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
                Console.WriteLine("\nDeseja sair, voltar ou cadastrar um novo livro?");
                string SouVouC = Console.ReadLine();
                if (SouVouC == "sair")
                {
                    Console.Clear();
                    Console.WriteLine("ok! :)");
                }
                else
                {
                    Console.Clear();
                    goto return2;
                }         
                break;
            default:

                break;
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

