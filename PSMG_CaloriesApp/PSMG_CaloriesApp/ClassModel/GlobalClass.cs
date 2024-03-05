using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Newtonsoft;
using Newtonsoft.Json;

namespace PSMG_CaloriesApp.ClassModel
{
    static public class GlobalClass
    {
        private static string DayLocation = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Day.txt");
        private static string SettingsLocation = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Settings.txt");

        private static SettingsModel DeafultSettings= new SettingsModel(2500,8,250);

        public static DayModel Day = new DayModel();
        public static SettingsModel Settings = new SettingsModel();

        public static void GetDay()
        {
            if(File.Exists(DayLocation))
            {
                DayModel tmp = new DayModel();
                tmp = JsonConvert.DeserializeObject<DayModel>(File.ReadAllText(DayLocation));
                if(tmp.Date != DateTime.Today) 
                {
                    File.Delete(DayLocation);
                }
                else
                {
                    Day = tmp;
                }
            }
        }

        public static void GetSettings()
        {
            if(File.Exists(SettingsLocation))
            {
                Settings = JsonConvert.DeserializeObject<SettingsModel>(File.ReadAllText(SettingsLocation));
            }
            else
            {
                Settings = DeafultSettings;
                OverRideSettings();
            }
        }

        public static void OverRideSettings()
        {
            File.WriteAllText(SettingsLocation, JsonConvert.SerializeObject(Settings));
        }

        public
    }
}
