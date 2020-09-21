using System;
using Bubble.PageModels;
using FreshMvvm;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Bubble
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            Navigation();
            Device.SetFlags(new string[] { "MediaElement_Experimental" });

        }

        public void Navigation()
        {
            var tabbedNavigation = new FreshTabbedNavigationContainer();
            tabbedNavigation.AddTab<HomePageModel>("Home", "Home1.png");
            tabbedNavigation.AddTab<TeamPageModel>("Team", "Team1.png");
            tabbedNavigation.AddTab<ContactPageModel>("Contacts", "Contact1.png");
            tabbedNavigation.AddTab<ResourcesPageModel>("Resources", "Other1.png");

            MainPage = tabbedNavigation;

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
