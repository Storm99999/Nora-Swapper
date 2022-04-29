using Swap.Nora.Items.Emotes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Swap
{
    public partial class Emotes : UserControl
    {
        public Emotes()
        {
            InitializeComponent();
        }

        private void siticoneCirclePictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This swap is currently unavailable please wait until an update fix the problem.");
        }

        private void siticoneCirclePictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This swap is currently unavailable please wait until an update fix the problem.");
        }

        private void siticoneCirclePictureBox4_Click(object sender, EventArgs e)
        {
            new Floss().Show();
        }

        private void siticoneCirclePictureBox6_Click(object sender, EventArgs e)
        {
            new TakeTheL().Show();
        }

        private void siticoneCirclePictureBox5_Click(object sender, EventArgs e)
        {
            
        }

        private void siticoneCirclePictureBox5_Click_1(object sender, EventArgs e)
        {
            new buildup().Show();
        }

        private void emoteWarning1_Load(object sender, EventArgs e)
        {

        }

        private void siticoneCirclePictureBox3_Click(object sender, EventArgs e)
        {
            new chickenwingit().Show();
        }

        private void siticoneCirclePictureBox7_Click(object sender, EventArgs e)
        {
            new vibin().Show();
        }

        private void siticoneCirclePictureBox8_Click(object sender, EventArgs e)
        {
            new blindinglights().Show();
        }

        private void siticoneCirclePictureBox1_Click_1(object sender, EventArgs e)
        {
            new My_World().Show();
        }
    }
}
