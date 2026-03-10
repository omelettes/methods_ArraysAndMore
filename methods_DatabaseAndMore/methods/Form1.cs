using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nigganigga
{
    public partial class Form1 : Form
    {
        
        calculations c = new calculations();
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbl_allscore.Text =c.Display_score();
            lbl_total.Text = c.Total_score().ToString();
            lbl_avg.Text = c.Average().ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

      

        private void lbl_total_Click(object sender, EventArgs e)
        {

        }

        private void btn_nextpage_Click(object sender, EventArgs e)
        {
            
            Form2 f = new Form2();
            f.ShowDialog();
            this.Close();
            
        }
    }
}
