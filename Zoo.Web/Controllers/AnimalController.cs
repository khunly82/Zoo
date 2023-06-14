using Microsoft.AspNetCore.Mvc;
using Zoo.Web.Models;

namespace Zoo.Web.Controllers
{
    public class AnimalController : Controller
    {
        public IActionResult Index()
        {

            using ZooContext context = new ZooContext();

            List<Animal> animaux = context.Animals.ToList();

            List<AnimalListViewModel> model = animaux.Select(a =>
                new AnimalListViewModel(a)
            ).ToList();

            return View(model);
        }
    }
}
