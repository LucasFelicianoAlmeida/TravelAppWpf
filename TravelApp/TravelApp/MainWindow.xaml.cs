using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;
using TravelApp.MVVM.Model;
using TravelApp.MVVM.ViewModel;

namespace TravelApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Timer t;
        public MainWindow()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            _Hvm = new HomeViewModel();
            DataContext = _Hvm;

            DispatcherTimer dp = new DispatcherTimer();
            dp.Interval = new TimeSpan(0, 0, 8);
            dp.Tick += Dp_Tick;
            dp.Start();

            Loaded += MainWindow_Loaded;
        }

        double ScrollPos = 0;
        private void Dp_Tick(object sender, EventArgs e)
        {


            var list = control.Items?.OfType<Country>().ToList();
            if (list.Count == 0) return;

            var first = list.FirstOrDefault(x => x.Status == CountryEnum.Selected);
            var index = list.IndexOf(first);
            scrollViewer.ScrollToVerticalOffset(50 * index);

            if (first == null)
            {
                first = list.FirstOrDefault();
                first.Status = CountryEnum.Near;
                list[0] = first;
                return;
            }
            else
            {
                
            }
          
            first.Status = CountryEnum.Near;
            list[index] = first;

            var last = list.ElementAtOrDefault(index - 1);

            foreach (var item in list.ToList())
            {
                if (item == first)
                {
                    var next = list.ElementAtOrDefault(index + 1);
                    if (next != null)
                    {
                        next.Status = CountryEnum.Selected;
                        list[index + 1] = next;

                        next = list.ElementAtOrDefault(index + 2);
                        if (next != null)
                        {
                            next.Status = CountryEnum.Near;
                            list[index + 2] = next;
                        }
                    }
                    else if (last != null & index != 0)
                    {
                        last.Status = CountryEnum.Near;
                        list[index - 1] = last;
                    }
                    else
                    {
                        item.Status = CountryEnum.Far;

                    }


                }
                else
                {
                }
            }

            _Hvm.Countries.Clear();
            foreach (var item in list)
            {
                _Hvm.Countries.Add(item);
            }

            //scrollViewer.ScrollToVerticalOffset()

        }

        private void TimeCount()
        {
        }

        bool Started;

        private  async void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
           await _Hvm.PopulateList();

            var list = control.Items;
            if (list.Count == 0) return;
            var first  = list[0] as Country;
            var second  = list[1] as Country;
            first.Status = CountryEnum.Selected;
            second.Status = CountryEnum.Near;

        }

        HomeViewModel _Hvm;

        private void ListView_Scroll(object sender, System.Windows.Controls.Primitives.ScrollEventArgs e)
        {
            var v = e.NewValue;
        }


        private void ScrollViewer_ScrollChanged(object sender, ScrollChangedEventArgs e)
        {
         

        }

        private async void control_Loaded(object sender, RoutedEventArgs e)
        {
            await Task.Delay(2000);
            Started = true;

        }
    }
}
