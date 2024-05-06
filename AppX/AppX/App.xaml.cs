using System;
using AppX.Control;
using AppX.Layout;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppX
{
    public partial class App : Application
    {
        public App ()
        {
            InitializeComponent();

            //MainPage = new MainPage();
            //MainPage = new ControllLabel();
            //MainPage = new ControllButton();
            //MainPage = new ControllEntry();
            //MainPage = new ControllConverter();
            //MainPage = new ControllImage();
            //MainPage = new ControllListView();
            //MainPage = new StacKLayout();

            //MainPage = new LayoutGrid();
            MainPage = new LayoutAbosluteLayout();
        }

        protected override void OnStart ()
        {

        }

        protected override void OnSleep ()
        {
        }

        protected override void OnResume ()
        {
        }
    }
}

