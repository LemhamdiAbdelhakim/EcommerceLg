using EcommerceLg.Data;
using EcommerceLg.Models;
using EcommerceLg.Models.ViewSubAndProduit;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceLg.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _applicationDbContext;

        public HomeController(ILogger<HomeController> logger , ApplicationDbContext applicationDbContext)
        {
            _logger = logger;
           _applicationDbContext = applicationDbContext;
        }

        public IActionResult Index()
        {
            var cat=_applicationDbContext.Categories.ToList();

            return View(cat);
        }

        public IActionResult Doctor()
        {
            return View();
        }

        public IActionResult RendezVous()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }
        

        // les produits
        // les subCategories

        public PartialViewResult ProductList(int id)
        {
            var productList = _applicationDbContext.Produits.OrderByDescending(x=>x.Id)
                .Where(x=>x.SubCategories.Id==id);
            return PartialView(productList);
        }
        public IActionResult Produits(int id)
        {
            //afficher les liste de catgories
            if (id==null) {
                return NotFound();
            }
            var ListSubcate = _applicationDbContext.SubCategories.Where(d => d.Category.Id == id).ToList();
            var lesProduits=_applicationDbContext.Produits.ToList();
            var ProCate = new SubCategorieProduit 
            {
                produits=lesProduits,
                subCategories=ListSubcate
            };
            return View(ProCate);
        }

        // les produits par subcategories


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
