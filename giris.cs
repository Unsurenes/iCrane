using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iCrane
{
    public partial class giris : Form
    {
        public giris()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            
        }


       
        private void timer1_Tick(object sender, EventArgs e)
        {
           
                timer1.Stop();
                this.Hide();
                var form2 = new ICrane();
                form2.Closed += (s, args) => this.Close();
                form2.Show();
           
        }

        private void giris_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
