
using System.Diagnostics.Eventing.Reader;
using System.Windows;

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            string userLogin = "you";
            string userPassword = "kipul";

            if (string.IsNullOrEmpty(TbLogin.Text) && string.IsNullOrEmpty(PbPSW.Password))
            {
                MessageBox.Show("No");

            }
            else
            {
                if (TbLogin.Text == userLogin && PbPSW.Password == userPassword)
                {
                    MessageBox.Show("Yee");
                }
                else
                {
                    MessageBox.Show("Noo");
                }








            }
        }
    }
}

