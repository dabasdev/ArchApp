namespace ArchApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.BtnViewFile = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.BtnGetFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "مسار الملف: ";
            // 
            // txtFilePath
            // 
            this.txtFilePath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtFilePath.Location = new System.Drawing.Point(141, 30);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.ReadOnly = true;
            this.txtFilePath.Size = new System.Drawing.Size(593, 36);
            this.txtFilePath.TabIndex = 1;
            this.txtFilePath.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BtnViewFile
            // 
            this.BtnViewFile.Location = new System.Drawing.Point(740, 30);
            this.BtnViewFile.Name = "BtnViewFile";
            this.BtnViewFile.Size = new System.Drawing.Size(118, 36);
            this.BtnViewFile.TabIndex = 2;
            this.BtnViewFile.Text = "تصفح";
            this.BtnViewFile.UseVisualStyleBackColor = true;
            this.BtnViewFile.Click += new System.EventHandler(this.BtnViewFile_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(141, 134);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(185, 40);
            this.BtnSave.TabIndex = 3;
            this.BtnSave.Text = "حفظ";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // ofd
            // 
            this.ofd.FileName = "openFileDialog1";
            // 
            // BtnGetFile
            // 
            this.BtnGetFile.Location = new System.Drawing.Point(352, 134);
            this.BtnGetFile.Name = "BtnGetFile";
            this.BtnGetFile.Size = new System.Drawing.Size(185, 40);
            this.BtnGetFile.TabIndex = 4;
            this.BtnGetFile.Text = "استرجاع";
            this.BtnGetFile.UseVisualStyleBackColor = true;
            this.BtnGetFile.Click += new System.EventHandler(this.BtnGetFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 213);
            this.Controls.Add(this.BtnGetFile);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnViewFile);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Hacen Tunisia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtFilePath;
        private Button BtnViewFile;
        private Button BtnSave;
        private OpenFileDialog ofd;
        private Button BtnGetFile;
    }
}