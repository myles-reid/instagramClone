using Microsoft.AspNetCore.Mvc;
using InstagramClone.Models;

namespace InstagramClone.Controllers {
	public class PostController : Controller {
		public IActionResult Index() {
			return View();
		}

		[HttpGet]
		public IActionResult NewPost() {
			return View();
		}

		[HttpPost]
		public IActionResult NewPost(Post post) {
			if (ModelState.IsValid) {
				// Save post to database
				return RedirectToAction("Home/Index");
			}
			return View(post);
		}
	}
}
