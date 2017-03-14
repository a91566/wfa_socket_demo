namespace Client
{
    partial class FormClient
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbPort = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbIP = new System.Windows.Forms.TextBox();
            this.btnLink = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txbSend = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnDisconntect = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 115F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 301F));
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.txbPort, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txbIP, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnLink, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txbSend, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnSend, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnDisconntect, 5, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 329F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(774, 457);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // textBox1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.textBox1, 6);
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(3, 103);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(768, 351);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Location = new System.Drawing.Point(172, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "端口号";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txbPort
            // 
            this.txbPort.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbPort.Location = new System.Drawing.Point(257, 7);
            this.txbPort.Name = "txbPort";
            this.txbPort.Size = new System.Drawing.Size(70, 26);
            this.txbPort.TabIndex = 3;
            this.txbPort.Text = "8899";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.Location = new System.Drawing.Point(3, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 27);
            this.label2.TabIndex = 4;
            this.label2.Text = "IP";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txbIP
            // 
            this.txbIP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbIP.Location = new System.Drawing.Point(57, 7);
            this.txbIP.Name = "txbIP";
            this.txbIP.Size = new System.Drawing.Size(109, 26);
            this.txbIP.TabIndex = 5;
            this.txbIP.Text = "127.0.0.1";
            // 
            // btnLink
            // 
            this.btnLink.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLink.Location = new System.Drawing.Point(333, 3);
            this.btnLink.Name = "btnLink";
            this.btnLink.Size = new System.Drawing.Size(62, 34);
            this.btnLink.TabIndex = 6;
            this.btnLink.Text = "连接";
            this.btnLink.UseVisualStyleBackColor = true;
            this.btnLink.Click += new System.EventHandler(this.btnLink_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.Location = new System.Drawing.Point(3, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "消息";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txbSend
            // 
            this.txbSend.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.txbSend, 3);
            this.txbSend.Location = new System.Drawing.Point(57, 43);
            this.txbSend.Multiline = true;
            this.txbSend.Name = "txbSend";
            this.txbSend.Size = new System.Drawing.Size(270, 54);
            this.txbSend.TabIndex = 8;
            this.txbSend.Text = "你能不能告诉我山里有没有住着神仙";
            // 
            // btnSend
            // 
            this.btnSend.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSend.Location = new System.Drawing.Point(333, 53);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(62, 34);
            this.btnSend.TabIndex = 9;
            this.btnSend.Text = "发送";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnDisconntect
            // 
            this.btnDisconntect.Location = new System.Drawing.Point(401, 3);
            this.btnDisconntect.Name = "btnDisconntect";
            this.btnDisconntect.Size = new System.Drawing.Size(96, 34);
            this.btnDisconntect.TabIndex = 10;
            this.btnDisconntect.Text = "断开连接";
            this.btnDisconntect.UseVisualStyleBackColor = true;
            this.btnDisconntect.Click += new System.EventHandler(this.btnDisconntect_Click);
            // 
            // FormClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(774, 457);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormClient";
            this.Text = "客户端";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbIP;
        private System.Windows.Forms.Button btnLink;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbSend;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnDisconntect;
    }
}

