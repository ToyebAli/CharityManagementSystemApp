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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminDashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.registerbtn = new System.Windows.Forms.Button();
            this.notificationbtn = new System.Windows.Forms.Button();
            this.paymentrecordsbtn = new System.Windows.Forms.Button();
            this.viewlistbtn = new System.Windows.Forms.Button();
            this.beneficiaryapplicationbtn = new System.Windows.Forms.Button();
            this.volunteerregisbtn = new System.Windows.Forms.Button();
            this.donorregistrationbtn = new System.Windows.Forms.Button();
            this.volunteeringeventsbtn = new System.Windows.Forms.Button();
            this.donationcampaignbtn = new System.Windows.Forms.Button();
            this.dashboardbtn = new System.Windows.Forms.Button();
            this.Labeltitle = new System.Windows.Forms.Label();
            this.Labelamount = new System.Windows.Forms.Label();
            this.amount = new System.Windows.Forms.Label();
            this.campaigns = new System.Windows.Forms.Label();
            this.labeluser = new System.Windows.Forms.Label();
            this.donationpanel = new System.Windows.Forms.Panel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.statistics = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.donationpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.registerbtn);
            this.panel1.Controls.Add(this.notificationbtn);
            this.panel1.Controls.Add(this.paymentrecordsbtn);
            this.panel1.Controls.Add(this.viewlistbtn);
            this.panel1.Controls.Add(this.beneficiaryapplicationbtn);
            this.panel1.Controls.Add(this.volunteerregisbtn);
            this.panel1.Controls.Add(this.donorregistrationbtn);
            this.panel1.Controls.Add(this.volunteeringeventsbtn);
            this.panel1.Controls.Add(this.donationcampaignbtn);
            this.panel1.Controls.Add(this.dashboardbtn);
            this.panel1.Location = new System.Drawing.Point(0, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(202, 640);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // registerbtn
            // 
            this.registerbtn.BackColor = System.Drawing.Color.Aqua;
            this.registerbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerbtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.registerbtn.Location = new System.Drawing.Point(12, 10);
            this.registerbtn.Name = "registerbtn";
            this.registerbtn.Size = new System.Drawing.Size(176, 42);
            this.registerbtn.TabIndex = 1;
            this.registerbtn.Text = "Logout";
            this.registerbtn.UseVisualStyleBackColor = false;
            this.registerbtn.Click += new System.EventHandler(this.registerbtn_Click);
            // 
            // notificationbtn
            // 
            this.notificationbtn.BackColor = System.Drawing.Color.PowderBlue;
            this.notificationbtn.Location = new System.Drawing.Point(12, 513);
            this.notificationbtn.Name = "notificationbtn";
            this.notificationbtn.Size = new System.Drawing.Size(176, 52);
            this.notificationbtn.TabIndex = 3;
            this.notificationbtn.Text = "Send notifications to all users";
            this.notificationbtn.UseVisualStyleBackColor = false;
            // 
            // paymentrecordsbtn
            // 
            this.paymentrecordsbtn.BackColor = System.Drawing.Color.Aqua;
            this.paymentrecordsbtn.Location = new System.Drawing.Point(12, 449);
            this.paymentrecordsbtn.Name = "paymentrecordsbtn";
            this.paymentrecordsbtn.Size = new System.Drawing.Size(176, 58);
            this.paymentrecordsbtn.TabIndex = 2;
            this.paymentrecordsbtn.Text = "Mnitor all donations and payment records ";
            this.paymentrecordsbtn.UseVisualStyleBackColor = false;
            // 
            // viewlistbtn
            // 
            this.viewlistbtn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.viewlistbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewlistbtn.Location = new System.Drawing.Point(12, 382);
            this.viewlistbtn.Name = "viewlistbtn";
            this.viewlistbtn.Size = new System.Drawing.Size(176, 61);
            this.viewlistbtn.TabIndex = 2;
            this.viewlistbtn.Text = "View User List";
            this.viewlistbtn.UseVisualStyleBackColor = false;
            this.viewlistbtn.Click += new System.EventHandler(this.viewlistbtn_Click);
            // 
            // beneficiaryapplicationbtn
            // 
            this.beneficiaryapplicationbtn.BackColor = System.Drawing.Color.LightCyan;
            this.beneficiaryapplicationbtn.Location = new System.Drawing.Point(12, 321);
            this.beneficiaryapplicationbtn.Name = "beneficiaryapplicationbtn";
            this.beneficiaryapplicationbtn.Size = new System.Drawing.Size(176, 55);
            this.beneficiaryapplicationbtn.TabIndex = 2;
            this.beneficiaryapplicationbtn.Text = "Add or reject beneficiary applications";
            this.beneficiaryapplicationbtn.UseVisualStyleBackColor = false;
            // 
            // volunteerregisbtn
            // 
            this.volunteerregisbtn.BackColor = System.Drawing.Color.Turquoise;
            this.volunteerregisbtn.Location = new System.Drawing.Point(12, 261);
            this.volunteerregisbtn.Name = "volunteerregisbtn";
            this.volunteerregisbtn.Size = new System.Drawing.Size(176, 54);
            this.volunteerregisbtn.TabIndex = 2;
            this.volunteerregisbtn.Text = "Approve or reject volunteer registrations";
            this.volunteerregisbtn.UseVisualStyleBackColor = false;
            // 
            // donorregistrationbtn
            // 
            this.donorregistrationbtn.BackColor = System.Drawing.Color.PowderBlue;
            this.donorregistrationbtn.Location = new System.Drawing.Point(12, 208);
            this.donorregistrationbtn.Name = "donorregistrationbtn";
            this.donorregistrationbtn.Size = new System.Drawing.Size(176, 47);
            this.donorregistrationbtn.TabIndex = 2;
            this.donorregistrationbtn.Text = "Approve or reject donor registration";
            this.donorregistrationbtn.UseVisualStyleBackColor = false;
            // 
            // volunteeringeventsbtn
            // 
            this.volunteeringeventsbtn.BackColor = System.Drawing.Color.Cyan;
            this.volunteeringeventsbtn.Location = new System.Drawing.Point(12, 156);
            this.volunteeringeventsbtn.Name = "volunteeringeventsbtn";
            this.volunteeringeventsbtn.Size = new System.Drawing.Size(176, 46);
            this.volunteeringeventsbtn.TabIndex = 2;
            this.volunteeringeventsbtn.Text = "Add, edit or delete volunteering events";
            this.volunteeringeventsbtn.UseVisualStyleBackColor = false;
            // 
            // donationcampaignbtn
            // 
            this.donationcampaignbtn.BackColor = System.Drawing.Color.SkyBlue;
            this.donationcampaignbtn.Location = new System.Drawing.Point(12, 101);
            this.donationcampaignbtn.Name = "donationcampaignbtn";
            this.donationcampaignbtn.Size = new System.Drawing.Size(176, 49);
            this.donationcampaignbtn.TabIndex = 2;
            this.donationcampaignbtn.Text = "Add , edit or delete donation campaigns";
            this.donationcampaignbtn.UseVisualStyleBackColor = false;
            // 
            // dashboardbtn
            // 
            this.dashboardbtn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.dashboardbtn.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardbtn.Location = new System.Drawing.Point(12, 58);
            this.dashboardbtn.Name = "dashboardbtn";
            this.dashboardbtn.Size = new System.Drawing.Size(176, 37);
            this.dashboardbtn.TabIndex = 2;
            this.dashboardbtn.Text = "View Dashboard";
            this.dashboardbtn.UseVisualStyleBackColor = false;
            // 
            // Labeltitle
            // 
            this.Labeltitle.AutoSize = true;
            this.Labeltitle.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Labeltitle.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Labeltitle.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Labeltitle.Location = new System.Drawing.Point(218, 14);
            this.Labeltitle.Name = "Labeltitle";
            this.Labeltitle.Size = new System.Drawing.Size(334, 49);
            this.Labeltitle.TabIndex = 1;
            this.Labeltitle.Text = "Admin Dashboard";
            // 
            // Labelamount
            // 
            this.Labelamount.AutoSize = true;
            this.Labelamount.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Labelamount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Labelamount.Location = new System.Drawing.Point(221, 85);
            this.Labelamount.Name = "Labelamount";
            this.Labelamount.Size = new System.Drawing.Size(214, 32);
            this.Labelamount.TabIndex = 2;
            this.Labelamount.Text = "Total Donation";
            // 
            // amount
            // 
            this.amount.AutoSize = true;
            this.amount.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amount.Location = new System.Drawing.Point(262, 123);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(104, 29);
            this.amount.TabIndex = 3;
            this.amount.Text = "$12,500";
            // 
            // campaigns
            // 
            this.campaigns.AutoSize = true;
            this.campaigns.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.campaigns.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campaigns.Location = new System.Drawing.Point(543, 85);
            this.campaigns.Name = "campaigns";
            this.campaigns.Size = new System.Drawing.Size(284, 32);
            this.campaigns.TabIndex = 4;
            this.campaigns.Text = "Active Campaigns 5";
            // 
            // labeluser
            // 
            this.labeluser.AutoSize = true;
            this.labeluser.BackColor = System.Drawing.Color.LightSteelBlue;
            this.labeluser.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeluser.Location = new System.Drawing.Point(601, 123);
            this.labeluser.Name = "labeluser";
            this.labeluser.Size = new System.Drawing.Size(163, 29);
            this.labeluser.TabIndex = 5;
            this.labeluser.Text = "New User 18";
            // 
            // donationpanel
            // 
            this.donationpanel.BackColor = System.Drawing.Color.Lavender;
            this.donationpanel.Controls.Add(this.pictureBox);
            this.donationpanel.Controls.Add(this.statistics);
            this.donationpanel.Location = new System.Drawing.Point(267, 229);
            this.donationpanel.Name = "donationpanel";
            this.donationpanel.Size = new System.Drawing.Size(609, 267);
            this.donationpanel.TabIndex = 6;
            // 
            // pictureBox
            // 
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.Location = new System.Drawing.Point(3, 143);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(237, 121);
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            // 
            // statistics
            // 
            this.statistics.AutoSize = true;
            this.statistics.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statistics.Location = new System.Drawing.Point(224, 18);
            this.statistics.Name = "statistics";
            this.statistics.Size = new System.Drawing.Size(170, 20);
            this.statistics.TabIndex = 0;
            this.statistics.Text = "Donation Statistics";
            this.statistics.Click += new System.EventHandler(this.statistics_Click);
            // 
            // adminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(981, 572);
            this.Controls.Add(this.donationpanel);
            this.Controls.Add(this.labeluser);
            this.Controls.Add(this.campaigns);
            this.Controls.Add(this.amount);
            this.Controls.Add(this.Labelamount);
            this.Controls.Add(this.Labeltitle);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "adminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "adminDasboard";
            this.Load += new System.EventHandler(this.adminDasboard_Load);
            this.panel1.ResumeLayout(false);
            this.donationpanel.ResumeLayout(false);
            this.donationpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button registerbtn;
        private System.Windows.Forms.Button dashboardbtn;
        private System.Windows.Forms.Button donationcampaignbtn;
        private System.Windows.Forms.Button volunteeringeventsbtn;
        private System.Windows.Forms.Button donorregistrationbtn;
        private System.Windows.Forms.Button viewlistbtn;
        private System.Windows.Forms.Button beneficiaryapplicationbtn;
        private System.Windows.Forms.Button volunteerregisbtn;
        private System.Windows.Forms.Button paymentrecordsbtn;
        private System.Windows.Forms.Button notificationbtn;
        private System.Windows.Forms.Label Labeltitle;
        private System.Windows.Forms.Label Labelamount;
        private System.Windows.Forms.Label amount;
        private System.Windows.Forms.Label campaigns;
        private System.Windows.Forms.Label labeluser;
        private System.Windows.Forms.Panel donationpanel;
        private System.Windows.Forms.Label statistics;
        private System.Windows.Forms.PictureBox pictureBox;
    }
}