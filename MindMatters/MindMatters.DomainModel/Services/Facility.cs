using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using MindMatters.DomainModel.Addresses;
using MindMatters.DomainModel.Locations;

namespace MindMatters.DomainModel.Services
{
    public class Facility
    {
        // PRIMARY KEY
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int FacilityID { get; set; }

        // FOREIGN KEYS
        public int AddressID { get; set; }
        public int GeoCoordinateID { get; set; }

        // Normal Properties
        public string Name { get; set; }
        public string EmailAddress { get; set; }
        public long TelephoneNumber { get; set; }
        public string Website { get; set; }

        // Navigation Properties
        public virtual Address Address { get; set; }
        public virtual GeoCoordinate GeoCoordinate { get; set; }
    }
}
