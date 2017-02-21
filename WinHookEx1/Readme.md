## C# Hook Example

- aim: to capture and displaymouse point in the form

- `[StructLayout(LayoutKind.Sequential)]`:  `struct`用`StructLayoutAttribute`特性来控制成员的内存布局,是C#引用非托管C/C++ DLL的一种定义结构体的方式
    - `using System.Runtime.InteropServices;`  
- `[DllImport("User32.dll", CharSet = CharSet.Auto)]`: 告诉C#编译器：从`User32.dll`中，查找C函数
