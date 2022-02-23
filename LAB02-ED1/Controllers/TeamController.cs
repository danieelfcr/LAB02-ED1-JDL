
using ClassLibrary01;
using LAB02_ED1.Models;
using Microsoft.AspNetCore.Hosting;
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


        private IWebHostEnvironment Environment;
        public TeamController(IWebHostEnvironment _environment)
        {
            Environment = _environment;
        }

        public ActionResult Index()
        {
            return View(GenericList<Team>.GetInstance);
        }


        [HttpPost]
        public ActionResult Index(IFormFile File)
        {
            if (File != null)
            {
                string path = Path.Combine(this.Environment.WebRootPath, "Uploads");

                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }

                string FileName = Path.GetFileName(File.FileName);
                string filePath = Path.Combine(path, FileName);
                FileStream stream = new FileStream(filePath, FileMode.Open, FileAccess.Read);



                string DataList = System.IO.File.ReadAllText(filePath);

                DataList.Trim();
                StreamReader read = new StreamReader(filePath);

                try
                {
                    string line = "";
                    while ((line = read.ReadLine()) != null)
                    {
                        string[] aux = line.Split(",");
                        Team team = new Team();
                        team.TeamID = GenericList<Team>.GetInstance.n;
                        team.TeamName = aux[0];
                        team.Coach = aux[1];
                        team.League = aux[2];
                        team.CreationDate = Convert.ToDateTime(aux[3]);
                        Node<Team> node = new Node<Team>(team);
                        node.NodeID = team.TeamID;
                        GenericList<Team>.GetInstance.Insert(node);
                    }
                }
                catch
                {

                }

            }
            return View(GenericList<Team>.GetInstance);
        }




        // GET: TeamController/Details/5
        public ActionResult Details(int id)
        {
            var x = GenericList<Team>.GetInstance.Find(id);
            return View(x.Data);
        }

        // GET: TeamController/Create
        public ActionResult Create()
        {
            return View(new Team());
        }

        // POST: TeamController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                Team team = new Team();
                team.TeamID = GenericList<Team>.GetInstance.n;
                team.TeamName = collection["TeamName"];
                team.Coach = collection["Coach"];
                team.League = collection["League"];
                team.CreationDate = Convert.ToDateTime(collection["CreationDate"]);
                Node <Team>  node = new Node<Team>(team);
                node.NodeID = team.TeamID;
                GenericList<Team>.GetInstance.Insert(node);

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
            var x = GenericList<Team>.GetInstance.Find(id);
            return View(x.Data);
        }

        // POST: TeamController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                var model = GenericList<Team>.GetInstance.Find(id);
                model.Data.TeamName = collection["TeamName"];
                model.Data.League = collection["League"];
                model.Data.Coach = collection["Coach"];
                model.Data.CreationDate = Convert.ToDateTime(collection["CreationDate"]);
                GenericList<Team>.GetInstance.Edit(id, model);

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
            var x = GenericList<Team>.GetInstance.Find(id);
            return View(x.Data);
        }

        // POST: TeamController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                GenericList<Team>.GetInstance.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
