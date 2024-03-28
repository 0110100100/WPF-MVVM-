using System.Collections.Generic;
using System.IO;
using System.Linq;
using CsvHelper;
using WPF_MVVM_.Models;
using WPF_MVVM_.ViewModels.Base;

namespace WPF_MVVM_.ViewModels
{
    internal class MainWindowViewModel : ViewModelBase
    {
        private string _title = "kukareku";

        public string Title
        {
            get => _title;
            set => Set(ref _title, value);
        }

        private List<ClientModel> _clients;

        public List<ClientModel> Clients
        {
            get => _clients;
            set => Set(ref _clients, value);
        }

        public MainWindowViewModel()
        {
            _clients = new List<ClientModel>();

            using (var reader = new StreamReader("clients.csv"))
            using (var csv = new CsvReader(reader, System.Globalization.CultureInfo.InvariantCulture))
            {

                _clients = csv.GetRecords<ClientModel>().ToList();
            }
        }
    }
}
