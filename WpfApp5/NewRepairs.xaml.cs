using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp5
{
    /// <summary>
    /// Interaction logic for NewRepairs.xaml
    /// </summary>
    public partial class NewRepairs : Window
    {
        InProgress n = new InProgress();


        public NewRepairs()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.DataContext = n;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ProgramContext.context.InProgress.Add(n);
            ProgramContext.context.SaveChanges();
            MessageBox.Show("Skráð");
            this.Close();
        }

        private void Button_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}
