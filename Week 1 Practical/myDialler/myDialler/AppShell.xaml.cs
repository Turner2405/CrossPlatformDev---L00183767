using myDialler.View;

namespace myDialler
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            // Register routes for navigation
            Routing.RegisterRoute("NewPage1", typeof(NewPage1));
            // NewPage1
        }
    }
}
