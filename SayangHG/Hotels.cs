using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SayangHG
{
    public partial class Hotels
    {
        public Hotels()
        {
            Rooms = new HashSet<Rooms>();
            Users = new HashSet<Users>();
        }

        public int Id { get; set; }
        public string Hotelname { get; set; }
        public int? City { get; set; }
        public string Adress { get; set; }
        public string Phone { get; set; }
        public int? Stars { get; set; }
        public byte[] Photo { get; set; }

        public virtual Cities CityNavigation { get; set; }
        public virtual ICollection<Rooms> Rooms { get; set; }
        public virtual ICollection<Users> Users { get; set; }
    }
}
