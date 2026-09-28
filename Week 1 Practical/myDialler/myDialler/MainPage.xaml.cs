namespace myDialler
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object? sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }

        //OnNavClicked

        private void OnNavClicked(object? sender, EventArgs e)
        {
            //Navigate to the NewPage1
            Shell.Current.GoToAsync("NewPage1");

        }
    }
}
