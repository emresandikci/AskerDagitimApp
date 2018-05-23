using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WFAskerDagitim
{
    public partial class Acilis : Form
    {
        public Acilis()
        {
            InitializeComponent();
        }
        Form1 frm = new Form1();
        Timer t = new Timer();
        private void Acilis_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile("../../imagess/soldiers.PNG");
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.Opacity = 0;
            t.Tick += t_Tick;
            t.Start();
        }

        void t_Tick(object sender, EventArgs e)
        {
            this.Opacity += 0.03;

            if (this.Opacity == 1.0)
            {
                frm.Show();
                t.Stop();
            }
        }

        private void Acilis_FormClosing(object sender, FormClosingEventArgs e)
        {
            t.Stop();
        }
    }
}
