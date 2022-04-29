using Swap.Nora.Items.Pick;
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
    public partial class PickAxes : UserControl
    {
        public PickAxes()
        {
            InitializeComponent();
        }

        private void PickAxes_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            new Frozen_Axe_To_Galaxy_Axe().Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            new MintyToCandy().Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            new oathandsorrowtodaredevilbillyclub().Show();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            new starwand().Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            new raidersrevenge().Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            new Crowbar().Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            new streetshine().Show();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            new WindowsBite().Show();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            new OGDefaultPick().Show();
        }
    }
}
