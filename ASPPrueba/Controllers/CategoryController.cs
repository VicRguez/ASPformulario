using ASPPrueba.Data;
using ASPPrueba.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASPPrueba.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDBContext _db;

        public CategoryController(ApplicationDBContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Category> objCategoryList = _db.categories;
            return View(objCategoryList);
        }

        //create a row on a table
        public IActionResult Create()
        {
            return View();
        }
        //Pst 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Category obj)
        {
            if (ModelState.IsValid)
            {
                _db.categories.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var categoryFromDb = _db.categories.Find(id);
            //var categoryFromDbFirst = _db.categories.FirstOrDefault(c => c.Id == id);
            //var categoryFromDbSingle = _db.categories.SingleOrDefault(c => c.Id == id);
            if (categoryFromDb == null) {
                return NotFound();
            }
            return View(categoryFromDb);
        }
        //Pst 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Category obj)
        {
            if (ModelState.IsValid)
            {
                _db.categories.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var categoryFromDb = _db.categories.Find(id);
            //var categoryFromDbFirst = _db.categories.FirstOrDefault(c => c.Id == id);
            //var categoryFromDbSingle = _db.categories.SingleOrDefault(c => c.Id == id);
            if (categoryFromDb == null)
            {
                return NotFound();
            }
            return View(categoryFromDb);
        }
        //Pst 
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePOST(int? id)
        {
            var obj = _db.categories.Find(id);

            if (obj == null)
            {
                return NotFound();
            }
            _db.categories.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        
    
        }
    }
}
