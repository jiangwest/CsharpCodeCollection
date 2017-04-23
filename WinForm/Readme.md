# WinForm Controls

## Form

创建子窗体

```
// first define a Form, eg., Form2
Form2 frm = new Form2();//实例化Form2
frm.MdiParent = this;//设置MdiParent属性，将当前窗体作为父窗体
frm.Show();//使用Show方法打开窗体
```

### 窗体Layout

```
LayoutMdi(MdiLayout.TileHorizontal);//使用MdiLayout枚举实现窗体的水平平铺
```

### 启动窗口

- 定义启动窗口

```
public partial class Form2 : Form
{
	...

	private void Form2_Load(object sender, EventArgs e)
	{
	    this.FormBorderStyle = FormBorderStyle.None;//设置启动窗体为无标题栏窗体
	    this.BackgroundImage = Image.FromFile("start.jpg");//设置启动窗体的背景图片
	    this.BackgroundImageLayout = ImageLayout.Stretch;//设置图片自动适应窗体大小
	    this.timer1.Start();//启动计时器
	    this.timer1.Interval = 10000;//设置启动窗体停留时间
	}

	private void timer1_Tick(object sender, EventArgs e)
	{	this.Close();//关闭启动窗体	}

	private void Form2_FormClosed(object sender, FormClosedEventArgs e)
	{	    this.timer1.Stop();//关闭计时器	}
}
```    

- 加载启动窗口

```
private void Form1_Load(object sender, EventArgs e)
{
    Form2 frm = new Form2();//实例化Form2窗体对象
    frm.StartPosition = FormStartPosition.CenterScreen;//设置窗体居中显示
    frm.ShowDialog();//显示Form2窗体
}
```	

### 加载图片

```
Bitmap bit;//声明位图对象
private void Form1_Load(object sender, EventArgs e)
{
    bit = new Bitmap("bg.png");//使用指定的图形实例化位图对象
    bit.MakeTransparent(Color.Blue);//设置图形透明
}

private void Form1_Paint(object sender, PaintEventArgs e)
{
    e.Graphics.DrawImage((Image)bit, new Point(0, 0));//窗体获得焦点时绘制图形
}
```	

## labels

```
label1.Font = new Font("楷体", 12);//设置label1控件的字体
label1.Text = "明日科技";//设置label1控件显示的文字
label1.ForeColor = Color.Red;//设置label1控件的字体颜色
```

## TextBox

- `Validating`事件

```csharp
private void txtBoxEmpty_Validating(object sender, CancelEventArgs e)
{
	// cast the sender object to that.
	TextBox tb = (TextBox)sender;

	// If the text is empty we set the background color of the
	// Textbox to red to indicate a problem. We use the tag value of the control to indicate if the control contains valid
	// information.
	if (tb.Text.Length == 0){
		tb.BackColor = Color.Red;

		// In this case we do not want to cancel further processing,
		// but if we had wanted to do this, we would have added this line:
		// e.Cancel = true;
	}	else{
		tb.BackColor = System.Drawing.SystemColors.Window;
	}
}
```


- `\r`: 回车,使光标到行首
- `\n`: 换行，使光标下移一格
- `\r\n`:
    - Unix中每行结尾只有`<换行>`，即`\n`
    - Windows中每行结尾是`<换行><回车>`，即`\n\r`

```csharp
void textBoxAge_KeyPress(object sender, KeyPressEventArgs e)
{
  if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
    e.Handled = true; // Remove the character
}
```
- `e.handled=true`: 指示事件机制是否已处理事件
- `Anchor`属性
- `Dock`属性

### 焦点focus转移

```
private void textBox1_KeyDown(object sender, KeyEventArgs e)
{
    if (e.KeyData == Keys.Enter)//判断是否按下了回车键
    {
	textBox2.Focus();//使textBox2文本框获取焦点
    }
}
```

### 隐藏输入字符 

- 密码

```
textBox1.PasswordChar = '@';//设置文本框的PasswordChar属性为字符@
textBox2.UseSystemPasswordChar = true;
```

## Button


```
button1.BackColor=Color.Orange;//设置背景颜色
button1.FlatStyle = FlatStyle.Flat;//设置显示外观
button1.Font = new Font("宋体", 9);//设置字体及大小
button1.Text = "确定";//设置显示文本
button1.TextAlign = ContentAlignment.MiddleCenter;//设置文本居中显示
```

## RadioButton和CheckBox


## NumericUpDown控件

```
numericUpDown1.Minimum = 1;//设置控件的最小值为1
numericUpDown1.Maximum = 20;//设置控件的最大值为20
//设置控件的DecimalPlaces属性，使控件中的数值的小数点后显示两位数
numericUpDown1.DecimalPlaces = 2;
numericUpDown1.Increment = 1;//设置递增或递减的值
numericUpDown1.InterceptArrowKeys = true;//设置用户可以通过向上、向下键选择值
```

- 事件触发: `ValueChange`

### numericUpDown 键盘输入

- Text和Value？


## GroupBox

- GroupBox vs. RadioButton

## RichTextBox


- 字体选择: `Font`
	- `richTextBoxText.SelectionFont`
	- `richTextBoxText.Focus()`
	- `FontFamily`

- `richTextBoxText.LoadFile("Test.rtf");`

```csharp
// Save the text.
try {
  richTextBoxText.SaveFile("Test.rtf");
} catch (System.Exception err) {
  MessageBox.Show(err.Message);
}
```


```csharp
void textBoxSize_Validated(object sender, EventArgs e)
{
  TextBox txt = (TextBox)sender;

  ApplyTextSize(txt.Text);
  this.richTextBoxText.Focus();
}
```

- LinkLabel控件: 向WinForm中添加Web链接

```csharp
private void richTextBoxText_LinkClicked(object sender, LinkClickedEventArgs e)
{
  System.Diagnostics.Process.Start(e.LinkText);
}
```

## List


## ComboBox

- `comboBox.Items.Add()`: 为下拉列表赋值
- `comboBox.Items.AddRange()`: 

- `SelectedIndexChanged`事件

## CheckBox

```
foreach (Control ctl in this.Controls)//遍历窗体中的控件
{
	if (ctl.GetType().Name == "CheckBox")//判断控件类型是否是CheckBox
	{
	    CheckBox cbox = (CheckBox)ctl;//将遍历到的控件强制转换为CheckBox类型
	    cbox.AutoEllipsis = true;//设置文本过长时，显示…
	    cbox.CheckAlign = ContentAlignment.MiddleLeft;//设置文本居左对齐
	    cbox.Checked = false;//设置复选框不选中
	}
}
```	    

- `CheckedChanged`事件


## ListBox和CheckedListBox
