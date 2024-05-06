using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace AppX.Control
{	
	public partial class ControllEntry : ContentPage
	{	
		public ControllEntry ()
		{
			InitializeComponent ();
		}

        void Entry_TextChanged(System.Object sender, Xamarin.Forms.TextChangedEventArgs e)
        {
			Console.WriteLine(entry_01.Text);
        }
    }
}

