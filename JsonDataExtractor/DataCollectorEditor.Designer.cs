
namespace JsonDataExtractor
{
	partial class DataCollectorEditor
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
			this.label2 = new System.Windows.Forms.Label();
			this.txtUrl = new System.Windows.Forms.TextBox();
			this.txtUser = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtPass = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.lbFileTemplates = new System.Windows.Forms.ListBox();
			this.label5 = new System.Windows.Forms.Label();
			this.btnOK = new System.Windows.Forms.Button();
			this.btnEdit = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.btnCancel = new System.Windows.Forms.Button();
			this.nudReloadSeconds = new System.Windows.Forms.NumericUpDown();
			((System.ComponentModel.ISupportInitialize)(this.nudReloadSeconds)).BeginInit();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 15);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(32, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "URL:";
			this.toolTip1.SetToolTip(this.label2, "URL to load a JSON string from");
			// 
			// txtUrl
			// 
			this.txtUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtUrl.Location = new System.Drawing.Point(79, 12);
			this.txtUrl.Name = "txtUrl";
			this.txtUrl.Size = new System.Drawing.Size(254, 20);
			this.txtUrl.TabIndex = 3;
			this.toolTip1.SetToolTip(this.txtUrl, "URL to load a JSON string from");
			// 
			// txtUser
			// 
			this.txtUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtUser.Location = new System.Drawing.Point(79, 38);
			this.txtUser.Name = "txtUser";
			this.txtUser.Size = new System.Drawing.Size(254, 20);
			this.txtUser.TabIndex = 5;
			this.toolTip1.SetToolTip(this.txtUser, "User name to use for HTTP basic authentication (leave empty if no credentials are" +
        " required)");
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 41);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(61, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "User name:";
			this.toolTip1.SetToolTip(this.label3, "User name to use for HTTP basic authentication (leave empty if no credentials are" +
        " required)");
			// 
			// txtPass
			// 
			this.txtPass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtPass.Location = new System.Drawing.Point(79, 64);
			this.txtPass.Name = "txtPass";
			this.txtPass.PasswordChar = '*';
			this.txtPass.Size = new System.Drawing.Size(254, 20);
			this.txtPass.TabIndex = 7;
			this.toolTip1.SetToolTip(this.txtPass, "Password to use for HTTP basic authentication (leave empty if no credentials are " +
        "required)");
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 67);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(56, 13);
			this.label4.TabIndex = 6;
			this.label4.Text = "Password:";
			this.toolTip1.SetToolTip(this.label4, "Password to use for HTTP basic authentication (leave empty if no credentials are " +
        "required)");
			// 
			// lbFileTemplates
			// 
			this.lbFileTemplates.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lbFileTemplates.FormattingEnabled = true;
			this.lbFileTemplates.Location = new System.Drawing.Point(12, 139);
			this.lbFileTemplates.Name = "lbFileTemplates";
			this.lbFileTemplates.Size = new System.Drawing.Size(321, 134);
			this.lbFileTemplates.TabIndex = 9;
			this.lbFileTemplates.DoubleClick += new System.EventHandler(this.lbFileTemplates_DoubleClick);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(12, 120);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(78, 13);
			this.label5.TabIndex = 9;
			this.label5.Text = "File Templates:";
			// 
			// btnOK
			// 
			this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnOK.Location = new System.Drawing.Point(179, 317);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(66, 23);
			this.btnOK.TabIndex = 13;
			this.btnOK.Text = "OK";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// btnEdit
			// 
			this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnEdit.Location = new System.Drawing.Point(179, 288);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(154, 23);
			this.btnEdit.TabIndex = 11;
			this.btnEdit.Text = "Edit Selected";
			this.btnEdit.UseVisualStyleBackColor = true;
			this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnDelete.Location = new System.Drawing.Point(12, 317);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(154, 23);
			this.btnDelete.TabIndex = 12;
			this.btnDelete.Text = "Delete Selected";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnAdd
			// 
			this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnAdd.Location = new System.Drawing.Point(12, 288);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(154, 23);
			this.btnAdd.TabIndex = 10;
			this.btnAdd.Text = "Add File Template";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(12, 93);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(73, 13);
			this.label6.TabIndex = 15;
			this.label6.Text = "Reload every ";
			this.toolTip1.SetToolTip(this.label6, "Password to use for HTTP basic authentication (leave empty if no credentials are " +
        "required)");
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(258, 93);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(47, 13);
			this.label7.TabIndex = 17;
			this.label7.Text = "seconds";
			this.toolTip1.SetToolTip(this.label7, "Password to use for HTTP basic authentication (leave empty if no credentials are " +
        "required)");
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(251, 317);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(82, 23);
			this.btnCancel.TabIndex = 14;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// nudReloadSeconds
			// 
			this.nudReloadSeconds.Location = new System.Drawing.Point(91, 90);
			this.nudReloadSeconds.Maximum = new decimal(new int[] {
            86400,
            0,
            0,
            0});
			this.nudReloadSeconds.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.nudReloadSeconds.Name = "nudReloadSeconds";
			this.nudReloadSeconds.Size = new System.Drawing.Size(161, 20);
			this.nudReloadSeconds.TabIndex = 8;
			this.nudReloadSeconds.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// DataCollectorEditor
			// 
			this.AcceptButton = this.btnOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(345, 352);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.nudReloadSeconds);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.btnEdit);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.lbFileTemplates);
			this.Controls.Add(this.txtPass);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtUser);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtUrl);
			this.Controls.Add(this.label2);
			this.MinimumSize = new System.Drawing.Size(361, 391);
			this.Name = "DataCollectorEditor";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Edit URL Loader";
			((System.ComponentModel.ISupportInitialize)(this.nudReloadSeconds)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtUrl;
		private System.Windows.Forms.TextBox txtUser;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtPass;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ListBox lbFileTemplates;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.Button btnEdit;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.NumericUpDown nudReloadSeconds;
		private System.Windows.Forms.Label label7;
	}
}