namespace SerialCom
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
            this.com_label = new System.Windows.Forms.Label();
            this.Set_groupBox = new System.Windows.Forms.GroupBox();
            this.testBTN = new System.Windows.Forms.Button();
            this.stopbitsCtrl = new System.Windows.Forms.ComboBox();
            this.urlTxt = new System.Windows.Forms.TextBox();
            this.serverURLTxt = new System.Windows.Forms.TextBox();
            this.parityCtrl = new System.Windows.Forms.ComboBox();
            this.databitsCtrl = new System.Windows.Forms.ComboBox();
            this.baudrateCtrl = new System.Windows.Forms.ComboBox();
            this.comCtrl = new System.Windows.Forms.ComboBox();
            this.parity_label = new System.Windows.Forms.Label();
            this.stopbits_label = new System.Windows.Forms.Label();
            this.databits_label = new System.Windows.Forms.Label();
            this.baudrate_label = new System.Windows.Forms.Label();
            this.url_label = new System.Windows.Forms.Label();
            this.openBtn = new System.Windows.Forms.Button();
            this.resultTxt = new System.Windows.Forms.TextBox();
            this.resultList = new System.Windows.Forms.ListBox();
            this.resetBtn = new System.Windows.Forms.Button();
            this.average_label = new System.Windows.Forms.Label();
            this.avgTxt = new System.Windows.Forms.TextBox();
            this.averageCtrl = new System.Windows.Forms.ComboBox();
            this.Set_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // com_label
            // 
            this.com_label.AutoSize = true;
            this.com_label.Location = new System.Drawing.Point(16, 62);
            this.com_label.Name = "com_label";
            this.com_label.Size = new System.Drawing.Size(50, 20);
            this.com_label.TabIndex = 0;
            this.com_label.Text = "Port : ";
            // 
            // Set_groupBox
            // 
            this.Set_groupBox.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Set_groupBox.Controls.Add(this.testBTN);
            this.Set_groupBox.Controls.Add(this.stopbitsCtrl);
            this.Set_groupBox.Controls.Add(this.urlTxt);
            this.Set_groupBox.Controls.Add(this.serverURLTxt);
            this.Set_groupBox.Controls.Add(this.parityCtrl);
            this.Set_groupBox.Controls.Add(this.averageCtrl);
            this.Set_groupBox.Controls.Add(this.databitsCtrl);
            this.Set_groupBox.Controls.Add(this.baudrateCtrl);
            this.Set_groupBox.Controls.Add(this.comCtrl);
            this.Set_groupBox.Controls.Add(this.parity_label);
            this.Set_groupBox.Controls.Add(this.stopbits_label);
            this.Set_groupBox.Controls.Add(this.average_label);
            this.Set_groupBox.Controls.Add(this.databits_label);
            this.Set_groupBox.Controls.Add(this.baudrate_label);
            this.Set_groupBox.Controls.Add(this.url_label);
            this.Set_groupBox.Controls.Add(this.com_label);
            this.Set_groupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Set_groupBox.Location = new System.Drawing.Point(12, 285);
            this.Set_groupBox.Name = "Set_groupBox";
            this.Set_groupBox.Size = new System.Drawing.Size(726, 154);
            this.Set_groupBox.TabIndex = 5;
            this.Set_groupBox.TabStop = false;
            this.Set_groupBox.Text = "Serial Port Setting";
            // 
            // testBTN
            // 
            this.testBTN.Location = new System.Drawing.Point(306, 19);
            this.testBTN.Name = "testBTN";
            this.testBTN.Size = new System.Drawing.Size(45, 28);
            this.testBTN.TabIndex = 3;
            this.testBTN.Text = "-->>";
            this.testBTN.UseVisualStyleBackColor = true;
            this.testBTN.Click += new System.EventHandler(this.testBTN_Click);
            // 
            // stopbitsCtrl
            // 
            this.stopbitsCtrl.FormattingEnabled = true;
            this.stopbitsCtrl.Items.AddRange(new object[] {
            "0 stop bit",
            "1 stop bit",
            "2 stop bit",
            "1,5 stop bit"});
            this.stopbitsCtrl.Location = new System.Drawing.Point(330, 105);
            this.stopbitsCtrl.Name = "stopbitsCtrl";
            this.stopbitsCtrl.Size = new System.Drawing.Size(120, 28);
            this.stopbitsCtrl.TabIndex = 1;
            // 
            // urlTxt
            // 
            this.urlTxt.Location = new System.Drawing.Point(358, 20);
            this.urlTxt.Name = "urlTxt";
            this.urlTxt.ReadOnly = true;
            this.urlTxt.Size = new System.Drawing.Size(362, 26);
            this.urlTxt.TabIndex = 2;
            // 
            // serverURLTxt
            // 
            this.serverURLTxt.Location = new System.Drawing.Point(72, 20);
            this.serverURLTxt.Name = "serverURLTxt";
            this.serverURLTxt.Size = new System.Drawing.Size(227, 26);
            this.serverURLTxt.TabIndex = 2;
            this.serverURLTxt.Text = "https://new.kartms.com/balance";
            // 
            // parityCtrl
            // 
            this.parityCtrl.FormattingEnabled = true;
            this.parityCtrl.Items.AddRange(new object[] {
            "No parity",
            "Odd",
            "Even",
            "Mark",
            "Space"});
            this.parityCtrl.Location = new System.Drawing.Point(72, 105);
            this.parityCtrl.Name = "parityCtrl";
            this.parityCtrl.Size = new System.Drawing.Size(120, 28);
            this.parityCtrl.TabIndex = 1;
            // 
            // databitsCtrl
            // 
            this.databitsCtrl.DropDownWidth = 120;
            this.databitsCtrl.FormattingEnabled = true;
            this.databitsCtrl.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.databitsCtrl.Location = new System.Drawing.Point(570, 58);
            this.databitsCtrl.Name = "databitsCtrl";
            this.databitsCtrl.Size = new System.Drawing.Size(120, 28);
            this.databitsCtrl.TabIndex = 1;
            // 
            // baudrateCtrl
            // 
            this.baudrateCtrl.DropDownWidth = 120;
            this.baudrateCtrl.FormattingEnabled = true;
            this.baudrateCtrl.Items.AddRange(new object[] {
            "110",
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "38400",
            "56000",
            "57600",
            "115200",
            "128000",
            "256000"});
            this.baudrateCtrl.Location = new System.Drawing.Point(330, 58);
            this.baudrateCtrl.Name = "baudrateCtrl";
            this.baudrateCtrl.Size = new System.Drawing.Size(120, 28);
            this.baudrateCtrl.TabIndex = 1;
            // 
            // comCtrl
            // 
            this.comCtrl.DropDownWidth = 120;
            this.comCtrl.FormattingEnabled = true;
            this.comCtrl.Items.AddRange(new object[] {
            "COM0",
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8",
            "COM9"});
            this.comCtrl.Location = new System.Drawing.Point(72, 58);
            this.comCtrl.Name = "comCtrl";
            this.comCtrl.Size = new System.Drawing.Size(120, 28);
            this.comCtrl.TabIndex = 1;
            // 
            // parity_label
            // 
            this.parity_label.AutoSize = true;
            this.parity_label.Location = new System.Drawing.Point(6, 108);
            this.parity_label.Name = "parity_label";
            this.parity_label.Size = new System.Drawing.Size(60, 20);
            this.parity_label.TabIndex = 0;
            this.parity_label.Text = "Parity : ";
            // 
            // stopbits_label
            // 
            this.stopbits_label.AutoSize = true;
            this.stopbits_label.Location = new System.Drawing.Point(244, 108);
            this.stopbits_label.Name = "stopbits_label";
            this.stopbits_label.Size = new System.Drawing.Size(80, 20);
            this.stopbits_label.TabIndex = 0;
            this.stopbits_label.Text = "Stopbits : ";
            // 
            // databits_label
            // 
            this.databits_label.AutoSize = true;
            this.databits_label.Location = new System.Drawing.Point(483, 62);
            this.databits_label.Name = "databits_label";
            this.databits_label.Size = new System.Drawing.Size(81, 20);
            this.databits_label.TabIndex = 0;
            this.databits_label.Text = "Databits : ";
            // 
            // baudrate_label
            // 
            this.baudrate_label.AutoSize = true;
            this.baudrate_label.Location = new System.Drawing.Point(237, 62);
            this.baudrate_label.Name = "baudrate_label";
            this.baudrate_label.Size = new System.Drawing.Size(87, 20);
            this.baudrate_label.TabIndex = 0;
            this.baudrate_label.Text = "Baudrate : ";
            // 
            // url_label
            // 
            this.url_label.AutoSize = true;
            this.url_label.Location = new System.Drawing.Point(12, 23);
            this.url_label.Name = "url_label";
            this.url_label.Size = new System.Drawing.Size(54, 20);
            this.url_label.TabIndex = 0;
            this.url_label.Text = "URL : ";
            // 
            // openBtn
            // 
            this.openBtn.Location = new System.Drawing.Point(632, 250);
            this.openBtn.Name = "openBtn";
            this.openBtn.Size = new System.Drawing.Size(106, 27);
            this.openBtn.TabIndex = 1;
            this.openBtn.Text = "Open";
            this.openBtn.UseVisualStyleBackColor = true;
            this.openBtn.Click += new System.EventHandler(this.openBtn_Click);
            // 
            // resultTxt
            // 
            this.resultTxt.Location = new System.Drawing.Point(12, 251);
            this.resultTxt.Name = "resultTxt";
            this.resultTxt.Size = new System.Drawing.Size(219, 26);
            this.resultTxt.TabIndex = 2;
            this.resultTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // resultList
            // 
            this.resultList.FormattingEnabled = true;
            this.resultList.ItemHeight = 20;
            this.resultList.Location = new System.Drawing.Point(12, 12);
            this.resultList.Name = "resultList";
            this.resultList.Size = new System.Drawing.Size(726, 224);
            this.resultList.TabIndex = 3;
            // 
            // resetBtn
            // 
            this.resetBtn.Location = new System.Drawing.Point(515, 250);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(100, 28);
            this.resetBtn.TabIndex = 4;
            this.resetBtn.Text = "Clear";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // average_label
            // 
            this.average_label.AutoSize = true;
            this.average_label.Location = new System.Drawing.Point(483, 110);
            this.average_label.Name = "average_label";
            this.average_label.Size = new System.Drawing.Size(84, 20);
            this.average_label.TabIndex = 0;
            this.average_label.Text = "Average  : ";
            // 
            // avgTxt
            // 
            this.avgTxt.Location = new System.Drawing.Point(257, 251);
            this.avgTxt.Name = "avgTxt";
            this.avgTxt.Size = new System.Drawing.Size(219, 26);
            this.avgTxt.TabIndex = 2;
            this.avgTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // averageCtrl
            // 
            this.averageCtrl.DropDownWidth = 120;
            this.averageCtrl.FormattingEnabled = true;
            this.averageCtrl.Items.AddRange(new object[] {
            "1",
            "5",
            "10",
            "20",
            "30",
            "40",
            "50",
            "60",
            "70",
            "80",
            "90",
            "100"});
            this.averageCtrl.Location = new System.Drawing.Point(570, 105);
            this.averageCtrl.Name = "averageCtrl";
            this.averageCtrl.Size = new System.Drawing.Size(120, 28);
            this.averageCtrl.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 450);
            this.Controls.Add(this.openBtn);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.resultList);
            this.Controls.Add(this.avgTxt);
            this.Controls.Add(this.resultTxt);
            this.Controls.Add(this.Set_groupBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Serial Comunication Application";
            this.Set_groupBox.ResumeLayout(false);
            this.Set_groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label com_label;
        private System.Windows.Forms.GroupBox Set_groupBox;
        private System.Windows.Forms.Label parity_label;
        private System.Windows.Forms.Label stopbits_label;
        private System.Windows.Forms.Label databits_label;
        private System.Windows.Forms.Label baudrate_label;
        private System.Windows.Forms.ComboBox databitsCtrl;
        private System.Windows.Forms.ComboBox baudrateCtrl;
        private System.Windows.Forms.ComboBox stopbitsCtrl;
        private System.Windows.Forms.ComboBox parityCtrl;
        private System.Windows.Forms.Button openBtn;
        private System.Windows.Forms.TextBox resultTxt;
        private System.Windows.Forms.ListBox resultList;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.TextBox serverURLTxt;
        private System.Windows.Forms.Label url_label;
        private System.Windows.Forms.ComboBox comCtrl;
        private System.Windows.Forms.TextBox urlTxt;
        private System.Windows.Forms.Button testBTN;
        private System.Windows.Forms.Label average_label;
        private System.Windows.Forms.ComboBox averageCtrl;
        private System.Windows.Forms.TextBox avgTxt;
    }
}

