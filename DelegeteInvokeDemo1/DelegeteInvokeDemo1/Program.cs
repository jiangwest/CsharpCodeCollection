using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Runtime.Remoting.Messaging;


namespace ConsoleTest
{
    public delegate int AddHandler(int a, int b);
    public class CAdd
    {
        public static int Add(int a, int b)
        {
            Console.WriteLine("开始计算：" + a + "+" + b);
            Thread.Sleep(3000); //模拟该方法运行三秒
            Console.WriteLine("计算完成！");
            return a + b;
        }
    }

    /// <summary>
    /// 同步调用
    /// </summary>
    public class CSyncInvoke
    {
        public CSyncInvoke()
        {
            Console.WriteLine("===== 同步调用 Sync Invoke Test =====");
            AddHandler handler = new AddHandler(CAdd.Add);
            int result = handler(1, 2); //等价于handler.Invoke(1, 2);
            Console.WriteLine("继续做别的事情。。。");
            Console.WriteLine(result);
        }
    }
    
    /// <summary>
    /// 异步调用
    /// </summary>
    public class CAsyncInvoke
    {
        public CAsyncInvoke()
        {
            Console.WriteLine("===== 异步调用 AsyncInvoke Test =====");
            AddHandler handler = new AddHandler(CAdd.Add);
            //IAsyncResult: 异步操作接口(interface)
            //BeginInvoke: 委托(delegate)的一个异步方法的开始
            IAsyncResult result = handler.BeginInvoke(1, 2, null, null);
            Console.WriteLine("继续做别的事情。。。");
            //异步操作返回
            Console.WriteLine(handler.EndInvoke(result));
        }
    }
    public class CCallback
    {
        public CCallback()
        {
            Console.WriteLine("===== 异步回调 AsyncInvokeTest =====");
            AddHandler handler = new AddHandler(CAdd.Add);
            //异步操作接口(注意BeginInvoke方法的不同！)
            IAsyncResult result = handler.BeginInvoke(1, 2, new AsyncCallback(CallbackFunc), "AsycState:OK");
            Console.WriteLine("继续做别的事情。。。");
        }
        static void CallbackFunc(IAsyncResult result)
        {
            //result 是“加法类.Add()方法”的返回值
            //AsyncResult 是IAsyncResult接口的一个实现类，引用空间：System.Runtime.Remoting.Messaging
            //AsyncDelegate 属性可以强制转换为用户定义的委托的实际类。
            AddHandler handler = (AddHandler)((AsyncResult)result).AsyncDelegate;
            Console.WriteLine(handler.EndInvoke(result));
            Console.WriteLine(result.AsyncState);
        }
    }

    class Program
    {
        static void Main()
        {
            List<object> ObjList = new List<object>(); //泛型列表List<T>初始化

            ObjList.Add(new CSyncInvoke());
            ObjList.Add(new CAsyncInvoke());
            ObjList.Add(new CCallback());

            Console.ReadKey();
        }
    }

}
