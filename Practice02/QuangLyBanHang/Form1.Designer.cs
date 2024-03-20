namespace QuangLyBanHang
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.doiMauToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxMoney = new System.Windows.Forms.TextBox();
            this.buttonPay = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.comboBoxProduct = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridView1.Location = new System.Drawing.Point(371, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(429, 450);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.doiMauToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 48);
            // 
            // doiMauToolStripMenuItem
            // 
            this.doiMauToolStripMenuItem.Name = "doiMauToolStripMenuItem";
            this.doiMauToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.doiMauToolStripMenuItem.Text = "Doi Mau";
            this.doiMauToolStripMenuItem.Click += new System.EventHandler(this.doiMauToolStripMenuItem_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ContextMenuStrip = this.contextMenuStrip1;
            this.label5.Location = new System.Drawing.Point(46, 374);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Tong Tien :";
            // 
            // textBoxMoney
            // 
            this.textBoxMoney.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMoney.ContextMenuStrip = this.contextMenuStrip1;
            this.textBoxMoney.Location = new System.Drawing.Point(114, 371);
            this.textBoxMoney.Name = "textBoxMoney";
            this.textBoxMoney.Size = new System.Drawing.Size(153, 20);
            this.textBoxMoney.TabIndex = 26;
            // 
            // buttonPay
            // 
            this.buttonPay.ContextMenuStrip = this.contextMenuStrip1;
            this.buttonPay.Location = new System.Drawing.Point(114, 301);
            this.buttonPay.Name = "buttonPay";
            this.buttonPay.Size = new System.Drawing.Size(153, 47);
            this.buttonPay.TabIndex = 25;
            this.buttonPay.Text = "Thanh Toan";
            this.buttonPay.UseVisualStyleBackColor = true;
            this.buttonPay.Click += new System.EventHandler(this.buttonPay_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRemove.ContextMenuStrip = this.contextMenuStrip1;
            this.buttonRemove.Location = new System.Drawing.Point(303, 212);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(51, 41);
            this.buttonRemove.TabIndex = 24;
            this.buttonRemove.Text = "<<";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdd.ContextMenuStrip = this.contextMenuStrip1;
            this.buttonAdd.Location = new System.Drawing.Point(303, 149);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(51, 41);
            this.buttonAdd.TabIndex = 23;
            this.buttonAdd.Text = ">>";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ContextMenuStrip = this.contextMenuStrip1;
            this.label4.Location = new System.Drawing.Point(58, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Don gia :";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPrice.ContextMenuStrip = this.contextMenuStrip1;
            this.textBoxPrice.Location = new System.Drawing.Point(114, 255);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(153, 20);
            this.textBoxPrice.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ContextMenuStrip = this.contextMenuStrip1;
            this.label3.Location = new System.Drawing.Point(53, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "So luong :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ContextMenuStrip = this.contextMenuStrip1;
            this.label2.Location = new System.Drawing.Point(50, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Ten Hang:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ContextMenuStrip = this.contextMenuStrip1;
            this.label1.Location = new System.Drawing.Point(45, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Ten Khach:";
            // 
            // buttonCreate
            // 
            this.buttonCreate.ContextMenuStrip = this.contextMenuStrip1;
            this.buttonCreate.Location = new System.Drawing.Point(114, 35);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(153, 47);
            this.buttonCreate.TabIndex = 17;
            this.buttonCreate.Text = "Tao Don Hang";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.ContextMenuStrip = this.contextMenuStrip1;
            this.numericUpDown1.Location = new System.Drawing.Point(114, 197);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 16;
            // 
            // textBoxName
            // 
            this.textBoxName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxName.ContextMenuStrip = this.contextMenuStrip1;
            this.textBoxName.Location = new System.Drawing.Point(114, 102);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(153, 20);
            this.textBoxName.TabIndex = 14;
            // 
            // comboBoxProduct
            // 
            this.comboBoxProduct.ContextMenuStrip = this.contextMenuStrip1;
            this.comboBoxProduct.FormattingEnabled = true;
            this.comboBoxProduct.Location = new System.Drawing.Point(114, 150);
            this.comboBoxProduct.Name = "comboBoxProduct";
            this.comboBoxProduct.Size = new System.Drawing.Size(153, 21);
            this.comboBoxProduct.TabIndex = 28;
            this.comboBoxProduct.SelectedIndexChanged += new System.EventHandler(this.comboBoxProduct_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBoxProduct);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxMoney);
            this.Controls.Add(this.buttonPay);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quann Ly Ban Hang ( Nguyen Van Quang - 2251172466 ) ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxMoney;
        private System.Windows.Forms.Button buttonPay;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.ComboBox comboBoxProduct;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem doiMauToolStripMenuItem;
    }
}

