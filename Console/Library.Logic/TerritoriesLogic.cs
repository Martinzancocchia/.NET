using Library.Data;
using Library.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Logic
{
    public class TerritoriesLogic : BaseLogic
    {
      
        public List<Territories> GetAll()
        {
            return context.Territories.ToList();
        }
        
        public void Add(Territories newTerritories)
        {
            context.Territories.Add(newTerritories);

            context.SaveChanges();
        }

        public void Delete(string id)
        {
            var territorioAEliminar = context.Territories.Find(id);

            context.Territories.Remove(territorioAEliminar);

            context.SaveChanges();


        }

        public void Update(Territories territories)
        {
            var territorioAActualizar = context.Territories.Find(territories.TerritoryID);

            territorioAActualizar.TerritoryDescription = territories.TerritoryDescription;
            

            context.SaveChanges();
        }

        //public void UpdateByID(string ID)
        //{
        //    var territorioAActualizar = context.Territories.Find(ID);

        //    territorioAActualizar.TerritoryDescription = territories.TerritoryDescription;


        //    context.SaveChanges();
        //}
    }
}
