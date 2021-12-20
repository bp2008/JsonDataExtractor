
namespace JsonDataExtractor
{
	partial class FileTemplateEditor
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
			this.label1 = new System.Windows.Forms.Label();
			this.txtFilename = new System.Windows.Forms.TextBox();
			this.txtTemplate = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtPreview = new System.Windows.Forms.TextBox();
			this.btnOK = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnLoadJson = new System.Windows.Forms.Button();
			this.txtJson = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.btnHelp = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(57, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "File Name:";
			// 
			// txtFilename
			// 
			this.txtFilename.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtFilename.Location = new System.Drawing.Point(75, 6);
			this.txtFilename.Name = "txtFilename";
			this.txtFilename.Size = new System.Drawing.Size(433, 20);
			this.txtFilename.TabIndex = 1;
			// 
			// txtTemplate
			// 
			this.txtTemplate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtTemplate.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTemplate.Location = new System.Drawing.Point(12, 242);
			this.txtTemplate.Multiline = true;
			this.txtTemplate.Name = "txtTemplate";
			this.txtTemplate.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtTemplate.Size = new System.Drawing.Size(246, 274);
			this.txtTemplate.TabIndex = 4;
			this.txtTemplate.TextChanged += new System.EventHandler(this.txtTemplate_TextChanged);
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.Location = new System.Drawing.Point(12, 226);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(246, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Template";
			this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.Location = new System.Drawing.Point(265, 226);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(243, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Preview";
			this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// txtPreview
			// 
			this.txtPreview.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtPreview.BackColor = System.Drawing.SystemColors.Window;
			this.txtPreview.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPreview.Location = new System.Drawing.Point(265, 242);
			this.txtPreview.Multiline = true;
			this.txtPreview.Name = "txtPreview";
			this.txtPreview.ReadOnly = true;
			this.txtPreview.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtPreview.Size = new System.Drawing.Size(243, 274);
			this.txtPreview.TabIndex = 5;
			this.txtPreview.WordWrap = false;
			// 
			// btnOK
			// 
			this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnOK.Location = new System.Drawing.Point(352, 522);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(75, 23);
			this.btnOK.TabIndex = 6;
			this.btnOK.Text = "OK";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(433, 522);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 7;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnLoadJson
			// 
			this.btnLoadJson.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnLoadJson.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLoadJson.Location = new System.Drawing.Point(262, 32);
			this.btnLoadJson.Name = "btnLoadJson";
			this.btnLoadJson.Size = new System.Drawing.Size(243, 23);
			this.btnLoadJson.TabIndex = 2;
			this.btnLoadJson.Text = "Reload Json data from URL";
			this.btnLoadJson.UseVisualStyleBackColor = true;
			this.btnLoadJson.Click += new System.EventHandler(this.btnLoadJson_Click);
			// 
			// txtJson
			// 
			this.txtJson.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtJson.BackColor = System.Drawing.SystemColors.Window;
			this.txtJson.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtJson.Location = new System.Drawing.Point(12, 61);
			this.txtJson.Multiline = true;
			this.txtJson.Name = "txtJson";
			this.txtJson.ReadOnly = true;
			this.txtJson.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtJson.Size = new System.Drawing.Size(496, 162);
			this.txtJson.TabIndex = 3;
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label4.Location = new System.Drawing.Point(12, 37);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(244, 13);
			this.label4.TabIndex = 10;
			this.label4.Text = "JSON Text";
			this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// btnHelp
			// 
			this.btnHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnHelp.Location = new System.Drawing.Point(12, 522);
			this.btnHelp.Name = "btnHelp";
			this.btnHelp.Size = new System.Drawing.Size(246, 23);
			this.btnHelp.TabIndex = 11;
			this.btnHelp.Text = "Read the Template Syntax Guide";
			this.btnHelp.UseVisualStyleBackColor = true;
			this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
			// 
			// FileTemplateEditor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(520, 556);
			this.Controls.Add(this.btnHelp);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtJson);
			this.Controls.Add(this.btnLoadJson);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtPreview);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtTemplate);
			this.Controls.Add(this.txtFilename);
			this.Controls.Add(this.label1);
			this.MinimumSize = new System.Drawing.Size(500, 500);
			this.Name = "FileTemplateEditor";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "FileTemplateEditor";
			this.Load += new System.EventHandler(this.FileTemplateEditor_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtFilename;
		private System.Windows.Forms.TextBox txtTemplate;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtPreview;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnLoadJson;
		private System.Windows.Forms.TextBox txtJson;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnHelp;
	}
}