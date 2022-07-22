namespace BusDepot
{
    class User
    {
        public int userid { get; set; }
        public string login { get; set; }
        public string password { get; set; }

        public User()
        {
            this.userid = 0;
            this.login = "";
            this.password = "";
        }

        public User(int userid, string login, string password, string firstname, string lastname, bool admin)
        {
            this.userid = userid;
            this.login = login;
            this.password = password;
        }
    }
}
