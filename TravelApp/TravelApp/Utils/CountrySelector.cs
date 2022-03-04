using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using TravelApp.MVVM.Model;

namespace TravelApp.Utils
{
    public class CountrySelector :  DataTemplateSelector
    {
        public DataTemplate UnselectedTemplate1 { get; set; }
        //public DataTemplate UnselectedTemplate2 { get; set; }
        public DataTemplate SelectedTemplate { get; set; }
        public int Counter { get; set; }
        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            var context = (ContentPresenter)container;
            var country = item as Country;
            if (country == null) return UnselectedTemplate1;

            return SelectedTemplate;

        }
    }
}
