﻿namespace MovieTheatrhe.Core.Models.Interfaces
{
    internal interface IEntity
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsActive { get; set; }
    }
}
