 # CSharpDemo/MenuHistory
这是ololee同学学习CSharp的demo仓库，在这里，我们一起探讨程序与人生啊。一起探讨人类的未来与个人的前途。欢迎你来哦~~~
This is ololee's CSharp demo hub,welcome.
Here I commited some project of learn CSharp and some of myself project.


 >技术要点: 将菜单中最近打开文件的文件名和路径保存到事先建立的*.ini文件中，软件启动时读取*.ini文件中的数据建立数组菜单，即可实现显示历史菜单的功能。
 > 注意：首先添加一个MenuStrip菜单控件，将主窗体的IsMdiContainer属性设置为True

demo:
```
 private void 打开ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";//设定打开文件对话框的初始内容为空
            this.openFileDialog1.ShowDialog();//显示打开文件对话框
            StreamWriter streamWriter = new StreamWriter("Menu.ini", true);//写文件助手，参数1：path，参数2:bool append[true 追加，false 覆盖]
            streamWriter.WriteLine(openFileDialog1.FileName);//写入打开文件的名字及其路径
            streamWriter.Flush();//刷新文件写助手
            streamWriter.Close();//关闭文件写助手
            ShowWindows(openFileDialog1.FileName);//调用ShowWindows函数，显示图片
        }
        public void ShowWindows(string filename)
        {
            Image p = Image.FromFile(filename);//获得一个Image对象
            Form form = new Form();//新建一个form窗口
            form.MdiParent = this;//其对象是当前的父本
            form.BackgroundImage = p;//为新建的form窗口设置背景为image对象，此处之前可以先对图片进行压缩
            form.Show();//一切工作就绪,准备显示form窗口
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          /*   在启动窗口时读取ini文件，并把读取到的路径加载到
               菜单栏选项里。并为其添加点击事件
         */
            StreamReader reader = new StreamReader("Menu.ini");//文件读助手 参数：path
            int i = this.文件ToolStripMenuItem.DropDownItems.Count - 2;//放菜单选项的位置，这里是在关闭所有与退出前面
            while (reader.Peek()>=0)//这里的peek函数是判断文件是否读取到段尾，没有读取到段尾则返回字符，否则返回-1，可能会触发I/O异常
            {
                ToolStripMenuItem menuItem = new ToolStripMenuItem(reader.ReadLine());//定义一个新ToolStripMenuItem对象，参数为菜单名。
                this.文件ToolStripMenuItem.DropDownItems.Insert(i,menuItem);//插入新建的对象
                i++;//位置自增
                menuItem.Click += new EventHandler(menuItem_Click);//为新建的菜单选项添加点击事件
            }
            reader.Close();//关闭文件读取助手
        }

        private void menuItem_Click(object sender, EventArgs e)
        {
            ShowWindows(sender.ToString());//打开文件
        }
```
