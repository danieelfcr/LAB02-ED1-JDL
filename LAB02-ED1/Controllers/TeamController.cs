
using LAB02_ED1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace LAB02_ED1.Controllers
{
    public class TeamController : Controller
    {
        // GET: TeamController

        public ActionResult Index()
        {



            /* var reader = new StreamReader(File.OpenRead(@"C:\Users\jmmr1\OneDrive\Escritorio\LOLTeams.CSV"));



             while (!reader.EndOfStream)
             {

                 var line = reader.ReadLine();
                 var values = line.Split(",");

                 TeamModel.Save(new TeamModel
                 {
                     TeamName = values[0],
                     Coach = values[1],
                     League = values[2],
                     DateCreation = Convert.ToDateTime(values[3]),

                 });
             }
            */

            //return View(DataTeam.Instance.Teamlist);
            return View();
        }

        // GET: TeamController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TeamController/Create
        public ActionResult Create()
        {
            return View(new TeamModel());
        }

        // POST: TeamController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                /*
                TeamModel.Save(new TeamModel
                {
                    TeamName = collection["TeamName"],
                    Coach = collection["Coach"],
                    League = collection["League"],
                    DateCreation = Convert.ToDateTime(collection["DateCreation"])
                });*/

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TeamController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TeamController/Edit/5
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

        // GET: TeamController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TeamController/Delete/5
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
