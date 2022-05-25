using BusinessLayer;
using DataLayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Controllers
{
    public class ServerController : Controller
    {
        private ServerContainer sc = new ServerContainer(new ServerDAL());
        private MetricContainer mc = new MetricContainer(new MetricDAL());
        // GET: SystemController
        public ActionResult Index()
        {
            List<Server> allServers = sc.GetAllSystems();
            List<Metric> metrics = new List<Metric>();

            var exceedingMetrics = new Dictionary<Server, List<Metric>>();
            allServers.ForEach(s => { 
                metrics = sc.GetExceedingMetricsFromServer(s.ServerId);
                if (metrics.Count > 0)
                {
                    exceedingMetrics.Add(s, metrics);
                }
            });
            ViewData["ExceedingMetrics"] = exceedingMetrics;
            return View();
        }

        // GET: SystemController/Details/5
        public ActionResult Details(int id)
        {
            ViewData["currentServer"] = sc.GetOneSystemById(id);
            ViewData["currentServerMetricsNames"] = mc.GetAllLatestMetricsFromServer(id);
            return View();
        }

        public ActionResult Get(int serverId, string name, int amount)
        {
            ViewData["metricData"] = mc.GetAllMetricsFromServerWithName(serverId, name, amount);
            return View();
        }

        // GET: SystemController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SystemController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SystemController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SystemController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SystemController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SystemController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
