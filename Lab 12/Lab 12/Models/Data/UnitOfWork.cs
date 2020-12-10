using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab_12.Models;
using Microsoft.EntityFrameworkCore;

namespace Lab_12.Models
{
    public class UnitOfWork : IUnitOfWork
    {
        private Repository<Accomodation> accomodations;
        private Repository<Activity> activities;
        private Repository<Destination> destinations;
        private Repository<Trip> trips;

        public UnitOfWork(TripLogContext ctx) => context = ctx;

        public Repository<Accomodation> Accomodations
        {
            get
            {
                if (accomodations == null)
                {
                    accomodations = new Repository<Accomodation>(context);
                }
                return accomodations;
            }
        }

        public Repository<Activity> Activities
        {
            get
            {
                if (activities == null)
                {
                    activities = new Repository<Activity>(context);
                }
                return activities;
            }
        }

        public Repository<Destination> Destinations
        {
            get
            {
                if (destinations == null)
                {
                    destinations = new Repository<Destination>(context);
                }
                return destinations;
            }
        }

        public Repository<Trip> Trips
        {
            get
            {
                if (trips == null)
                {
                    trips = new Repository<Trip>(context);
                }
                return trips;
            }
        }

        private TripLogContext context { get; set; }

        public void Save() => context.SaveChanges();
    }
}