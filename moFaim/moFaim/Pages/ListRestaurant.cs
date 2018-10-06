using moFaim.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace moFaim.Pages
{
    class ListRestaurant: ContentPage
    {
        public ObservableCollection<RestaurantListView> listRestaurant { get; set; }
       

        public ListRestaurant()
        {

            listRestaurant = new ObservableCollection<RestaurantListView>();
            ListView lstView = new ListView();
            lstView.RowHeight = 60;
            this.Title = "ListView Code Sample";
            lstView.ItemTemplate = new DataTemplate(typeof(CustomVeggieCell));
            listRestaurant.Add(new RestaurantListView { RestaurantName = "Luigi", Location = "Grand Baie", Image = "splash.jpg" });
            listRestaurant.Add(new RestaurantListView { RestaurantName = "Kimchi", Location = "PortLouis", Image = "back.jpg" });
            listRestaurant.Add(new RestaurantListView { RestaurantName = "Panarotti", Location = "Bagatelle", Image = "splash.jpg" });
            lstView.ItemsSource = listRestaurant;
            Content = lstView;
        }

        public class CustomVeggieCell : ViewCell
        {
            public CustomVeggieCell()
            {
                //instantiate each of our views
                var image = new Image();
                var nameLabel = new Label();
                var typeLabel = new Label();
                var verticaLayout = new StackLayout();
                var horizontalLayout = new RelativeLayout() { BackgroundColor = Color.White};

                //set bindings
                nameLabel.SetBinding(Label.TextProperty, new Binding("RestaurantName"));
                typeLabel.SetBinding(Label.TextProperty, new Binding("Location"));
                image.SetBinding(Image.SourceProperty, new Binding("Image"));

                //Set properties for desired design
                //horizontalLayout.Orientation = StackOrientation.Horizontal;
                verticaLayout.Orientation = StackOrientation.Vertical;
                horizontalLayout.HorizontalOptions = LayoutOptions.Fill;
                image.HorizontalOptions = LayoutOptions.Start;
                nameLabel.FontSize = 20;
                typeLabel.FontSize = 10;

                //add views to the view hierarchy
                verticaLayout.Children.Add(nameLabel);
                verticaLayout.Children.Add(typeLabel);
                horizontalLayout.Children.Add(verticaLayout, Constraint.RelativeToParent((parent) => {
                    return parent.X +80;
                }), Constraint.RelativeToParent((parent) => {
                    return parent.Y;
                }), Constraint.RelativeToParent((parent) => {
                    return parent.Width*.5;
                }), Constraint.RelativeToParent((parent) => {
                    return parent.Height;
                }));
                horizontalLayout.Children.Add(image, Constraint.RelativeToParent((parent) => {
                    return parent.X;
                }), Constraint.RelativeToParent((parent) => {
                    return parent.Y * .15;
                }), Constraint.RelativeToParent((parent) => {
                    return parent.Width* .30;
                }), Constraint.RelativeToParent((parent) => {
                    return parent.Height;
                }));

                // add to parent view
                View = horizontalLayout;
            }
        }
    }
}
