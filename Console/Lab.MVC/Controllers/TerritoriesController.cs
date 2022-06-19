using Lab.MVC.Models;
using Library.Entidades;
using Library.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Lab.MVC.Controllers
{
    public class TerritoriesController : Controller
    {
        TerritoriesLogic logic = new TerritoriesLogic();
        
        public ActionResult Index()
        {
            //logic = new TerritoriesLogic();
            var territorios = logic.GetAll();

            List<TerritoriesView> territoriesViews = territorios.Select(t => new TerritoriesView
            {
                TerritoriesId = t.TerritoryID,
                TerritoriesName = t.TerritoryDescription,
                TerritoriesRegion = t.RegionID,

            }).ToList();
            return View(territoriesViews);
        }

        public ActionResult Insert()
        {
            return View();

        }

        [HttpPost]
        public ActionResult Insert(TerritoriesView territoriesView)
        {
            try
            {
                Territories territorio = new Territories { TerritoryID = territoriesView.TerritoriesId, TerritoryDescription = territoriesView.TerritoriesName, RegionID = territoriesView.TerritoriesRegion};

                logic.Add(territorio);

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index", "Error");
            }
        }

        public ActionResult Delete(string ID)
        {
            logic.Delete(ID);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Update(TerritoriesView territoriesView)
        {
            try
            {
                Territories territorio = new Territories { TerritoryID = territoriesView.TerritoriesId, TerritoryDescription = territoriesView.TerritoriesName, RegionID = territoriesView.TerritoriesRegion };

                logic.Update(territorio);

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index", "Error");
            }
        }

        public ActionResult Update(string ID)
        {
            List<Territories> territories = logic.GetAll();
            Territories updateTerritory = new Territories();
            foreach (Territories item in territories)
            {
                if (item.TerritoryID==ID)
                {
                    updateTerritory = item;
                }
            }
            TerritoriesView territoriesView = new TerritoriesView()
            {
                TerritoriesId = updateTerritory.TerritoryID,
                TerritoriesName = updateTerritory.TerritoryDescription,
                TerritoriesRegion =updateTerritory.RegionID,

            };
                
            return View(territoriesView);
        }
    }
}