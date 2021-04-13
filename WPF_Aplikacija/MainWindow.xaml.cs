using PodatkovniSloj;
using PodatkovniSloj.Models;
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

namespace WPF_Aplikacija
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            Repo.SaveInfoToFile(cbWorldCup.Text.ToString(), 1, FilePath.Path);
            Repo.SaveInfoToFile(cbLanguage.Text.ToString(), 2, FilePath.Path);
            Repo.SaveInfoToFile(cbResolution.Text.ToString(), 4, FilePath.Path);
            this.Hide();
            FootballForm football = new FootballForm();
            football.Show();
            this.Close();

        }

        

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
