using System.Configuration;

namespace TestMailRu.WebDriver
{
    public class Configuration 
    {
        public static string GetEnviromentVar(string var,string defaultValue)
        {
            return  ConfigurationManager.AppSettings[var] ?? defaultValue;
        }

        public static string ElementTimeout => GetEnviromentVar("ElementTimeout", "10");

        public static string Browser => GetEnviromentVar("Browser", "Chrome");

        public static string Password => GetEnviromentVar("Password", "ITNUA71pd");

        public static string Login => GetEnviromentVar("Login", "epam.test.kopylov@mail.ru");

        public static string StartUrl => GetEnviromentVar("StartUrl", "https://mail.ru/");

    }
}
