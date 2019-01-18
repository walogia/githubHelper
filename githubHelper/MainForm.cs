/*
 * 由SharpDevelop创建。
 * 用户： Administrator
 * 日期: 2019/1/18 星期五
 * 时间: 16:52
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace githubHelper
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Label1Click(object sender, EventArgs e)
		{
			 System.Diagnostics.Process.Start("https://github.com/");  
		}
		void Label3Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start("https://www.githubs.cn/");   //打开中文社区
		}
		void Label2Click(object sender, EventArgs e)
		{
		　　Clipboard.SetDataObject("git add ."); 
		}
		void Label4Click(object sender, EventArgs e)
		{
			Clipboard.SetDataObject("git commit -m \"提交文件\""); 
		}
		void Label5Click(object sender, EventArgs e)
		{
			Clipboard.SetDataObject("git push -u origin master "); 
		}
		void Label6Click(object sender, EventArgs e)
		{
			Clipboard.SetDataObject("git clone "+textBox1.Text); 
		}
		void Label7Click(object sender, EventArgs e)
		{
			Clipboard.SetDataObject("git remote add origin "+textBox2.Text); 
		}
		void Label8Click(object sender, EventArgs e)
		{
			Clipboard.SetDataObject(textBox3.Text); 
		}
	}
}
