namespace InstagramClone.Models {
	public class User {
		public int UserId { get; set; }
		public string Username { get; set; }
		private string Password { get; set; }
		public string Email { get; set; }
		public int NumFollowers { get; set; }
		public int NumFollowing { get; set; }
		public string Biography { get; set; }
		public string ProfilePicture { get; set; }
	}
}
