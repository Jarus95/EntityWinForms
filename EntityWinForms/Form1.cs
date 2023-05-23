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
    public partial class Form1 : Form
    {
        public string login, password;  
        AppdbContext db;
        public Form1()
        {
            InitializeComponent();
            db = new AppdbContext();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //OK
            if(string.IsNullOrEmpty(Login_input.Text) || string.IsNullOrEmpty(password_input.Text))
            {
                MessageBox.Show("EMPTY");
                return;
            }

         
            login =  Login_input.Text;
            password = password_input.Text;

            Users _users = new Users();
            _users.Login = login;
            _users.Password = password;

            db.Users.Add(_users);
            db.SaveChanges();
            MessageBox.Show("Сохранен");



        }
    }
}
