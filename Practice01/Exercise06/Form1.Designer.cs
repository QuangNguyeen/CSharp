namespace Exercise06
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
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rBtn_Philipines = new System.Windows.Forms.RadioButton();
            this.rBtn_Italy = new System.Windows.Forms.RadioButton();
            this.rBtn_USA = new System.Windows.Forms.RadioButton();
            this.rBtn_Vietnam = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Orange;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(540, 61);
            this.button1.TabIndex = 0;
            this.button1.Text = "COUNTRY FLAGS";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rBtn_Philipines);
            this.groupBox1.Controls.Add(this.rBtn_Italy);
            this.groupBox1.Controls.Add(this.rBtn_USA);
            this.groupBox1.Controls.Add(this.rBtn_Vietnam);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft New Tai Lue", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(37, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(155, 172);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Country";
            // 
            // rBtn_Philipines
            // 
            this.rBtn_Philipines.AutoSize = true;
            this.rBtn_Philipines.Location = new System.Drawing.Point(35, 136);
            this.rBtn_Philipines.Name = "rBtn_Philipines";
            this.rBtn_Philipines.Size = new System.Drawing.Size(75, 19);
            this.rBtn_Philipines.TabIndex = 3;
            this.rBtn_Philipines.TabStop = true;
            this.rBtn_Philipines.Text = "Philipines";
            this.rBtn_Philipines.UseVisualStyleBackColor = true;
            this.rBtn_Philipines.CheckedChanged += new System.EventHandler(this.rBtn_Philipines_CheckedChanged);
            // 
            // rBtn_Italy
            // 
            this.rBtn_Italy.AutoSize = true;
            this.rBtn_Italy.Location = new System.Drawing.Point(35, 101);
            this.rBtn_Italy.Name = "rBtn_Italy";
            this.rBtn_Italy.Size = new System.Drawing.Size(57, 19);
            this.rBtn_Italy.TabIndex = 2;
            this.rBtn_Italy.TabStop = true;
            this.rBtn_Italy.Text = "Italian";
            this.rBtn_Italy.UseVisualStyleBackColor = true;
            this.rBtn_Italy.CheckedChanged += new System.EventHandler(this.rBtn_Italy_CheckedChanged);
            // 
            // rBtn_USA
            // 
            this.rBtn_USA.AutoSize = true;
            this.rBtn_USA.Location = new System.Drawing.Point(35, 64);
            this.rBtn_USA.Name = "rBtn_USA";
            this.rBtn_USA.Size = new System.Drawing.Size(46, 19);
            this.rBtn_USA.TabIndex = 1;
            this.rBtn_USA.TabStop = true;
            this.rBtn_USA.Text = "USA";
            this.rBtn_USA.UseVisualStyleBackColor = true;
            this.rBtn_USA.CheckedChanged += new System.EventHandler(this.rBtn_USA_CheckedChanged);
            // 
            // rBtn_Vietnam
            // 
            this.rBtn_Vietnam.AutoSize = true;
            this.rBtn_Vietnam.Location = new System.Drawing.Point(35, 26);
            this.rBtn_Vietnam.Name = "rBtn_Vietnam";
            this.rBtn_Vietnam.Size = new System.Drawing.Size(67, 19);
            this.rBtn_Vietnam.TabIndex = 0;
            this.rBtn_Vietnam.TabStop = true;
            this.rBtn_Vietnam.Text = "Vietnam";
            this.rBtn_Vietnam.UseVisualStyleBackColor = true;
            this.rBtn_Vietnam.CheckedChanged += new System.EventHandler(this.rBtn_Vietnam_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(212, 93);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(282, 172);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 364);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rBtn_Philipines;
        private System.Windows.Forms.RadioButton rBtn_Italy;
        private System.Windows.Forms.RadioButton rBtn_USA;
        private System.Windows.Forms.RadioButton rBtn_Vietnam;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

