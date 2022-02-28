using DIO.Biblioteca.Enum;
namespace DIO.Biblioteca.Class
{
    public class Livro : EntidadeBase
    {
        public Livro(int id, Genero genero, string titulo, string descricao, string editora, string autor, int pages, int ano)
        {
            this.Id = id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Editora = editora;
            this.Autor = autor;
            this.Pages = pages;
            this.Ano = ano;
            this.Excluido = false;

        }
        private Genero Genero { get; set; }
        private string Titulo { get; set; }
        private string Descricao { get; set; }
        private string Editora { get; set; }
        private string Autor { get; set; }
        private int Pages { get; set; }
        private int Ano { get; set; }
        private bool Excluido {get; set;}
    

    public override string ToString()
    {
        string retorno = "";
        retorno += "Titulo: " + this.Titulo + Environment.NewLine;
        retorno += "Genero: " + this.Genero + Environment.NewLine;
        retorno += "Descricao: " + this.Descricao + Environment.NewLine;
        retorno += "Editora: " + this.Editora + Environment.NewLine;
        retorno += "Autor: " + this.Autor + Environment.NewLine;
        retorno += "Pages: " + this.Pages + Environment.NewLine;
        retorno += "Excluído: " + this.Excluido + Environment.NewLine;
        retorno += "Ano de Lançamento: " + this.Ano;
        return retorno;
    }


    public string retornaTitulo()
    {
        return this.Titulo;
    }
    public int retornaId()
    {
        return this.Id;
    }
    public bool retornaExcluido()
    {
        return this.Excluido;
    }
    public void Excluir()
    {
        this.Excluido = true;
    }


    }

    
}