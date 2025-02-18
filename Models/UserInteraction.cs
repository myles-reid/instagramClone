namespace InstagramClone.Models {
	public class UserInteraction {
		public int InteractionID { get; set; }
		public int PostID { get; set; }
		public int UserID { get; set; }
		public bool IsLiked { get; set; }
		public bool IsSaved { get; set; }

	}
}
