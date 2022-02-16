using System.Collections.Generic;


namespace TestMailRu.Entities
{
    public  class User
    {

        private string _name;
        public string Name => _name;


        private readonly string _login;
        public string Login => _login;

        private readonly string _password;
        public string Password => _password;

       

        public User(string name, string login, string password)
        {
            this._name = name;
            this._login = login;
            this._password = password;

            
        }
    }
}
