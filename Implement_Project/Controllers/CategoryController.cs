﻿using Implement_Project.Data;
using Implement_Project.Models;
using Microsoft.AspNetCore.Mvc;

namespace Implement_Project.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;
        public CategoryController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var catList = _db.Categories.ToList();
            return View(catList);
        }

        [HttpGet]
        public IActionResult Create()
        {
            Category cat = new Category();
            return View(cat);
        }
        [HttpPost]
        public IActionResult Create(Category obj)
        {

            //________ 1. Server Side Validation ____________
            if (ModelState.IsValid)
            {
                _db.Categories.Add(obj);
                _db.SaveChanges();
                
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null || id==0)
            {
                return NotFound();
            }
            //___ for only F.K Find ____
            Category? category1 = _db.Categories.Find(id);
            //___ withOUt F.k but  get Single Record ____
            Category? category2 = _db.Categories.FirstOrDefault(u=>u.CategoryId == id);
            Category? category3 = _db.Categories.Where(x=>x.CategoryId == id).FirstOrDefault();
            
            if (category1 == null)
            {
                return NotFound();
            }
            return View(category1);
        }
        [HttpPost]  
        public IActionResult Edit(Category obj)
        {
            //___ for only F.K Find ____
            if (obj.CategoryId > 0)
            {
                _db.Categories.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            Category? category1 = _db.Categories.Find(id);
            _db.Categories.Remove(category1);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        
    }
}