using System.Security.Cryptography.X509Certificates;
using Microsoft.AspNetCore.Mvc;
public class YazarlarController:Controller
{
    public IActionResult YazarBilgi()
    {
        var yazar =new YazarlarModel
        {
            YazarAdi="Halit Talha",
            KitapIsmi="satranç"
        };
        ViewBag.Yazar=yazar;
        ViewBag.Sahip1="selin yayınevi";
        return View();
    }
}