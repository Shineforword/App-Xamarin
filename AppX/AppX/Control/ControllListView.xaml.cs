using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace AppX.Control
{	
	public partial class ControllListView : ContentPage
	{
		List<Student> list = new List<Student>();


		public ControllListView ()
		{
			InitializeComponent ();

			for(int i = 0; i<20; i++) {

				list.Add(new Student
				{
					ID = i,
					Name = "张" + i

				}) ;
			}
			listStudents.ItemsSource = list;

		}

        void listStudents_ItemTapped(System.Object sender, Xamarin.Forms.ItemTappedEventArgs e)
        {

        }
    }

	public class Student
	{
		public int ID { get; set; }
        public String Name { get; set; }

    }


}

