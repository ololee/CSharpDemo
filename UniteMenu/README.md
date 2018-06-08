####0x02:菜单动态合并 
```
技术要点:弹出菜单控件，也就是常说的右键菜单ContextMenuStrip
利用该控件中的Items对象可以操作菜单中的菜单项。该对象为ToolStripMenuItme类型，使用Items.AddRange方法可以向弹出菜单添加菜单项。
语法格式：
public void AddRange(ToolStripItem [] toolStripItems);//其中toolStripItem为ToolStripItem控件数组。

过程：新建C#Windows窗体应用，项目名与解决方案均为UniteMenu,默认窗体为Form1,从工具箱中为其添加MenuStrip控件用来设计菜单，同是，添加ContextMenuStrip控件用来设计右键菜单，并依次添加"a","b","c","d","e"等子项,选中MenuStrip控件，创建一个"打开子窗体"主菜单和新建一个"文件"菜单项用于打开右键菜单ContextMenuStrip；再为程序新建一个窗体,默认名Form2,同时向窗体添加ContextMenuStrip控件，并为其添加"1","2","3","4","5"等子项。

demo:
       private int flag=0;//避免重复添加
       private void 打开子窗体ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.MdiParent = this;//此句话可能会报错，只需要修改Form1的IsMdiContainer属性设置为True
            form2.Show();
            form2.Resize += new EventHandler(f_Resize);//当新建的窗口程序放大或者缩小按钮点击或者改变尺寸就会触发事件，有点bug
        }

        private void f_Resize(object sender, EventArgs e)
        {//避免重复执行，需要定义一个状态量，其实这个bug就是当你还原窗口时，合并的菜单依然合并
           if (flag == 1)
            {  
                return;
            }
            Form2 f = sender as Form2;//类型的装化，as 能够转化时返回转化后的数据结构，不能时返回空
            //   is是能够转化返回true，否则false 
            ToolStripMenuItem item = new ToolStripMenuItem();
            for (int i = 0; i < f.contextMenuStrip1.Items.Count;)//注意，这里的i不需要人为的自增，在Add函数里已经为你自增了
            {
                item.DropDownItems.Add(f.contextMenuStrip1.Items[i]);
            }
            this.contextMenuStrip1.Items.AddRange(new ToolStripItem[] { item});//添加了一列菜单项toolstripitems
            flag=1;
        }

        private void 文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {//显示右键菜单
            contextMenuStrip1.Show(this,new Point(menuStrip1.Location.X+打开子窗体ToolStripMenuItem.Width,menuStrip1.Location.Y+打开子窗体ToolStripMenuItem.Height));//对显示的右键菜单的位置进行规定，第一个参数为Control,第二个为Point或者直接的x,y坐标
        }
```
![运行程序截图](https://upload-images.jianshu.io/upload_images/8179669-b4fe92f20652f4d3.png?imageMogr2/auto-orient/strip%7CimageView2/2/w/240)