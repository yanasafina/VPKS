using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SayangHG
{
    public partial class Booking
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Fullame { get; set; }
        public string Parentname { get; set; }
        public string Coming { get; set; }
        public string Leaving { get; set; }
        public string Phone { get; set; }
        public int? Room { get; set; }
        public string Food { get; set; }
        public string Cot { get; set; }

        public virtual Rooms RoomNavigation { get; set; }
    }
}
