using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        ToolStripMenuItem child;
        public static int check = 1;
        public int Check { get; set; }
        public void CheckRemove()
        {
            check++;
        }
        public Form1()
        {
            InitializeComponent();
            child = new ToolStripMenuItem();
            child.ShowDropDown(); 
            int val = 1;
            toolStripMenuItem1.Tag = val;
            CheckRemove();
            child.Visible = true;

        }
        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            var b = new Button() { Parent = this, Text = Convert.ToString(check)};
            Button s = sender as Button;
            b.Text = Convert.ToString(check);
        }

        private void menuStrip1_MouseEnter(object sender, EventArgs e)
        {
            string check1 = check.ToString();
            toolStrip1.Items.Add(child);
            child.Text = check1;
        }
    }
}



