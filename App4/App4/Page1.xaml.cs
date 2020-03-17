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
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void Page2(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page2());
        }

        private void Page3(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page3());
        }

        private void Page4(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page4());
        }

        private void Page5(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page5());
        }

        private void Page6(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page6());
            
        }

        private void Page7(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page7());
        }

        private void Page8(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Page8());
        }

        private void Page9(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page9());
        }

        private void Page10(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page10());
        }

        private void Page14(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page14());
        }

        private void Page15(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page15());
        }

        private void Page16(object sender, EventArgs e)
        {
            
        }
    }
}