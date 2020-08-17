using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using MindMatters.DomainModel.Locations;

namespace MindMatters.DomainModel.Addresses
{
    public class Address
    {
        // PRIMARY KEY
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AddressID { get; set; }

        // Foreign Key
        //public int ServiceID { get; set; }

        // Normal Properties
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string County { get; set; }
        public string PostCode { get; set; }

    }
}
