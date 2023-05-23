using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityWinForms.Models
{
    public class mcrm_users
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int Id { get; set; }
        public string qr_code { get; set; }
        public string id_org { get; set; }
        public string login { get; set; }   
        public string password { get; set; }
        public string status { get; set; }
        public string status_rus { get; set; }
        public string user_ip { get; set; }
        public int security { get; set; }
        public string enter_date { get; set; }
        public string enter_time { get; set;}
        public int id_kassa { get; set; }
        public string kassa { get; set; }
        public int id_store { get; set; }
        public string store { get; set; }
        public string org { get; set;}





    }
}
