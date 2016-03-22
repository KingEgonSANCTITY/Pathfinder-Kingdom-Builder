using MongoDB.Bson;
using MongoDB.Driver;
using MongoKingmaker.Models;
using MongoKingmaker.Models.ContextModel;
using MongoKingmaker.Models.UpdateModels;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace MongoKingmaker.Controllers
{
    public class HomeController : Controller
    {
        private KingdomContext db = new KingdomContext();

        /*
        var sb = Builders<Kingdom>.Sort;
        var pb = Builders<Kingdom>.Projection;
        var ud = Builders<Kingdom>.Update;

        var filter = fb.Empty;
        var sort = sb.Ascending("_id");
        var projection = pb.Include("scores");
        */

        public async Task<ActionResult> Index()
        {
            var fb = Builders<Kingdom>.Filter;
            var kingdoms = await db.Kingdoms.Find<Kingdom>(fb.Empty).ToListAsync();
            return View(kingdoms);
        }

        [HttpGet]
        public async Task<ActionResult> Details(string id)
        {
            var fb = Builders<Kingdom>.Filter.Eq("_id", ObjectId.Parse(id));
            var kingdom = await db.Kingdoms.Find(fb).SingleOrDefaultAsync<Kingdom>();

            if (kingdom == null)
            {
                return RedirectToAction("Index");
            }

            return View(kingdom);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View(new Kingdom());
        }

        [HttpPost]
        public async Task<ActionResult> Create(Kingdom model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            await db.Kingdoms.InsertOneAsync(model);

            return RedirectToAction("Details", new { id = model._id });
        }

        [HttpGet]
        public async Task<ActionResult> Alignment(string id, int size)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }

            var model = new AlignmentUpdate() { id = id };

            if (size > 0)
            {
                var fb = Builders<Kingdom>.Filter.Eq("_id", ObjectId.Parse(id));
                var kingdom = await db.Kingdoms.Find(fb).SingleOrDefaultAsync<Kingdom>();

                model.left = kingdom.alignments[0];
                model.right = kingdom.alignments[1];
            }

            return View(model);
        }

        [HttpPost]
        public async Task<ActionResult> Alignment(Alignment left, Alignment right, string id)
        {
            var fb = Builders<Kingdom>.Filter.Eq("_id", ObjectId.Parse(id));
            var ub = Builders<Kingdom>.Update;

            var result = await db.Kingdoms.FindOneAndUpdateAsync(fb, ub.Set<Alignment>(x => x.alignments[0], left).Set(x => x.alignments[1], right));

            //var align = new List<Alignment>() { };
            //align.Add(left);
            //align.Add(right);
            //var result = await db.Kingdoms.FindOneAndUpdateAsync(x => x._id == ObjectId.Parse(id), ub.PushEach<Alignment>(x => x.alignments, align));

            return RedirectToAction("Details", new { id = id });
        }

        [HttpGet]
        public ActionResult Leader(string id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }

            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Leader(Leader leader,string id)
        {
            var fb = Builders<Kingdom>.Filter.Eq("_id", ObjectId.Parse(id));
            var ub = Builders<Kingdom>.Update;

            var result = await db.Kingdoms.FindOneAndUpdateAsync(fb, ub.Push<Leader>(x => x.leaders, leader));

            //var align = new List<Alignment>() { };
            //align.Add(left);
            //align.Add(right);
            //var result = await db.Kingdoms.FindOneAndUpdateAsync(x => x._id == ObjectId.Parse(id), ub.PushEach<Alignment>(x => x.alignments, align));

            return RedirectToAction("Details", new { id = id });
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}