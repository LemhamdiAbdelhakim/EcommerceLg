using System.Collections.Generic;

namespace EcommerceLg.Models
{
    public class Produit
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string description { get; set; }
        public string imageProduit { get; set; }
        public string Type { get; set; }

        //public Category Category { get; set; }
        public SubCategories SubCategories { get; set; }
        public IList<Commande> commandes { get; set; }
    }
}
