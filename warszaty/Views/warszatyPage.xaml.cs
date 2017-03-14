using Xamarin.Forms;

namespace warszaty
{
	public partial class warszatyPage : ContentPage
	{
		void Login_Clicked(object sender, System.EventArgs e)
		{
			bool isLoginOk = false;
			bool isPasswordOk = false;
			if (LoginEntry.Text.Contains("@") && LoginEntry.Text.Contains(".") && LoginEntry.Text.Length > 6)
			{
				isLoginOk = true;
			}
			if (PasswordEntry.Text.Length > 10)
			{
				isPasswordOk = true;
			}
			if (isLoginOk && isPasswordOk)
			{
				Navigation.PushModalAsync(new TaskListPage());
			}
			else
			{
				DisplayAlert("Error", "Wrong login or password", "Ok");
			}
				
		}

		public warszatyPage()
		{
			InitializeComponent();
		}
	}
}
