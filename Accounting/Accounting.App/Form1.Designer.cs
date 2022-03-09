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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnCustomers = new System.Windows.Forms.ToolStripButton();
            this.btnNewAccountig = new System.Windows.Forms.ToolStripButton();
            this.btnRecieveReport = new System.Windows.Forms.ToolStripButton();
            this.btnPayReport = new System.Windows.Forms.ToolStripButton();
            this.toolStrip2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
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
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(63, 22);
            this.toolStripDropDownButton1.Text = "تنظیمات";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
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
    }
}

