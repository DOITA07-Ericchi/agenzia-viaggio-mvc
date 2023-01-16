using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using bootstrap_travel_agency_MVC.Models;
using bootstrap_travel_agency_MVC.Databeezu;

namespace bootstrap_travel_agency_MVC.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        using (TravelContext db = new TravelContext())
        {

            List<Viaggio> ListaViaggi = db.Viaggi.ToList();

        return View(ListaViaggi);
        }
    }

    public IActionResult Dettagli(int ID)
    {
        using (TravelContext db = new TravelContext())
        {
            Viaggio? viaggio =
                (from vi in db.Viaggi
                 where vi.Id == ID
                 select vi).FirstOrDefault();
            if (viaggio != null)
            {
                return View(viaggio);
            }
            else
            {
                return NotFound("Il Viaggio ricercato non è presente");
            }

        }
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

