using EntityWinForms.Models;
using Microsoft.EntityFrameworkCore;
using MySql.Data.MySqlClient;
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
        public DbSet<mcrm_users> mcrm_users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            //string connString = "Server=83.69.136.27;Database=mcrmdemo;port=3306;User Id=mcrmdemo;password=mcrmdemo;" +
            // ";CertificateFile=" + AppDomain.CurrentDomain.BaseDirectory + "images" + @"\" + "Certificate" + @"\" + "main_first.pfx" + ";" +
            // "CertificatePassword=jQLv$c9R5(nb!uKCFPgg;" +
            //"SslMode=Required";




              // optionsBuilder.UseMySql(connString);
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
