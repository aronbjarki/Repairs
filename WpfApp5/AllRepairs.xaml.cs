using System;
using System.Collections.Generic;
using System.Data.Entity;
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

namespace WpfApp5
{
    /// <summary>
    /// Interaction logic for AllRepairs.xaml
    /// </summary>
    public partial class AllRepairs : Window
    {
        public AllRepairs()
        {
            InitializeComponent();
        }

        private void lbInProgress2_Loaded(object sender, RoutedEventArgs e)
        {
            CollectionViewSource view = new CollectionViewSource();
            SharedContext.context.InProgress.Load();
            SharedContext.context.NotDelivered.Load();
            SharedContext.context.Delivered.Load();
            view.Source = SharedContext.context.InProgress.Local;
            
            this.DataContext = view;
            
        }
    }
}
