using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace GorselProgramlamaProje.Areas.Admin
{
	public class AdminControllerBase : Controller
	{
		protected override void Initialize(RequestContext requestContext)
		{
			var IsLogin = false;
			if (requestContext.HttpContext.Session["AdminLoginUser"] == null)
			{
				//Admin Girişi Yok
				requestContext.HttpContext.Response.Redirect("Admin/AdminLogin");

			}
			else
			{
				//Admin Girişi Yapıldı
				base.Initialize(requestContext);
			}
			base.Initialize(requestContext);
		}
	}
}