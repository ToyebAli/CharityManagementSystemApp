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
            this.SuspendLayout();
            // 
            // paymentTextBOX
            // 
            this.paymentTextBOX.BackColor = System.Drawing.Color.WhiteSmoke;
            this.paymentTextBOX.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentTextBOX.Location = new System.Drawing.Point(137, 54);
            this.paymentTextBOX.Name = "paymentTextBOX";
            this.paymentTextBOX.Size = new System.Drawing.Size(541, 57);
            this.paymentTextBOX.TabIndex = 0;
            this.paymentTextBOX.Text = "How would you like to pay?";
            // 
            // amount
            // 
            this.amount.AutoSize = true;
            this.amount.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amount.Location = new System.Drawing.Point(116, 278);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(271, 38);
            this.amount.TabIndex = 4;
            this.amount.Text = "Payment Amount";
            // 
            // lowestAmount
            // 
            this.lowestAmount.AutoSize = true;
            this.lowestAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lowestAmount.Location = new System.Drawing.Point(429, 293);
            this.lowestAmount.Name = "lowestAmount";
            this.lowestAmount.Size = new System.Drawing.Size(149, 43);
            this.lowestAmount.TabIndex = 5;
            this.lowestAmount.TabStop = true;
            this.lowestAmount.Text = "5000 tk";
            this.lowestAmount.UseVisualStyleBackColor = true;
            // 
            // middleAmount
            // 
            this.middleAmount.AutoSize = true;
            this.middleAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.middleAmount.Location = new System.Drawing.Point(429, 355);
            this.middleAmount.Name = "middleAmount";
            this.middleAmount.Size = new System.Drawing.Size(168, 43);
            this.middleAmount.TabIndex = 6;
            this.middleAmount.TabStop = true;
            this.middleAmount.Text = "10000 tk";
            this.middleAmount.UseVisualStyleBackColor = true;
            // 
            // highestAmount
            // 
            this.highestAmount.AutoSize = true;
            this.highestAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highestAmount.Location = new System.Drawing.Point(429, 413);
            this.highestAmount.Name = "highestAmount";
            this.highestAmount.Size = new System.Drawing.Size(168, 43);
            this.highestAmount.TabIndex = 7;
            this.highestAmount.TabStop = true;
            this.highestAmount.Text = "20000 tk";
            this.highestAmount.UseVisualStyleBackColor = true;
            // 
            // confirm
            // 
            this.confirm.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirm.Location = new System.Drawing.Point(594, 481);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(338, 80);
            this.confirm.TabIndex = 8;
            this.confirm.Text = "Confirm Payment";
            this.confirm.UseVisualStyleBackColor = true;
            // 
            // bkash
            // 
            this.bkash.Image = ((System.Drawing.Image)(resources.GetObject("bkash.Image")));
            this.bkash.Location = new System.Drawing.Point(162, 166);
            this.bkash.Name = "bkash";
            this.bkash.Size = new System.Drawing.Size(60, 60);
            this.bkash.TabIndex = 9;
            this.bkash.UseVisualStyleBackColor = true;
            // 
            // nagad
            // 
            this.nagad.Image = ((System.Drawing.Image)(resources.GetObject("nagad.Image")));
            this.nagad.Location = new System.Drawing.Point(356, 166);
            this.nagad.Name = "nagad";
            this.nagad.Size = new System.Drawing.Size(60, 60);
            this.nagad.TabIndex = 10;
            this.nagad.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(563, 166);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(60, 60);
            this.button3.TabIndex = 11;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // enter
            // 
            this.enter.AutoSize = true;
            this.enter.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enter.Location = new System.Drawing.Point(685, 296);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(225, 38);
            this.enter.TabIndex = 12;
            this.enter.Text = "Enter Amount";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(702, 355);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(197, 45);
            this.textBox1.TabIndex = 13;
            // 
            // paymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(963, 594);
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
    }
}