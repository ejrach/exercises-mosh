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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Using downcasting, we can downcast (base to derived) the object 'sender', to a button.
            //We use casting like this when we know it's safe. 
            var button = (Button)sender;

            //now we can access properties of this button.
            button.Width = 400;
            button.Height = 400;

            //If we don't know it's safe, then use 'as'
            var button1 = sender as Button;
            if (button1 != null)
            {
                MessageBox.Show(button1.ActualHeight.ToString());
            }

            //MessageBox.Show("Hello world");
        }
    }
}
