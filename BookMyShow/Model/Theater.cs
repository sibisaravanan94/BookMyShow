﻿namespace BookMyShow.Models
{
    public class Theater : Auditable
    {
        public string Name { get; set; }
        public string Adress { get; set; }
        public List<Hall> Halls { get; set; }
    }
}