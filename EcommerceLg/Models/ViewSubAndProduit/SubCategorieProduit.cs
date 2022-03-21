using System.Collections.Generic;

namespace EcommerceLg.Models.ViewSubAndProduit
{
    public class SubCategorieProduit
    {
        public List<Produit> produits { get; set; }
        public List<SubCategories> subCategories { get; set; }
    }
}
