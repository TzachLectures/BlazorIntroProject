namespace BlazorProject.Services
{
    public class ChatService
    {
        private static readonly List<string> Messages = new List<string>();
        public event Action OnMessageReceived;

        public void SendMessage(string message)
        {
            Messages.Add(message);
            OnMessageReceived?.Invoke();
        }

        public List<string> GetMessages () => Messages;
    }
}
