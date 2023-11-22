using dotnet_test4.Data;
using dotnet_test4.Models;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_test4.Controllers;
public class KYCController : Controller
{
    private readonly ApplicationDbContext _db;

    public KYCController(ApplicationDbContext db)
    {
        _db = db;
    }

    public IActionResult Index()
    {
        IEnumerable<KYC> objKYCList = _db.UserAccount;
        return View(objKYCList);
    }

    //GET
    // public IActionResult Create()
    // {
    //     return View();
    // }

    // //POST
    // [HttpPost]
    // [ValidateAntiForgeryToken]
    // public IActionResult Create(KYC obj)
    // {  
    //     if (obj.KYCSystem == obj.KYCType.ToString())
    //     {
    //         ModelState.AddModelError("UAccID", "UAccUsername cannot exactly match the UAccID.");
    //     }
    //     if (ModelState.IsValid)
    //     {
    //         _db.KYCAccount.Add(obj);
    //         _db.SaveChanges();
    //         TempData["success"] = "Category created successfully";
    //         return RedirectToAction("Index");
    //     }
    //     return View(obj);   
    // }

    // //GET
    // public IActionResult Edit(int? id)
    // {
    //     if(id==null || id == 0)
    //     {
    //         return NotFound();
    //     }
    //     var KYCFromDb = _db.KYCAccount.Find(id);
       

    //     if (KYCFromDb == null)
    //     {
    //         return NotFound();
    //     }

    //     return View(KYCFromDb);
    // }

    // //POST
    // [HttpPost]
    // [ValidateAntiForgeryToken]
    // public IActionResult Edit(KYC obj)
    // {
    //     if (obj.KYCSystem == obj.KYCType.ToString())
    //     {
    //         ModelState.AddModelError("UAccID", "UAccUsername cannot exactly match the UAccID.");
    //     }
    //     if (ModelState.IsValid)
    //     {
    //         _db.KYCAccount.Update(obj);
    //         _db.SaveChanges();
    //         TempData["success"] = "Category updated successfully";
    //         return RedirectToAction("Index");
    //     }
    //     return View(obj);
    // }


    // //GET
    // public IActionResult Delete(int? id)
    // {
    //     if (id == null || id == 0)
    //     {
    //         return NotFound();
    //     }
    //     var KYCFromDb = _db.KYCAccount.Find(id);

    //     if (KYCFromDb == null)
    //     {
    //         return NotFound();
    //     }

    //     return View(KYCFromDb);
    // }

    // //POST
    // [HttpPost,ActionName("Delete")]
    // [ValidateAntiForgeryToken]
    // public IActionResult DeletePOST(int? id)
    // {
    //     var obj = _db.KYCAccount.Find(id);
    //     if (obj == null)
    //     {
    //         return NotFound();
    //     }

    //     _db.KYCAccount.Remove(obj);
    //         _db.SaveChanges();
    //     TempData["success"] = "Category deleted successfully";
    //     return RedirectToAction("Index");
        
    // }
}