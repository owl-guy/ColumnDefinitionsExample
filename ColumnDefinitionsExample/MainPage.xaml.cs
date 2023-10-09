namespace ColumnDefinitionsExample
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
            Loaded += MainPage_Loaded;
        }

        private void MainPage_Loaded(object sender, EventArgs e)
        {
            UpdateItemsSource();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            UpdateItemsSource();
        }

        protected override void OnAppearing()
        {
            //UpdateItemsSource();
        }

        private void UpdateItemsSource()
        {
            var source = new List<int>();
            for (int i = 0; i < 100; i++)
            {
                source.Add(i);
            }
            colView.ItemsSource = source;
        }
    }
}