namespace FrmProjectSetup
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
            this.lbLevelTemplate = new System.Windows.Forms.Label();
            this.tbLevelTemplate = new System.Windows.Forms.TextBox();
            this.btnLevelFile = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSheetTemplatePath = new System.Windows.Forms.TextBox();
            this.btnOPenSheetDataFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbLevelTemplate
            // 
            this.lbLevelTemplate.AutoSize = true;
            this.lbLevelTemplate.Location = new System.Drawing.Point(13, 13);
            this.lbLevelTemplate.Name = "lbLevelTemplate";
            this.lbLevelTemplate.Size = new System.Drawing.Size(212, 25);
            this.lbLevelTemplate.TabIndex = 0;
            this.lbLevelTemplate.Text = "Level Tempalate File";
            // 
            // tbLevelTemplate
            // 
            this.tbLevelTemplate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbLevelTemplate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLevelTemplate.Location = new System.Drawing.Point(18, 41);
            this.tbLevelTemplate.Name = "tbLevelTemplate";
            this.tbLevelTemplate.Size = new System.Drawing.Size(913, 38);
            this.tbLevelTemplate.TabIndex = 1;
            // 
            // btnLevelFile
            // 
            this.btnLevelFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLevelFile.Location = new System.Drawing.Point(18, 96);
            this.btnLevelFile.Name = "btnLevelFile";
            this.btnLevelFile.Size = new System.Drawing.Size(203, 57);
            this.btnLevelFile.TabIndex = 2;
            this.btnLevelFile.Text = "File";
            this.btnLevelFile.UseVisualStyleBackColor = true;
            this.btnLevelFile.Click += new System.EventHandler(this.btnLevelFile_Click);
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(585, 439);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(184, 50);
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(775, 439);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(184, 50);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Sheet Template File";
            // 
            // tbSheetTemplatePath
            // 
            this.tbSheetTemplatePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSheetTemplatePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSheetTemplatePath.Location = new System.Drawing.Point(18, 250);
            this.tbSheetTemplatePath.Name = "tbSheetTemplatePath";
            this.tbSheetTemplatePath.Size = new System.Drawing.Size(913, 38);
            this.tbSheetTemplatePath.TabIndex = 6;
            // 
            // btnOPenSheetDataFile
            // 
            this.btnOPenSheetDataFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOPenSheetDataFile.Location = new System.Drawing.Point(18, 315);
            this.btnOPenSheetDataFile.Name = "btnOPenSheetDataFile";
            this.btnOPenSheetDataFile.Size = new System.Drawing.Size(203, 57);
            this.btnOPenSheetDataFile.TabIndex = 7;
            this.btnOPenSheetDataFile.Text = "File";
            this.btnOPenSheetDataFile.UseVisualStyleBackColor = true;
            this.btnOPenSheetDataFile.Click += new System.EventHandler(this.btnOPenSheetDataFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 501);
            this.Controls.Add(this.btnOPenSheetDataFile);
            this.Controls.Add(this.tbSheetTemplatePath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnLevelFile);
            this.Controls.Add(this.tbLevelTemplate);
            this.Controls.Add(this.lbLevelTemplate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbLevelTemplate;
        public System.Windows.Forms.TextBox tbLevelTemplate;
        private System.Windows.Forms.Button btnLevelFile;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox tbSheetTemplatePath;
        private System.Windows.Forms.Button btnOPenSheetDataFile;
    }
}