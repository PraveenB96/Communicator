using Communicator_Frontend.Models;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace Communicator_Frontend.ViewModels
{
    public class ConversationViewModel : BindableObject
    {
        public ObservableCollection<MessageModel> Messages { get; set; } = new();

        private string newMessage;
        public string NewMessage
        {
            get => newMessage;
            set
            {
                newMessage = value;
                OnPropertyChanged();
            }
        }

        public ICommand SendMessageCommand { get; }

        public ConversationViewModel()
        {
            // Sample data
            Messages.Add(new MessageModel
            {
                Text = "Hey, how are you?",
                IsIncoming = true,
                SenderName = "Alice",
                SenderProfileImage = "dotnet_bot.png",
                Timestamp = DateTime.Now.AddMinutes(-10)
            });

            Messages.Add(new MessageModel
            {
                Text = "I’m good, working on the chat app!",
                IsIncoming = false,
                SenderName = "You",
                SenderProfileImage = "dotnet_bot.png",
                Timestamp = DateTime.Now.AddMinutes(-8)
            });

            Messages.Add(new MessageModel
            {
                Text = "That’s awesome! 🚀",
                IsIncoming = true,
                SenderName = "Alice",
                SenderProfileImage = "dotnet_bot.png",
                Timestamp = DateTime.Now.AddMinutes(-5)
            });

            SendMessageCommand = new Command(SendMessage);
        }

        public void SendMessage()
        {
            if (!string.IsNullOrWhiteSpace(NewMessage))
            {
                Messages.Add(new MessageModel
                {
                    Text = NewMessage,
                    IsIncoming = false,
                    SenderName = "You",
                    SenderProfileImage = "dotnet_bot.png",
                    Timestamp = DateTime.Now
                });
                NewMessage = string.Empty;
            }
        }
    }
}