using System.Windows;
using System.Windows.Controls;

namespace MyMemesWeb
{
	public partial class MainPage : Page
	{
		public MainPage()
		{
			InitializeComponent();
		}

		/*
		 * GLOBAL DECLARATIONS
		*/
		string userNameEmail;
		string userPassword;

		private void LoginBn_Click(object sender, RoutedEventArgs e)
		{
			if (UsernameEmailTtBx.Text == userNameEmail && PasswordPdBx.Password == userPassword)
			{
				LoginScrollViewer.Visibility = Visibility.Collapsed;
			} 
			else
			{
				InvalidCredentialsTtBk.Visibility = Visibility.Visible;
			}
		}
	}
}
