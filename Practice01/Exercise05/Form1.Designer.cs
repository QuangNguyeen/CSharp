namespace Exercise05
{
    partial class frmMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.textWord = new System.Windows.Forms.TextBox();
            this.rbtn_TimesNewRoman = new System.Windows.Forms.RadioButton();
            this.rBtn_Arial = new System.Windows.Forms.RadioButton();
            this.rBtn_Tahoma = new System.Windows.Forms.RadioButton();
            this.rBtn_CourierNew = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnExit = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhap Van Ban";
            // 
            // textWord
            // 
            this.textWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textWord.Location = new System.Drawing.Point(58, 70);
            this.textWord.Multiline = true;
            this.textWord.Name = "textWord";
            this.textWord.Size = new System.Drawing.Size(171, 161);
            this.textWord.TabIndex = 1;
            // 
            // rbtn_TimesNewRoman
            // 
            this.rbtn_TimesNewRoman.AutoSize = true;
            this.rbtn_TimesNewRoman.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_TimesNewRoman.Location = new System.Drawing.Point(3, 3);
            this.rbtn_TimesNewRoman.Name = "rbtn_TimesNewRoman";
            this.rbtn_TimesNewRoman.Size = new System.Drawing.Size(143, 23);
            this.rbtn_TimesNewRoman.TabIndex = 2;
            this.rbtn_TimesNewRoman.TabStop = true;
            this.rbtn_TimesNewRoman.Text = "Times New Roman\r\n";
            this.rbtn_TimesNewRoman.UseVisualStyleBackColor = true;
            this.rbtn_TimesNewRoman.CheckedChanged += new System.EventHandler(this.rBtn_TimesNewRoman_CheckedChanged);
            // 
            // rBtn_Arial
            // 
            this.rBtn_Arial.AutoSize = true;
            this.rBtn_Arial.Location = new System.Drawing.Point(3, 49);
            this.rBtn_Arial.Name = "rBtn_Arial";
            this.rBtn_Arial.Size = new System.Drawing.Size(58, 22);
            this.rBtn_Arial.TabIndex = 3;
            this.rBtn_Arial.TabStop = true;
            this.rBtn_Arial.Text = "Arial";
            this.rBtn_Arial.UseVisualStyleBackColor = true;
            this.rBtn_Arial.CheckedChanged += new System.EventHandler(this.rBtn_Arial_CheckedChanged);
            // 
            // rBtn_Tahoma
            // 
            this.rBtn_Tahoma.AutoSize = true;
            this.rBtn_Tahoma.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBtn_Tahoma.Location = new System.Drawing.Point(3, 91);
            this.rBtn_Tahoma.Name = "rBtn_Tahoma";
            this.rBtn_Tahoma.Size = new System.Drawing.Size(85, 23);
            this.rBtn_Tahoma.TabIndex = 4;
            this.rBtn_Tahoma.TabStop = true;
            this.rBtn_Tahoma.Text = "Tahoma";
            this.rBtn_Tahoma.UseVisualStyleBackColor = true;
            this.rBtn_Tahoma.CheckedChanged += new System.EventHandler(this.rBtn_Tahoma_CheckedChanged);
            // 
            // rBtn_CourierNew
            // 
            this.rBtn_CourierNew.AutoSize = true;
            this.rBtn_CourierNew.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBtn_CourierNew.Location = new System.Drawing.Point(3, 130);
            this.rBtn_CourierNew.Name = "rBtn_CourierNew";
            this.rBtn_CourierNew.Size = new System.Drawing.Size(136, 22);
            this.rBtn_CourierNew.TabIndex = 5;
            this.rBtn_CourierNew.TabStop = true;
            this.rBtn_CourierNew.Text = "Courier New";
            this.rBtn_CourierNew.UseVisualStyleBackColor = true;
            this.rBtn_CourierNew.CheckedChanged += new System.EventHandler(this.rBtn_CourierNew_CheckedChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.rbtn_TimesNewRoman, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.rBtn_CourierNew, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.rBtn_Arial, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.rBtn_Tahoma, 0, 2);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(263, 70);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.85185F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.14815F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(155, 161);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(198, 261);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(89, 33);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Thoat";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExist_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 323);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.textWord);
            this.Controls.Add(this.label1);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangeFont";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textWord;
        private System.Windows.Forms.RadioButton rbtn_TimesNewRoman;
        private System.Windows.Forms.RadioButton rBtn_Arial;
        private System.Windows.Forms.RadioButton rBtn_Tahoma;
        private System.Windows.Forms.RadioButton rBtn_CourierNew;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnExit;
    }
}

