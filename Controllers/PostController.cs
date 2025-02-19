using Microsoft.AspNetCore.Mvc;
using InstagramClone.Models;

namespace InstagramClone.Controllers {
	public class PostController : Controller {
		new List<Post> posts = new List<Post>();
		private static int _nextID = 1;
		public IActionResult Index() {
			return View();
		}

		[HttpGet]
		public IActionResult NewPost() {
			return View();
		}

		[HttpPost]
		public IActionResult NewPost(PostViewModel newPost, int userID) {
			if (ModelState.IsValid) {
				newPost.PostId = _nextID++;
				newPost.Images = AddImages(newPost);
				newPost.TaggedUsers = AddTags(newPost);
				return RedirectToAction("Home/Index");
			}
			return View(newPost);
		}

		private List<string> AddImages(PostViewModel post) {
			List<string> images = new List<string>();
			if (post.ImageInput == null) {
				post.ImageInput = "";
			} else {
				string[] split = post.ImageInput.Split(", ");
				foreach (string s in split) {
					images.Add(s);
				}
			}
			return images;
		}

		private List<string> AddTags(PostViewModel post) {
			List<string> tags = new List<string>();
			if (post.TaggedUsersInput == null) {
				post.TaggedUsersInput = "";
			} else {
				string[] split = post.ImageInput.Split(", ");
				foreach (string s in split) {
					tags.Add(s);
				}
			}
			return tags;
		}
	}
}
