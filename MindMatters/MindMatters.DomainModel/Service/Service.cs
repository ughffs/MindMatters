using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MindMatters.DomainModel.Service
{
    public class Service
    {
        // PRIMARY KEY
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ServiceID { get; set; }

        // FOREIGN KEYS

        // Normal Properties

        // Navigation Properties
    }
}
