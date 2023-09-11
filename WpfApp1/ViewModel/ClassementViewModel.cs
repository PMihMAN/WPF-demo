using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfApp1.ViewModel
{
    public class ClassementViewModel : ViewModelBase
    {
        public ObservableCollection<ModelUtilisateurs> Users { get; set; }

        private ModelUtilisateurs _SelectedUtilisateurs;
        public ModelUtilisateurs SelectedUtilisateurs
        {
            get { return _SelectedUtilisateurs; }
            set
            {
                Set(ref _SelectedUtilisateurs, value);
            }
        }

        public ICommand DeleteCommand { get; }
        public ICommand ClearCommand { get; }
        public ICommand SaveCommand { get; }


        public ClassementViewModel()
        {
            Users = new ObservableCollection<ModelUtilisateurs>();
            Users.Add(new ModelUtilisateurs("Vivien", "KORPYS"));
            Users.Add(new ModelUtilisateurs("Auguston", "COUVAL"));
            Users.Add(new ModelUtilisateurs("Mickael", "DA PONTE"));

            DeleteCommand = new RelayCommand(Delete);
            ClearCommand = new RelayCommand(Clear);
            SaveCommand = new RelayCommand(Save);
            SelectedUtilisateurs = new ModelUtilisateurs();

        }


        public void Delete()
        {
            Users.Remove(SelectedUtilisateurs);
            SelectedUtilisateurs = new ModelUtilisateurs();


        }
        public void Clear()
        {
            SelectedUtilisateurs = new ModelUtilisateurs();


        }
        public void Save()
        {
            Users.Add(new ModelUtilisateurs(_SelectedUtilisateurs.prenom, _SelectedUtilisateurs.nom));
        }

    }
}
