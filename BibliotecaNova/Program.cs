using BibliotecaNova;
using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.Title = "Biblioteca Prover";
        Livro l = new Livro(" ", " ", " ");
        l.Apresentar();
    }
}