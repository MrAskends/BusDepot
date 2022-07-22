namespace BusDepot
{
    class Driver
    {
        public int id { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public int experience { get; set; }
        public string route { get; set; }

        public Driver()
        {
            this.id = 0;
            this.name = "";
            this.surname = "";
            this.experience = 0;
            this.route = "";
        }

        public Driver(int id, string name, string surname, int experience, string route)
        {
            this.id = id;
            this.name = name;
            this.surname = surname;
            this.experience = experience;
            this.route = route;
        }
    }
}
