namespace Accounting.App
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnCustomers = new System.Windows.Forms.ToolStripButton();
            this.btnNewAccountig = new System.Windows.Forms.ToolStripButton();
            this.btnRecieveReport = new System.Windows.Forms.ToolStripButton();
            this.btnPayReport = new System.Windows.Forms.ToolStripButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbDayReport = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRefreshDaysReport = new System.Windows.Forms.Button();
            this.lblDayRecieveReport = new System.Windows.Forms.Label();
            this.lblDayPayReport = new System.Windows.Forms.Label();
            this.lblDayBalanceReport = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblMonthsBalanceReport = new System.Windows.Forms.Label();
            this.lblMonthsPayReport = new System.Windows.Forms.Label();
            this.lblMonthsRecieveReport = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cbMonthsReport = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblDataBalanceReport = new System.Windows.Forms.Label();
            this.lblDataPayReport = new System.Windows.Forms.Label();
            this.lblDataRecieveReport = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtToDate = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFromDate = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.toolStrip2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(784, 25);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(63, 22);
            this.toolStripDropDownButton1.Text = "تنظیمات";
            this.toolStripDropDownButton1.Click += new System.EventHandler(this.toolStripDropDownButton1_Click);
            // 
            // ToolStripMenuItem
            // 
            this.ToolStripMenuItem.Name = "ToolStripMenuItem";
            this.ToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.ToolStripMenuItem.Text = "تغییر نام کاربری یا رمز عبور";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCustomers,
            this.btnNewAccountig,
            this.btnRecieveReport,
            this.btnPayReport});
            this.toolStrip1.Location = new System.Drawing.Point(0, 25);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(784, 62);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnCustomers
            // 
            this.btnCustomers.Image = global::Accounting.App.Properties.Resources._1371476468_preferences_contact_list;
            this.btnCustomers.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnCustomers.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(71, 59);
            this.btnCustomers.Text = "طرف حساب";
            this.btnCustomers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // btnNewAccountig
            // 
            this.btnNewAccountig.Image = global::Accounting.App.Properties.Resources._1371476499_todo_list;
            this.btnNewAccountig.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnNewAccountig.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNewAccountig.Name = "btnNewAccountig";
            this.btnNewAccountig.Size = new System.Drawing.Size(72, 59);
            this.btnNewAccountig.Text = "تراکنش جدید";
            this.btnNewAccountig.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNewAccountig.Click += new System.EventHandler(this.btnNewAccountig_Click);
            // 
            // btnRecieveReport
            // 
            this.btnRecieveReport.Image = global::Accounting.App.Properties.Resources.servicesCosts;
            this.btnRecieveReport.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnRecieveReport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRecieveReport.Name = "btnRecieveReport";
            this.btnRecieveReport.Size = new System.Drawing.Size(98, 59);
            this.btnRecieveReport.Text = "گزارش دریافتی ها";
            this.btnRecieveReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRecieveReport.Click += new System.EventHandler(this.btnRecieveReport_Click);
            // 
            // btnPayReport
            // 
            this.btnPayReport.Image = global::Accounting.App.Properties.Resources._1370791030_credit_card;
            this.btnPayReport.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnPayReport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPayReport.Name = "btnPayReport";
            this.btnPayReport.Size = new System.Drawing.Size(97, 59);
            this.btnPayReport.Text = "گزارش پرداختی ها";
            this.btnPayReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPayReport.Click += new System.EventHandler(this.btnPayReport_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Accounting.App.Properties.Resources.Untitled_1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 90);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(415, 476);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblTime,
            this.lblDate});
            this.statusStrip1.Location = new System.Drawing.Point(0, 569);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(784, 24);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblTime
            // 
            this.lblTime.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(62, 19);
            this.lblTime.Text = "lblTime";
            // 
            // lblDate
            // 
            this.lblDate.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(58, 19);
            this.lblDate.Text = "lblDate";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRefreshDaysReport);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(421, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(351, 476);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "گزارشات کلی";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblDayBalanceReport);
            this.groupBox2.Controls.Add(this.lblDayPayReport);
            this.groupBox2.Controls.Add(this.lblDayRecieveReport);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cbDayReport);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(0, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(345, 135);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "گزارش روز های اخیر";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "انتخاب تعداد روزهای گزارش :";
            // 
            // cbDayReport
            // 
            this.cbDayReport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDayReport.FormattingEnabled = true;
            this.cbDayReport.Location = new System.Drawing.Point(21, 20);
            this.cbDayReport.Name = "cbDayReport";
            this.cbDayReport.Size = new System.Drawing.Size(56, 27);
            this.cbDayReport.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(278, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "در آمد :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(280, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "هزینه :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "باقی مانده:";
            // 
            // btnRefreshDaysReport
            // 
            this.btnRefreshDaysReport.Location = new System.Drawing.Point(15, 435);
            this.btnRefreshDaysReport.Name = "btnRefreshDaysReport";
            this.btnRefreshDaysReport.Size = new System.Drawing.Size(324, 35);
            this.btnRefreshDaysReport.TabIndex = 5;
            this.btnRefreshDaysReport.Text = "به روز رسانی";
            this.btnRefreshDaysReport.UseVisualStyleBackColor = true;
            // 
            // lblDayRecieveReport
            // 
            this.lblDayRecieveReport.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDayRecieveReport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblDayRecieveReport.Location = new System.Drawing.Point(115, 61);
            this.lblDayRecieveReport.Name = "lblDayRecieveReport";
            this.lblDayRecieveReport.Size = new System.Drawing.Size(168, 19);
            this.lblDayRecieveReport.TabIndex = 5;
            this.lblDayRecieveReport.Text = "0";
            // 
            // lblDayPayReport
            // 
            this.lblDayPayReport.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDayPayReport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblDayPayReport.Location = new System.Drawing.Point(115, 92);
            this.lblDayPayReport.Name = "lblDayPayReport";
            this.lblDayPayReport.Size = new System.Drawing.Size(168, 19);
            this.lblDayPayReport.TabIndex = 6;
            this.lblDayPayReport.Text = "0";
            // 
            // lblDayBalanceReport
            // 
            this.lblDayBalanceReport.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDayBalanceReport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblDayBalanceReport.Location = new System.Drawing.Point(6, 87);
            this.lblDayBalanceReport.Name = "lblDayBalanceReport";
            this.lblDayBalanceReport.Size = new System.Drawing.Size(103, 19);
            this.lblDayBalanceReport.TabIndex = 7;
            this.lblDayBalanceReport.Text = "0";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblMonthsBalanceReport);
            this.groupBox3.Controls.Add(this.lblMonthsPayReport);
            this.groupBox3.Controls.Add(this.lblMonthsRecieveReport);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.cbMonthsReport);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Location = new System.Drawing.Point(6, 167);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(345, 135);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "گزارش ماه های اخیر";
            // 
            // lblMonthsBalanceReport
            // 
            this.lblMonthsBalanceReport.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMonthsBalanceReport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblMonthsBalanceReport.Location = new System.Drawing.Point(6, 87);
            this.lblMonthsBalanceReport.Name = "lblMonthsBalanceReport";
            this.lblMonthsBalanceReport.Size = new System.Drawing.Size(103, 19);
            this.lblMonthsBalanceReport.TabIndex = 7;
            this.lblMonthsBalanceReport.Text = "0";
            // 
            // lblMonthsPayReport
            // 
            this.lblMonthsPayReport.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMonthsPayReport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblMonthsPayReport.Location = new System.Drawing.Point(115, 92);
            this.lblMonthsPayReport.Name = "lblMonthsPayReport";
            this.lblMonthsPayReport.Size = new System.Drawing.Size(168, 19);
            this.lblMonthsPayReport.TabIndex = 6;
            this.lblMonthsPayReport.Text = "0";
            // 
            // lblMonthsRecieveReport
            // 
            this.lblMonthsRecieveReport.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMonthsRecieveReport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblMonthsRecieveReport.Location = new System.Drawing.Point(115, 61);
            this.lblMonthsRecieveReport.Name = "lblMonthsRecieveReport";
            this.lblMonthsRecieveReport.Size = new System.Drawing.Size(168, 19);
            this.lblMonthsRecieveReport.TabIndex = 5;
            this.lblMonthsRecieveReport.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 63);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 19);
            this.label9.TabIndex = 4;
            this.label9.Text = "باقی مانده:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(280, 92);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 19);
            this.label10.TabIndex = 3;
            this.label10.Text = "هزینه :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(278, 61);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 19);
            this.label11.TabIndex = 2;
            this.label11.Text = "در آمد :";
            // 
            // cbMonthsReport
            // 
            this.cbMonthsReport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMonthsReport.FormattingEnabled = true;
            this.cbMonthsReport.Location = new System.Drawing.Point(15, 23);
            this.cbMonthsReport.Name = "cbMonthsReport";
            this.cbMonthsReport.Size = new System.Drawing.Size(56, 27);
            this.cbMonthsReport.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(84, 23);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(203, 19);
            this.label12.TabIndex = 0;
            this.label12.Text = "انتخاب تعداد روزهای گزارش :";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtToDate);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.lblDataBalanceReport);
            this.groupBox4.Controls.Add(this.lblDataPayReport);
            this.groupBox4.Controls.Add(this.lblDataRecieveReport);
            this.groupBox4.Controls.Add(this.txtFromDate);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Location = new System.Drawing.Point(6, 308);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(345, 128);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "گزارش بر اساس تاریخ";
            // 
            // lblDataBalanceReport
            // 
            this.lblDataBalanceReport.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDataBalanceReport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblDataBalanceReport.Location = new System.Drawing.Point(6, 85);
            this.lblDataBalanceReport.Name = "lblDataBalanceReport";
            this.lblDataBalanceReport.Size = new System.Drawing.Size(103, 19);
            this.lblDataBalanceReport.TabIndex = 7;
            this.lblDataBalanceReport.Text = "0";
            // 
            // lblDataPayReport
            // 
            this.lblDataPayReport.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDataPayReport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblDataPayReport.Location = new System.Drawing.Point(115, 90);
            this.lblDataPayReport.Name = "lblDataPayReport";
            this.lblDataPayReport.Size = new System.Drawing.Size(168, 19);
            this.lblDataPayReport.TabIndex = 6;
            this.lblDataPayReport.Text = "0";
            // 
            // lblDataRecieveReport
            // 
            this.lblDataRecieveReport.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDataRecieveReport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblDataRecieveReport.Location = new System.Drawing.Point(115, 59);
            this.lblDataRecieveReport.Name = "lblDataRecieveReport";
            this.lblDataRecieveReport.Size = new System.Drawing.Size(168, 19);
            this.lblDataRecieveReport.TabIndex = 5;
            this.lblDataRecieveReport.Text = "0";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(15, 61);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(86, 19);
            this.label16.TabIndex = 4;
            this.label16.Text = "باقی مانده:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(280, 90);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(57, 19);
            this.label17.TabIndex = 3;
            this.label17.Text = "هزینه :";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(278, 59);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(59, 19);
            this.label18.TabIndex = 2;
            this.label18.Text = "در آمد :";
            // 
            // txtToDate
            // 
            this.txtToDate.Location = new System.Drawing.Point(25, 26);
            this.txtToDate.Mask = "0000/00/00";
            this.txtToDate.Name = "txtToDate";
            this.txtToDate.PromptChar = '-';
            this.txtToDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtToDate.Size = new System.Drawing.Size(93, 27);
            this.txtToDate.TabIndex = 9;
            this.txtToDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(124, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "تا تاریخ :";
            // 
            // txtFromDate
            // 
            this.txtFromDate.Location = new System.Drawing.Point(194, 26);
            this.txtFromDate.Mask = "0000/00/00";
            this.txtFromDate.Name = "txtFromDate";
            this.txtFromDate.PromptChar = '-';
            this.txtFromDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtFromDate.Size = new System.Drawing.Size(82, 27);
            this.txtFromDate.TabIndex = 7;
            this.txtFromDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(274, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 19);
            this.label6.TabIndex = 6;
            this.label6.Text = "از تاریخ :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 593);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.toolStrip2);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "حسابداری شخصی من";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnCustomers;
        private System.Windows.Forms.ToolStripButton btnNewAccountig;
        private System.Windows.Forms.ToolStripButton btnRecieveReport;
        private System.Windows.Forms.ToolStripButton btnPayReport;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblDate;
        private System.Windows.Forms.ToolStripStatusLabel lblTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblDataBalanceReport;
        private System.Windows.Forms.Label lblDataPayReport;
        private System.Windows.Forms.Label lblDataRecieveReport;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblMonthsBalanceReport;
        private System.Windows.Forms.Label lblMonthsPayReport;
        private System.Windows.Forms.Label lblMonthsRecieveReport;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbMonthsReport;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnRefreshDaysReport;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblDayBalanceReport;
        private System.Windows.Forms.Label lblDayPayReport;
        private System.Windows.Forms.Label lblDayRecieveReport;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbDayReport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtToDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox txtFromDate;
        private System.Windows.Forms.Label label6;
    }
}

