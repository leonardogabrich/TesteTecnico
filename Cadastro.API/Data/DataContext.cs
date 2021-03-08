using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using Cadastro.API.Models;
using Cadastro.API.Util;

namespace Cadastro.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options){}
        public DbSet<Pessoa> Pessoas { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Pessoa>().HasData(
                new List<Pessoa>(){
                    new Pessoa(11, "JOSE", "RUA JAMIL JO�O ZARIF", "12345678@gmail.com"),
                    new Pessoa(13, "RODINEIA", "RUA CORONEL JO�O AFFONSO", "12345679@gmail.com"),
                    new Pessoa(14, "DANIELLY", "RUA JAMIL JO�O ZARIF", "12345680@gmail.com"),
                    new Pessoa(15, "ROSEVANIA", "RUA JAMIL JO�O ZARIF", "12345681@gmail.com"),
                    new Pessoa(16, "JULIANA", "RUA JAMIL JO�O ZARIF", "12345682@gmail.com"),
                    new Pessoa(22, "EVANDRO", "RUA BENJAMIN CONSTANT", "12345683@gmail.com"),
                    new Pessoa(28, "LUIS ANTONIO", "RUA ARAG�O", "12345684@gmail.com"),
                    new Pessoa(29, "LUCIO", "AVENIDA ARMANDO �TALO SETTI", "12345685@gmail.com"),
                    new Pessoa(30, "MIGUEL", "AVENIDA ARMANDO �TALO SETTI", "12345686@gmail.com"),
                    new Pessoa(31, "LUCIANO", "AVENIDA ARMANDO �TALO SETTI", "12345687@gmail.com"),
                    new Pessoa(32, "JOSE RODRIGUES", "AVENIDA ARMANDO �TALO SETTI", "12345688@gmail.com")
                }
            );
        }
    }
}
