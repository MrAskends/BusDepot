namespace BusDepot
{
    class Bus
    {
        public int id { get; set; }
        public string brand { get; set; }
        public string number { get; set; }
        public string route { get; set; }

        public Bus()
        {
            this.id = 0;
            this.brand = "";
            this.number = "";
            this.route = "";
        }

        public Bus(int id, string brand, string number, string route)
        {
            this.id = id;
            this.brand = brand;
            this.number = number;
            this.route = route;
        }
    }
}
