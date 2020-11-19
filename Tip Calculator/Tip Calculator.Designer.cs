
namespace Tip_Calculator
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.peopleno = new System.Windows.Forms.Label();
            this.tip = new System.Windows.Forms.Label();
            this.billbox = new System.Windows.Forms.TextBox();
            this.peopleincrbutton = new System.Windows.Forms.Button();
            this.peoplebox = new System.Windows.Forms.TextBox();
            this.peopledecrbutton = new System.Windows.Forms.Button();
            this.tipincrbutton = new System.Windows.Forms.Button();
            this.tipbox = new System.Windows.Forms.TextBox();
            this.tipdecrbutton = new System.Windows.Forms.Button();
            this.bill = new System.Windows.Forms.Label();
            this.totalperpersonbox = new System.Windows.Forms.TextBox();
            this.tipperpersonbox = new System.Windows.Forms.TextBox();
            this.total2 = new System.Windows.Forms.Label();
            this.total1 = new System.Windows.Forms.Label();
            this.tip2 = new System.Windows.Forms.Label();
            this.tip1 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.Controls.Add(this.peopleno);
            this.splitContainer1.Panel1.Controls.Add(this.tip);
            this.splitContainer1.Panel1.Controls.Add(this.billbox);
            this.splitContainer1.Panel1.Controls.Add(this.peopleincrbutton);
            this.splitContainer1.Panel1.Controls.Add(this.peoplebox);
            this.splitContainer1.Panel1.Controls.Add(this.peopledecrbutton);
            this.splitContainer1.Panel1.Controls.Add(this.tipincrbutton);
            this.splitContainer1.Panel1.Controls.Add(this.tipbox);
            this.splitContainer1.Panel1.Controls.Add(this.tipdecrbutton);
            this.splitContainer1.Panel1.Controls.Add(this.bill);
            this.splitContainer1.Panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splitContainer1.Panel1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitter1);
            this.splitContainer1.Panel2.Controls.Add(this.totalperpersonbox);
            this.splitContainer1.Panel2.Controls.Add(this.tipperpersonbox);
            this.splitContainer1.Panel2.Controls.Add(this.total2);
            this.splitContainer1.Panel2.Controls.Add(this.total1);
            this.splitContainer1.Panel2.Controls.Add(this.tip2);
            this.splitContainer1.Panel2.Controls.Add(this.tip1);
            this.splitContainer1.Size = new System.Drawing.Size(873, 340);
            this.splitContainer1.SplitterDistance = 314;
            this.splitContainer1.TabIndex = 0;
            // 
            // peopleno
            // 
            this.peopleno.AutoSize = true;
            this.peopleno.Location = new System.Drawing.Point(5, 203);
            this.peopleno.Name = "peopleno";
            this.peopleno.Size = new System.Drawing.Size(141, 20);
            this.peopleno.TabIndex = 9;
            this.peopleno.Text = "Number of people";
            // 
            // tip
            // 
            this.tip.AutoSize = true;
            this.tip.Location = new System.Drawing.Point(5, 114);
            this.tip.Name = "tip";
            this.tip.Size = new System.Drawing.Size(52, 20);
            this.tip.TabIndex = 8;
            this.tip.Text = "Tip %";
            // 
            // billbox
            // 
            this.billbox.Location = new System.Drawing.Point(12, 58);
            this.billbox.Name = "billbox";
            this.billbox.Size = new System.Drawing.Size(235, 27);
            this.billbox.TabIndex = 7;
            this.billbox.Text = "0.00";
            this.billbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.billbox.Click += new System.EventHandler(this.billbox_Click);
            this.billbox.TextChanged += new System.EventHandler(this.billbox_TextChanged);
            this.billbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.billbox_KeyPress);
            // 
            // peopleincrbutton
            // 
            this.peopleincrbutton.Location = new System.Drawing.Point(220, 234);
            this.peopleincrbutton.Name = "peopleincrbutton";
            this.peopleincrbutton.Size = new System.Drawing.Size(28, 28);
            this.peopleincrbutton.TabIndex = 6;
            this.peopleincrbutton.Text = "+";
            this.peopleincrbutton.UseVisualStyleBackColor = true;
            this.peopleincrbutton.Click += new System.EventHandler(this.peopleincrbutton_Click);
            // 
            // peoplebox
            // 
            this.peoplebox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.peoplebox.Location = new System.Drawing.Point(40, 234);
            this.peoplebox.Margin = new System.Windows.Forms.Padding(0);
            this.peoplebox.Name = "peoplebox";
            this.peoplebox.ReadOnly = true;
            this.peoplebox.Size = new System.Drawing.Size(180, 27);
            this.peoplebox.TabIndex = 5;
            this.peoplebox.Text = "0";
            this.peoplebox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.peoplebox.TextChanged += new System.EventHandler(this.peoplebox_TextChanged);
            // 
            // peopledecrbutton
            // 
            this.peopledecrbutton.Location = new System.Drawing.Point(12, 234);
            this.peopledecrbutton.Name = "peopledecrbutton";
            this.peopledecrbutton.Size = new System.Drawing.Size(28, 28);
            this.peopledecrbutton.TabIndex = 4;
            this.peopledecrbutton.Text = "-";
            this.peopledecrbutton.UseVisualStyleBackColor = true;
            this.peopledecrbutton.Click += new System.EventHandler(this.peopledecrbutton_Click);
            // 
            // tipincrbutton
            // 
            this.tipincrbutton.Location = new System.Drawing.Point(220, 152);
            this.tipincrbutton.Name = "tipincrbutton";
            this.tipincrbutton.Size = new System.Drawing.Size(28, 28);
            this.tipincrbutton.TabIndex = 3;
            this.tipincrbutton.Text = "+";
            this.tipincrbutton.UseVisualStyleBackColor = true;
            this.tipincrbutton.Click += new System.EventHandler(this.Tipincrbutton);
            // 
            // tipbox
            // 
            this.tipbox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tipbox.Location = new System.Drawing.Point(40, 152);
            this.tipbox.Margin = new System.Windows.Forms.Padding(0);
            this.tipbox.Name = "tipbox";
            this.tipbox.ReadOnly = true;
            this.tipbox.Size = new System.Drawing.Size(180, 27);
            this.tipbox.TabIndex = 2;
            this.tipbox.Text = "0%";
            this.tipbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tipbox.TextChanged += new System.EventHandler(this.tipbox_TextChanged);
            // 
            // tipdecrbutton
            // 
            this.tipdecrbutton.Location = new System.Drawing.Point(12, 152);
            this.tipdecrbutton.Name = "tipdecrbutton";
            this.tipdecrbutton.Size = new System.Drawing.Size(28, 28);
            this.tipdecrbutton.TabIndex = 1;
            this.tipdecrbutton.Text = "-";
            this.tipdecrbutton.UseVisualStyleBackColor = true;
            this.tipdecrbutton.Click += new System.EventHandler(this.Tipdecrbutton);
            // 
            // bill
            // 
            this.bill.AutoSize = true;
            this.bill.Location = new System.Drawing.Point(8, 35);
            this.bill.Name = "bill";
            this.bill.Size = new System.Drawing.Size(33, 20);
            this.bill.TabIndex = 0;
            this.bill.Text = "Bill";
            // 
            // totalperpersonbox
            // 
            this.totalperpersonbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.totalperpersonbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalperpersonbox.Location = new System.Drawing.Point(155, 171);
            this.totalperpersonbox.Multiline = true;
            this.totalperpersonbox.Name = "totalperpersonbox";
            this.totalperpersonbox.ReadOnly = true;
            this.totalperpersonbox.Size = new System.Drawing.Size(337, 53);
            this.totalperpersonbox.TabIndex = 5;
            this.totalperpersonbox.Text = "$0.00";
            this.totalperpersonbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.totalperpersonbox.TextChanged += new System.EventHandler(this.totalperpersonbox_TextChanged);
            // 
            // tipperpersonbox
            // 
            this.tipperpersonbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tipperpersonbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipperpersonbox.Location = new System.Drawing.Point(155, 102);
            this.tipperpersonbox.Multiline = true;
            this.tipperpersonbox.Name = "tipperpersonbox";
            this.tipperpersonbox.ReadOnly = true;
            this.tipperpersonbox.Size = new System.Drawing.Size(337, 53);
            this.tipperpersonbox.TabIndex = 4;
            this.tipperpersonbox.Text = "$0.00";
            this.tipperpersonbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tipperpersonbox.TextChanged += new System.EventHandler(this.tipperpersonbox_TextChanged);
            // 
            // total2
            // 
            this.total2.AutoSize = true;
            this.total2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.total2.Location = new System.Drawing.Point(47, 203);
            this.total2.Name = "total2";
            this.total2.Size = new System.Drawing.Size(89, 20);
            this.total2.TabIndex = 3;
            this.total2.Text = "per person";
            this.total2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // total1
            // 
            this.total1.AutoSize = true;
            this.total1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total1.Location = new System.Drawing.Point(45, 171);
            this.total1.Name = "total1";
            this.total1.Size = new System.Drawing.Size(79, 32);
            this.total1.TabIndex = 2;
            this.total1.Text = "Total";
            this.total1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tip2
            // 
            this.tip2.AutoSize = true;
            this.tip2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tip2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tip2.Location = new System.Drawing.Point(47, 134);
            this.tip2.Name = "tip2";
            this.tip2.Size = new System.Drawing.Size(89, 20);
            this.tip2.TabIndex = 1;
            this.tip2.Text = "per person";
            this.tip2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tip1
            // 
            this.tip1.AutoSize = true;
            this.tip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tip1.Location = new System.Drawing.Point(45, 102);
            this.tip1.Name = "tip1";
            this.tip1.Size = new System.Drawing.Size(55, 32);
            this.tip1.TabIndex = 0;
            this.tip1.Text = "Tip";
            this.tip1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 340);
            this.splitter1.TabIndex = 6;
            this.splitter1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 340);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tip Calculator";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox totalperpersonbox;
        private System.Windows.Forms.TextBox tipperpersonbox;
        private System.Windows.Forms.Label total2;
        private System.Windows.Forms.Label total1;
        private System.Windows.Forms.Label tip2;
        private System.Windows.Forms.Label tip1;
        private System.Windows.Forms.Label peopleno;
        private System.Windows.Forms.Label tip;
        private System.Windows.Forms.TextBox billbox;
        private System.Windows.Forms.Button peopleincrbutton;
        private System.Windows.Forms.TextBox peoplebox;
        private System.Windows.Forms.Button peopledecrbutton;
        private System.Windows.Forms.Button tipincrbutton;
        private System.Windows.Forms.TextBox tipbox;
        private System.Windows.Forms.Button tipdecrbutton;
        private System.Windows.Forms.Label bill;
        private System.Windows.Forms.Splitter splitter1;
    }
}

