using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MenuHistory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void 打开ToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            this.openFileDialog1.ShowDialog();
            StreamWriter streamWriter = new StreamWriter("Menu.ini", true);
            streamWriter.WriteLine(openFileDialog1.FileName);
            streamWriter.Flush();
            streamWriter.Close();
            ShowWindows(openFileDialog1.FileName);
        }
        public void ShowWindows(string filename)
        {
            Image p = Image.FromFile(filename);
            Form form = new Form();
            form.MdiParent = this;
            form.BackgroundImage = p;
            form.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StreamReader reader = new StreamReader("Menu.ini");
            int i = this.文件ToolStripMenuItem.DropDownItems.Count - 2;
            while (reader.Peek()>=0)
            {
                ToolStripMenuItem menuItem = new ToolStripMenuItem(reader.ReadLine());
                this.文件ToolStripMenuItem.DropDownItems.Insert(i,menuItem);
                i++;
                menuItem.Click += new EventHandler(menuItem_Click);
            }
            reader.Close();
        }

        private void menuItem_Click(object sender, EventArgs e)
        {
            ShowWindows(sender.ToString());
        }

        private void 关闭所有ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
