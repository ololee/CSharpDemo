using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UniteMenu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        public int flag = 0;
        private void 打开子窗体ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.MdiParent = this;
            form2.Show();
            form2.Resize += new EventHandler(f_Resize);
        }

        private void f_Resize(object sender, EventArgs e)
        {
            if (flag == 1)
            {
                return;
            }
            Form2 f = sender as Form2;
            ToolStripMenuItem item = new ToolStripMenuItem();
            for (int i = 0; i < f.contextMenuStrip1.Items.Count;)
            {
                item.DropDownItems.Add(f.contextMenuStrip1.Items[i]);
            }
            this.contextMenuStrip1.Items.AddRange(new ToolStripItem[] { item});
            flag = 1;
        }

        private void 文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(this,new Point(menuStrip1.Location.X+打开子窗体ToolStripMenuItem.Width,menuStrip1.Location.Y+打开子窗体ToolStripMenuItem.Height));
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
