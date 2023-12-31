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

		/*
		 * UNDERLYING PROGRAM METHODS
		*/

		public void LoginScreenPageSwitch(ScrollViewer visibleSlVr)
		{
			LoginSlVr.Visibility = Visibility.Collapsed;
			CreateAccountSlVr.Visibility = Visibility.Collapsed;

			visibleSlVr.Visibility = Visibility.Visible;
		}

		public void LeaveLoginScreen ()
		{
			LoginGd.Visibility = Visibility.Collapsed;
			LoginSlVr.Visibility = Visibility.Collapsed;

			LandingGd.Visibility = Visibility.Visible;
		}

		/*
		 * PROGRAM EVENT HANDLERS
		 * \\ (Parent container for where the event handlers 
		 * for the corresponding controls exist)
		*/

		// LoginSlVr
		private void LoginHkBn_Click(object sender, RoutedEventArgs e)
		{
			if (UsernameEmailTtBx.Text == userNameEmail && PasswordPdBx.Password == userPassword)
			{
				LoginSlVr.Visibility = Visibility.Collapsed;
			} 
			else
			{
				InvalidCredentialsTtBk.Visibility = Visibility.Visible;
			}
		}

		private void CreateAccountHkBn_Click(object sender, RoutedEventArgs e)
		{
			LoginScreenPageSwitch(CreateAccountSlVr);
		}

		private void NoLoggingInHkBn_Click(object sender, RoutedEventArgs e)
		{
			LeaveLoginScreen();
		}

		// CreateAccountSlVr
		private void BackToLoginHkBn_Click(object sender, RoutedEventArgs e)
		{
			LoginScreenPageSwitch(LoginSlVr);
		}
	}
}
