﻿namespace QLNH_APIs.Models
{
    public class GuestTable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public bool Deleted { get; set; }
        public virtual Status Status { get; set; }
        public virtual Guest Guest { get; set; }

    }
}
