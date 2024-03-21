using WPF_MVVM_.ViewModels.Base;

namespace WPF_MVVM_.ViewModels
{
    internal class MainWindowViewModel : ViewModelBase
    {
        private string _Title;

        public string Title
        {
            get => _Title;
            set => Set(ref _Title, value);
        }
    }
}
