using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WirelessMedia.Models;

namespace WirelessMedia.Controllers
{
    public class HomeController : Controller
    {
        private readonly WirelessMediaContext db;
        public HomeController(WirelessMediaContext _db)
        {
            db = _db;

        }

        public IActionResult Index(string kategorija = "")
        {
            ViewBag.Kategorija = kategorija;
            IEnumerable<Proizvod> listaProizvoda = db.Proizvodi;
            if (kategorija != "")
            {
                listaProizvoda = listaProizvoda
                .Where(p => p.Kategorija == kategorija);
            }
            return View(listaProizvoda.ToList());
        }


        private List<Proizvod> JsonProizvodi()
        {
            var listaProizvoda = new List<Proizvod>
            {

            new Proizvod
            {
                ProizvodId = 1,
                Naziv = "Trocal New 70mm 140x140",
                Opis = "Dvokrilni prozor Trocal 70mm dimenzija 140x140",
                Kategorija = "PVC prozori i vrata",
                Proizvodjac = "Trocal Germany",
                Dobavljac = "Rollplast SRB",
                Cena = 22275
            },
            new Proizvod
            {
                ProizvodId = 2,
                Naziv = "Trocal New 76mm 140x140",
                Opis = "Dvokrilni prozor Trocal 76mm dimenzija 140x140",
                Kategorija = "PVC prozori i vrata",
                Proizvodjac = "Trocal Germany",
                Dobavljac = "Rollplast SRB",
                Cena = 33348
            },
            new Proizvod
            {
                ProizvodId = 3,
                Naziv = "Trocal New 70mm ulazna vrata 100x200",
                Opis = "Jednokrilna ulazna vrata Trokal 70mm dimenzija 100x2000",
                Kategorija = "PVC prozori i vrata",
                Proizvodjac = "Trocal Germany",
                Dobavljac = "Rollplast SRB",
                Cena = 30234
            },
            new Proizvod
            {
                ProizvodId = 4,
                Naziv = "Alumil E-700 140x140",
                Opis = "Dvokrilni prozor ALUMIL termo aluminijum dimenzija 140x140",
                Kategorija = "ALU prozori i vrata",
                Proizvodjac = "Alumil Greece",
                Dobavljac = "Rollplast SRB",
                Cena = 22275
            },
            new Proizvod
            {
                ProizvodId = 5,
                Naziv = "Etem E-1000 140x140",
                Opis = "Dvokrilni prozor hladni aluminijum dimenzija 140x140",
                Kategorija = "ALU prozori i vrata",
                Proizvodjac = "Etem Greece",
                Dobavljac = "Rollplast SRB",
                Cena = 14795
            },
            new Proizvod
            {
                ProizvodId = 6,
                Naziv = "Etem E-45 140x140",
                Opis = "Dvokrilni prozor termo aluminijum dimenzija 140x14",
                Kategorija = "ALU prozori i vrata",
                Proizvodjac = "Etem Greece",
                Dobavljac = "Rollplast SRB",
                Cena = 26687
            },
            new Proizvod
            {
                ProizvodId = 7,
                Naziv = "PVC PRIMA roletna 140x140",
                Opis = "Spoljasnja PVC roletna dimenzija 140x140",
                Kategorija = "ALU i PVC roletne",
                Proizvodjac = "Trocal Germany",
                Dobavljac = "Rollplast SRB",
                Cena = 17545
            },
            new Proizvod
            {
                ProizvodId = 8,
                Naziv = "AL Mini roletne 140x140",
                Opis = "Spoljasnja ALU roletna dimenzija 140x140",
                Kategorija = "ALU i PVC roletne",
                Proizvodjac = "Trocal Germany",
                Dobavljac = "Rollplast SRB",
                Cena = 12045
            },
            new Proizvod
            {
                ProizvodId = 9,
                Naziv = "AL RELAX roletna 140x160",
                Opis = "Unutrasnja ALU roletna dimenzija 140x160",
                Kategorija = "ALU i PVC roletne",
                Proizvodjac = "Trocal Germany",
                Dobavljac = "Rollplast SRB",
                Cena = 19034
            }


            };

            return listaProizvoda;

        }

        public JsonResult VratiJsonProizvode()
        {
            var proizvodi = JsonProizvodi();

            return Json(proizvodi);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
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
}
