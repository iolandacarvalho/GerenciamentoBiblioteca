// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

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

                Console.WriteLine("-".PadLeft(30,'-'));
                Console.WriteLine("Livro: 1984");
                Console.WriteLine("Autor: George Orwell");
                Console.WriteLine("Gênero: Romance distópico");
                Console.WriteLine("-");
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Unidades disponíveis: 2");
                Console.ResetColor();
                Console.WriteLine("-".PadLeft(30,'-'));
                Console.WriteLine("Livro: Orgulho E Preconceito");
                Console.WriteLine("Autor: Jane Austen");
                Console.WriteLine("Gênero: Romance");
                Console.WriteLine("-");
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Unidades disponíveis: 0");
                Console.ResetColor();
                Console.WriteLine("-".PadLeft(30,'-'));
                Console.WriteLine("Livro: O Pequeno Príncipe");
                Console.WriteLine("Autor: Antoine de Saint-Exupéry");
                Console.WriteLine("Gênero: Literatura infantil");
                Console.WriteLine("-");
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Unidades disponíveis: 1");
                Console.ResetColor();
                Console.WriteLine("-".PadLeft(30,'-'));
                Console.WriteLine("Livro: A sutil arte de ligar o f*da-se");
                Console.WriteLine("Autor: Mark Manson");
                Console.WriteLine("Gênero: Autoajuda");
                Console.WriteLine("-");
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Unidades disponíveis: 3");
                Console.ResetColor();
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
                
                break;
            case 3:
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("- Cadastrar novos livros -");
                Console.ResetColor();
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

