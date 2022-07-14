namespace PagesDemo;

public partial class FlyoutPageDemo : FlyoutPage
{
	public FlyoutPageDemo()
	{
		InitializeComponent();
        Menu.collectionView.SelectionChanged += OnSelectionChanged;

    }

	void OnSelectionChanged(Object Sender, SelectionChangedEventArgs e)
    {

        var item = e.CurrentSelection.FirstOrDefault() as FlyoutPageItem;
        if (item != null)
        {
            Detail = new NavigationPage((Page)Activator.CreateInstance(item.TargetType));
            IsPresented = false;
        }
    }
}