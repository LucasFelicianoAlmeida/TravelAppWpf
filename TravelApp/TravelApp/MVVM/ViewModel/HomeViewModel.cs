using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
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

        public async Task PopulateList()
        {

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:5001/api/");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var response = await client.GetAsync("country");
            var content = await response.Content.ReadAsStringAsync();
            var countries = JsonConvert.DeserializeObject<Country[]>(content);

            foreach (var country in countries)
            {
                Countries.Add(country);
            }
        }

    }
}
