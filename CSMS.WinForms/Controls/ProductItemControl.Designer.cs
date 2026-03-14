namespace CSMS.WinForms.Controls
{
    partial class ProductItemControl
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
            panelProduct = new Panel();
            lblCode = new Label();
            panelProduct.SuspendLayout();
            SuspendLayout();
            // 
            // panelProduct
            // 
            panelProduct.BackColor = SystemColors.ControlLightLight;
            panelProduct.BorderStyle = BorderStyle.FixedSingle;
            panelProduct.Controls.Add(lblCode);
            panelProduct.Dock = DockStyle.Fill;
            panelProduct.Location = new Point(0, 0);
            panelProduct.Name = "panelProduct";
            panelProduct.Size = new Size(1385, 762);
            panelProduct.TabIndex = 1;
            panelProduct.Paint += panel1_Paint;
            // 
            // lblCode
            // 
            lblCode.AutoSize = true;
            lblCode.Location = new Point(393, 69);
            lblCode.Name = "lblCode";
            lblCode.Size = new Size(41, 20);
            lblCode.TabIndex = 0;
            lblCode.Text = "P001";
            // 
            // ProductItemControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelProduct);
            Name = "ProductItemControl";
            Size = new Size(1385, 762);
            panelProduct.ResumeLayout(false);
            panelProduct.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelProduct;
        private Label lblCode;
    }
}
