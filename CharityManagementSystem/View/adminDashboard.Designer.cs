namespace CharityManagementSystem.View
{
    partial class adminDashboard
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.logOutbtn = new System.Windows.Forms.Button();
            this.viewUserListbtn = new System.Windows.Forms.Button();
            this.Labeltitle = new System.Windows.Forms.Label();
            this.flowLayoutPanelDashboard = new System.Windows.Forms.FlowLayoutPanel();
            this.userShow = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.logOutbtn);
            this.panel1.Controls.Add(this.viewUserListbtn);
            this.panel1.Location = new System.Drawing.Point(0, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(202, 640);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // logOutbtn
            // 
            this.logOutbtn.BackColor = System.Drawing.Color.Aqua;
            this.logOutbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutbtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.logOutbtn.Location = new System.Drawing.Point(12, 10);
            this.logOutbtn.Name = "logOutbtn";
            this.logOutbtn.Size = new System.Drawing.Size(176, 51);
            this.logOutbtn.TabIndex = 1;
            this.logOutbtn.Text = "Log Out";
            this.logOutbtn.UseVisualStyleBackColor = false;
            this.logOutbtn.Click += new System.EventHandler(this.registerbtn_Click);
            // 
            // viewUserListbtn
            // 
            this.viewUserListbtn.BackColor = System.Drawing.Color.Aqua;
            this.viewUserListbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewUserListbtn.Location = new System.Drawing.Point(12, 86);
            this.viewUserListbtn.Name = "viewUserListbtn";
            this.viewUserListbtn.Size = new System.Drawing.Size(176, 80);
            this.viewUserListbtn.TabIndex = 2;
            this.viewUserListbtn.Text = "User List";
            this.viewUserListbtn.UseVisualStyleBackColor = false;
            this.viewUserListbtn.Click += new System.EventHandler(this.viewlistbtn_Click);
            // 
            // Labeltitle
            // 
            this.Labeltitle.AutoSize = true;
            this.Labeltitle.BackColor = System.Drawing.Color.Transparent;
            this.Labeltitle.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Labeltitle.ForeColor = System.Drawing.Color.Black;
            this.Labeltitle.Location = new System.Drawing.Point(218, 14);
            this.Labeltitle.Name = "Labeltitle";
            this.Labeltitle.Size = new System.Drawing.Size(334, 49);
            this.Labeltitle.TabIndex = 1;
            this.Labeltitle.Text = "Admin Dashboard";
            // 
            // flowLayoutPanelDashboard
            // 
            this.flowLayoutPanelDashboard.AutoScroll = true;
            this.flowLayoutPanelDashboard.Location = new System.Drawing.Point(227, 69);
            this.flowLayoutPanelDashboard.Name = "flowLayoutPanelDashboard";
            this.flowLayoutPanelDashboard.Size = new System.Drawing.Size(742, 491);
            this.flowLayoutPanelDashboard.TabIndex = 2;
            // 
            // userShow
            // 
            this.userShow.AutoSize = true;
            this.userShow.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userShow.Location = new System.Drawing.Point(837, 31);
            this.userShow.Name = "userShow";
            this.userShow.Size = new System.Drawing.Size(0, 26);
            this.userShow.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Aqua;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 172);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 79);
            this.button1.TabIndex = 3;
            this.button1.Text = "Donation Record";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Aqua;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(12, 259);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(176, 77);
            this.button2.TabIndex = 4;
            this.button2.Text = "Donation Given Record";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Aqua;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(12, 342);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(176, 79);
            this.button3.TabIndex = 5;
            this.button3.Text = "Volunteer Applied";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // adminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(981, 572);
            this.Controls.Add(this.userShow);
            this.Controls.Add(this.flowLayoutPanelDashboard);
            this.Controls.Add(this.Labeltitle);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "adminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "adminDasboard";
            this.Load += new System.EventHandler(this.adminDasboard_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button logOutbtn;
        private System.Windows.Forms.Button viewUserListbtn;
        private System.Windows.Forms.Label Labeltitle;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelDashboard;
        private System.Windows.Forms.Label userShow;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}