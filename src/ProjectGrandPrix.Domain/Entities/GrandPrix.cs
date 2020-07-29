using System;

namespace ProjectGrandPrix.Domain.Entities
{
    public class GrandPrix
    {
        public int Id {get; set;}
        public string TrackName {get; set;}
        public int Laps {get; set;}
        public DateTime Date {get; set;}
    }
}