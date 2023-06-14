using Microsoft.AspNetCore.Mvc;
using Zoo.Web.Models;

namespace Zoo.Web.Controllers
{
    public class AnimalController : Controller
    {
        private readonly ZooContext context;

        public AnimalController(ZooContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            List<Animal> animaux = context.Animals.ToList();

            List<AnimalListViewModel> model = animaux.Select(a =>
                new AnimalListViewModel(a)
            ).ToList();

            return View(model);
        }

        public IActionResult CreateLion()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateLion(LionCreateViewModel model)
        {
            if(!ModelState.IsValid)
            {
                return View(model);
            }
            context.Add(new Lion
            {
                Nom = model.Nom,
                Sexe = model.Sexe,
                Couleur = model.Couleur
            });

            context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
