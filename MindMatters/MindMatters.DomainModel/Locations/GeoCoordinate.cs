using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MindMatters.DomainModel.Locations
{
    public class GeoCoordinate
    {
        // PRIMARY KEY
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int GeoCoordinateID { get; set; }

        // Foreign Keys
       
        // Normal Properties
        public double Longitude { get; set; }
        public double Latitude { get; set; }

    }
}
