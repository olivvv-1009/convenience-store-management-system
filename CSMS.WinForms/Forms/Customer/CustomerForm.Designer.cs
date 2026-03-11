namespace CSMS.WinForms.Forms.Customer
{
    partial class CustomerForm
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
			flowLayoutPanel1 = new FlowLayoutPanel();
			button1 = new Button();
			button2 = new Button();
			button3 = new Button();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label1.Location = new Point(19, 17);
			label1.Name = "label1";
			label1.Size = new Size(115, 24);
			label1.TabIndex = 0;
			label1.Text = "Customer ";
			// 
			// flowLayoutPanel1
			// 
			flowLayoutPanel1.Location = new Point(19, 81);
			flowLayoutPanel1.Name = "flowLayoutPanel1";
			flowLayoutPanel1.Size = new Size(669, 307);
			flowLayoutPanel1.TabIndex = 1;
			// 
			// button1
			// 
			button1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			button1.Location = new Point(694, 81);
			button1.Name = "button1";
			button1.Size = new Size(169, 37);
			button1.TabIndex = 2;
			button1.Text = "Add customer";
			button1.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			button2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			button2.Location = new Point(694, 124);
			button2.Name = "button2";
			button2.Size = new Size(169, 43);
			button2.TabIndex = 3;
			button2.Text = "Delete customer";
			button2.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			button3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			button3.Location = new Point(694, 173);
			button3.Name = "button3";
			button3.Size = new Size(169, 43);
			button3.TabIndex = 4;
			button3.Text = "Customize";
			button3.UseVisualStyleBackColor = true;
			// 
			// CustomerForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(button3);
			Controls.Add(button2);
			Controls.Add(button1);
			Controls.Add(flowLayoutPanel1);
			Controls.Add(label1);
			Name = "CustomerForm";
			Size = new Size(880, 424);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private FlowLayoutPanel flowLayoutPanel1;
		private Button button1;
		private Button button2;
		private Button button3;
	}
}
