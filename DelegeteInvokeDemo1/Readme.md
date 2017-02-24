- **aim**:  the delegate invoke type

分为三类:

- 同步
- 异步
- 异步回调: `AsyncCallback`


### .Net异步



.NET 两种异步操作设计模式：

1. `IAsyncResult` 异步设计模式 -> 同步方法的异步调用
2. 使用事件`event`的异步操作


`IAsyncResult` 接口

```
public interface IAsyncResult  
{  
    object AsyncState { get; }  
    WaitHandle AsyncWaitHandle { get; }  
    bool CompletedSynchronously { get; }  
    bool IsCompleted { get; }  
} 
```


```csharp
BeginOperationName()
...
EndOperationName()
```

`FileStream` 类提供 `BeginRead` 和 `EndRead` 方法来从文件异步读取字节，它们是 `Read` 方法的异步版本
 
*Exmaple*:

```
BeginInvoke();  //启动异步调用
...
EndInvoke();    //检索异步调用的结果
```


-  IAsyncResult 通过名为  的两个方法来实现原，如 



- 委托(Delegate)
    - BeginInvoke方法可以使用线程异步地执行委托所指向的方法
    - 然后通过EndInvoke方法获得方法的返回值

- `BeginInvoke()`参数
    - 具有与需异步执行的方法相同的参数
    - 还有两个可选参数
        - 第一个参数是`AsyncCallback` 委托，该委托引用在异步调用完成时要调用的方法
        - 第二个参数是一个用户定义对象，可向回调方法传递信息


四种使用BeginInvoke和EndInvoke异步调用的常用方法。在调用BeginInvoke 之后，可执行下列操作：

1. 进行某些操作，然后调用 EndInvoke 一直阻止到调用完成。
2. 使用 System.IAsyncResult.AsyncWaitHandle 属性获取 WaitHandle，使用它的 WaitOne 方法一直阻止执行直到发出 WaitHandle 信号，然后调用 EndInvoke。
3. 轮询由 BeginInvoke 返回的 IAsyncResult，确定异步调用何时完成，然后调用 EndInvoke。
4. 将用于回调方法的委托传递给 BeginInvoke。异步调用完成后，将在ThreadPool 线程上执行该方法。该回调方法将调用 EndInvoke。

**注意**： 每次都要调用EndInvoke来完成异步调用。


判断异步调用是否完成的方法

- `IAsyncResult asyncResult`属性
- `WaitOne`方法

异步回调: `public delegate void AsyncCallback(IAsyncResult ar);`


