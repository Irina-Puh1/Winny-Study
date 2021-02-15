using System;
using System.Configuration;

namespace HomeWorkLesson_8
{
    class Program
    {
        static void Main(string[] args)
        {
            bool key;
            string greeting = "Приветствую Вас!";
            string name;
            string age;
            string ocupation;

            key = Check();
            if (key)
            {
                name = ReadSetting("Name");
                age = ReadSetting("Age");
                ocupation = ReadSetting("Ocupation");
                Console.WriteLine($"{greeting} {name}");
                Console.WriteLine($"возраст: {age}");
                Console.WriteLine($"профессия: {ocupation}");

            }
            else 
            {
                Console.WriteLine(greeting);
                Console.Write("Введите фамилию и имя: ");
                AddSetting("Name", Console.ReadLine());
                Console.Write("Введите возраст: ");
                AddSetting("Age", Console.ReadLine());
                Console.Write("Введите профессию: ");
                AddSetting("Ocupation", Console.ReadLine());
            }
                
        }

        static bool Check()
        {
            var Settings = ConfigurationManager.AppSettings;
            if (Settings.Count == 0)
                return false;
            else
                return true;
        }

        static string ReadSetting(string value)
        {
            try
            {
                var Setting = ConfigurationManager.AppSettings;

               return Setting[value];
                  
            }
            catch (ConfigurationErrorsException)
            {
                return "Error reading app settings";
            }
        }

        static void AddSetting(string key, string value)
        {
            try
            {
                var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var setting = configFile.AppSettings.Settings;
                setting.Add(key, value);
                configFile.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
            }
            catch (ConfigurationErrorsException)
            {
                Console.WriteLine("Error writing app settings");
            }
        }
    }
}
