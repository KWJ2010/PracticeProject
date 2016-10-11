using System.ComponentModel;

namespace PasswordHasher
{
    public interface INotifyPropertyChanged
    {
        event PropertyChangedEventHandler PropertyChanged;
    }
}
