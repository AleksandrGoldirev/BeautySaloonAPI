using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BeautySaloonAPI.Models
{
    public partial class ServicePhotos
    {
        public int Id { get; set; }
        public int ServiceId { get; set; }
        public string PhotoPath { get; set; }

        public virtual Services Service { get; set; }
    }
}
