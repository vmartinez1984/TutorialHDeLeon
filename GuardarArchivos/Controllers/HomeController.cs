using GuardarArchivos.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace GuardarArchivos.Controllers
{
    public class HomeController : Controller
    {
        private readonly IWebHostEnvironment _webHostEnvironment;

        public HomeController(IWebHostEnvironment webHostEnvironment)
        {
            this._webHostEnvironment = webHostEnvironment;
        }

        public IActionResult Index()
        {
            ViewBag.mensaje = TempData["Mensaje"];
            return View();
        }

        public async Task<IActionResult> Upload1(ArchivoViewModel archivoViewModel)
        {
            using (var memoryStream = new MemoryStream())
            {
                await archivoViewModel.FormFile.CopyToAsync(memoryStream);
            }

            TempData["Mensaje"] = "Archivo arriba";
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Upload2(ArchivoViewModel archivoViewModel)
        {
            string fileName;

            fileName = Path.Combine(_webHostEnvironment.ContentRootPath, "Upload", archivoViewModel.FormFile.FileName);

            await archivoViewModel.FormFile.CopyToAsync(new FileStream(fileName, FileMode.Create));


            TempData["Mensaje"] = "Archivo arriba";
            return RedirectToAction("Index");
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
