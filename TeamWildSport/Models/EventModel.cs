using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TeamWildSport.Models
{
    public class EventModel
    {
        public string Description { get; set; }
        public string Name { get; set; }
        public PlaceModel Place { get; set; }
        public string Id { get; set; }
        public DateTime Start_time { get; set; }
        public DateTime End_time { get; set; }
    }

    public class PlaceModel
    {
        public string Name { get; set; }
        public LocationModel Location { get; set; }
        public string Id { get; set; }
    }

    public class LocationModel
    {
        public string City { get; set; }
        public string Country { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string ZipCode { get; set; }
    }
}