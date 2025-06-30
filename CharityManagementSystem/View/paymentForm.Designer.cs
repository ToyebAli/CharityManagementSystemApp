namespace CharityManagementSystem.View
{
    partial class paymentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(paymentForm));
            this.label3 = new System.Windows.Forms.Label();
            this.lowestAmount = new System.Windows.Forms.RadioButton();
            this.middleAmount = new System.Windows.Forms.RadioButton();
            this.highestAmount = new System.Windows.Forms.RadioButton();
            this.confirm = new System.Windows.Forms.Button();
            this.bkash = new System.Windows.Forms.Button();
            this.nagad = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(56, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Payment Amount:";
            // 
            // lowestAmount
            // 
            this.lowestAmount.AutoSize = true;
            this.lowestAmount.BackColor = System.Drawing.Color.Transparent;
            this.lowestAmount.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lowestAmount.Location = new System.Drawing.Point(196, 120);
            this.lowestAmount.Name = "lowestAmount";
            this.lowestAmount.Size = new System.Drawing.Size(116, 28);
            this.lowestAmount.TabIndex = 5;
            this.lowestAmount.Text = "5000 BDT";
            this.lowestAmount.UseVisualStyleBackColor = false;
            this.lowestAmount.CheckedChanged += new System.EventHandler(this.lowestAmount_CheckedChanged);
            // 
            // middleAmount
            // 
            this.middleAmount.AutoSize = true;
            this.middleAmount.BackColor = System.Drawing.Color.Transparent;
            this.middleAmount.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.middleAmount.Location = new System.Drawing.Point(344, 120);
            this.middleAmount.Name = "middleAmount";
            this.middleAmount.Size = new System.Drawing.Size(123, 28);
            this.middleAmount.TabIndex = 6;
            this.middleAmount.Text = "10000 BDT";
            this.middleAmount.UseVisualStyleBackColor = false;
            this.middleAmount.CheckedChanged += new System.EventHandler(this.middleAmount_CheckedChanged);
            // 
            // highestAmount
            // 
            this.highestAmount.AutoSize = true;
            this.highestAmount.BackColor = System.Drawing.Color.Transparent;
            this.highestAmount.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highestAmount.Location = new System.Drawing.Point(490, 120);
            this.highestAmount.Name = "highestAmount";
            this.highestAmount.Size = new System.Drawing.Size(126, 28);
            this.highestAmount.TabIndex = 7;
            this.highestAmount.Text = "20000 BDT";
            this.highestAmount.UseVisualStyleBackColor = false;
            this.highestAmount.CheckedChanged += new System.EventHandler(this.highestAmount_CheckedChanged_1);
            // 
            // confirm
            // 
            this.confirm.BackColor = System.Drawing.Color.LimeGreen;
            this.confirm.Font = new System.Drawing.Font("Bahnschrift SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirm.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.confirm.Location = new System.Drawing.Point(296, 453);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(248, 51);
            this.confirm.TabIndex = 8;
            this.confirm.Text = "Confirm Payment";
            this.confirm.UseVisualStyleBackColor = false;
            this.confirm.Click += new System.EventHandler(this.confirm_Click);
            // 
            // bkash
            // 
            this.bkash.Image = ((System.Drawing.Image)(resources.GetObject("bkash.Image")));
            this.bkash.Location = new System.Drawing.Point(58, 215);
            this.bkash.Name = "bkash";
            this.bkash.Size = new System.Drawing.Size(64, 60);
            this.bkash.TabIndex = 9;
            this.bkash.UseVisualStyleBackColor = true;
            this.bkash.Click += new System.EventHandler(this.bkash_Click);
            // 
            // nagad
            // 
            this.nagad.Image = ((System.Drawing.Image)(resources.GetObject("nagad.Image")));
            this.nagad.Location = new System.Drawing.Point(128, 215);
            this.nagad.Name = "nagad";
            this.nagad.Size = new System.Drawing.Size(60, 60);
            this.nagad.TabIndex = 10;
            this.nagad.UseVisualStyleBackColor = true;
            this.nagad.Click += new System.EventHandler(this.nagad_Click);
            // 
            // button3
            // 
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(194, 215);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(62, 60);
            this.button3.TabIndex = 11;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(223, 52);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(197, 30);
            this.textBox1.TabIndex = 13;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.Color.Transparent;
            this.radioButton1.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(58, 120);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(112, 28);
            this.radioButton1.TabIndex = 15;
            this.radioButton1.Text = "1000 BDT";
            this.radioButton1.UseVisualStyleBackColor = false;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 23);
            this.label1.TabIndex = 16;
            this.label1.Text = "Payment Method:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(54, 312);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 23);
            this.label2.TabIndex = 17;
            this.label2.Text = "Phone Number:";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(223, 307);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(197, 30);
            this.textBox2.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(56, 365);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 23);
            this.label4.TabIndex = 19;
            this.label4.Text = "Pin:";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(223, 358);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(197, 30);
            this.textBox3.TabIndex = 20;
            // 
            // paymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(814, 516);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.nagad);
            this.Controls.Add(this.bkash);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.highestAmount);
            this.Controls.Add(this.middleAmount);
            this.Controls.Add(this.lowestAmount);
            this.Controls.Add(this.label3);
            this.MaximizeBox = false;
            this.Name = "paymentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "paymentForm";
            this.Load += new System.EventHandler(this.paymentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton lowestAmount;
        private System.Windows.Forms.RadioButton middleAmount;
        private System.Windows.Forms.RadioButton highestAmount;
        private System.Windows.Forms.Button confirm;
        private System.Windows.Forms.Button bkash;
        private System.Windows.Forms.Button nagad;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
    }
}