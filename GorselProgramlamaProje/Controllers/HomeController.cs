using GorselProgramlamaProjeModel.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GorselProgramlamaProje.Controllers
{
    public class HomeController : Controller
    {
		ProjeDB db = new ProjeDB();
		// GET: Home
		public ActionResult Index()
        {
			var data = db.Products.OrderByDescending(x => x.CreationDate).Take(5).ToList();

			return View(data);
        }

		public PartialViewResult GetMenu()
		{
			
			var menus = db.Categories.Where(x => x.ParentID == 0).ToList();
			return PartialView(menus);
		}

		[Route("Uye-Giris")]
		public ActionResult Login()
		{
			return View();
		}

		[HttpPost]
		[Route("Uye-Giris")]

		public ActionResult Login(string Email, string Password)
		{
			
			var users = db.Users.Where(x => x.Email == Email
			&& x.Password == Password
			&& x.IsActive == true
			&& x.IsAdmin==false).ToList();
			if (users.Count == 1)
			{
				//Giriş Yapıldı
				Session["LoginUser"] = users.FirstOrDefault();
				return Redirect("/");
			}
			else
			{
				ViewBag.Error = "Hatalı Kullanıcı Adı veya Şifre";
				return View();
			}
			
		}

		
		[Route("Uye-Kayit")]
		public ActionResult CreateUser()
		{
			
			return View();

		}
		
		[HttpPost]
		[Route("Uye-Kayit")]
		public ActionResult CreateUser(User entity)
		{
			try { 
			entity.CreationDate = DateTime.Now;
			entity.CreatorUserId = 1;
			entity.IsActive = true;
			entity.IsAdmin = false;

			db.Users.Add(entity);
			db.SaveChanges();
			return Redirect("/");
			}

			catch (Exception ex)
			{
				return View();
			}

			
		
		}
	}
}