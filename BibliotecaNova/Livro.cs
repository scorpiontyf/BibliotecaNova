using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaNova
{
    public class Livro 
    {
        public string Titulo { get; private set; }

        public string Autor { get; set; }

        public string Pagina { get; set; }

 

        public Livro(string titulo, string autor, string pagina)
        {
            Titulo = titulo;
            Autor = autor;
            Pagina = pagina;

        }


        public void Cadastrar()
        {
            Console.WriteLine("Digite o número de livros que deseja cadastrar: ");
            int nLivros = int.Parse(Console.ReadLine());

            Livro[] livros = new Livro[nLivros];

            for(int i = 0; i < livros.Length; i++)
            {
                Console.Clear();
                Console.WriteLine("Livro # " + (i+1) + " Título: ");
                string titulo = Console.ReadLine();

                Console.WriteLine("Livro # " + (i + 1) + " Nome do Autor: ");
                string autor = Console.ReadLine();

                Console.WriteLine("Livro # " + (i + 1) + " Número de Páginas: ");
                string pagina = Console.ReadLine();

                livros[i] = new Livro(titulo, autor, pagina);

                Console.WriteLine("Seus livros foram cadastrados com sucesso! ");
 

                Console.WriteLine("Digite qualquer tecla para voltar!");

                Voltar();

            }
        }

        public void Emprestar()
        {
            Console.WriteLine("Digite o número de livros que deseja emprestar: ");
            int nLivros = int.Parse(Console.ReadLine());

            Livro[] livros = new Livro[nLivros];

            for (int i = 0; i < livros.Length; i++)
            {
                Console.Clear();
                Console.WriteLine("Livro # " + (i + 1) + " Título: ");
                string titulo = Console.ReadLine();

                Console.WriteLine("Livro # " + (i + 1) + " Nome do Autor: ");
                string autor = Console.ReadLine();

                Console.WriteLine("Livro # " + (i + 1) + " Número de Páginas: ");
                string pagina = Console.ReadLine();

                livros[i] = new Livro(titulo, autor, pagina);

                Console.WriteLine("Seus livros foram emprestados com sucesso! ");


                Console.WriteLine("Digite qualquer tecla para voltar!");

                Voltar();

            }

        }

        public void Devolver()
        {
            Console.WriteLine("Digite o número de livros que deseja devolver: ");
            int nLivros = int.Parse(Console.ReadLine());

            Livro[] livros = new Livro[nLivros];

            for (int i = 0; i < livros.Length; i++)
            {
                Console.Clear();
                Console.WriteLine("Livro # " + (i + 1) + " Título: ");
                string titulo = Console.ReadLine();

                Console.WriteLine("Livro # " + (i + 1) + " Nome do Autor: ");
                string autor = Console.ReadLine();

                Console.WriteLine("Livro # " + (i + 1) + " Número de Páginas: ");
                string pagina = Console.ReadLine();

                livros[i] = new Livro(titulo, autor, pagina);

                Console.WriteLine("Seus livros foram e com sucesso! ");


                Console.WriteLine("Digite qualquer tecla para voltar!");

                Voltar();

            }

        }
        public void Erro()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Digite a opção correta que desejas realizar:");
            Console.ResetColor();


            Console.WriteLine("1- Cadastrar " + "\n2- Emprestar " + "\n3- Devolver ");
            string option = Console.ReadLine();
            switch (option)
            {
                case "1":
                    Console.Clear();
                    Cadastrar();
                    break;
                case "2":
                    Console.Clear();
                    Emprestar();
                    break;
                case "3":
                    Console.Clear();
                    Devolver();
                    break;
                default:
                    while (option != "1" && option != "2" && option != "3" && option != "4")
                    {
                        Console.Clear();
                        Erro();
                    }
                    break;
            }

        }

        public void Voltar()
        {
            Console.WriteLine("Digite a opção que desejas realizar:");


            Console.WriteLine("1- Cadastrar " + "\n2- Emprestar " + "\n3- Devolver ");
            string option = Console.ReadLine();
            switch (option)
            {
                case "1":
                    Console.Clear();
                    Cadastrar();
                    break;
                case "2":
                    Console.Clear();
                    Emprestar();
                    break;
                case "3":
                    Console.Clear();
                    Devolver();
                    break;
                default:
                    while (option != "1" && option != "2" && option != "3" && option != "4")
                    {
                        Console.Clear();
                        Erro();
                    }
                    break;
            }

        }


        public void Apresentar()
        {
            Console.WriteLine("Digite a opção que desejas realizar:");
            Console.WriteLine("1- Cadastrar " + "\n2- Emprestar " + "\n3- Devolver ");
            string option = Console.ReadLine();
            switch(option)
            {
                case "1":
                    Console.Clear();
                    Cadastrar();
                    break;
                case "2":
                    Console.Clear();
                    Emprestar();
                    break;
                case "3":
                    Console.Clear();
                    Devolver();
                    break;
                default:
                    while (option != "1" && option != "2" && option != "3" && option != "4")
                    {
                        Console.Clear();
                        Erro();
                    }
                    break;
            }
        }

    }
}
