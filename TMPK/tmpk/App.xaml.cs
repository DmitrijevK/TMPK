using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace tmpk
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new stranitsi.osnova();
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
