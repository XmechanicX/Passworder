using Passworder.DataBase;
using Passworder.Instruments;
using Passworder.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Passworder.ViewModel
{
    public class vmMainPage : ViewModelBase<mMainPage>
    {
        public vmMainPage() : base(new mMainPage())
        {
            AddCommand = new NonParamRelayCommand(Add, CanAdd);
            DeleteCommand = new NonParamRelayCommand(Delete, CanDelete);
            ApplyCommand = new NonParamRelayCommand(Apply);
        }

        public NonParamRelayCommand AddCommand { get; }
        public NonParamRelayCommand DeleteCommand { get; }
        public NonParamRelayCommand LoadCommand { get; }
        public NonParamRelayCommand ApplyCommand { get; }

        private DataFilling _selectedItem;
        public DataFilling SelectedItem
        {
            set
            {
                _selectedItem = value;
                Model.UpdateSelectedItemd(_selectedItem);
                CallPropertyChanged(nameof(SelectedItem));
            }
            get => _selectedItem;
        }
        public ObservableCollection<DataFilling> Items => Model.Items;

        private void Add()
        {
            Model.Add(new DataFilling());
        }

        private bool CanAdd() => true;

        private void Delete()
        {
            if (SelectedItem != null)
            {
                Model.Remove(SelectedItem);
            }
        }

        private bool CanDelete() => SelectedItem != null;

        private void Apply()
        {
            Model.UpdateDataInDb(SelectedItem);
        }
    }
}
