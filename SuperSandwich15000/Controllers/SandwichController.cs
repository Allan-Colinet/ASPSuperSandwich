using Microsoft.AspNetCore.Mvc;
using SuperSandwich15000.Models;
using SuperSandwich15000.Services;

namespace SuperSandwich15000.Controllers
{
    public class SandwichController : Controller
    {
        private SandwichService _sandwichService;
        private CommandeService _commandeService;
        
        public SandwichController()
        {
            _sandwichService = new SandwichService();
            _commandeService = new CommandeService();
        }
        public IActionResult Index()
        {
            return View(_sandwichService.GetAll());
        } 
        public IActionResult CreerCommande(int id)
        {
            Commande sandwichCommande = new Commande();
            sandwichCommande.SandwichId = id; 
            sandwichCommande.sandwich = _sandwichService.GetById(id) ;
            return View(sandwichCommande);
        }
        [HttpPost]
        public IActionResult CreerCommande(Commande commande) 
        {
            _commandeService.Create(commande);

            return RedirectToAction("Index");
        }
    }
}
