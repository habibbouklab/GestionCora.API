using Gestion.Cora.Restaurant.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion.Cora.Restaurant.Application.Contracts
{
    public interface IGererAssiettes
    {
        List<Ingridient> GetListIngridients();
        int CalculateCalories(Assiette assiette);
    }
}
