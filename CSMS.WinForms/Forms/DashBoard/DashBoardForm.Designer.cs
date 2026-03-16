namespace CSMS.WinForms.Forms.DashBoard
{
    partial class DashBoardForm
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
            pnlSidebar = new Panel();
            pnlMenu = new Panel();
            panel1 = new Panel();
            lblRole = new Label();
            lblFullName = new Label();
            lblAvatar = new Label();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            pnlUser = new Panel();
            label1 = new Label();
            pnlMainContent = new Panel();
            pnlScrollBody = new Panel();
            flowCards = new FlowLayoutPanel();
            pnlCard1 = new Panel();
            label2 = new Label();
            label4 = new Label();
            label3 = new Label();
            panel5 = new Panel();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            panel4 = new Panel();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            panel3 = new Panel();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            panel2 = new Panel();
            pnlChartArea = new Panel();
            pnlSidebar.SuspendLayout();
            pnlMenu.SuspendLayout();
            panel1.SuspendLayout();
            pnlUser.SuspendLayout();
            pnlMainContent.SuspendLayout();
            pnlScrollBody.SuspendLayout();
            flowCards.SuspendLayout();
            pnlCard1.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.White;
            pnlSidebar.Controls.Add(pnlMenu);
            pnlSidebar.Controls.Add(pnlUser);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 0);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(250, 800);
            pnlSidebar.TabIndex = 0;
            // 
            // pnlMenu
            // 
            pnlMenu.Controls.Add(panel1);
            pnlMenu.Controls.Add(button8);
            pnlMenu.Controls.Add(button7);
            pnlMenu.Controls.Add(button6);
            pnlMenu.Controls.Add(button5);
            pnlMenu.Controls.Add(button4);
            pnlMenu.Controls.Add(button3);
            pnlMenu.Controls.Add(button2);
            pnlMenu.Controls.Add(button1);
            pnlMenu.Dock = DockStyle.Fill;
            pnlMenu.Location = new Point(0, 70);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(250, 730);
            pnlMenu.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblRole);
            panel1.Controls.Add(lblFullName);
            panel1.Controls.Add(lblAvatar);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 660);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 70);
            panel1.TabIndex = 8;
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRole.ForeColor = Color.DimGray;
            lblRole.Location = new Point(83, 38);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(52, 21);
            lblRole.TabIndex = 2;
            lblRole.Text = "label3";
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.ForeColor = Color.Black;
            lblFullName.Location = new Point(83, 13);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(59, 25);
            lblFullName.TabIndex = 1;
            lblFullName.Text = "label3";
            // 
            // lblAvatar
            // 
            lblAvatar.BackColor = Color.FromArgb(28, 98, 242);
            lblAvatar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblAvatar.ForeColor = Color.White;
            lblAvatar.Location = new Point(22, 16);
            lblAvatar.Name = "lblAvatar";
            lblAvatar.Size = new Size(40, 40);
            lblAvatar.TabIndex = 0;
            lblAvatar.Text = "JA";
            lblAvatar.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button8
            // 
            button8.BackColor = Color.White;
            button8.Dock = DockStyle.Top;
            button8.FlatAppearance.BorderSize = 0;
            button8.ForeColor = Color.Black;
            button8.Location = new Point(0, 350);
            button8.Name = "button8";
            button8.Padding = new Padding(20, 0, 0, 0);
            button8.Size = new Size(250, 50);
            button8.TabIndex = 7;
            button8.Text = "Reports";
            button8.TextAlign = ContentAlignment.MiddleLeft;
            button8.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            button7.BackColor = Color.White;
            button7.Dock = DockStyle.Top;
            button7.FlatAppearance.BorderSize = 0;
            button7.ForeColor = Color.Black;
            button7.Location = new Point(0, 300);
            button7.Name = "button7";
            button7.Padding = new Padding(20, 0, 0, 0);
            button7.Size = new Size(250, 50);
            button7.TabIndex = 6;
            button7.Text = "Employees";
            button7.TextAlign = ContentAlignment.MiddleLeft;
            button7.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = Color.White;
            button6.Dock = DockStyle.Top;
            button6.FlatAppearance.BorderSize = 0;
            button6.ForeColor = Color.Black;
            button6.Location = new Point(0, 250);
            button6.Name = "button6";
            button6.Padding = new Padding(20, 0, 0, 0);
            button6.Size = new Size(250, 50);
            button6.TabIndex = 5;
            button6.Text = "Promotions";
            button6.TextAlign = ContentAlignment.MiddleLeft;
            button6.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.White;
            button5.Dock = DockStyle.Top;
            button5.FlatAppearance.BorderSize = 0;
            button5.ForeColor = Color.Black;
            button5.Location = new Point(0, 200);
            button5.Name = "button5";
            button5.Padding = new Padding(20, 0, 0, 0);
            button5.Size = new Size(250, 50);
            button5.TabIndex = 4;
            button5.Text = "Customers";
            button5.TextAlign = ContentAlignment.MiddleLeft;
            button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.White;
            button4.Dock = DockStyle.Top;
            button4.FlatAppearance.BorderSize = 0;
            button4.ForeColor = Color.Black;
            button4.Location = new Point(0, 150);
            button4.Name = "button4";
            button4.Padding = new Padding(20, 0, 0, 0);
            button4.Size = new Size(250, 50);
            button4.TabIndex = 3;
            button4.Text = "Inventory";
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.Dock = DockStyle.Top;
            button3.FlatAppearance.BorderSize = 0;
            button3.ForeColor = Color.Black;
            button3.Location = new Point(0, 100);
            button3.Name = "button3";
            button3.Padding = new Padding(20, 0, 0, 0);
            button3.Size = new Size(250, 50);
            button3.TabIndex = 2;
            button3.Text = "Product";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.Dock = DockStyle.Top;
            button2.FlatAppearance.BorderSize = 0;
            button2.ForeColor = Color.Black;
            button2.Location = new Point(0, 50);
            button2.Name = "button2";
            button2.Padding = new Padding(20, 0, 0, 0);
            button2.Size = new Size(250, 50);
            button2.TabIndex = 1;
            button2.Text = "POS";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(28, 98, 242);
            button1.Dock = DockStyle.Top;
            button1.FlatAppearance.BorderSize = 0;
            button1.ForeColor = Color.White;
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Padding = new Padding(20, 0, 0, 0);
            button1.Size = new Size(250, 50);
            button1.TabIndex = 0;
            button1.Text = "Dashboard";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
            // 
            // pnlUser
            // 
            pnlUser.Controls.Add(label1);
            pnlUser.Dock = DockStyle.Top;
            pnlUser.Location = new Point(0, 0);
            pnlUser.Name = "pnlUser";
            pnlUser.Size = new Size(250, 70);
            pnlUser.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(28, 98, 242);
            label1.Location = new Point(56, 10);
            label1.Name = "label1";
            label1.Size = new Size(140, 47);
            label1.TabIndex = 0;
            label1.Text = "StorePOS";
            label1.UseCompatibleTextRendering = true;
            // 
            // pnlMainContent
            // 
            pnlMainContent.AutoScroll = true;
            pnlMainContent.BackColor = Color.FromArgb(240, 245, 250);
            pnlMainContent.Controls.Add(pnlScrollBody);
            pnlMainContent.Controls.Add(panel2);
            pnlMainContent.Dock = DockStyle.Fill;
            pnlMainContent.Location = new Point(250, 0);
            pnlMainContent.Name = "pnlMainContent";
            pnlMainContent.Size = new Size(1150, 800);
            pnlMainContent.TabIndex = 1;
            // 
            // pnlScrollBody
            // 
            pnlScrollBody.AutoScroll = true;
            pnlScrollBody.Controls.Add(pnlChartArea);
            pnlScrollBody.Controls.Add(flowCards);
            pnlScrollBody.Dock = DockStyle.Top;
            pnlScrollBody.Location = new Point(0, 60);
            pnlScrollBody.Name = "pnlScrollBody";
            pnlScrollBody.Size = new Size(1124, 1500);
            pnlScrollBody.TabIndex = 1;
            // 
            // flowCards
            // 
            flowCards.BackColor = Color.White;
            flowCards.Controls.Add(pnlCard1);
            flowCards.Controls.Add(panel5);
            flowCards.Controls.Add(panel4);
            flowCards.Controls.Add(panel3);
            flowCards.Dock = DockStyle.Top;
            flowCards.Location = new Point(0, 0);
            flowCards.Name = "flowCards";
            flowCards.Padding = new Padding(20, 20, 0, 0);
            flowCards.Size = new Size(1124, 180);
            flowCards.TabIndex = 0;
            // 
            // pnlCard1
            // 
            pnlCard1.Controls.Add(label2);
            pnlCard1.Controls.Add(label4);
            pnlCard1.Controls.Add(label3);
            pnlCard1.Location = new Point(23, 23);
            pnlCard1.Margin = new Padding(3, 3, 20, 3);
            pnlCard1.Name = "pnlCard1";
            pnlCard1.Size = new Size(250, 140);
            pnlCard1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(5, 12);
            label2.Name = "label2";
            label2.Size = new Size(229, 45);
            label2.TabIndex = 0;
            label2.Text = "Total Revenue";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 8F);
            label4.ForeColor = Color.Green;
            label4.Location = new Point(33, 116);
            label4.Name = "label4";
            label4.Size = new Size(180, 21);
            label4.TabIndex = 2;
            label4.Text = "+20.1% from last month";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(31, 57);
            label3.Name = "label3";
            label3.Size = new Size(182, 45);
            label3.TabIndex = 1;
            label3.Text = "$45,231.89";
            // 
            // panel5
            // 
            panel5.Controls.Add(label11);
            panel5.Controls.Add(label12);
            panel5.Controls.Add(label13);
            panel5.Location = new Point(296, 23);
            panel5.Margin = new Padding(3, 3, 20, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(250, 140);
            panel5.TabIndex = 6;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label11.ForeColor = Color.Gray;
            label11.Location = new Point(5, 12);
            label11.Name = "label11";
            label11.Size = new Size(229, 45);
            label11.TabIndex = 0;
            label11.Text = "Total Revenue";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 8F);
            label12.ForeColor = Color.Green;
            label12.Location = new Point(33, 116);
            label12.Name = "label12";
            label12.Size = new Size(180, 21);
            label12.TabIndex = 2;
            label12.Text = "+20.1% from last month";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label13.ForeColor = Color.Black;
            label13.Location = new Point(31, 57);
            label13.Name = "label13";
            label13.Size = new Size(182, 45);
            label13.TabIndex = 1;
            label13.Text = "$45,231.89";
            // 
            // panel4
            // 
            panel4.Controls.Add(label8);
            panel4.Controls.Add(label9);
            panel4.Controls.Add(label10);
            panel4.Location = new Point(569, 23);
            panel4.Margin = new Padding(3, 3, 20, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(250, 140);
            panel4.TabIndex = 5;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label8.ForeColor = Color.Gray;
            label8.Location = new Point(5, 12);
            label8.Name = "label8";
            label8.Size = new Size(229, 45);
            label8.TabIndex = 0;
            label8.Text = "Total Revenue";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 8F);
            label9.ForeColor = Color.Green;
            label9.Location = new Point(33, 116);
            label9.Name = "label9";
            label9.Size = new Size(180, 21);
            label9.TabIndex = 2;
            label9.Text = "+20.1% from last month";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(31, 57);
            label10.Name = "label10";
            label10.Size = new Size(182, 45);
            label10.TabIndex = 1;
            label10.Text = "$45,231.89";
            // 
            // panel3
            // 
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label7);
            panel3.Location = new Point(842, 23);
            panel3.Margin = new Padding(3, 3, 20, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(250, 140);
            panel3.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label5.ForeColor = Color.Gray;
            label5.Location = new Point(5, 12);
            label5.Name = "label5";
            label5.Size = new Size(229, 45);
            label5.TabIndex = 0;
            label5.Text = "Total Revenue";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 8F);
            label6.ForeColor = Color.Green;
            label6.Location = new Point(33, 116);
            label6.Name = "label6";
            label6.Size = new Size(180, 21);
            label6.TabIndex = 2;
            label6.Text = "+20.1% from last month";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(31, 57);
            label7.Name = "label7";
            label7.Size = new Size(182, 45);
            label7.TabIndex = 1;
            label7.Text = "$45,231.89";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1124, 60);
            panel2.TabIndex = 0;
            // 
            // pnlChartArea
            // 
            pnlChartArea.BackColor = Color.White;
            pnlChartArea.Location = new Point(166, 260);
            pnlChartArea.Name = "pnlChartArea";
            pnlChartArea.Size = new Size(800, 300);
            pnlChartArea.TabIndex = 1;
            // 
            // DashBoardForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            Controls.Add(pnlMainContent);
            Controls.Add(pnlSidebar);
            Name = "DashBoardForm";
            Size = new Size(1400, 800);
            pnlSidebar.ResumeLayout(false);
            pnlMenu.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnlUser.ResumeLayout(false);
            pnlUser.PerformLayout();
            pnlMainContent.ResumeLayout(false);
            pnlScrollBody.ResumeLayout(false);
            flowCards.ResumeLayout(false);
            pnlCard1.ResumeLayout(false);
            pnlCard1.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSidebar;
        private Panel pnlMenu;
        private Button button1;
        private Panel pnlUser;
        private Label label1;
        private Button button8;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Panel panel1;
        private Label lblAvatar;
        private Label lblFullName;
        private Label lblRole;
        private Panel pnlMainContent;
        private Panel panel2;
        private Panel pnlScrollBody;
        private FlowLayoutPanel flowCards;
        private Label label2;
        private Label label3;
        private Label label4;
        private Panel pnlCard1;
        private Panel panel5;
        private Label label11;
        private Label label12;
        private Label label13;
        private Panel panel4;
        private Label label8;
        private Label label9;
        private Label label10;
        private Panel panel3;
        private Label label5;
        private Label label6;
        private Label label7;
        private Panel pnlChartArea;
    }
}
