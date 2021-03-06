﻿using System.Data.Entity;

using IoCCinema.Business;
using IoCCinema.Business.Notifications;
using IoCCinema.DataAccess.AuditLogging;
using IoCCinema.Business.Authentication;

namespace IoCCinema.DataAccess
{
    public class CinemaContext : DbContext
    {
        public DbSet<LoginAttempt> LoginAttempts { get; set; }
        public DbSet<AuditLog> AuditLogs { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Seanse> Seanses { get; set; }
        public DbSet<SeatAssignment> SeatAssignments { get; set; }
        public DbSet<MailToSend> MailsToSend { get; set; }
        public DbSet<SmsToSend> SmsesToSend { get; set; }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}
