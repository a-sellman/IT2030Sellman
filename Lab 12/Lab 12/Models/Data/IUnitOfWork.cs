using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Linq.Expressions;
using Lab_12.Models;
using Microsoft.EntityFrameworkCore;

namespace Lab_12.Models
{
    public interface IUnitOfWork
    {
        Repository<Accomodation> Accomodations { get; set; }
        Repository<Activity> Actvities { get; set; }
        Repository<Destination> Destinations { get; set; }
        Repository<Trip> Trips { get; set; }

        void Save();
    }
}