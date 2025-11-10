using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Passworder.DataBase;
using Passworder.Instruments;
using Passworder.Model;

namespace Passworder.ViewModel
{
    public class vmMainPage : ViewModelBase
    {
        public vmMainPage()
        {
            Items.Add(new DataFilling() { Website = "https://example.com", Title = "Example", Login = "user1", Password = "password1", Notes = "Info" });
            Items.Add(new DataFilling() { Website = "https://example.com", Title = "Example2", Login = "user2", Password = "password2", Notes = "Info1" });
            Items.Add(new DataFilling() { Website = "https://example.com", Title = "Example3", Login = "user3", Password = "password3", Notes = "Info2" });

            AddCommand = new NonParamRelayCommand(Add, CanAdd);
            DeleteCommand = new NonParamRelayCommand(Delete, CanDelete);
            LoadCommand = new NonParamRelayCommand(Load);
        }

        public NonParamRelayCommand AddCommand { get; }
        public NonParamRelayCommand DeleteCommand { get; }
        public NonParamRelayCommand LoadCommand { get; }

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
        public ObservableCollection<DataFilling> Items { get; set; } = new ObservableCollection<DataFilling>();

        private void Add()
        {
            var item = new DataFilling { Website = "", Title = "New", Login = "", Password = "" };
            Items.Add(item);
            SelectedItem = item;
        }

        private bool CanAdd() => true;

        private void Delete()
        {
            if (SelectedItem != null)
            {
                var toRemove = SelectedItem;
                SelectedItem = null;
                Items.Remove(toRemove);
            }
            SelectedItem = Items.LastOrDefault();
        }

        private bool CanDelete() => SelectedItem != null;

        private void Load()
        {
            // Пример: загрузка из репозитория/файла/сервиса
            // Для демонстрации ничего не делаем
        }
    }
}
