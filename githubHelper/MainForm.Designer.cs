/*
 * 由SharpDevelop创建。
 * 用户： Administrator
 * 日期: 2019/1/18 星期五
 * 时间: 16:52
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
namespace githubHelper
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox textBox3;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(254, 30);
			this.label1.TabIndex = 0;
			this.label1.Text = "1. 打开github 新建项目";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.label1.Click += new System.EventHandler(this.Label1Click);
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.label2.Location = new System.Drawing.Point(0, 30);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(298, 30);
			this.label2.TabIndex = 1;
			this.label2.Text = "2. git add .   ";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.label2.Click += new System.EventHandler(this.Label2Click);
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.label3.Location = new System.Drawing.Point(253, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(45, 30);
			this.label3.TabIndex = 2;
			this.label3.Text = "中文";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.label3.Click += new System.EventHandler(this.Label3Click);
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.label4.Location = new System.Drawing.Point(0, 60);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(298, 30);
			this.label4.TabIndex = 3;
			this.label4.Text = "3. git commit -m \"提交文件\"";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.label4.Click += new System.EventHandler(this.Label4Click);
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.label5.Location = new System.Drawing.Point(0, 90);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(298, 30);
			this.label5.TabIndex = 4;
			this.label5.Text = "4. git push -u origin master ";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.label5.Click += new System.EventHandler(this.Label5Click);
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.label6.Location = new System.Drawing.Point(0, 120);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(298, 30);
			this.label6.TabIndex = 5;
			this.label6.Text = "5. 克隆项目";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.label6.Click += new System.EventHandler(this.Label6Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(86, 121);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(211, 26);
			this.textBox1.TabIndex = 6;
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.label7.Location = new System.Drawing.Point(0, 150);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(298, 30);
			this.label7.TabIndex = 7;
			this.label7.Text = "6. 添加远程仓库";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.label7.Click += new System.EventHandler(this.Label7Click);
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(114, 153);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(183, 26);
			this.textBox2.TabIndex = 8;
			// 
			// label8
			// 
			this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
			this.label8.Location = new System.Drawing.Point(0, 180);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(298, 30);
			this.label8.TabIndex = 9;
			this.label8.Text = "7. 捐助代码";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.label8.Click += new System.EventHandler(this.Label8Click);
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(14, 219);
			this.textBox3.Multiline = true;
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(269, 36);
			this.textBox3.TabIndex = 10;
			this.textBox3.Text = "<a href=\"http://walogia.ucoz.club/donate.html\" target=\"_blank\">\r\n    <img  src=\"h" +
	"ttps://c1.staticflickr.com/5/4891/32909597848_f042487d54_b.jpg\"  height=\"150\" wi" +
	"dth=\"400\" /\r\n</a>";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(297, 209);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "githubHelper";
			this.TopMost = true;
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
