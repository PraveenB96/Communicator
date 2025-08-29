namespace Communicator_Frontend.Models
{
    public class MessageModel
    {
        public string Text { get; set; }
        public bool IsIncoming { get; set; }
        public string SenderName { get; set; }
        public string SenderProfileImage { get; set; }
        public DateTime Timestamp { get; set; }
    }
}