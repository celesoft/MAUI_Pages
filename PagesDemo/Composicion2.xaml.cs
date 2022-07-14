namespace PagesDemo;

public partial class Composicion2 : ContentPage
{
	public Composicion2()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        Navigation.PopAsync();    }
}