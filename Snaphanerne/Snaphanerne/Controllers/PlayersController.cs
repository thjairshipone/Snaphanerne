namespace Snaphanerne.Controllers
{
    using System.Data.Entity;
    using System.Linq;
    using System.Net;
    using System.Web.Mvc;
    using Models.Entity;
    using Models.View;
    using Models.StaticData;

    public class PlayersController : Controller
    {
        private SnaphanerneContext db;
        private PlayerViewModel viewModelPlayer;

        public PlayersController()
        {
            this.db = new SnaphanerneContext();
            this.viewModelPlayer = new PlayerViewModel();
            PopulateView();
        }
        
        private void PopulateView()
        {
            this.viewModelPlayer.Player = new Player();
            this.viewModelPlayer.Matches = this.db.Matches.ToList();
            this.viewModelPlayer.THLevels = Level.levels;
        }

        // GET: Players
        public ActionResult Index()
        {
            return View(db.Players.ToList());
        }

        // GET: Players/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Player player = db.Players.Find(id);
            if (player == null)
            {
                return HttpNotFound();
            }
            return View(player);
        }

        // GET: Players/Create
        public ActionResult Create()
        {
            ViewBag.THLevels = new SelectList(this.viewModelPlayer.THLevels, "THLevel", "THLevel");
            //ViewBag.SelectListMatches = new SelectList(this.viewModelPlayer.Matches);
            return View();
        }

        // POST: Players/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        // [Bind(Include = "ID,Name,THLevel")]
        public ActionResult Create([Bind(Include = "Name, THLevel")] Player player)
        {
            System.Diagnostics.Debug.WriteLine(player.THLevel);
            System.Diagnostics.Debug.WriteLine(player.Name);
            if (ModelState.IsValid)
            {
                db.Players.Add(player);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(player);
        }

        // GET: Players/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Player player = db.Players.Find(id);
            if (player == null)
            {
                return HttpNotFound();
            }
            return View(player);
        }

        // POST: Players/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name,THLevel")] Player player)
        {
            if (ModelState.IsValid)
            {
                db.Entry(player).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(player);
        }

        // GET: Players/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Player player = db.Players.Find(id);
            if (player == null)
            {
                return HttpNotFound();
            }
            return View(player);
        }

        // POST: Players/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Player player = db.Players.Find(id);
            db.Players.Remove(player);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
