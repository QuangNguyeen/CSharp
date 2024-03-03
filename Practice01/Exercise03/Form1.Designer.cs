namespace Exercise03
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
            this.components = new System.ComponentModel.Container();
            this.textFirstNumber = new System.Windows.Forms.TextBox();
            this.textSecondNumber = new System.Windows.Forms.TextBox();
            this.groupOption = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radioAdd = new System.Windows.Forms.RadioButton();
            this.radioSub = new System.Windows.Forms.RadioButton();
            this.radioMul = new System.Windows.Forms.RadioButton();
            this.radioDiv = new System.Windows.Forms.RadioButton();
            this.textResult = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupOption.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // textFirstNumber
            // 
            this.textFirstNumber.Location = new System.Drawing.Point(133, 23);
            this.textFirstNumber.Name = "textFirstNumber";
            this.textFirstNumber.Size = new System.Drawing.Size(244, 20);
            this.textFirstNumber.TabIndex = 0;
            this.textFirstNumber.TextChanged += new System.EventHandler(this.textFirstNumber_TextChanged);
            // 
            // textSecondNumber
            // 
            this.textSecondNumber.Location = new System.Drawing.Point(133, 59);
            this.textSecondNumber.Name = "textSecondNumber";
            this.textSecondNumber.Size = new System.Drawing.Size(244, 20);
            this.textSecondNumber.TabIndex = 1;
            this.textSecondNumber.TextChanged += new System.EventHandler(this.textSecondNumber_TextChanged);
            // 
            // groupOption
            // 
            this.groupOption.BackColor = System.Drawing.Color.MediumAquamarine;
            this.groupOption.Controls.Add(this.radioDiv);
            this.groupOption.Controls.Add(this.radioAdd);
            this.groupOption.Controls.Add(this.radioSub);
            this.groupOption.Controls.Add(this.radioMul);
            this.groupOption.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupOption.ForeColor = System.Drawing.Color.Black;
            this.groupOption.Location = new System.Drawing.Point(41, 96);
            this.groupOption.Name = "groupOption";
            this.groupOption.Size = new System.Drawing.Size(336, 65);
            this.groupOption.TabIndex = 2;
            this.groupOption.TabStop = false;
            this.groupOption.Text = "CALCULATION";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "First Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Second Number";
            // 
            // radioAdd
            // 
            this.radioAdd.AutoSize = true;
            this.radioAdd.Location = new System.Drawing.Point(34, 29);
            this.radioAdd.Name = "radioAdd";
            this.radioAdd.Size = new System.Drawing.Size(44, 17);
            this.radioAdd.TabIndex = 0;
            this.radioAdd.TabStop = true;
            this.radioAdd.Text = "Add";
            this.radioAdd.UseVisualStyleBackColor = true;
            this.radioAdd.CheckedChanged += new System.EventHandler(this.radioAdd_CheckedChanged);
            // 
            // radioSub
            // 
            this.radioSub.AutoSize = true;
            this.radioSub.Location = new System.Drawing.Point(102, 29);
            this.radioSub.Name = "radioSub";
            this.radioSub.Size = new System.Drawing.Size(44, 17);
            this.radioSub.TabIndex = 1;
            this.radioSub.TabStop = true;
            this.radioSub.Text = "Sub";
            this.radioSub.UseVisualStyleBackColor = true;
            this.radioSub.CheckedChanged += new System.EventHandler(this.radioSub_CheckedChanged);
            // 
            // radioMul
            // 
            this.radioMul.AutoSize = true;
            this.radioMul.Location = new System.Drawing.Point(176, 29);
            this.radioMul.Name = "radioMul";
            this.radioMul.Size = new System.Drawing.Size(42, 17);
            this.radioMul.TabIndex = 2;
            this.radioMul.TabStop = true;
            this.radioMul.Text = "Mul";
            this.radioMul.UseVisualStyleBackColor = true;
            this.radioMul.CheckedChanged += new System.EventHandler(this.radioMul_CheckedChanged);
            // 
            // radioDiv
            // 
            this.radioDiv.AutoSize = true;
            this.radioDiv.Location = new System.Drawing.Point(254, 29);
            this.radioDiv.Name = "radioDiv";
            this.radioDiv.Size = new System.Drawing.Size(41, 17);
            this.radioDiv.TabIndex = 3;
            this.radioDiv.TabStop = true;
            this.radioDiv.Text = "Div";
            this.radioDiv.UseVisualStyleBackColor = true;
            this.radioDiv.CheckedChanged += new System.EventHandler(this.radioDiv_CheckedChanged);
            // 
            // textResult
            // 
            this.textResult.Location = new System.Drawing.Point(133, 178);
            this.textResult.Name = "textResult";
            this.textResult.Size = new System.Drawing.Size(244, 20);
            this.textResult.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Result";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 243);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textResult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupOption);
            this.Controls.Add(this.textSecondNumber);
            this.Controls.Add(this.textFirstNumber);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simple Calculator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.groupOption.ResumeLayout(false);
            this.groupOption.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textFirstNumber;
        private System.Windows.Forms.TextBox textSecondNumber;
        private System.Windows.Forms.GroupBox groupOption;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioAdd;
        private System.Windows.Forms.RadioButton radioSub;
        private System.Windows.Forms.RadioButton radioMul;
        private System.Windows.Forms.RadioButton radioDiv;
        private System.Windows.Forms.TextBox textResult;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}

