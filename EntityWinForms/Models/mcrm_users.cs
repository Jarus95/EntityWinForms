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
        public string Qr_code { get; set; }
        public string Id_org { get; set; }
        public string Login { get; set; }   
        public string Password { get; set; }
        public string Status { get; set; }
        public string Status_rus { get; set; }
        public string User_ip { get; set; }
        public int Security { get; set; }
        public string Enter_date { get; set; }
        public string Enter_time { get; set;}
        public int Id_kassa { get; set; }
        public string Kassa { get; set; }
        public int Id_store { get; set; }
        public string Store { get; set; }
        public string Org { get; set;}





    }
}
