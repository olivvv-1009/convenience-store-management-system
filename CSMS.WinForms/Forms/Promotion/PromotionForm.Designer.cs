namespace CSMS.WinForms.Forms.Promotion
{
	partial class PromotionForm
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
            createPromo = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(37, 21);
            label1.Name = "label1";
            label1.Size = new Size(186, 39);
            label1.TabIndex = 0;
            label1.Text = "Promotion";
            // 
            // createPromo
            // 
            createPromo.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            createPromo.Location = new Point(674, 85);
            createPromo.Margin = new Padding(3, 4, 3, 4);
            createPromo.Name = "createPromo";
            createPromo.Size = new Size(242, 43);
            createPromo.TabIndex = 1;
            createPromo.Text = "+    Create Promotion";
            createPromo.UseVisualStyleBackColor = true;
            createPromo.Click += createPromo_Click;
            // 
            // panel1
            // 
            panel1.Location = new Point(16, 152);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(803, 332);
            panel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(951, 512);
            panel2.TabIndex = 3;
            // 
            // PromotionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(createPromo);
            Controls.Add(label1);
            Controls.Add(panel2);
            Margin = new Padding(3, 4, 3, 4);
            Name = "PromotionForm";
            Size = new Size(951, 512);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
		private Button createPromo;
		private Panel panel1;
        private Panel panel2;
    }
}
