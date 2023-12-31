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

		public void LeaveLoginScreen()
		{
			switch (WelcomeGreetGd.Visibility)
			{
				case Visibility.Visible:
				{
					WelcomeGreetGd.Visibility = Visibility.Collapsed;
					break;
				}
				case Visibility.Collapsed:
				{
					break;
				}
			}
			switch (LoginGd.Visibility)
			{
				case Visibility.Visible:
				{
					LoginGd.Visibility = Visibility.Collapsed;
					break;
				}
				case Visibility.Collapsed:
				{
					break;
				}
			}
			switch (LoginSlVr.Visibility)
			{
				case Visibility.Visible:
				{
					LoginSlVr.Visibility = Visibility.Collapsed;
					break;
				}
				case Visibility.Collapsed:
				{
					break;
				}
			}

			LandingGd.Visibility = Visibility.Visible;
		}
		/*
		 * PROGRAM EVENT HANDLERS
		 * \\ (Parent container for where the event handlers 
		 * for the corresponding controls exist)
		*/


		// WelcomeGreetGd

		private void WelcomeGreetLoginHkBn_Click(object sender, RoutedEventArgs e)
		{
			WelcomeGreetGd.Visibility = Visibility.Collapsed;
			LoginGd.Visibility = Visibility.Visible;
		}


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
