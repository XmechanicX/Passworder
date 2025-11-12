using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Passworder
{
    public abstract class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void CallPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    public abstract class ViewModelBase<T> : ViewModelBase
    {
        public ViewModelBase(T model)
        {
            this.Model = model;
        }

        public T Model { get; }
    }
}
