namespace ExcelApp
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
            this.btnInsert = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.c = new System.Windows.Forms.GroupBox();
            this.cbbSheetName = new System.Windows.Forms.ComboBox();
            this.btnGetShape = new System.Windows.Forms.Button();
            this.cbPO62 = new System.Windows.Forms.CheckBox();
            this.cbPO63 = new System.Windows.Forms.CheckBox();
            this.cbPO64 = new System.Windows.Forms.CheckBox();
            this.cbPO70 = new System.Windows.Forms.CheckBox();
            this.cbST102a = new System.Windows.Forms.CheckBox();
            this.cbST103a = new System.Windows.Forms.CheckBox();
            this.lbGetShape = new System.Windows.Forms.Label();
            this.c.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(545, 19);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 0;
            this.btnInsert.Text = "button1";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(82, 21);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(456, 20);
            this.txtPath.TabIndex = 1;
            this.txtPath.Text = "C:\\Users\\Admin\\Desktop\\img\\excel.xlsx";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(544, 21);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // c
            // 
            this.c.Controls.Add(this.lbGetShape);
            this.c.Controls.Add(this.cbST103a);
            this.c.Controls.Add(this.cbST102a);
            this.c.Controls.Add(this.cbPO70);
            this.c.Controls.Add(this.cbPO64);
            this.c.Controls.Add(this.cbPO63);
            this.c.Controls.Add(this.cbPO62);
            this.c.Controls.Add(this.btnGetShape);
            this.c.Controls.Add(this.cbbSheetName);
            this.c.Controls.Add(this.btnInsert);
            this.c.Location = new System.Drawing.Point(37, 68);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(722, 142);
            this.c.TabIndex = 3;
            this.c.TabStop = false;
            this.c.Text = "groupBox1";
            // 
            // cbbSheetName
            // 
            this.cbbSheetName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSheetName.FormattingEnabled = true;
            this.cbbSheetName.Location = new System.Drawing.Point(33, 21);
            this.cbbSheetName.Name = "cbbSheetName";
            this.cbbSheetName.Size = new System.Drawing.Size(221, 21);
            this.cbbSheetName.TabIndex = 1;
            // 
            // btnGetShape
            // 
            this.btnGetShape.Location = new System.Drawing.Point(260, 19);
            this.btnGetShape.Name = "btnGetShape";
            this.btnGetShape.Size = new System.Drawing.Size(75, 23);
            this.btnGetShape.TabIndex = 2;
            this.btnGetShape.Text = "Get Shape";
            this.btnGetShape.UseVisualStyleBackColor = true;
            this.btnGetShape.Click += new System.EventHandler(this.btnGetShape_Click);
            // 
            // cbPO62
            // 
            this.cbPO62.AutoSize = true;
            this.cbPO62.Location = new System.Drawing.Point(33, 88);
            this.cbPO62.Name = "cbPO62";
            this.cbPO62.Size = new System.Drawing.Size(53, 17);
            this.cbPO62.TabIndex = 3;
            this.cbPO62.Text = "PO62";
            this.cbPO62.UseVisualStyleBackColor = true;
            // 
            // cbPO63
            // 
            this.cbPO63.AutoSize = true;
            this.cbPO63.Location = new System.Drawing.Point(92, 88);
            this.cbPO63.Name = "cbPO63";
            this.cbPO63.Size = new System.Drawing.Size(53, 17);
            this.cbPO63.TabIndex = 4;
            this.cbPO63.Text = "PO63";
            this.cbPO63.UseVisualStyleBackColor = true;
            // 
            // cbPO64
            // 
            this.cbPO64.AutoSize = true;
            this.cbPO64.Location = new System.Drawing.Point(151, 88);
            this.cbPO64.Name = "cbPO64";
            this.cbPO64.Size = new System.Drawing.Size(53, 17);
            this.cbPO64.TabIndex = 5;
            this.cbPO64.Text = "PO64";
            this.cbPO64.UseVisualStyleBackColor = true;
            // 
            // cbPO70
            // 
            this.cbPO70.AutoSize = true;
            this.cbPO70.Location = new System.Drawing.Point(210, 88);
            this.cbPO70.Name = "cbPO70";
            this.cbPO70.Size = new System.Drawing.Size(53, 17);
            this.cbPO70.TabIndex = 6;
            this.cbPO70.Text = "PO70";
            this.cbPO70.UseVisualStyleBackColor = true;
            // 
            // cbST102a
            // 
            this.cbST102a.AutoSize = true;
            this.cbST102a.Location = new System.Drawing.Point(269, 88);
            this.cbST102a.Name = "cbST102a";
            this.cbST102a.Size = new System.Drawing.Size(64, 17);
            this.cbST102a.TabIndex = 7;
            this.cbST102a.Text = "ST102a";
            this.cbST102a.UseVisualStyleBackColor = true;
            // 
            // cbST103a
            // 
            this.cbST103a.AutoSize = true;
            this.cbST103a.Location = new System.Drawing.Point(328, 88);
            this.cbST103a.Name = "cbST103a";
            this.cbST103a.Size = new System.Drawing.Size(64, 17);
            this.cbST103a.TabIndex = 8;
            this.cbST103a.Text = "ST103a";
            this.cbST103a.UseVisualStyleBackColor = true;
            // 
            // lbGetShape
            // 
            this.lbGetShape.AutoSize = true;
            this.lbGetShape.ForeColor = System.Drawing.Color.Red;
            this.lbGetShape.Location = new System.Drawing.Point(30, 54);
            this.lbGetShape.Name = "lbGetShape";
            this.lbGetShape.Size = new System.Drawing.Size(126, 13);
            this.lbGetShape.TabIndex = 9;
            this.lbGetShape.Text = "Chưa lấy thông tin Shape";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.c);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.txtPath);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.c.ResumeLayout(false);
            this.c.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.GroupBox c;
        private System.Windows.Forms.ComboBox cbbSheetName;
        private System.Windows.Forms.Button btnGetShape;
        private System.Windows.Forms.CheckBox cbPO62;
        private System.Windows.Forms.CheckBox cbPO70;
        private System.Windows.Forms.CheckBox cbPO64;
        private System.Windows.Forms.CheckBox cbPO63;
        private System.Windows.Forms.CheckBox cbST103a;
        private System.Windows.Forms.CheckBox cbST102a;
        private System.Windows.Forms.Label lbGetShape;
    }
}

