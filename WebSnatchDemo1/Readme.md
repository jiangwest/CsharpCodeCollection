## C# HTTP简单示例 -- 抓取网页


- C# 两个Http对象类
    - HTTPWebRequest: 向某资源发送请求
    - HTTPWebResponse: 获得响应
    
C#抓取网页程序步骤

- 指定一个待抓取URL地址
- 用HTTPWebRequest对象进行请求
- 用HTTPWebResponse对象接收响应结果
- 用TextStream对象来提取所需信息，并在控制台打印

C# 字符串string和字节数组byte[]的转换

- string转byte[]: `byte[] byteArray = System.Text.Encoding.Default.GetBytes ( str );`
- byte[]转string：`string str = System.Text.Encoding.Default.GetString ( byteArray );`
