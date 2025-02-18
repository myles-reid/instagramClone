namespace InstagramClone.Models {
	public class Story {
		public int StoryID { get; set; }
		public int UserID { get; set; }
		public string Caption { get; set; }
		public string Image { get; set; }
		public DateTime Timestamp { get; set; }
	}
}
