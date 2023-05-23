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
    public partial class Form2 : Form
    {
        AppdbContext db;
        public Form2()
        {
            InitializeComponent();
            db = new AppdbContext();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //OK
            if (string.IsNullOrEmpty(Login_input.Text) || string.IsNullOrEmpty(password_input.Text))
            {
                MessageBox.Show("EMPTY");
                return;
            }

            Users user = new Users();
            user.Login = Login_input.Text;
            user.Password = password_input.Text;
            var value =  db.Users.Where(p => p.Login == user.Login && p.Password == user.Password).FirstOrDefault();
            if (value == null)
            {
                MessageBox.Show("Not found");
            }

            else
            {
                MessageBox.Show("Succes");
            }


        }
    }
}
