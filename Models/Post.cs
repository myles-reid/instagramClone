namespace InstagramClone.Models {
	public class Post {
		public int PostId { get; set; }
		public List<string> Images { get; set; }
		public DateTime Timestamp { get; set; }
		public string Caption { get; set; }
		public int TotalLikes { get; set; }
		public List<int> InteractionIDs { get; set; }
		public int UserID { get; set; }
		public List<int> TaggedUsers { get; set; }
	}
}
