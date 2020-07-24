using EF_DBFirst.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EF_DBFirst
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using(AdventureWorks2017Entities ctx = new AdventureWorks2017Entities())
            {
                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = ctx.Person.ToList();
                
            }
        }
    }
}
