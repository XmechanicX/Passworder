using Microsoft.EntityFrameworkCore;
using Passworder.DataBase;
using Passworder.ViewModel;
using System.Collections;
using System.Collections.ObjectModel;

namespace Passworder.Model
{
    public class mMainPage : ViewModelBase
    {
        public mMainPage()
        {
            Load();
            Items.CollectionChanged += Items_CollectionChanged;
        }

        private void Items_CollectionChanged(object? sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            CallPropertyChanged(nameof(Items));
        }

        private DataFilling _selectedItem;
        public DataFilling SelectedItem
        {
            set
            {
                _selectedItem = value;
                CallPropertyChanged(nameof(SelectedItem));
            }
            get => _selectedItem;
        }

        public ObservableCollection<DataFilling> Items;

        DbCommand command = new DbCommand();

        public void UpdateSelectedItemd(DataFilling selectedItem)
        {
            SelectedItem = selectedItem;
        }

        public void Add(DataFilling item)
        {
            Items.Add(item);
            AddDataInDb(item);
        }

        public void Remove(DataFilling item)
        {
            Items.Remove(item);
            RemoveDataInDb(item);
            SelectedItem = Items.FirstOrDefault();
        }

        private void Load()
        {
            Items = new ObservableCollection<DataFilling>(command.GetData());
            SelectedItem = Items.FirstOrDefault();
            CallPropertyChanged(nameof(Items));
        }

        public bool AddDataInDb(DataFilling dataFilling)
        {
            command.AddDataInDb(dataFilling);
            return true;
        }

        public bool RemoveDataInDb(DataFilling dataFilling)
        {
            command.RemoveDataInDb(dataFilling);
            return true;
        }

        public bool UpdateDataInDb(DataFilling dataFilling)
        {
            command.UpdateDataInDb(dataFilling);
            return true;
        }
    }
}
