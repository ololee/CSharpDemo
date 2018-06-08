using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HideMenu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.toolStripMenuItem5.Visible = false;
            this.toolStripMenuItem6.Visible = false;
            this.toolStripMenuItem7.Visible = false;
            this.toolStripMenuItem8.Visible = false;
        }

        private void moreToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
                    this.moreToolStripMenuItem.Visible = false;
                    this.toolStripMenuItem5.Visible = true;
                    this.toolStripMenuItem6.Visible = true;
                    this.toolStripMenuItem7.Visible = true;
                    this.toolStripMenuItem8.Visible = true;
                    this.numToolStripMenuItem.ShowDropDown();
        }

        private void numToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.moreToolStripMenuItem.Visible = true;
            this.toolStripMenuItem5.Visible = false;
            this.toolStripMenuItem6.Visible = false;
            this.toolStripMenuItem7.Visible = false;
            this.toolStripMenuItem8.Visible = false;
        }
    }
}
