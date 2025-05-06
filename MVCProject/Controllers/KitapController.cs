using Microsoft.AspNetCore.Mvc;
public class KitapController: Controller
{
 public IActionResult Kategoriler()
 {
    var kitap = new KitapModel{
      KitapId = 1,
      KitapAdi="WTUG",
      SayfaSayisi = 321
    };
    ViewBag.Kitap=kitap; 
    //ViewBag.Kitap ile "kitap" modeli view'e aktarılıyor
    ViewBag.Sahip ="Milli Eğitim Bakanlığı";
    // ViewBag.Sahip ile bir string veri view'e aktarılıyor
    return View(); //View sayfası çağırılıyor
 }

 public IActionResult KitapListesi(int id)
 {
    return View();
 }
 
}
