using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace DozeMinClone.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void SetProperty<T>(ref T privateProperty, T value, [CallerMemberName] string publicProperty = null)
        {
            if (EqualityComparer<T>.Default.Equals(privateProperty, value))
                return;

            privateProperty = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(publicProperty));
        }
    }
}
