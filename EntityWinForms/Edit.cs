using EntityWinForms.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityWinForms
{
    public partial class Edit : Form
    {
        AppdbContext appdbContext;
        public string idorg;
        public Edit()
        {
            InitializeComponent();
            appdbContext = new AppdbContext();

            var value = appdbContext.mcrm_users.Last();
            id_input.Text = value.id_org.ToString();
            idorg = id_input.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Login_input.Text) || string.IsNullOrEmpty(password_input.Text))
            {
                MessageBox.Show("EMPTY");
                return;
            }

            var record = appdbContext.mcrm_users.FirstOrDefault(i=>i.id_org == idorg);
            record.login = Login_input.Text;
            record.password = CalculateMD5Hash(password_input.Text);
            record.id_org = id_input.Text;

            appdbContext.mcrm_users.Update(record);
            appdbContext.SaveChanges();

            MessageBox.Show("Sucess");
 

        }


        public string CalculateMD5Hash(string input)
        {
            System.Security.Cryptography.MD5 alg = System.Security.Cryptography.MD5.Create();
            System.Text.UTF8Encoding enc = new System.Text.UTF8Encoding();


            byte[] hash = alg.ComputeHash(enc.GetBytes(input));
            string output = Convert.ToBase64String(hash);
            return output;
        }
    }
}
