#### 任务栏盘菜单
```
技术要点: NotifyIcon控件是运行，或者显示在系统任务栏的图标控件，比如腾讯qq等就有运行在NotifyIcon的图标，这个图标如要实现菜单，则需要右键菜单ContextMenuStrip控件。 
实现过程：创建一个项目，将其命名为NotifyIconS1,默认窗台为Form1。 
向Form1添加NotifyIcon控件和ContextMenuStrip控件,并为ContextMenuStrip控件添加子项。 
选择NotifyIcon控件，并将ContextMenuStrip对象添加到NotifyIcon的ContextMenuStrip属性 
上，并为NotifyIcon设置自己喜欢的图标。
```
![程序运行结果](https://upload-images.jianshu.io/upload_images/8179669-381cf49ae5893cfa.png?imageMogr2/auto-orient/strip%7CimageView2/2/w/1240)