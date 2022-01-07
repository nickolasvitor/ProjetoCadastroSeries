using Projeto.Enum;
using System;

namespace Projeto.Classes.Series
{
    public class series : EntidadeBase
    {
        private Generos Genero { get; set; }
        private string Descricao { get; set; }
        private string Titulo { get; set; }
        private temas Tema { get; set; }
        private int AnoLancamento { get; set; }
        
        private int Temporadas {get;set;}
        private bool Excludo {get;set;}

    
    public series(int id, string titulo, string descricao, temas tema, Generos genero, int ano, int temporadas)
    {
        this.id = id;
        this.Titulo = titulo;
        this.Descricao = descricao;
        this.Tema = tema;
        this.Genero = genero;
       
        this.AnoLancamento = ano;
        this.Temporadas=temporadas;
        this.Excludo=false;
    }
    
    public override string ToString()
    {
        string mostrarnatela = "";
        mostrarnatela += "Gênero:" + this.Genero + Environment.NewLine;
        mostrarnatela += "Titulo:" + this.Titulo + Environment.NewLine;
        mostrarnatela += "Descrição:" + this.Descricao + Environment.NewLine;
        
        mostrarnatela += "O ano que a serie foi lançada foi " + this.AnoLancamento + Environment.NewLine;
        mostrarnatela += $"A serie tem {this.Temporadas} temporadas"+ Environment.NewLine;

        return mostrarnatela;
    }
    public int retornaID()
    {
        return this.id;
    }
    public string retornatitulo()
    {
        return this.Titulo;
    }
    public void ExcluiSerie()
    {
        this.Excludo=true;
        
    }
    public bool retornaExcluido()
    {
        return this.Excludo;
    }
}
}
