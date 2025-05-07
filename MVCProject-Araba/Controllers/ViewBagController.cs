using Microsoft.AspNetCore.Mvc;


public class ViewBagController: Controller
{
    public IActionResult Index()
    {
        ViewBag.Message="Merhaba dünyaaa";
        ViewBag.Tarih=DateTime.Now;
        ViewData["Mesaj"] = "Merhaba, ViewData ile veri taşıyorsun!";


        return View();
    }
}