#### 可以拉伸的菜单界面
~~~
实例用途:
如果程序功能非常多而用户又不常用，那么，通常就会隐藏这些功能选项，当用户自己去打开的时候才会展现全部的菜单功能
技术要点:
实现可以拉伸的菜单，关键是使用一个开关变量，同时调用ToolStripDropDownItem的ShowDropDown方法
demo:
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
~~~
![点击前](https://upload-images.jianshu.io/upload_images/8179669-9b262c9d146cd1ad.png?imageMogr2/auto-orient/strip%7CimageView2/2/w/100)
![点击后](https://upload-images.jianshu.io/upload_images/8179669-55e42746be70cda1.png?imageMogr2/auto-orient/strip%7CimageView2/2/w/90)