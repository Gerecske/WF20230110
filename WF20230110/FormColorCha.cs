using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF20230110
{
    public partial class FormColorCha : Form
    {
        public PictureBox PictureBox { get; set; }

        public FormColorCha(PictureBox pictureBox)
        {
            InitializeComponent();
            PictureBox = pictureBox;
        }

        private void btApply_Click(object sender, EventArgs e)
        {
            PictureBox.BackColor = Color.FromArgb(tBRed.Value, tBGreen.Value, tBBlue.Value);
        }
    }
}
