using System.Collections.Generic;

namespace EcommerceLg.Models
{
    public class SubCategories
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //public string descriptionSub { get; set; }
        public  Category Category { get; set; }

        public IList<Produit> Produits { get; set; }
    }
}
