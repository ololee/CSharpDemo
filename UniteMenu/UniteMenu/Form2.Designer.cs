namespace UniteMenu
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.仓库管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.库存盘点ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.仓库调拨ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.仓库报损ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.入库管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.出库管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退货管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.仓库管理ToolStripMenuItem,
            this.库存盘点ToolStripMenuItem,
            this.仓库调拨ToolStripMenuItem,
            this.仓库报损ToolStripMenuItem,
            this.入库管理ToolStripMenuItem,
            this.出库管理ToolStripMenuItem,
            this.退货管理ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(241, 233);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // 仓库管理ToolStripMenuItem
            // 
            this.仓库管理ToolStripMenuItem.Name = "仓库管理ToolStripMenuItem";
            this.仓库管理ToolStripMenuItem.Size = new System.Drawing.Size(152, 28);
            this.仓库管理ToolStripMenuItem.Text = "仓库管理";
            // 
            // 库存盘点ToolStripMenuItem
            // 
            this.库存盘点ToolStripMenuItem.Name = "库存盘点ToolStripMenuItem";
            this.库存盘点ToolStripMenuItem.Size = new System.Drawing.Size(152, 28);
            this.库存盘点ToolStripMenuItem.Text = "库存盘点";
            // 
            // 仓库调拨ToolStripMenuItem
            // 
            this.仓库调拨ToolStripMenuItem.Name = "仓库调拨ToolStripMenuItem";
            this.仓库调拨ToolStripMenuItem.Size = new System.Drawing.Size(152, 28);
            this.仓库调拨ToolStripMenuItem.Text = "仓库调拨";
            // 
            // 仓库报损ToolStripMenuItem
            // 
            this.仓库报损ToolStripMenuItem.Name = "仓库报损ToolStripMenuItem";
            this.仓库报损ToolStripMenuItem.Size = new System.Drawing.Size(152, 28);
            this.仓库报损ToolStripMenuItem.Text = "仓库报损";
            // 
            // 入库管理ToolStripMenuItem
            // 
            this.入库管理ToolStripMenuItem.Name = "入库管理ToolStripMenuItem";
            this.入库管理ToolStripMenuItem.Size = new System.Drawing.Size(152, 28);
            this.入库管理ToolStripMenuItem.Text = "入库管理";
            // 
            // 出库管理ToolStripMenuItem
            // 
            this.出库管理ToolStripMenuItem.Name = "出库管理ToolStripMenuItem";
            this.出库管理ToolStripMenuItem.Size = new System.Drawing.Size(152, 28);
            this.出库管理ToolStripMenuItem.Text = "出库管理";
            // 
            // 退货管理ToolStripMenuItem
            // 
            this.退货管理ToolStripMenuItem.Name = "退货管理ToolStripMenuItem";
            this.退货管理ToolStripMenuItem.Size = new System.Drawing.Size(152, 28);
            this.退货管理ToolStripMenuItem.Text = "退货管理";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "Form2";
            this.Text = "Form2";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 仓库管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 库存盘点ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 仓库调拨ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 仓库报损ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 入库管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 出库管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退货管理ToolStripMenuItem;
    }
}