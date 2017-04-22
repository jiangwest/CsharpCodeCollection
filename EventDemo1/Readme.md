

- 创建线程三种方式: 
    - `Thread t1 = new Thread(方法名);`
    - `Thread t1 = new Thread(new ThreadStart(方法名));`
    - `new Thread(() => FileWatchEventSource.MonitorFile()).Start();`


C#中使用事件的要点

- 首先，要创建委托，格式为：`public delegate void 委托名(object sender,EventArgs e);`
    - **注意**：委托即C/C++函数指针
    - 委托命名规范一般格式：`名字+EventHandle`
- 然后建立一个事件：`public event 委托类型 事件名;`
    - **注意**：`event`关键字代表事件，返回类型为委托；
- 再定义一个事件处理方法
- 最后还要创建*触发事件*的方法


- **Error**:  线程间操作无效: 从不是创建控件的线程访问
    - $\because$ ui线程创建的子线程操作ui控件时，系统提示错误
- *problem*: 对 Windows 窗体控件进行线程安全调用?
- solution

```csharp
//对 Windows 窗体控件进行线程安全调用
Control.CheckForIllegalCrossThreadCalls = false;
```

- `BackGroundWorker`控件?
