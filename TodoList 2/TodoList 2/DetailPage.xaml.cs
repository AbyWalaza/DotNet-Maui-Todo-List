using TodoList_2.ViewModel;

namespace TodoList_2;

public partial class DetailPage : ContentPage
{
	public DetailPage(DetailViewModel dvm)
	{
		InitializeComponent();
		BindingContext = dvm;
	}
}