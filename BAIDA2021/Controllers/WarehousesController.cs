using BAIDA2021.ClassProject;
using BAIDA2021.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BAIDA2021.Controllers
{
    public class WarehousesController : Controller
    {

        baida2021 db;

        public WarehousesController()
        {
            db = new baida2021();
        }

        // GET: Warehouses
        public ActionResult cartonType()
        {
            return View(db.Carton_types.ToList());
        }



        public ActionResult AddtypeCorton()
        {


            return View();
        }


        [HttpPost]
        public ActionResult AddtypeCorton(Carton_type tc)
        {
            var data = db.Carton_types.Where(x => x.Type.ToLower() == tc.Type.ToLower()).FirstOrDefault();

            if(data==null)
            {

                db.Carton_types.Add(tc);
                db.SaveChanges();
                return RedirectToAction("AddtypeCorton");
            }


            else
            {

                ViewData["Error"] = "موجود مسبقا لا يمكن اضافته";
                return View("AddtypeCorton");

            }
           
        }



        public ActionResult EdittypeCorton(int id)
        {
            
            return View(db.Carton_types.Where(x=>x.id==id).FirstOrDefault());
        }

        [HttpPost]
        public ActionResult EdittypeCorton(Carton_type tc)
        {

            var Getdata = db.Carton_types.SingleOrDefault(x => x.id == tc.id);

            var data = db.Carton_types.Where(x => x.Type.ToLower() == tc.Type.ToLower()).FirstOrDefault();

            if(data ==null)
            {

                Getdata.Type = tc.Type;
                db.SaveChanges();

                return RedirectToAction("cartonType");
            }
            else
            {

                ViewData["Error"] = "موجود مسبقا لا يمكن تعديله ";
                return View("EdittypeCorton");
            }

        
        }


        public int DeletetypeCorton(int id)
        {

            var data = db.Carton_types.Where(x => x.id == id).FirstOrDefault();
            db.Carton_types.Remove(data);
            db.SaveChanges();
           return 0;//0 deleted |1 somrthing go wrong
        }


        public ActionResult getspecifications(int id)
        {
            ViewData["id"] = id;
            var item = db.Carton_types.Where(x => x.id == id).FirstOrDefault();
            ViewData["nametype"] = item.Type;
            return View(db.Specifications.Where(x => x.idtypcoton == id).ToList());
        }



        public ActionResult Addspecifications(int id)
        {
            ViewData["id"] = id;
            var item = db.Carton_types.Where(x => x.id == id).FirstOrDefault();
            ViewData["nametype"] = item.Type;


            return View();
        }







    }
}