using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TravelApp.MVVM.Model;

namespace TravelApp.MVVM.ViewModel
{
    public class HomeViewModel : BaseViewModel
    {
        public ObservableCollection<Country> Countries { get; set; }
        public HomeViewModel()
        {
            Countries = new ObservableCollection<Country>();
        }

        public void PopulateList()
        {

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://");
            client.GetAsync("");
        }

    }
}
