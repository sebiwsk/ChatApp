using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ChatApp
{
    /// <summary>
    /// Interaktionslogik für RegisterWindow.xaml
    /// </summary>
    public partial class RegisterWindow : Window
    {
        public RegisterWindow()
        {
            InitializeComponent();
        }
        private void Border_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }
        private void MinimizeButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.WindowState = WindowState.Minimized;
        }
        private void WindowsStateButton_Click(object sender, RoutedEventArgs e)
        {
            if (Application.Current.MainWindow.WindowState != WindowState.Maximized)
            {
                Application.Current.MainWindow.WindowState = WindowState.Maximized;
            }
            else
            {
                Application.Current.MainWindow.WindowState = WindowState.Normal;
            }
        }
        private void closeButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
        private void OpenWindowTextBlock_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            double left = this.Left;
            double top = this.Top;

            LoginWindow loginWindow = new LoginWindow();

            loginWindow.Left = left;
            loginWindow.Top = top;

            loginWindow.Show();
            this.Close();
        }
        private void SignUpButton(object sender, RoutedEvent e)
        {
            string username = UsernameTextBox.Text;
            string password = PasswordBox.Password;
            string repeatpassword = RepeatPasswordBx.Password;

            //if (password == repeatpassword)
            //{
            //    double left = this.Left;
            //    double top = this.Top;

            //    MainWindow mainWindow = new MainWindow();

            //    mainWindow.Left = left;
            //    mainWindow.Top = top;

            //    mainWindow.Show();
            //    this.Close();
            //}
            //else
            //{
            //    MessageBox.Show("Das Passwort ist nicht identisch.");
            //}
        }
    }
}
