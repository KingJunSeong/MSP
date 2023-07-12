using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSP.Database
{
    public class UserContext : DbContext
    {
        public virtual DbSet<User> Users {  get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseMySql("Server=127.0.0.1;User=root;Database=discord;Password=rlawnstjddl12;", ServerVersion.Create(new Version("11.1.0"), Pomelo.EntityFrameworkCore.MySql.Infrastructure.ServerType.MariaDb));

        }

    }

    public class User
    {
        [Key]
        public int id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string apikey { get; set; }
    }
}
