using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using WpfApp1.ViewModel;

namespace WpfApp1
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<ModelUtilisateurs> Users = new ObservableCollection<ModelUtilisateurs>();

        public MainWindow()
        {

            InitializeComponent();
        }

        private void ListeUtilisateur_Loaded(object sender, RoutedEventArgs e)
        {
            ClassementViewModel classementViewModel = new ClassementViewModel();

            ListeUtilisateur.DataContext = classementViewModel;

        }
    }
}
