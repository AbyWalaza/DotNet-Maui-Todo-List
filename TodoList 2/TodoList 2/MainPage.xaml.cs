using TodoList_2.ViewModel;

namespace TodoList_2;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage(MainViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;	
	}

	
}

