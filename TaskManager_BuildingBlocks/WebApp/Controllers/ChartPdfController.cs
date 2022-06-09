using BusinessLayer;
using DataLayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SelectPdf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class ChartPdfController : Controller
    {
        MetricContainer mc = new MetricContainer(new MetricDAL());
        ServerContainer sc = new ServerContainer(new ServerDAL());

        static int id;
        

        // GET: ChartPdfController
        public IActionResult Index()
        {
            PdfPrintViewModel pdfPrintViewModel = new PdfPrintViewModel();
            ListViewModel list = new ListViewModel();


            Server server = sc.GetOneSystemById(id);
            
            foreach (Metric metric in mc.GetAllMetricsFromServer(id))
            {
                pdfPrintViewModel = new PdfPrintViewModel(server.ServerName, metric.Name, metric.Value, metric.Date);
                if(metric.Date >= DateTime.Now.AddHours(-4))
                {
                    list.allmetrics.Add(pdfPrintViewModel);
                }
                if(list.allmetrics.Count > 120) { break; }
            }
            list.allmetrics = list.allmetrics.OrderBy(o => o.MetricName).ThenBy(o => o.Date).ToList();

            return View(list.allmetrics);
        }

        public IActionResult PdfPrint()
        {
            id = (int)HttpContext.Session.GetInt32("SystemId");

            var desktop = new HtmlToPdf();
            desktop.Options.WebPageWidth = 1920;

            var pdf = desktop.ConvertUrl("https://localhost:44368/chartpdf/index");

            var pdfBytes = pdf.Save();

            return File(pdfBytes, "Application/pdf");
        }
    }
}
