namespace GetBookPicture
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtURL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStartID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEndID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPrefix = new System.Windows.Forms.TextBox();
            this.txtSavePath = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labCurrentID = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labResidual = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labLost = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labSaved = new System.Windows.Forms.Label();
            this.btnGO = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nudWildLong = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtUrlPrefix1 = new System.Windows.Forms.TextBox();
            this.txtRegex1 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtUrlPrefix2 = new System.Windows.Forms.TextBox();
            this.txtRegex2 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudWildLong)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtURL
            // 
            this.txtURL.BackColor = System.Drawing.SystemColors.Window;
            this.txtURL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtURL.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtURL.Location = new System.Drawing.Point(8, 38);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(371, 21);
            this.txtURL.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "URL: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label2.Location = new System.Drawing.Point(6, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "起始:";
            // 
            // txtStartID
            // 
            this.txtStartID.BackColor = System.Drawing.SystemColors.Window;
            this.txtStartID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStartID.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtStartID.Location = new System.Drawing.Point(8, 90);
            this.txtStartID.Name = "txtStartID";
            this.txtStartID.Size = new System.Drawing.Size(81, 21);
            this.txtStartID.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label3.Location = new System.Drawing.Point(102, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "结束:";
            // 
            // txtEndID
            // 
            this.txtEndID.BackColor = System.Drawing.SystemColors.Window;
            this.txtEndID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEndID.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtEndID.Location = new System.Drawing.Point(105, 90);
            this.txtEndID.Name = "txtEndID";
            this.txtEndID.Size = new System.Drawing.Size(81, 21);
            this.txtEndID.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label4.Location = new System.Drawing.Point(5, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "保存: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label5.Location = new System.Drawing.Point(296, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "文件名前缀:";
            // 
            // txtPrefix
            // 
            this.txtPrefix.BackColor = System.Drawing.SystemColors.Window;
            this.txtPrefix.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrefix.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPrefix.Location = new System.Drawing.Point(299, 90);
            this.txtPrefix.Name = "txtPrefix";
            this.txtPrefix.Size = new System.Drawing.Size(80, 21);
            this.txtPrefix.TabIndex = 8;
            this.txtPrefix.Text = "book_";
            // 
            // txtSavePath
            // 
            this.txtSavePath.BackColor = System.Drawing.SystemColors.Window;
            this.txtSavePath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSavePath.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtSavePath.Location = new System.Drawing.Point(8, 143);
            this.txtSavePath.Name = "txtSavePath";
            this.txtSavePath.Size = new System.Drawing.Size(281, 22);
            this.txtSavePath.TabIndex = 9;
            // 
            // btnBrowse
            // 
            this.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnBrowse.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnBrowse.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnBrowse.Location = new System.Drawing.Point(297, 142);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(82, 26);
            this.btnBrowse.TabIndex = 10;
            this.btnBrowse.Text = "浏览...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.folderBrowserDialog1.SelectedPath = "D:\\Downloads\\test";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(104, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "已保存: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "当前: ";
            // 
            // labCurrentID
            // 
            this.labCurrentID.AutoSize = true;
            this.labCurrentID.Location = new System.Drawing.Point(59, 21);
            this.labCurrentID.Name = "labCurrentID";
            this.labCurrentID.Size = new System.Drawing.Size(13, 13);
            this.labCurrentID.TabIndex = 2;
            this.labCurrentID.Text = "0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labResidual);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.labLost);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.labSaved);
            this.groupBox1.Controls.Add(this.labCurrentID);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.groupBox1.Location = new System.Drawing.Point(17, 491);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(386, 51);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // labResidual
            // 
            this.labResidual.AutoSize = true;
            this.labResidual.Location = new System.Drawing.Point(247, 21);
            this.labResidual.Name = "labResidual";
            this.labResidual.Size = new System.Drawing.Size(13, 13);
            this.labResidual.TabIndex = 7;
            this.labResidual.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(206, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "剩余:";
            // 
            // labLost
            // 
            this.labLost.AutoSize = true;
            this.labLost.Location = new System.Drawing.Point(331, 21);
            this.labLost.Name = "labLost";
            this.labLost.Size = new System.Drawing.Size(13, 13);
            this.labLost.TabIndex = 5;
            this.labLost.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(290, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "失败: ";
            // 
            // labSaved
            // 
            this.labSaved.AutoSize = true;
            this.labSaved.Location = new System.Drawing.Point(160, 21);
            this.labSaved.Name = "labSaved";
            this.labSaved.Size = new System.Drawing.Size(13, 13);
            this.labSaved.TabIndex = 3;
            this.labSaved.Text = "0";
            // 
            // btnGO
            // 
            this.btnGO.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnGO.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnGO.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnGO.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnGO.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnGO.Location = new System.Drawing.Point(41, 555);
            this.btnGO.Name = "btnGO";
            this.btnGO.Size = new System.Drawing.Size(93, 26);
            this.btnGO.TabIndex = 12;
            this.btnGO.Text = "开始";
            this.btnGO.UseVisualStyleBackColor = false;
            this.btnGO.Click += new System.EventHandler(this.btnGO_Click);
            // 
            // btnStop
            // 
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnStop.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnStop.Location = new System.Drawing.Point(162, 555);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(93, 26);
            this.btnStop.TabIndex = 13;
            this.btnStop.Text = "停止";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nudWildLong);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtURL);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtStartID);
            this.groupBox2.Controls.Add(this.btnBrowse);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtSavePath);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtEndID);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtPrefix);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.groupBox2.Location = new System.Drawing.Point(17, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(386, 185);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "设置";
            // 
            // nudWildLong
            // 
            this.nudWildLong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudWildLong.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.nudWildLong.Location = new System.Drawing.Point(202, 89);
            this.nudWildLong.Name = "nudWildLong";
            this.nudWildLong.Size = new System.Drawing.Size(80, 22);
            this.nudWildLong.TabIndex = 12;
            this.nudWildLong.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label13.Location = new System.Drawing.Point(199, 69);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 14);
            this.label13.TabIndex = 11;
            this.label13.Text = "通配符长:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label10.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label10.Location = new System.Drawing.Point(41, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(209, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "( 如: http://junnan.org/down/file(*).htm )";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label14.Location = new System.Drawing.Point(5, 26);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(78, 13);
            this.label14.TabIndex = 11;
            this.label14.Text = "下载URL前缀:";
            // 
            // txtUrlPrefix1
            // 
            this.txtUrlPrefix1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUrlPrefix1.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtUrlPrefix1.Location = new System.Drawing.Point(7, 45);
            this.txtUrlPrefix1.Name = "txtUrlPrefix1";
            this.txtUrlPrefix1.Size = new System.Drawing.Size(371, 21);
            this.txtUrlPrefix1.TabIndex = 12;
            this.txtUrlPrefix1.Enter += new System.EventHandler(this.txtUrlPrefix1_Enter);
            // 
            // txtRegex1
            // 
            this.txtRegex1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRegex1.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtRegex1.Location = new System.Drawing.Point(7, 97);
            this.txtRegex1.Name = "txtRegex1";
            this.txtRegex1.Size = new System.Drawing.Size(371, 21);
            this.txtRegex1.TabIndex = 12;
            this.txtRegex1.Text = "W\\d{21}.jpg";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label15.Location = new System.Drawing.Point(3, 76);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(67, 13);
            this.label15.TabIndex = 13;
            this.label15.Text = "正则表达式";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.txtUrlPrefix1);
            this.groupBox3.Controls.Add(this.txtRegex1);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.groupBox3.Location = new System.Drawing.Point(17, 199);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(386, 139);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "匹配一";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtLog);
            this.groupBox4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.groupBox4.Location = new System.Drawing.Point(411, 7);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(233, 574);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "下载日志";
            // 
            // txtLog
            // 
            this.txtLog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLog.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtLog.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtLog.Location = new System.Drawing.Point(8, 23);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(218, 543);
            this.txtLog.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.txtUrlPrefix2);
            this.groupBox5.Controls.Add(this.txtRegex2);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.groupBox5.Location = new System.Drawing.Point(17, 345);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(386, 139);
            this.groupBox5.TabIndex = 16;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "匹配二";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label11.Location = new System.Drawing.Point(5, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "下载URL前缀:";
            // 
            // txtUrlPrefix2
            // 
            this.txtUrlPrefix2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUrlPrefix2.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtUrlPrefix2.Location = new System.Drawing.Point(7, 45);
            this.txtUrlPrefix2.Name = "txtUrlPrefix2";
            this.txtUrlPrefix2.Size = new System.Drawing.Size(371, 21);
            this.txtUrlPrefix2.TabIndex = 12;
            this.txtUrlPrefix2.Text = "http://www.pep.com.cn/oldimages/";
            // 
            // txtRegex2
            // 
            this.txtRegex2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRegex2.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtRegex2.Location = new System.Drawing.Point(7, 97);
            this.txtRegex2.Name = "txtRegex2";
            this.txtRegex2.Size = new System.Drawing.Size(371, 21);
            this.txtRegex2.TabIndex = 12;
            this.txtRegex2.Text = "pic_\\d{6}.jpg";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label12.Location = new System.Drawing.Point(3, 76);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 13);
            this.label12.TabIndex = 13;
            this.label12.Text = "正则表达式";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.button1.Location = new System.Drawing.Point(283, 555);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 26);
            this.button1.TabIndex = 13;
            this.button1.Text = "关于";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 597);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnGO);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "人民教育出版社课本下载器 v1.3";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudWildLong)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStartID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEndID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPrefix;
        private System.Windows.Forms.TextBox txtSavePath;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labCurrentID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGO;
		private System.Windows.Forms.Label labSaved;
		private System.Windows.Forms.Button btnStop;
		private System.Windows.Forms.Label labLost;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label labResidual;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.TextBox txtRegex1;
		private System.Windows.Forms.TextBox txtUrlPrefix1;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.TextBox txtLog;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox txtUrlPrefix2;
		private System.Windows.Forms.TextBox txtRegex2;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.NumericUpDown nudWildLong;
    }
}

