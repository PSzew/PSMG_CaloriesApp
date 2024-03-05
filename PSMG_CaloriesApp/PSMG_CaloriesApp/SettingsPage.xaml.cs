using PSMG_CaloriesApp.ClassModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PSMG_CaloriesApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SettingsPage : ContentPage
    {
        public SettingsPage()
        {
            InitializeComponent();
            ChangeCaloriesEntry.Text = GlobalClass.Settings.CaloriesGoal.ToString();
            ChangeWaterCupsEntry.Text = GlobalClass.Settings.WaterGoal.ToString();
            ChangeWaterEntry.Text = GlobalClass.Settings.CupCapacity.ToString();
        }

        private void ChangeDataBtn_Clicked(object sender, EventArgs e)
        {
            if(Int32.TryParse(ChangeCaloriesEntry.Text,out int ResultCalories) && Int32.TryParse(ChangeWaterCupsEntry.Text,out int ResultWaterCups) && Int32.TryParse(ChangeWaterEntry.Text,out int ResultCupCapacity))
            {
                GlobalClass.Settings.CaloriesGoal = ResultCalories;
                GlobalClass.Settings.CupCapacity = ResultCupCapacity;
                GlobalClass.Settings.WaterGoal = ResultWaterCups;
                GlobalClass.OverRideSettings();
                Navigation.PopAsync();
            }
        }
    }
}