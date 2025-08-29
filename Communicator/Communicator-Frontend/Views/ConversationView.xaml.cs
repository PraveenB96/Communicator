using Communicator_Frontend.ViewModels;

namespace Communicator_Frontend.Views;

public partial class ConversationView : ContentPage
{
    private readonly ConversationViewModel _conversationViewModel;
	public ConversationView()
	{
		InitializeComponent();

        _conversationViewModel = new ConversationViewModel();

        BindingContext = _conversationViewModel;
    }

    private void Entry_Completed(object sender, EventArgs e)
    {
        _conversationViewModel.SendMessage();
    }
}