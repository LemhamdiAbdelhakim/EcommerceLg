using System.Collections.Generic;

namespace EcommerceLg.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageCategory { get; set; }

        public IList<SubCategories> subCategories { get; set; }

        //public IList<Produit> produits { get; set; }
    }
}
