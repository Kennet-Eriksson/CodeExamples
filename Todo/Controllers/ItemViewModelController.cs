using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Todo.Models;
using Todo.ViewModels;

namespace Todo.Controllers
{
    public class ItemViewModelController : Controller
    {
        private ItemContext db = new ItemContext();

        // GET: ItemViewModel
        public ActionResult Index()
        {
            ItemViewModel itemViewModel = new ItemViewModel();
            itemViewModel.Items = db.Items.ToList();
            return View(itemViewModel);
        }

        // GET: ItemViewModel/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ItemViewModel/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ItemViewModel/Create
        [HttpPost]
        public ActionResult Create(ItemViewModel itemViewModel)
        {
            try
            {
                if (itemViewModel.SetItem.Description == null)
                {
                    return RedirectToAction("Index", "ItemViewModel");
                }
                else
                {
                    Item item = new Item();
                    item.Description = itemViewModel.SetItem.Description;
                    item.Status = false;

                    db.Items.Add(item);
                    db.SaveChanges();

                    return RedirectToAction("Index", "ItemViewModel");
                }
            }
            catch
            {
                return View();
            }
        }

        // GET: ItemViewModel/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ItemViewModel/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        [HttpPost]
        public ActionResult Update(string sid)
        {
            if (sid != null)
            {
                try
                {
                    {
                        Int32.TryParse(sid, out int cid);
                        Item item = db.Items.Find(cid);
                        bool st = item.Status;
                        item.Status = (st ? false : true);
                        db.SaveChanges();
                    }
                    return RedirectToAction("Index", "ItemViewModel");
                }
                catch
                {
                    return View();
                }
            }
            return RedirectToAction("Index", "ItemViewModel");
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            try
            {
                // TODO: Add delete logic here
                Item item = db.Items.Find(id);
                db.Items.Remove(item);
                db.SaveChanges();
                return RedirectToAction("Index", "ItemViewModel");
            }
            catch
            {
                return View();
            }
        }
    }
}
