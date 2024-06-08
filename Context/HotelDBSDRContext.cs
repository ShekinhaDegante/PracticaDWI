using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using Pracv1.Models;


namespace Pracv1.Context
{
    public class HotelDBSDRContext : DbContext
    {

        public HotelDBSDRContext()
        {

        }
        public HotelDBSDRContext(DbContextOptions<HotelDBSDRContext> options)
            : base(options)
        {

        }

        public DbSet<cHabitacion> tHabitacion { get; set; }

        public DbSet<cAlquiler> tAlquiler { get; set; }

        public DbSet<cCliente> tCliente { get; set; }

        public DbSet<cEstado> tEstado { get; set; }

        public DbSet<cNacionalidad> tNacionalidad { get; set; }

        public DbSet<cRegistrador> tRegistrador { get; set; }

        public DbSet<cTipoHabitacion> tTipoHabitacion { get; set; }

    }
}
