using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion.Cora.Restaurant.Domain.Entities
{
    public class Assiette
    {
        public int Id { get; set; }
        public string? Nom { get; set; }
        public List<Ingridient>? Ingridients { get; set; } 
    }
}
