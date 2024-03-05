using PSMG_CaloriesApp.ClassModel;
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
            GlobalClass.GetDay();
            GlobalClass.GetSettings();
            RefreshCalories();
            RefreshWater();
        }

        private void DecreaseWaterCupAmountBtn_Clicked(object sender, EventArgs e)
        {
            GlobalClass.Day.WaterCups--;
            GlobalClass.OverRideDay();
            RefreshWater();
        }

        private void SettingsToolBar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SettingsPage());
        }

        private void IncreaseWaterCupAmountBtn_Clicked(object sender, EventArgs e)
        {
            GlobalClass.Day.WaterCups++;
            GlobalClass.OverRideDay();
            RefreshWater();
        }

        private void AddCaloriesBtn_Clicked(object sender, EventArgs e)
        {
            if (Int32.TryParse(AddCaloriesEntry.Text, out int result))
            {
                GlobalClass.Day.Calories += result;
                GlobalClass.OverRideDay();
                RefreshCalories();
                AddCaloriesEntry.Text = "";
            }
            else
                DisplayAlert("Błąd", "Podano złe dane!", "Ok");
        }

        private void RefreshCalories()
        {
            CaloriesProgressBar.Progress = (double)GlobalClass.Day.Calories / (double)GlobalClass.Settings.CaloriesGoal;
            CaloriesLbl.Text = GlobalClass.Day.Calories.ToString() + "Kcal / " + GlobalClass.Settings.CaloriesGoal.ToString() + " Kcal";
        }

        private void RefreshWater()
        {            
            WaterCupsLbl.Text = GlobalClass.Day.WaterCups.ToString() + " szklanek z " + GlobalClass.Settings.WaterGoal.ToString() + " szklanek";
        }

    }
}
