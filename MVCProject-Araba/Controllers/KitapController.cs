using Microsoft.AspNetCore.Mvc;

public class KitapController:Controller
{
public IActionResult Kategoriler()
{
 var kitap = new KitapModel
 {
 kitapID = 1,
 KitapAdi = "WEB TABANLI UYGULAMA GELİŞTİRME"
 };
 ViewBag.Kitap = kitap;
 ViewBag.Sahip = "Millî Eğitim Bakanlığı";
 return View();
}
}