using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace IMC
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(Weight.Text) && !string.IsNullOrEmpty(Height.Text))
                {

                var weigth = double.Parse(Weight.Text);
                var heigth = double.Parse(Height.Text);

                var imc = weigth / (heigth * heigth);
                Imc.Text = imc.ToString();

                string result = "";

                if (imc < 20)
                {
                    result = "You have low weight";

                }
                else if (imc >= 21 && imc < 30)
                {
                    result = "You have normal weight";

                }
                else if (imc > 31)
                {
                    result = "You have high weight";
                }

                DisplayAlert("Result", result, "OK");
            } else
            {
                DisplayAlert("Error", "Please fill the fields", "OK");
            }

       
        }

        
    }
}
