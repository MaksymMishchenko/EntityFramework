﻿namespace ClientsApp.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? CityId { get; set; }
        public City City { get; set; }
    }
}
