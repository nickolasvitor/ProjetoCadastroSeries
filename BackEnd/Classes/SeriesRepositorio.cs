using Projeto.Interfaces;
using Projeto.Classes.Series;
using System.Collections.Generic;

namespace Projeto.Classes.SeriesRepositorio
{
    public class SeriesRepositorio : IRepositorio<series>
    {
        private List<series>
        listaseries = new List<series>();


       
       
        public void Atualiza(int id, series entidade)  
        {  listaseries[id] = entidade;

        }

        public void Excluir(int id)
        {
            listaseries[id].ExcluiSerie();
        }

        public void Inserir(series entidade)
        {
           listaseries.Add(entidade);
        }

        public List<series> Lista()
        {
           return listaseries;
        }

        public series retornoporID(int id)
        {
            return listaseries[id];
        }
        public int Proximo(){
            return listaseries.Count;
        }

    }   



}