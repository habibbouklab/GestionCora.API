using Gestion.Cora.Restaurant.Domain.Entities;

namespace Gestion.Cora.Restaurant.Persistance
{
    public static class IAccesBD
    {
        public static List<Ingridient> GetIngridients()
        {
            return new List<Ingridient>()
            {
                new Ingridient(){
                Id=1,
                Nom="Farine",
                Calories=200,
                IsSelected=false
                },new Ingridient()
                {
                Id=2,
                Nom="Lait",
                Calories=150,
                IsSelected=false
                },new Ingridient()
                {
                Id=3,
                Nom="Sirop",
                Calories=800,
                IsSelected=false

                },new Ingridient()
                {
                Id=4,
                Nom="Fraises",
                Calories=350,
                IsSelected=false
                }
            };
        }
    }
}