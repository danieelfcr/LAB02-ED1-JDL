using ClassLibrary01;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using LAB02_ED1.Models;
using System.Data;
using System.IO;
using Microsoft.AspNetCore.Hosting;


namespace LAB02_ED1.Controllers
{
    public class PlayerController : Controller
    {

        //public static GenericList<Player> playerList = new GenericList<Player>();

        // GET: PlayerController

        private IWebHostEnvironment Environment;
        public PlayerController(IWebHostEnvironment _environment)
        {
            Environment = _environment;
        }



        public ActionResult Index()
        {
           
            return View(GenericList<Player>.GetInstance);
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
                        Player player = new Player();
                        player.ID = GenericList<Player>.GetInstance.n;
                        player.Name = aux[0];
                        player.LastName = aux[1];
                        player.Role = aux[2];
                        player.KDA = double.Parse(aux[3]);
                        player.CreepScore = int.Parse(aux[4]);
                        player.Team = aux[5];
                        Node<Player> node = new Node<Player>(player);
                        node.NodeID = player.ID;
                        GenericList<Player>.GetInstance.Insert(node);
                    }
                }
                catch
                {

                }

            }
            return View(GenericList<Player>.GetInstance);
        }


        [HttpPost]
        public ActionResult Filter(string FilterSelection, string Search)
        {

            return RedirectToAction(nameof(Index));
        }



        // GET: PlayerController/Details/5
        public ActionResult Details(int id)
        {
            var x = GenericList<Player>.GetInstance.Find(id);
            return View(x.Data);
        }

        // GET: PlayerController/Create
        public ActionResult Create()
        {
            return View(new Player());
        }

        // POST: PlayerController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                Player player = new Player();
                player.ID = GenericList<Player>.GetInstance.n;
                player.Name = collection["Name"];
                player.LastName = collection["LastName"];
                player.Role = collection["Role"];
                player.KDA = double.Parse(collection["KDA"]);
                player.CreepScore = int.Parse(collection["CreepScore"]);
                player.Team = collection["Team"];          
                Node<Player> node = new Node<Player>(player);
                node.NodeID = player.ID;
                GenericList<Player>.GetInstance.Insert(node);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PlayerController/Edit/5
        public ActionResult Edit(int id)
        {
            var x = GenericList<Player>.GetInstance.Find(id); 
            return View(x.Data);
        }

        // POST: PlayerController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                var model = GenericList<Player>.GetInstance.Find(id);
                model.Data.Name = collection["Name"];
                model.Data.LastName = collection["LastName"];
                model.Data.Role = collection["Role"];
                model.Data.KDA = double.Parse(collection["KDA"]);
                model.Data.CreepScore = int.Parse(collection["CreepScore"]);
                model.Data.Team = collection["Team"];
                GenericList<Player>.GetInstance.Edit(id, model);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PlayerController/Delete/5
        public ActionResult Delete(int id)
        {
            var x = GenericList<Player>.GetInstance.Find(id);
            return View(x.Data);
        }

        // POST: PlayerController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                GenericList<Player>.GetInstance.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
