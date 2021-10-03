using System;
using System.Collection.Generic;
using Dio.Series.Interfaces;

namespace Dio.Series
{
    public class SerieRepositorio: IRepositorio<Series>
    {
     private List<Series>  listaSeries = new List<Series>();
     public void Atualiza(int id,Series entidade)
     {
       listaSeries[id] = entidade;
     }  

     public void Excluir(int id)
     {
        listaSeries[id].Excluir();
     } 
     public void Insere(Series entidade)
     {
         listaSeries.Add(entidade);
     } 
     public List<Series>Lista()
     {
      return listaSeries;  
     }

       public int ProximoId()
     {
        return listaSeries.Count;
     } 

       public int RetornaPorId(int id)
     {
        return listaSeries[id];
     } 
    }
}