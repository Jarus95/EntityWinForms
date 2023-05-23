using EntityWinForms.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace EntityWinForms
{
    public class AppdbContext : DbContext
    {
        public DbSet<Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
                optionsBuilder.UseMySql("datasource = 127.0.0.1; port=3306; username = root; database= mcrmdemo");
               // optionsBuilder.UseSqlite("Filename = test.db");

        }


        public bool CheckInternetConnection()
        {
            try
            {
                using (var client = new Ping())
                {
                    var reply = client.Send("www.google.com", 1000);
                    return reply.Status == IPStatus.Success;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
