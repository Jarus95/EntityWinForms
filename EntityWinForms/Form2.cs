﻿using EntityWinForms.Models;
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

            mcrm_users user = new mcrm_users();
            user.login = Login_input.Text;
            user.password = password_input.Text;
            user.id_org = id_input.Text;
            var value =  db.mcrm_users.Where(p => p.login == user.login && p.password == CalculateMD5Hash(user.password) && p.id_org == user.id_org).FirstOrDefault();
            if (value == null)
            {
                MessageBox.Show("Not found");
            }

            else
            {
                MessageBox.Show($"{value.id_org}  {value.login}  {value.qr_code} {value.org}");
            }


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
