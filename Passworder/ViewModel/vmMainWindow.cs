using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using Passworder.View;

namespace Passworder.ViewModel
{
    public class vmMainWindow : ViewModelBase
    {
        public vmMainWindow()
        {
            CurrentPage = new MainPage();
        }

        private Page _currentPage;
        public Page CurrentPage
        {
            set
            {
                _currentPage = value;
                CallPropertyChanged(nameof(CurrentPage));
            }
            get => _currentPage;
        }
    }
}
