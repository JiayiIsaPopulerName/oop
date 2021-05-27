using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oop
{
    public partial class fund : Form
    {
        public fund()
        {
            InitializeComponent();
        }

        private void young_SelectedIndexChanged(object sender, EventArgs e)
        {
            young.Items.Add(100);
            young.Items.Add(200);
            young.Items.Add(300);
            young.Items.Add(400);
        }

        private void adult_SelectedIndexChanged(object sender, EventArgs e)
        {
            adult.Items.Add(100);
            adult.Items.Add(200);
            adult.Items.Add(300);
            adult.Items.Add(400);
        }

        private void old_SelectedIndexChanged(object sender, EventArgs e)
        {
            old.Items.Add(100);
            old.Items.Add(200);
            old.Items.Add(300);
            old.Items.Add(400);
        }
    }
}
