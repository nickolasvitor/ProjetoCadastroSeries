using System;
using  Projeto.Classes.SeriesRepositorio;
using Projeto.Classes.Series;
using Projeto.Enum;

namespace Projeto
{
    class Program
    {
        static SeriesRepositorio SeriesRepositorio = new SeriesRepositorio();
        static void Main(string[] args)
        {
         int entrar = 1;
         while(entrar==1)
         {  
             string resposta = ObterRespostaUsuario();
             switch(resposta)
             {
                 case "1":
                 ListarSeries();
                 break;
                 case "2":
                 CadastrarSeries();
                 break;
                 case "3":
                 AtualizarSeries();
                 break;
                 case "4":
                 ConsultarSeries();
                 break;
                 case "5":
                 ExcluirSerie();
                 break;
                 case "L":
                 Console.Clear();
                 break;
                 case "S":
                 entrar = 0;
                 break;




             }




         }  




        }
        public static string ObterRespostaUsuario()
        {
            System.Console.WriteLine("Olá muito bem vindos a o programa de cadastro de séries");
            System.Console.WriteLine("Todas as séries cadastradas aqui foram sobre eventos históricos");

            System.Console.WriteLine("");
            System.Console.WriteLine("Digite quais das opções abaixo a prosseguir");
            System.Console.WriteLine("1 Para listar Séries");
            System.Console.WriteLine("2 Para cadastrar Séries");
            System.Console.WriteLine("3 Para atualizar alguma serie já existente");
            System.Console.WriteLine("4 Para consultar alguma serie pelo seu ID");
            System.Console.WriteLine("5 Para Deletar série");
            System.Console.WriteLine("L Para limpar a tela do console");
            System.Console.WriteLine("S Para sair");
            string resposta=Console.ReadLine();
            
            return (resposta);

        }








        static void ListarSeries()

        {   
            
            var lista = SeriesRepositorio.Lista();
            if(lista.Count==0)
            {
                System.Console.WriteLine("Não existe nenhuma série cadastrada" + Environment.NewLine);
                
            }
            else
            {   
                
            
                 foreach(var series in lista)
                 {
                     var excluido = series.retornaExcluido();
                    if(excluido==false)
                    {
                    System.Console.WriteLine($"A série chamada {series.retornatitulo()} de ID:{series.retornaID()}");
                    }else
                    {
                        System.Console.WriteLine($"A série chamada {series.retornatitulo()} de ID:{series.retornaID()} está EXCLUIDA");
                    }
                 }
            }
        }
        static void AtualizarSeries()
        {
            var lista = SeriesRepositorio.Lista();
            if(lista.Count==0)
            {
                System.Console.WriteLine("Não existe nenhuma série cadastrada");
            }
            else{
            System.Console.WriteLine("Qual o ID da serie que deseja cadastrar as informações");
            int id =int.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite o título da série");
                string titulo = Console.ReadLine();
                System.Console.WriteLine("Atualizar uma série"+ Environment.NewLine);

                System.Console.WriteLine("Qual a temática historica da série? Siga o guia abaixo"+ Environment.NewLine);
                System.Console.WriteLine("Guerras Mundiais = 1");
                System.Console.WriteLine("Idade Média = 2");
                System.Console.WriteLine("Civilizações Antigas = 3");
                System.Console.WriteLine("Revoluções = 4");
                System.Console.WriteLine("História da Ciência = 5");
                System.Console.WriteLine("Catástrofes = 6" + Environment.NewLine);
                int tema = int.Parse(Console.ReadLine());

                System.Console.WriteLine("Qual o gênero historica da série? Siga o guia abaixo"+ Environment.NewLine);
                System.Console.WriteLine("Ação = 1");
                System.Console.WriteLine("Aventura = 2");
                System.Console.WriteLine("Romance= 3");
                System.Console.WriteLine("Comédia= 4");
                System.Console.WriteLine("Drama= 5");
                System.Console.WriteLine("Documentário= 6");
                System.Console.WriteLine("Religioso= 7" + Environment.NewLine);
                int genero = int.Parse(Console.ReadLine());

                System.Console.WriteLine("Digite o ano de lançamento " + Environment.NewLine);
                int ano = int.Parse(Console.ReadLine());

                System.Console.WriteLine("Diga uma Descrição sucinta da série" + Environment.NewLine);
                string descricao = Console.ReadLine();

                System.Console.WriteLine("Informe quantas temporadas a série tem" + Environment.NewLine);
                int temporadas = int.Parse(Console.ReadLine());

            
                series atualizar = new series(id:id,titulo:titulo,descricao:descricao, tema:(temas)tema, genero:(Generos)genero,ano,temporadas);
                SeriesRepositorio.Atualiza(id,atualizar);
            


            }
        }

    static void ConsultarSeries()
    {
         var lista = SeriesRepositorio.Lista();
            if(lista.Count==0)
            {
                System.Console.WriteLine("Não existe nenhuma série cadastrada");
            }
            else{
            System.Console.WriteLine("Qual o ID da serie que deseja cadastrar as informações");
            int id =int.Parse(Console.ReadLine());
            var consultar = SeriesRepositorio.retornoporID(id);
            System.Console.WriteLine(consultar);


             }
    }
    static void ExcluirSerie()
    {
        var lista = SeriesRepositorio.Lista();
            if(lista.Count==0)
            {
                System.Console.WriteLine("Não existe nenhuma série cadastrada");
            }
            else{
            System.Console.WriteLine("Qual o ID da serie que deseja cadastrar as informações");
            int id =int.Parse(Console.ReadLine());
            SeriesRepositorio.Excluir(id);
    }

    }
        static void CadastrarSeries()
        {
             string resposta="S";
            while(resposta.ToUpper()=="S")
            {
                System.Console.WriteLine("Digite o título da série");
                string titulo = Console.ReadLine();
                System.Console.WriteLine("Cadastrar nova série"+ Environment.NewLine);

                System.Console.WriteLine("Qual a temática historica da série? Siga o guia abaixo"+ Environment.NewLine);
                System.Console.WriteLine("Guerras Mundiais = 1");
                System.Console.WriteLine("Idade Média = 2");
                System.Console.WriteLine("Civilizações Antigas = 3");
                System.Console.WriteLine("Revoluções = 4");
                System.Console.WriteLine("História da Ciência = 5");
                System.Console.WriteLine("Catástrofes = 6" + Environment.NewLine);
                int tema = int.Parse(Console.ReadLine());

                System.Console.WriteLine("Qual o gênero historica da série? Siga o guia abaixo"+ Environment.NewLine);
                System.Console.WriteLine("Ação = 1");
                System.Console.WriteLine("Aventura = 2");
                System.Console.WriteLine("Romance= 3");
                System.Console.WriteLine("Comédia= 4");
                System.Console.WriteLine("Drama= 5");
                System.Console.WriteLine("Documentário= 6");
                System.Console.WriteLine("Religioso= 7" + Environment.NewLine);
                int genero = int.Parse(Console.ReadLine());

                System.Console.WriteLine("Digite o ano de lançamento " + Environment.NewLine);
                int ano = int.Parse(Console.ReadLine());

                System.Console.WriteLine("Diga uma Descrição sucinta da série" + Environment.NewLine);
                string descricao = Console.ReadLine();

                System.Console.WriteLine("Informe quantas temporadas a série tem" + Environment.NewLine);
                int temporadas = int.Parse(Console.ReadLine());

                
                series serie = new series(id:SeriesRepositorio.Proximo(),titulo:titulo,descricao:descricao, tema:(temas)tema, genero:(Generos)genero,ano,temporadas);
                SeriesRepositorio.Inserir(serie);
            System.Console.WriteLine("Deseja cadastrar uma nova serie S ou N?");
            resposta=Console.ReadLine();
            
        }


        }
    }


   
}


















