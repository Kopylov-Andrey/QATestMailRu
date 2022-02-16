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

        //public static string StartUrl => GetEnviromentVar("StartUrl", "https://mail.ru/");
        public static string StartUrl => GetEnviromentVar("StartUrl", "https://e.mail.ru/inbox/?app_id_mytracker=58519&authid=kzo64410.1i&back=1%2C1&dwhsplit=s10273.b1ss12743s&from=login%2Cnavi&x-login-auth=1");
    }
}
