using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1__7th_lesson_
{
    public partial class Form1 : Form
    {
        private Random rand = new Random();
        private int num = 1;
        private int num1 = 0;

        public Form1()
        {
            InitializeComponent();
            btnCommand1.Text = "+1";
            btnCommand2.Text = "x2";
            btnReset.Text = "Сброс";
            lblNumber.Text = "0";
            this.Text = "Удвоитель";
            lblCounter.Text = "0";            
            this.Width = 310;
            num = rand.Next(2, 500);
        }

        private void btnCommand1_Click(object sender, EventArgs e)
        {
            lblNumber.Text = (Convert.ToInt32(lblNumber.Text) + 1).ToString();
            lblCounter.Text = (Convert.ToInt32(lblCounter.Text) + 1).ToString();
        }

        private void btnCommand2_Click(object sender, EventArgs e)
        {
            lblNumber.Text = (Convert.ToInt32(lblNumber.Text) * 2).ToString();
            lblCounter.Text = (Convert.ToInt32(lblCounter.Text) + 1).ToString();

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lblNumber.Text = "0";
            lblCounter.Text = (Convert.ToInt32(lblCounter.Text) + 1).ToString();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            pnlGame.Left = 0;
            pnlMenu.Visible = false;
            pnlGame.Visible = true;
            lblTarget.Text = rand.Next(2,500).ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBackMenu_Click(object sender, EventArgs e)
        {
            pnlGame.Visible = false;
            pnlMenu.Visible = true;
        }
    }    
}
