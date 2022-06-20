namespace SignalRChat.Models
{
    public class ChatModel
    {
        public string Username { get; set; }
        public string Message { get; set; }
        public string Extras { get; set; }

        public override string ToString()
        {
            return $"[\n\tUsername: {Username},\n\tMessage: {Message},\n\tExtras: {Extras}\n]";
        }
    }
}