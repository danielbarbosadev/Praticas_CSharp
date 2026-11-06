using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicios_POO
{
    public class Livro
    {
        public string titulo { get; private set; }
        public string autor { get; private set; }
        public int numeroPaginas { get; private set; }

        public Livro()
        {
            titulo = "Não informado";
            autor = "Não informado";
            numeroPaginas = 0;
        }
        public Livro(string titulo)
        {
            this.titulo = titulo;
        }
        public Livro(string titulo, string autor)
        {
            this.titulo = titulo;
            this.autor = autor;
            
        }
        public Livro(string titulo, string autor, int numeroPaginas)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.numeroPaginas = numeroPaginas;
        }

        public void ConsultarLivro()
        {
            Console.WriteLine
            ($"""
            === LIVRO ====
            Nome: {titulo}
            Autor: {autor}
            Número de Páginas: {numeroPaginas}
            
            """);
        }
    }
}