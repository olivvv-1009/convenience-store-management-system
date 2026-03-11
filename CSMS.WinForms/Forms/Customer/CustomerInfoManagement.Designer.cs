namespace CSMS.WinForms.Forms.Customer
{
	partial class CustomerInfoManagement
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			label4 = new Label();
			label5 = new Label();
			textBox1 = new TextBox();
			textBox2 = new TextBox();
			textBox3 = new TextBox();
			textBox4 = new TextBox();
			button1 = new Button();
			button2 = new Button();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label1.Location = new Point(87, 17);
			label1.Name = "label1";
			label1.Size = new Size(125, 24);
			label1.TabIndex = 0;
			label1.Text = "Information";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label2.Location = new Point(16, 91);
			label2.Name = "label2";
			label2.Size = new Size(28, 23);
			label2.TabIndex = 1;
			label2.Text = "ID";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label3.Location = new Point(16, 230);
			label3.Name = "label3";
			label3.Size = new Size(135, 23);
			label3.TabIndex = 2;
			label3.Text = "Diem Tich Luy";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label4.Location = new Point(16, 133);
			label4.Name = "label4";
			label4.Size = new Size(140, 23);
			label4.TabIndex = 3;
			label4.Text = "Phone Number";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label5.Location = new Point(16, 186);
			label5.Name = "label5";
			label5.Size = new Size(161, 23);
			label5.TabIndex = 4;
			label5.Text = "Hang Thanh Vien";
			// 
			// textBox1
			// 
			textBox1.Location = new Point(87, 94);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(213, 23);
			textBox1.TabIndex = 5;
			// 
			// textBox2
			// 
			textBox2.Location = new Point(162, 133);
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(138, 23);
			textBox2.TabIndex = 6;
			// 
			// textBox3
			// 
			textBox3.Location = new Point(183, 189);
			textBox3.Name = "textBox3";
			textBox3.Size = new Size(117, 23);
			textBox3.TabIndex = 7;
			// 
			// textBox4
			// 
			textBox4.Location = new Point(157, 230);
			textBox4.Name = "textBox4";
			textBox4.Size = new Size(143, 23);
			textBox4.TabIndex = 8;
			// 
			// button1
			// 
			button1.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			button1.Location = new Point(16, 396);
			button1.Name = "button1";
			button1.Size = new Size(284, 31);
			button1.TabIndex = 9;
			button1.Text = "Accept";
			button1.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			button2.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			button2.Location = new Point(16, 433);
			button2.Name = "button2";
			button2.Size = new Size(284, 31);
			button2.TabIndex = 10;
			button2.Text = "Discard";
			button2.UseVisualStyleBackColor = true;
			// 
			// CustomerInfoManagement
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(button2);
			Controls.Add(button1);
			Controls.Add(textBox4);
			Controls.Add(textBox3);
			Controls.Add(textBox2);
			Controls.Add(textBox1);
			Controls.Add(label5);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Name = "CustomerInfoManagement";
			Size = new Size(324, 489);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
		private Label label5;
		private TextBox textBox1;
		private TextBox textBox2;
		private TextBox textBox3;
		private TextBox textBox4;
		private Button button1;
		private Button button2;
	}
}
