using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App4
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page2 : ContentPage
    {
        public Page2()
        {
            InitializeComponent();
        }

        private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            //valueLabel.Text = e.NewValue.ToString("F1");
            valueLabel.Text = ((Slider)sender).Value.ToString("F2");
        }

        private async void Button_ClickVedAsync(object sender, EventArgs e)
        {
            //Button button = (Button)sender;
            await DisplayAlert("clicked!", "The button labeled'" + ((Button)sender).Text + "'has been clicked", "ok");
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page4());
        }
    }
}