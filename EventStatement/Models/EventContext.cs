using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EventStatement.Models
{
    public class EventContext:DbContext
    {
        public DbSet<Event> events { get; set; }
    }
}