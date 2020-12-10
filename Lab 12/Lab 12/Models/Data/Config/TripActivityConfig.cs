using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Lab_12.Models
{
    public class TripActivityConfig : IEntityTypeConfiguration<TripActivity>
    {
        public void Configure(EntityTypeBuilder<TripActivity> entity)
        {
            entity.HasKey(ta => new { ta.Trip, ta.ActivityId });
            entity.HasOne(ta => ta.Trip)
                .WithMany(t =>.TripActivities)
                .HasForeignKey(ta => ta.ActivityId);
        }
    }
}