using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App2
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
            StackLayout stacklayout = new StackLayout
            {
                Orientation = StackOrientation.Vertical,
                VerticalOptions = LayoutOptions.CenterAndExpand
                
            };
                var label = new Label { Text = "Hola", FontSize = 25, TextColor = Color.Black  };
                              
                var buton = new Button { Text = "El Boton" };
                

            stacklayout.Children.Add(label);
            stacklayout.Children.Add(buton);
            this.Content = stacklayout;
            buton.Clicked += OnClick;


        }

        private void OnClick(object sender, EventArgs e)
        {
            DisplayAlert("Hola", "Ya puedes undir ok", "ok");
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            //elSaludo.Text = "Hola " + elEntry.Text;
            
        }
    }
}
