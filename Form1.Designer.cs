namespace WindowsFormsApplication6
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnClose = new System.Windows.Forms.Button();
            this.txbGetUIDh = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.sector1 = new System.Windows.Forms.ComboBox();
            this.block1 = new System.Windows.Forms.ComboBox();
            this.key1 = new System.Windows.Forms.ComboBox();
            this.LoadKey = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Arial Narrow", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(417, 62);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(182, 66);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txbGetUIDh
            // 
            this.txbGetUIDh.Font = new System.Drawing.Font("Arial Narrow", 15F);
            this.txbGetUIDh.Location = new System.Drawing.Point(66, 126);
            this.txbGetUIDh.Margin = new System.Windows.Forms.Padding(4);
            this.txbGetUIDh.Name = "txbGetUIDh";
            this.txbGetUIDh.Size = new System.Drawing.Size(779, 36);
            this.txbGetUIDh.TabIndex = 9;
            this.txbGetUIDh.TextChanged += new System.EventHandler(this.txbGetUIDh_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(862, 121);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 45);
            this.button1.TabIndex = 8;
            this.button1.Text = "Read DATA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnGetUID_Click);
            // 
            // sector1
            // 
            this.sector1.AutoCompleteCustomSource.AddRange(new string[] {
            "0",
            "1",
            "2",
            "3"});
            this.sector1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sector1.FormattingEnabled = true;
            this.sector1.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03"});
            this.sector1.Location = new System.Drawing.Point(66, 60);
            this.sector1.Margin = new System.Windows.Forms.Padding(4);
            this.sector1.Name = "sector1";
            this.sector1.Size = new System.Drawing.Size(160, 32);
            this.sector1.TabIndex = 14;
            this.sector1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // block1
            // 
            this.block1.AutoCompleteCustomSource.AddRange(new string[] {
            "0",
            "1",
            "2",
            "3"});
            this.block1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.block1.FormattingEnabled = true;
            this.block1.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03"});
            this.block1.Location = new System.Drawing.Point(248, 60);
            this.block1.Margin = new System.Windows.Forms.Padding(4);
            this.block1.Name = "block1";
            this.block1.Size = new System.Drawing.Size(160, 32);
            this.block1.TabIndex = 15;
            this.block1.SelectedIndexChanged += new System.EventHandler(this.block1_SelectedIndexChanged);
            // 
            // key1
            // 
            this.key1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.key1.FormattingEnabled = true;
            this.key1.Items.AddRange(new object[] {
            "A",
            "B"});
            this.key1.Location = new System.Drawing.Point(429, 60);
            this.key1.Margin = new System.Windows.Forms.Padding(4);
            this.key1.Name = "key1";
            this.key1.Size = new System.Drawing.Size(160, 32);
            this.key1.TabIndex = 16;
            this.key1.SelectedIndexChanged += new System.EventHandler(this.key1_SelectedIndexChanged);
            // 
            // LoadKey
            // 
            this.LoadKey.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadKey.Location = new System.Drawing.Point(609, 59);
            this.LoadKey.Margin = new System.Windows.Forms.Padding(4);
            this.LoadKey.Name = "LoadKey";
            this.LoadKey.Size = new System.Drawing.Size(363, 30);
            this.LoadKey.TabIndex = 17;
            this.LoadKey.Text = "FFFFFFFFFFFF";
            this.LoadKey.TextChanged += new System.EventHandler(this.LoadKey_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Impact", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(61, 22);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 27);
            this.label3.TabIndex = 18;
            this.label3.Text = "Sector:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Impact", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(243, 22);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 27);
            this.label4.TabIndex = 19;
            this.label4.Text = "Block:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Impact", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(424, 22);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 27);
            this.label5.TabIndex = 20;
            this.label5.Text = "KeyAB:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Impact", 13F);
            this.label6.Location = new System.Drawing.Point(608, 23);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 27);
            this.label6.TabIndex = 21;
            this.label6.Text = "Load Key:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(649, 91);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 15);
            this.label7.TabIndex = 22;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.LoadKey);
            this.panel1.Controls.Add(this.key1);
            this.panel1.Controls.Add(this.block1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.sector1);
            this.panel1.Controls.Add(this.txbGetUIDh);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1165, 185);
            this.panel1.TabIndex = 23;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(150)))), ((int)(((byte)(170)))));
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Location = new System.Drawing.Point(1, 186);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1163, 167);
            this.panel2.TabIndex = 24;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 351);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "RFID Homework1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnClose;
        internal System.Windows.Forms.TextBox txbGetUIDh;
        internal System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox sector1;
        private System.Windows.Forms.ComboBox block1;
        private System.Windows.Forms.ComboBox key1;
        private System.Windows.Forms.TextBox LoadKey;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

