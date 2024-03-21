using System.ComponentModel;
using System.Runtime.CompilerServices;
using WPF_MVVM_.Models;

public class ConsultantVM : INotifyPropertyChanged
{
    private ConsultantModel _consultant;

    public ConsultantVM(ConsultantModel consultant)
    {
        _consultant = consultant;
    }

    public string Name
    {
        get => _consultant.Name;
        set
        {
            if (_consultant.Name != value)
            {
                _consultant.Name = value;
                OnPropertyChanged();
            }
        }
    }

    public string Phone
    {
        get => _consultant.Phone;
        set
        {
            if (_consultant.Phone != value)
            {
                _consultant.Phone = value;
                OnPropertyChanged();
            }
        }
    }

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
