namespace Exercise07
{
    partial class Form1
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
            this.textNumber = new System.Windows.Forms.TextBox();
            this.btn_Update = new System.Windows.Forms.Button();
            this.groupEnterNumber = new System.Windows.Forms.GroupBox();
            this.cB_Number = new System.Windows.Forms.ComboBox();
            this.listBoxDivisors = new System.Windows.Forms.ListBox();
            this.grB_Divisors = new System.Windows.Forms.GroupBox();
            this.btn_SumDivisors = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.groupEnterNumber.SuspendLayout();
            this.grB_Divisors.SuspendLayout();
            this.SuspendLayout();
            // 
            // textNumber
            // 
            this.textNumber.Location = new System.Drawing.Point(6, 19);
            this.textNumber.Name = "textNumber";
            this.textNumber.Size = new System.Drawing.Size(100, 20);
            this.textNumber.TabIndex = 2;
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(119, 16);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(75, 23);
            this.btn_Update.TabIndex = 3;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // groupEnterNumber
            // 
            this.groupEnterNumber.Controls.Add(this.cB_Number);
            this.groupEnterNumber.Controls.Add(this.textNumber);
            this.groupEnterNumber.Controls.Add(this.btn_Update);
            this.groupEnterNumber.Location = new System.Drawing.Point(32, 37);
            this.groupEnterNumber.Name = "groupEnterNumber";
            this.groupEnterNumber.Size = new System.Drawing.Size(200, 95);
            this.groupEnterNumber.TabIndex = 4;
            this.groupEnterNumber.TabStop = false;
            this.groupEnterNumber.Text = "Enter Number";
            // 
            // cB_Number
            // 
            this.cB_Number.FormattingEnabled = true;
            this.cB_Number.Location = new System.Drawing.Point(6, 55);
            this.cB_Number.Name = "cB_Number";
            this.cB_Number.Size = new System.Drawing.Size(188, 21);
            this.cB_Number.TabIndex = 4;
            // 
            // listBoxDivisors
            // 
            this.listBoxDivisors.FormattingEnabled = true;
            this.listBoxDivisors.Location = new System.Drawing.Point(6, 19);
            this.listBoxDivisors.Name = "listBoxDivisors";
            this.listBoxDivisors.Size = new System.Drawing.Size(138, 69);
            this.listBoxDivisors.TabIndex = 5;
            // 
            // grB_Divisors
            // 
            this.grB_Divisors.Controls.Add(this.listBoxDivisors);
            this.grB_Divisors.Location = new System.Drawing.Point(256, 37);
            this.grB_Divisors.Name = "grB_Divisors";
            this.grB_Divisors.Size = new System.Drawing.Size(150, 95);
            this.grB_Divisors.TabIndex = 6;
            this.grB_Divisors.TabStop = false;
            this.grB_Divisors.Text = "List of Divisors";
            // 
            // btn_SumDivisors
            // 
            this.btn_SumDivisors.Location = new System.Drawing.Point(256, 148);
            this.btn_SumDivisors.Name = "btn_SumDivisors";
            this.btn_SumDivisors.Size = new System.Drawing.Size(150, 23);
            this.btn_SumDivisors.TabIndex = 7;
            this.btn_SumDivisors.Text = "Sum of Divisors";
            this.btn_SumDivisors.UseVisualStyleBackColor = true;
            this.btn_SumDivisors.Click += new System.EventHandler(this.btn_SumDivisors_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(256, 177);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "The number of Even divisor";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(256, 206);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "The number of Prime divisor";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(157, 206);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(75, 23);
            this.btn_Exit.TabIndex = 10;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 286);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_SumDivisors);
            this.Controls.Add(this.grB_Divisors);
            this.Controls.Add(this.groupEnterNumber);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.groupEnterNumber.ResumeLayout(false);
            this.groupEnterNumber.PerformLayout();
            this.grB_Divisors.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textNumber;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.GroupBox groupEnterNumber;
        private System.Windows.Forms.ComboBox cB_Number;
        private System.Windows.Forms.ListBox listBoxDivisors;
        private System.Windows.Forms.GroupBox grB_Divisors;
        private System.Windows.Forms.Button btn_SumDivisors;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_Exit;
    }
}

