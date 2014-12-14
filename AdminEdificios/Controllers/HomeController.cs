using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CrystalDecisions.CrystalReports.Engine;
using System.IO; 


namespace AdminEdificios.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        admedifEntities db = new admedifEntities();
        public ActionResult Visitas()
        {
            return View(db.Visitas.ToList());
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Visitas visitas)
        {
            if (ModelState.IsValid)
            {
                db.Visitas.Add(visitas);
                db.SaveChanges();
                return RedirectToAction("Visitas");
            }
            return View(visitas);
        }

        public ActionResult Estacionamientos()
        {
            return View(db.Estacionamientos.ToList()); 
        }

        public ActionResult GastosComunes()
        {
            return View(db.GastosComunes.ToList());
        }

        [HttpGet]
        public ActionResult CreateGC()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateGC(GastosComunes gastoscomunes)
        {
            if (ModelState.IsValid)
            {
                db.GastosComunes.Add(gastoscomunes);
                db.SaveChanges();
                return RedirectToAction("GastosComunes");
            }
            return View(gastoscomunes);
        }

        public ActionResult GenerateReport()
        {
 
        ReportClass rptH = new ReportClass();
        rptH.FileName = (Server.MapPath("~/Reports/CrystalReport1.rpt")); 
        rptH.Load();
        //rptH.SetDataSource(db);
        Stream stream = rptH.ExportToStream(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat);

        return File(stream, "application/pdf");
        }

    }
}