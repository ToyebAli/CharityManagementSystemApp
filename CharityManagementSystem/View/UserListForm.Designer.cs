namespace CharityManagementSystem.View
{
    partial class UserListForm
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
            this.name = new System.Windows.Forms.Label();
            this.age = new System.Windows.Forms.Label();
            this.number = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.Label();
            this.profession = new System.Windows.Forms.Label();
            this.namebox = new System.Windows.Forms.TextBox();
            this.numberbox = new System.Windows.Forms.TextBox();
            this.addressbox = new System.Windows.Forms.TextBox();
            this.agebox = new System.Windows.Forms.TextBox();
            this.emailbox = new System.Windows.Forms.TextBox();
            this.professionbox = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.approve = new System.Windows.Forms.Button();
            this.reject = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Button();
            this.refresh = new System.Windows.Forms.Button();
            this.gridview = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridview)).BeginInit();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.name.Location = new System.Drawing.Point(32, 37);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(119, 25);
            this.name.TabIndex = 0;
            this.name.Text = "User Name";
            // 
            // age
            // 
            this.age.AutoSize = true;
            this.age.BackColor = System.Drawing.Color.Transparent;
            this.age.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.age.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.age.Location = new System.Drawing.Point(447, 37);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(51, 25);
            this.age.TabIndex = 1;
            this.age.Text = "Age";
            // 
            // number
            // 
            this.number.AutoSize = true;
            this.number.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.number.Location = new System.Drawing.Point(32, 133);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(155, 25);
            this.number.TabIndex = 2;
            this.number.Text = "Phone Number";
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.email.Location = new System.Drawing.Point(447, 133);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(89, 25);
            this.email.TabIndex = 3;
            this.email.Text = "Email Id";
            // 
            // address
            // 
            this.address.AutoSize = true;
            this.address.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.address.Location = new System.Drawing.Point(32, 237);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(92, 25);
            this.address.TabIndex = 4;
            this.address.Text = "Address";
            // 
            // profession
            // 
            this.profession.AutoSize = true;
            this.profession.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profession.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.profession.Location = new System.Drawing.Point(447, 233);
            this.profession.Name = "profession";
            this.profession.Size = new System.Drawing.Size(114, 25);
            this.profession.TabIndex = 5;
            this.profession.Text = "Profession";
            // 
            // namebox
            // 
            this.namebox.Location = new System.Drawing.Point(212, 37);
            this.namebox.Name = "namebox";
            this.namebox.Size = new System.Drawing.Size(164, 22);
            this.namebox.TabIndex = 6;
            // 
            // numberbox
            // 
            this.numberbox.Location = new System.Drawing.Point(212, 133);
            this.numberbox.Name = "numberbox";
            this.numberbox.Size = new System.Drawing.Size(164, 22);
            this.numberbox.TabIndex = 7;
            // 
            // addressbox
            // 
            this.addressbox.Location = new System.Drawing.Point(212, 237);
            this.addressbox.Name = "addressbox";
            this.addressbox.Size = new System.Drawing.Size(164, 22);
            this.addressbox.TabIndex = 8;
            // 
            // agebox
            // 
            this.agebox.Location = new System.Drawing.Point(582, 37);
            this.agebox.Name = "agebox";
            this.agebox.Size = new System.Drawing.Size(156, 22);
            this.agebox.TabIndex = 9;
            // 
            // emailbox
            // 
            this.emailbox.Location = new System.Drawing.Point(582, 133);
            this.emailbox.Name = "emailbox";
            this.emailbox.Size = new System.Drawing.Size(156, 22);
            this.emailbox.TabIndex = 10;
            // 
            // professionbox
            // 
            this.professionbox.Location = new System.Drawing.Point(582, 233);
            this.professionbox.Name = "professionbox";
            this.professionbox.Size = new System.Drawing.Size(156, 22);
            this.professionbox.TabIndex = 11;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(37, 308);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 38);
            this.add.TabIndex = 12;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(170, 308);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 38);
            this.delete.TabIndex = 13;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            // 
            // approve
            // 
            this.approve.Location = new System.Drawing.Point(301, 308);
            this.approve.Name = "approve";
            this.approve.Size = new System.Drawing.Size(75, 38);
            this.approve.TabIndex = 14;
            this.approve.Text = "Approve";
            this.approve.UseVisualStyleBackColor = true;
            // 
            // reject
            // 
            this.reject.Location = new System.Drawing.Point(431, 308);
            this.reject.Name = "reject";
            this.reject.Size = new System.Drawing.Size(75, 38);
            this.reject.TabIndex = 15;
            this.reject.Text = "Reject";
            this.reject.UseVisualStyleBackColor = true;
            // 
            // edit
            // 
            this.edit.Location = new System.Drawing.Point(567, 308);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(75, 38);
            this.edit.TabIndex = 16;
            this.edit.Text = "Edit";
            this.edit.UseVisualStyleBackColor = true;
            // 
            // refresh
            // 
            this.refresh.Location = new System.Drawing.Point(700, 308);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(75, 38);
            this.refresh.TabIndex = 17;
            this.refresh.Text = "Refresh";
            this.refresh.UseVisualStyleBackColor = true;
            // 
            // gridview
            // 
            this.gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridview.Location = new System.Drawing.Point(32, 361);
            this.gridview.Name = "gridview";
            this.gridview.RowHeadersWidth = 51;
            this.gridview.RowTemplate.Height = 24;
            this.gridview.Size = new System.Drawing.Size(743, 176);
            this.gridview.TabIndex = 18;
            // 
            // UserListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(800, 549);
            this.Controls.Add(this.gridview);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.reject);
            this.Controls.Add(this.approve);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.add);
            this.Controls.Add(this.professionbox);
            this.Controls.Add(this.emailbox);
            this.Controls.Add(this.agebox);
            this.Controls.Add(this.addressbox);
            this.Controls.Add(this.numberbox);
            this.Controls.Add(this.namebox);
            this.Controls.Add(this.profession);
            this.Controls.Add(this.address);
            this.Controls.Add(this.email);
            this.Controls.Add(this.number);
            this.Controls.Add(this.age);
            this.Controls.Add(this.name);
            this.Name = "UserListForm";
            this.Text = "UserListForm";
            this.Load += new System.EventHandler(this.UserListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label age;
        private System.Windows.Forms.Label number;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label address;
        private System.Windows.Forms.Label profession;
        private System.Windows.Forms.TextBox namebox;
        private System.Windows.Forms.TextBox numberbox;
        private System.Windows.Forms.TextBox addressbox;
        private System.Windows.Forms.TextBox agebox;
        private System.Windows.Forms.TextBox emailbox;
        private System.Windows.Forms.TextBox professionbox;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button approve;
        private System.Windows.Forms.Button reject;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.DataGridView gridview;
    }
}