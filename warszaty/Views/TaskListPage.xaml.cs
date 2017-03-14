using System;
using System.Collections.Generic;
using Realms;
using System.Linq;

using Xamarin.Forms;

namespace warszaty
{
	public partial class TaskListPage : ContentPage
	{
		Realm realm;
		RealmConfiguration config = new RealmConfiguration();
		public List<string> GetTasks() 
		{
			List<string> tasksList = new List<string>();

			realm = Realm.GetInstance(config);

			foreach (var task in realm.All<Task>())
			{
				tasksList.Add(task.Description);
			}

			return tasksList;
		}
		void GoToAddTaskPage_Clicked(object sender, System.EventArgs e)
		{
			Navigation.PushModalAsync(new HomePage());
		}

		public TaskListPage()
		{
			InitializeComponent();
			TaskList.ItemsSource = GetTasks();
		}
	}
}
