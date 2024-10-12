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

namespace PartnersApp
{
    /// <summary>
    /// Логика взаимодействия для Partners.xaml
    /// </summary>
    public partial class Partners : Window
    {
        Entities entity = new Entities();
        public Partners()
        {
            InitializeComponent();

            PartnersView.ItemsSource = entity.Partner.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AddPartner addPartner = new AddPartner();
            addPartner.Show();
            this.Close();
        }
    }
}
