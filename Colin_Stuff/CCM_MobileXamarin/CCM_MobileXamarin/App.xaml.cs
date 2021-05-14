using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CCM_MobileXamarin
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            var nav = new NavigationPage(new LoginPage());
            nav.BarBackgroundColor = Color.DarkSlateBlue;
            nav.BarTextColor = Color.White;
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
