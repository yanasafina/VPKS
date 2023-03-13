using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SayangHG
{
    public partial class Rooms
    {
        public Rooms()
        {
            Booking = new HashSet<Booking>();
        }

        public int Id { get; set; }
        public int? Number { get; set; }
        public int? Hotel { get; set; }
        public int? Beds { get; set; }
        public string Status { get; set; }
        public byte[] Photo { get; set; }

        public virtual Hotels HotelNavigation { get; set; }
        public virtual ICollection<Booking> Booking { get; set; }
    }
}
