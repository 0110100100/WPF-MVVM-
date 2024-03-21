using System.ComponentModel;
using System.Runtime.CompilerServices;

public class ManagerVM : ConsultantVM
{
    private ManagerModel _manager;

    public ManagerVM(ManagerModel manager) : base(manager)
    {
        _manager = manager;
    }

    public new string Name
    {
        get => _manager.Name;
        set
        {
            if (_manager.Name != value)
            {
                _manager.Name = value;
                OnPropertyChanged();
            }
        }
    }

    public new event PropertyChangedEventHandler PropertyChanged;

    protected override void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}