﻿using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
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

namespace PartnersApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Entities entity = new Entities();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void EnterButton_Click(object sender, RoutedEventArgs e)
        {
            var Login = LoginBox.Text;
            var Pass = PassBox.Text;


            if (entity.User.First(x => x.Login == Login).Login == Login)
            {
                
                if (entity.User.First(x => x.Password == Pass).Password == Pass)
                {
                    Partners partnerWindow = new Partners();
                    partnerWindow.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Неправильный пароль");
                }
            }
            else
            {
                MessageBox.Show("Неправильный логин");
            }


        }
    }
}
