using ClassLibrary01;
using LAB02_ED1.Helpers;
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
           
            return View(Data.Instance.Playerlist);
        }

        // GET: PlayerController/Details/5
        public ActionResult Details(int id)
        {
            var model = Data.Instance.Playerlist.Find(Player => Player.CreepScore == id);
            return View(model);
        }

        // GET: PlayerController/Create
        public ActionResult Create()
        {
            return View(new PlayerModel());
        }

        // POST: PlayerController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                PlayerModel.Save(new PlayerModel
                {
                    Name = collection["Name"],
                    LastName = collection["LastName"],
                    Role = collection["Role"],
                    KDA = double.Parse(collection["KDA"]),
                    CreepScore = int.Parse(collection["CreepScore"]),
                    Team = collection["Team"]    
                });

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
            return View();
        }

        // POST: PlayerController/Edit/5
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

        // GET: PlayerController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PlayerController/Delete/5
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
