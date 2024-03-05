using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PSMG_CaloriesApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void DecreaseWaterCupAmountBtn_Clicked(object sender, EventArgs e)
        {

        }

        private void SettingsToolBar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SettingsPage());
        }

        private void IncreaseWaterCupAmountBtn_Clicked(object sender, EventArgs e)
        {

        }

        private void AddCaloriesBtn_Clicked(object sender, EventArgs e)
        {

        }
    }
}
