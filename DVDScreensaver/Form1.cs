using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVDScreensaver
{
    public partial class Form1 : Form
    {
        int nachLinks = 3;
        int nachOben = 3;

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Hier schreiben wir unsere Logik für die Button-Wanderung rein.

            if (button1.Right >= ClientRectangle.Right || button1.Left <= 0)
                nachLinks *= -1;

            if (button1.Bottom >= ClientRectangle.Bottom || button1.Top <= 0)
                nachOben *= -1;

            button1.Left += nachLinks;
            button1.Top += nachOben;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cool du hast mich angeklickt!");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //WEnn das Formular lädt, wird irgendwann einmal Form1_Load aufgerufen
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
                MessageBox.Show("Hier ist das A-Team");
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 'a')
            {
                MessageBox.Show("Hier ist das A-Team");
            }
        }

        private void Form1_MaximumSizeChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Fenstergröße wurde geändert!");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Form1 wird jetzt abgebaurt!");
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Auf Wiedersehen :-) ");
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            MessageBox.Show("Fenstergröße wurde geändert! Mit Resize");
        }

        private void Form1_MouseLeave(object sender, EventArgs e)
        {
            MessageBox.Show("Wo willst du hin mit der Maus");
        }
    }
}
