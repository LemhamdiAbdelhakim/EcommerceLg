namespace EcommerceLg.Models
{
    public class Commande
    {
        public int Id { get; set; }
        public string Quantity { get; set; }

        public Produit Produit { get; set; }
        public UserApplication UserApplication { get; set; }

    }
}
