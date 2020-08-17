using Microsoft.EntityFrameworkCore.Internal;
using MindMatters.DomainModel.Addresses;
using System;
using MindMatters.DomainModel.Locations;
using MindMatters.DomainModel.Services;

namespace MindMatters.Repository
{
    public static class DbInitialiser
    {
        public static void Initialise(DataContext context)
        {
            // This line will check to see if the database in our appsettings exists, if not it will create it.
            Console.WriteLine(context.Database.EnsureCreated());

            // Check to see if the database has already been seeded
            if (context.Facilities.Any())
            {
                return; // DB has been seeded
            }


            // Create array of GeoCoordinates
            var coordinates = new GeoCoordinate[]
            {
                new GeoCoordinate { GeoCoordinateID = 1, Latitude = -20.23012, Longitude = -151.07963 },
                new GeoCoordinate { GeoCoordinateID = 2, Latitude = -6.38433, Longitude = 165.86065 },
                new GeoCoordinate { GeoCoordinateID = 3, Latitude = 0.16163, Longitude = 33.67175 }
            };

            // Add each coordinate to the context
            foreach (GeoCoordinate coordinate in coordinates)
            {
                context.GeoCoordinates.Add(coordinate);
            }

            // Save changes to the context
            context.SaveChanges();

            // Create array of Addresses
            var addresses = new Address[]
            {
                new Address { AddressID = 1, AddressLine1 = "3 Place Crescent", AddressLine2 = "", County = "Hampshire", PostCode = "PO7 5UR" },
                new Address { AddressID = 2, AddressLine1 = "Some Other Address", AddressLine2 = "", County = "Hampshire", PostCode = "PO7 5UR" },
                new Address { AddressID = 3, AddressLine1 = "Another random address", AddressLine2 = "", County = "Hampshire", PostCode = "PO7 5UR" }
            };

            // Add each address to context
            foreach (Address address in addresses)
            {
                context.Addresses.Add(address);
            }

            // Save changes to the context
            context.SaveChanges();

            // Creating array of new Services
            var facilities = new Facility[]
            {
                new Facility { Name = "Aquilis", EmailAddress = "contact@aqilis.com", Website = "www.aquilis.co.uk", TelephoneNumber = 02392359538, AddressID = 1, GeoCoordinateID = 1},
                
                new Facility { Name = "Terrys MH", EmailAddress = "contact@tmh.com", Website = "www.terrysmh.com", TelephoneNumber = 02392359538, AddressID = 2, GeoCoordinateID = 2 },

                new Facility { Name = "MindMatters Org", EmailAddress = "contact@mindmatters.community", Website = "www.mindmatters.community", TelephoneNumber = 02392359538, AddressID = 3, GeoCoordinateID = 3 }
            };

            // Add each service to the context
            foreach (Facility facility in facilities)
            {
                context.Facilities.Add(facility);
            }

            // Save changes to the context
            context.SaveChanges();
        } 
    }
}
