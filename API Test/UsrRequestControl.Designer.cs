namespace API_Test
{
    partial class UsrRequestControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsrRequestControl));
            this.cmbRequestType = new System.Windows.Forms.ComboBox();
            this.txtRequestUrl = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gridHeaders = new System.Windows.Forms.DataGridView();
            this.Key = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtBody = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtTextName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGloabalVariables = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.RichTextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridHeaders)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbRequestType
            // 
            this.cmbRequestType.FormattingEnabled = true;
            this.cmbRequestType.Items.AddRange(new object[] {
            "GET",
            "PUT",
            "POST",
            "DELETE"});
            this.cmbRequestType.Location = new System.Drawing.Point(3, 28);
            this.cmbRequestType.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.cmbRequestType.Name = "cmbRequestType";
            this.cmbRequestType.Size = new System.Drawing.Size(106, 21);
            this.cmbRequestType.TabIndex = 1;
            this.cmbRequestType.Text = "GET";
            this.cmbRequestType.SelectedIndexChanged += new System.EventHandler(this.cmbRequestType_SelectedIndexChanged);
            // 
            // txtRequestUrl
            // 
            this.txtRequestUrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRequestUrl.Location = new System.Drawing.Point(115, 28);
            this.txtRequestUrl.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.txtRequestUrl.Name = "txtRequestUrl";
            this.txtRequestUrl.Size = new System.Drawing.Size(687, 20);
            this.txtRequestUrl.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.tabControl1, 2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 85);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(799, 210);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gridHeaders);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(791, 184);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Headers";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // gridHeaders
            // 
            this.gridHeaders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridHeaders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Key,
            this.colValue});
            this.gridHeaders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridHeaders.Location = new System.Drawing.Point(3, 3);
            this.gridHeaders.Name = "gridHeaders";
            this.gridHeaders.Size = new System.Drawing.Size(785, 178);
            this.gridHeaders.TabIndex = 0;
            // 
            // Key
            // 
            this.Key.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Key.HeaderText = "Key";
            this.Key.MinimumWidth = 50;
            this.Key.Name = "Key";
            // 
            // colValue
            // 
            this.colValue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colValue.HeaderText = "Value";
            this.colValue.Name = "colValue";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtBody);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(791, 184);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Body";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtBody
            // 
            this.txtBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBody.Enabled = false;
            this.txtBody.Location = new System.Drawing.Point(3, 3);
            this.txtBody.Name = "txtBody";
            this.txtBody.Size = new System.Drawing.Size(785, 178);
            this.txtBody.TabIndex = 0;
            this.txtBody.Text = "";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 112F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.cmbRequestType, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtRequestUrl, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtTextName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tabControl1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtResult, 0, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(805, 515);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // txtTextName
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txtTextName, 2);
            this.txtTextName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTextName.Location = new System.Drawing.Point(3, 3);
            this.txtTextName.Name = "txtTextName";
            this.txtTextName.Size = new System.Drawing.Size(799, 20);
            this.txtTextName.TabIndex = 5;
            this.txtTextName.Text = "{Sample Test Name}";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnGloabalVariables);
            this.panel1.Controls.Add(this.btnSend);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(115, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(687, 24);
            this.panel1.TabIndex = 8;
            // 
            // btnGloabalVariables
            // 
            this.btnGloabalVariables.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnGloabalVariables.Image = ((System.Drawing.Image)(resources.GetObject("btnGloabalVariables.Image")));
            this.btnGloabalVariables.Location = new System.Drawing.Point(496, 0);
            this.btnGloabalVariables.Name = "btnGloabalVariables";
            this.btnGloabalVariables.Size = new System.Drawing.Size(41, 24);
            this.btnGloabalVariables.TabIndex = 10;
            this.btnGloabalVariables.UseVisualStyleBackColor = true;
            this.btnGloabalVariables.Click += new System.EventHandler(this.btnGloabalVariables_Click);
            // 
            // btnSend
            // 
            this.btnSend.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSend.Location = new System.Drawing.Point(537, 0);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 24);
            this.btnSend.TabIndex = 9;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnSave
            // 
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSave.Location = new System.Drawing.Point(612, 0);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 24);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtResult
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txtResult, 2);
            this.txtResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtResult.Location = new System.Drawing.Point(3, 301);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(799, 211);
            this.txtResult.TabIndex = 9;
            this.txtResult.Text = "";
            // 
            // UsrRequestControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UsrRequestControl";
            this.Size = new System.Drawing.Size(805, 515);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridHeaders)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbRequestType;
        private System.Windows.Forms.TextBox txtRequestUrl;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtTextName;
        private System.Windows.Forms.DataGridView gridHeaders;
        private System.Windows.Forms.RichTextBox txtBody;
        private System.Windows.Forms.DataGridViewTextBoxColumn Key;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValue;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.RichTextBox txtResult;
        private System.Windows.Forms.Button btnGloabalVariables;
    }
}
