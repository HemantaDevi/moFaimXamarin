using moFaim.ViewModels;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using static moFaim.Pages.ListRestaurant;

namespace moFaim.Pages
{
    public partial class RestaurantView: ContentPage
    {
        public ObservableCollection<RestaurantListView> restaurants { get; set; }

        public RestaurantView()
        {
            var scroll = new ScrollView();
            Content = scroll; 

            InitializeComponent();

            restaurants = new ObservableCollection<RestaurantListView>();
            lstView.ItemTemplate = new DataTemplate(typeof(CustomVeggieCell));
            restaurants.Add(new RestaurantListView { RestaurantName = "Luigi", Location = "Grand Baie", Image = "luigi.jpg" });
            restaurants.Add(new RestaurantListView { RestaurantName = "Kimchi", Location = "Port Louis", Image = "kimchi.jpg" });
            restaurants.Add(new RestaurantListView { RestaurantName = "Panarotti", Location = "Bagatelle", Image = "panarotti.jpg" });
            
            lstView.ItemsSource = restaurants;
            
        }
    }
}
