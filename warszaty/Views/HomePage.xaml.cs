using System;
using System.Collections.Generic;
using Realms;

using Xamarin.Forms;

namespace warszaty
{
	public partial class HomePage : ContentPage
	{
		Realm realm;
		RealmConfiguration config= new RealmConfiguration();
		void AddTask_Clicked(object sender, System.EventArgs e)
		{
			realm = Realm.GetInstance(config);
			realm.Write(() =>
			{
				realm.Add(new Task { Description = TaskEntry.Text });
			});
			TaskEntry.Text = String.Empty;
		}

		void BackButton_Clicked(object sender, System.EventArgs e)
		{
			Navigation.PopModalAsync();
		}

		public HomePage()
		{
			InitializeComponent();
		}
	}
}
