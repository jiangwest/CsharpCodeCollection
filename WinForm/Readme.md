# WinForm Controls

## labels

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


- `\r': 回车,使光标到行首
- '\n': 换行，使光标下移一格
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

## RadioButton和CheckBox

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




## ListBox和CheckedListBox
