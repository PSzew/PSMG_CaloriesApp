using System;
using System.Collections.Generic;
using System.Text;

namespace PSMG_CaloriesApp.ClassModel
{
    public class DayModel
    {
        public DayModel()
        {
            Date = DateTime.Today;
        }
        public DateTime Date { get; set; }
        public int Calories { get; set; }
        public int WaterCups { get; set; }
    }
}
