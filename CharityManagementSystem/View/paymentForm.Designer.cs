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
            this.paymentTextBOX = new System.Windows.Forms.TextBox();
            this.amount = new System.Windows.Forms.Label();
            this.lowestAmount = new System.Windows.Forms.RadioButton();
            this.middleAmount = new System.Windows.Forms.RadioButton();
            this.highestAmount = new System.Windows.Forms.RadioButton();
            this.confirm = new System.Windows.Forms.Button();
            this.bkash = new System.Windows.Forms.Button();
            this.nagad = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.enter = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // paymentTextBOX
            // 
            this.paymentTextBOX.BackColor = System.Drawing.Color.WhiteSmoke;
            this.paymentTextBOX.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.paymentTextBOX.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentTextBOX.Location = new System.Drawing.Point(60, 342);
            this.paymentTextBOX.Name = "paymentTextBOX";
            this.paymentTextBOX.Size = new System.Drawing.Size(198, 27);
            this.paymentTextBOX.TabIndex = 0;
            this.paymentTextBOX.Text = "  Payment Method";
            // 
            // amount
            // 
            this.amount.AutoSize = true;
            this.amount.BackColor = System.Drawing.Color.Transparent;
            this.amount.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amount.Location = new System.Drawing.Point(54, 92);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(230, 32);
            this.amount.TabIndex = 4;
            this.amount.Text = "Payment Amount:";
            // 
            // lowestAmount
            // 
            this.lowestAmount.AutoSize = true;
            this.lowestAmount.BackColor = System.Drawing.Color.Transparent;
            this.lowestAmount.Font = new System.Drawing.Font("Bahnschrift", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lowestAmount.Location = new System.Drawing.Point(331, 143);
            this.lowestAmount.Name = "lowestAmount";
            this.lowestAmount.Size = new System.Drawing.Size(182, 45);
            this.lowestAmount.TabIndex = 5;
            this.lowestAmount.TabStop = true;
            this.lowestAmount.Text = "5000 BDT";
            this.lowestAmount.UseVisualStyleBackColor = false;
            // 
            // middleAmount
            // 
            this.middleAmount.AutoSize = true;
            this.middleAmount.BackColor = System.Drawing.Color.Transparent;
            this.middleAmount.Font = new System.Drawing.Font("Bahnschrift", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.middleAmount.Location = new System.Drawing.Point(331, 194);
            this.middleAmount.Name = "middleAmount";
            this.middleAmount.Size = new System.Drawing.Size(192, 45);
            this.middleAmount.TabIndex = 6;
            this.middleAmount.TabStop = true;
            this.middleAmount.Text = "10000 BDT";
            this.middleAmount.UseVisualStyleBackColor = false;
            // 
            // highestAmount
            // 
            this.highestAmount.AutoSize = true;
            this.highestAmount.BackColor = System.Drawing.Color.Transparent;
            this.highestAmount.Font = new System.Drawing.Font("Bahnschrift", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highestAmount.Location = new System.Drawing.Point(331, 245);
            this.highestAmount.Name = "highestAmount";
            this.highestAmount.Size = new System.Drawing.Size(199, 45);
            this.highestAmount.TabIndex = 7;
            this.highestAmount.TabStop = true;
            this.highestAmount.Text = "20000 BDT";
            this.highestAmount.UseVisualStyleBackColor = false;
            // 
            // confirm
            // 
            this.confirm.BackColor = System.Drawing.Color.LimeGreen;
            this.confirm.Font = new System.Drawing.Font("Bahnschrift SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirm.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.confirm.Location = new System.Drawing.Point(569, 365);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(216, 56);
            this.confirm.TabIndex = 8;
            this.confirm.Text = "Confirm Payment";
            this.confirm.UseVisualStyleBackColor = false;
            this.confirm.Click += new System.EventHandler(this.confirm_Click);
            // 
            // bkash
            // 
            this.bkash.Image = ((System.Drawing.Image)(resources.GetObject("bkash.Image")));
            this.bkash.Location = new System.Drawing.Point(60, 375);
            this.bkash.Name = "bkash";
            this.bkash.Size = new System.Drawing.Size(64, 60);
            this.bkash.TabIndex = 9;
            this.bkash.UseVisualStyleBackColor = true;
            // 
            // nagad
            // 
            this.nagad.Image = ((System.Drawing.Image)(resources.GetObject("nagad.Image")));
            this.nagad.Location = new System.Drawing.Point(130, 375);
            this.nagad.Name = "nagad";
            this.nagad.Size = new System.Drawing.Size(60, 60);
            this.nagad.TabIndex = 10;
            this.nagad.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(196, 375);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(62, 60);
            this.button3.TabIndex = 11;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // enter
            // 
            this.enter.AutoSize = true;
            this.enter.BackColor = System.Drawing.Color.Transparent;
            this.enter.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enter.Location = new System.Drawing.Point(338, 337);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(185, 32);
            this.enter.TabIndex = 12;
            this.enter.Text = "Total Amount:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(333, 376);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(197, 45);
            this.textBox1.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(60, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 33);
            this.button1.TabIndex = 14;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.Color.Transparent;
            this.radioButton1.Font = new System.Drawing.Font("Bahnschrift", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(331, 92);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(174, 45);
            this.radioButton1.TabIndex = 15;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "1000 BDT";
            this.radioButton1.UseVisualStyleBackColor = false;
            // 
            // paymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(814, 516);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.enter);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.nagad);
            this.Controls.Add(this.bkash);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.highestAmount);
            this.Controls.Add(this.middleAmount);
            this.Controls.Add(this.lowestAmount);
            this.Controls.Add(this.amount);
            this.Controls.Add(this.paymentTextBOX);
            this.Name = "paymentForm";
            this.Text = "paymentForm";
            this.Load += new System.EventHandler(this.paymentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox paymentTextBOX;
        private System.Windows.Forms.Label amount;
        private System.Windows.Forms.RadioButton lowestAmount;
        private System.Windows.Forms.RadioButton middleAmount;
        private System.Windows.Forms.RadioButton highestAmount;
        private System.Windows.Forms.Button confirm;
        private System.Windows.Forms.Button bkash;
        private System.Windows.Forms.Button nagad;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label enter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}