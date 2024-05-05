using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;
using Button = Xamarin.Forms.Button;

namespace AppX.Control
{	
	public partial class ControllButton : ContentPage
	{	
		public ControllButton ()
		{
			InitializeComponent ();
		}

        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
			//button1.Text = "点击改变";
			Button b = sender as Button;
			b.Text = "改变";
        }
    }
}

