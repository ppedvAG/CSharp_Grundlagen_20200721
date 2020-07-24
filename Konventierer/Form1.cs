using Modul04_Lib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Konventierer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                double mph = FahrzeugBase.KmhToMph(textBox1.Text);

                textBox2.Text = mph.ToString();
            }
            catch (FahrzeugException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (FormatException ex) //Alle Fehler die eine FormatException haben...land hier
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.ToString());
            }
            catch (Exception ex) // alle anderen Exceptions landen hier
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.ToString());
            }


            
        }
    }
}
