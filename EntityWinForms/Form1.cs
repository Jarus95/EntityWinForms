﻿using EntityWinForms.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.CompilerServices.RuntimeHelpers;

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

            mcrm_users users = new mcrm_users();

            users.qr_code = "88888888";
            users.id_org = "100000000099";
            users.login = login;
            users.password = password;
            users.status = "admin";
            users.org = "MCRM ENTITY";


            db.mcrm_users.Add(users);
            db.SaveChanges();


            MessageBox.Show("Сохранен");



        }

        public void test()
        {
            //string UsersQuery = "INSERT INTO mcrm_users (qr_code, id_org, login, password, status, org) VALUES (@uQ,@uD,@uL,@uP,@uS,@Uo);";

            //MySqlCommand UsersComm = new MySqlCommand(UsersQuery, db.getConnection());
            //UsersComm.Parameters.Add("@uQ", MySqlDbType.VarChar).Value = qr_code.ToString();
            //UsersComm.Parameters.Add("@uD", MySqlDbType.VarChar).Value = orgID;
            //UsersComm.Parameters.Add("@uL", MySqlDbType.VarChar).Value = this.text_login.Text;
            //UsersComm.Parameters.Add("@uP", MySqlDbType.VarChar).Value = CalculateMD5Hash(this.text_passw1.Text);
            //UsersComm.Parameters.Add("@uS", MySqlDbType.VarChar).Value = "admin";
            //UsersComm.Parameters.Add("@Uo", MySqlDbType.VarChar).Value = this.text_company.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Delete form2 = new Delete();
            form2.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Edit form2 = new Edit();
            form2.Show();
            this.Hide();
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
