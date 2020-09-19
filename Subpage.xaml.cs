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

namespace Okna
{
    /// <summary>
    /// Логика взаимодействия для Subpage.xaml
    /// </summary>
    public partial class Subpage : Page
    {
        public Subpage()
        {
            InitializeComponent();
        }

        private void BtnGo_Click(object sender, RoutedEventArgs e)
        {
            LoadFrame1.MainFrameLoad.Navigate(new SubPage2());
        }
    }
}
