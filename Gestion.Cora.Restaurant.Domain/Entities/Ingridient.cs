using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion.Cora.Restaurant.Domain.Entities
{
    public class Ingridient
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public int Calories { get; set; }
        public bool IsSelected { get; set; }

    }
}
