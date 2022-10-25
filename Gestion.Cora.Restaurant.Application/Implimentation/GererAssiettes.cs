using Gestion.Cora.Restaurant.Application.Contracts;
using Gestion.Cora.Restaurant.Domain.Entities;
using Gestion.Cora.Restaurant.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion.Cora.Restaurant.Application.Implimentation
{
    public class GererAssiettes : IGererAssiettes
    {
        public int CalculateCalories(Assiette assiette)
        {
            var sommeCalories = 0;
            foreach (var ingridient in assiette.Ingridients)
            {
                sommeCalories += ingridient.Calories;
            }
            return sommeCalories;
        }

        public List<Ingridient> GetListIngridients()
        {
            var listIngridients = IAccesBD.GetIngridients();
            return listIngridients;
        }
    }
}
