using Swap.Nora.Items.Skins;
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
    public partial class RenegadeOptions : Form
    {
        public RenegadeOptions()
        {
            InitializeComponent();
        }

        private void siticoneCirclePictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new RenegadeNoHead().Show();
        }

        private void siticoneCirclePictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new RenegadeRaidr().Show();
        }

        private void siticoneCirclePictureBox3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("THIS SKIN DOES NOT WORK.");
        }
    }
}
