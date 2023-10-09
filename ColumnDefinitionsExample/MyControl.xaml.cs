namespace ColumnDefinitionsExample;

public partial class MyControl : ContentView
{
	public MyControl()
	{
		InitializeComponent();
	}

    protected override void OnSizeAllocated(double width, double height)
    {
        base.OnSizeAllocated(width, height);
        if (width < 0 || height < 0) return;

        SetDefinitions();
    }

    private void SetDefinitions()
    {
        mainGrid.ColumnDefinitions.Clear();

        mainGrid.ColumnDefinitions.Add(new ColumnDefinition(new GridLength(66, GridUnitType.Star)));
        mainGrid.ColumnDefinitions.Add(new ColumnDefinition(new GridLength(33, GridUnitType.Star)));

        mainGrid.SetColumn(box1, 0);
        mainGrid.SetColumn(box2, 1);
    }
}