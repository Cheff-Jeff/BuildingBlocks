﻿using BusinessLayer;
using DataLayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class ServerController : Controller
    {
        private ServerContainer sc = new ServerContainer(new ServerDAL());
        private MetricContainer mc = new MetricContainer(new MetricDAL());
        private RuleContainer rc = new RuleContainer(new RuleDal());
        // GET: SystemController
        public ActionResult Index()
        {
            if (HttpContext.Session.GetInt32("isAdmin") != null) 
            {
                List<Server> allServers = sc.GetAllSystems();
                List<Metric> metrics = new List<Metric>();
                List<ServerViewModel> servers = new List<ServerViewModel>();

                var exceedingMetrics = new Dictionary<Server, List<Metric>>();
                allServers.ForEach(s => {
                    metrics = sc.GetExceedingMetricsFromServer(s.ServerId);
                    if (metrics.Count > 0)
                    {
                        exceedingMetrics.Add(s, metrics);
                    }
                });


                foreach (Server server in allServers)
                {
                    ServerViewModel system = new ServerViewModel()
                    { 
                        ServerId = server.ServerId,
                        ServerName = server.ServerName,
                    };

                    servers.Add(system);
                }

                ViewData["ExceedingMetrics"] = exceedingMetrics;
                return View(servers);
            }
            return RedirectToAction("Index", "Home");
        }

        // GET: SystemController/Details/5
        public ActionResult Details(int id)
        {
            if (HttpContext.Session.GetInt32("isAdmin") != null)
            {
                ViewData["currentServer"] = sc.GetOneSystemById(id);
                ViewData["currentServerMetricsNames"] = mc.GetAllLatestMetricsFromServer(id);
                return View();
            }
            return RedirectToAction("Index", "Home");
        }

        public ActionResult Get(int id, string name, int amount)
        {
            ViewData["metricData"] = mc.GetAllMetricsFromServerWithName(id, name, amount);
            var rule = rc.GetRule(id, name);

            ViewData["metricTypeDataName"] = rule.RuleName; 
            ViewData["metricTypeDataMin"] = rule.Min;
            ViewData["metricTypeDataMax"] = rule.Max;
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
