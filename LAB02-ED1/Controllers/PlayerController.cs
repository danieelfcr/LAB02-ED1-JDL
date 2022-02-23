using ClassLibrary01;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using LAB02_ED1.Models;


namespace LAB02_ED1.Controllers
{
    public class PlayerController : Controller
    {

        //public static GenericList<Player> playerList = new GenericList<Player>();

        // GET: PlayerController
        public ActionResult Index()
        {
           
            return View(GenericList<Player>.GetInstance);
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
