using ShimmerEffectDemo.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
namespace ShimmerEffectDemo.ViewModels
{
    public class MainPageViewModel : BaseViewModel
    {
        private ObservableCollection<Item> items;


        public MainPageViewModel()
        {
            IsBusy = true;
            Task.Delay(2500);
            IsBusy = false;
            OnLoadCommandExecute();
        }
        public ObservableCollection<Item> Items
        {
            get { return items; }
            set { SetProperty(ref items, value); }
        }
        protected override async void OnLoadCommandExecute()
        {
            var title = "xxxxxxxxxxx";

            this.Items = new ObservableCollection<Item>(new List<Item> {
                new Item
                {
                    Title = title,
                    Subtitle = title,
                    IsBusy = true
                },
                new Item
                {
                    Title = title,
                    Subtitle = title,
                    IsBusy = true
                },
                new Item
                {
                    Title = title,
                    Subtitle = title,
                    IsBusy = true
                },
                new Item
                {
                    Title = title,
                    Subtitle = title,
                    IsBusy = true
                },
                new Item
                {
                    Title = title,
                    Subtitle = title,
                    IsBusy = true
                },
                new Item
                {
                    Title = title,
                    Subtitle = title,
                    IsBusy = true
                },
            });

            this.IsBusy = true;
            await Task.Delay(5000);
            this.IsBusy = false;

            this.Items = new ObservableCollection<Item>(new List<Item> {
                new Item
                {
                    Title = "Antelope Canyon",
                    Subtitle = "Arizona, United States",
                    Image = "img_1.jpg",
                },
                new Item
                {
                    Title = "Giza Plateau",
                    Subtitle = "Cairo, Egypt",
                    Image = "img_2.jpg",
                },
                new Item
                {
                    Title = "Machu Picchu",
                    Subtitle = "Peru",
                    Image = "img_3.jpg",
                },
                new Item
                {
                    Title = "Lake Louise",
                    Subtitle = "Alberta, Canada",
                    Image = "img_4.jpg",
                },
                 new Item
                {
                    Title = "Navagio Beach",
                    Subtitle = "Zakynthos, Greece",
                    Image = "img_5.jpg",
                },
                new Item
                {
                    Title = "Angels Landing",
                    Subtitle = "Utah, United States",
                    Image = "img_6.jpg",
                },
            });
        }
    } 
}
