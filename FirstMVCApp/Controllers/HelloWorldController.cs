using FirstMVCApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstMVCApp.Controllers;

public class HelloWorldController : Controller
{
    private static List<DogViewModel> dogs = new();

    public IActionResult Index()
    {
        return View(dogs);
    }

    public IActionResult Hello()
    {
        CatViewModel gato = new()
        {
            Name = "Gato",
            Age = 100
        };
        return View(gato);
    }

    public IActionResult Create()
    {
        var dogViewModel = new DogViewModel();
        return View(dogViewModel);
    }

    public IActionResult CreateDog(DogViewModel dogViewModel)
    {
        // return View("Index");
        dogs.Add(dogViewModel);
        return RedirectToAction(nameof(Index));
    }

    public IActionResult HotelBooking()
    {
        HotelBookingModel hotelBookingModel = new()
        {
            Id = 1,
            GuestName = "Ronald McDonald",
            DateStart = DateTime.Today,
            DateEnd = DateTime.Today.AddDays(10)
        };
        return View(hotelBookingModel);
    }
}