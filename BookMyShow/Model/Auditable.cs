﻿namespace BookMyShow.Models
{
    public abstract class Auditable
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }
    }
}
