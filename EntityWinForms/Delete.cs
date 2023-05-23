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
    public partial class Delete : Form
    {
        AppdbContext dbContext;
        public string idOrg;
        public Delete()
        {
            InitializeComponent();
            dbContext = new AppdbContext();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(id_input.Text))
            {
                MessageBox.Show("empty");
                return;
            }

            idOrg = id_input.Text;
            var record = dbContext.mcrm_users.FirstOrDefault(i=>i.id_org == idOrg);
            if (record != null)
            {
               dbContext.mcrm_users.Remove(record);    
               dbContext.SaveChanges();
               MessageBox.Show("Succes");
            }

            else
            {
                MessageBox.Show("Not found");
            }
          

        }
    }
}
