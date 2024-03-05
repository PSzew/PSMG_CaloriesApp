using System;
using System.Collections.Generic;
using System.Text;

namespace PSMG_CaloriesApp.ClassModel
{
    public class SettingsModel
    {

        public SettingsModel()
        {
            
        }

        public SettingsModel(int caloriesGoal, int waterGoal, int cupCapacity)
        {
            CaloriesGoal = caloriesGoal;
            WaterGoal = waterGoal;
            CupCapacity = cupCapacity;
        }

        public int CaloriesGoal { get; set; }
        public int WaterGoal { get; set; }
        public int CupCapacity { get; set; }
    }
}
