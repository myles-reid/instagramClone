namespace InstagramClone.Models {
	public class DirectMessage {
		public int MessageID { get; set; }
		public int SenderID { get; set; }
		public int RevieverID { get; set; }
		public string MessageContent { get; set; }
		public DateTime Timestamp { get; set; }

	}
}
