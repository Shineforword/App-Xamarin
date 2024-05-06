using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace AppX.Control
{	
	public partial class ControllImage : ContentPage
	{	
		public ControllImage ()
		{
			InitializeComponent ();

			localIcon.Source = ImageSource.FromResource("AppX.Control.localIcon.png");
        }
	}
}

