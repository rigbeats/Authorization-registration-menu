using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Life_tracker.Forms
{
    public partial class AttentionForm : Form
    {
        public AttentionForm(string text)
        {
            InitializeComponent();
            WarningText.Text = text;
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AttentionForm_Load(object sender, EventArgs e)
        {
            pictureBox1.Select();
        }
    }
}
