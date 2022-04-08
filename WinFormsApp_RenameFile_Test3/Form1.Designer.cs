
namespace WinFormsApp_RenameFile_Test3
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
            this.btnBrowse = new System.Windows.Forms.Button();
            this.lblPath = new System.Windows.Forms.Label();
            this.lblFileName = new System.Windows.Forms.Label();
            this.lblNewFileName = new System.Windows.Forms.Label();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.txtNewFileName = new System.Windows.Forms.TextBox();
            this.btnRename = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(674, 38);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(94, 37);
            this.btnBrowse.TabIndex = 0;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(50, 46);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(44, 20);
            this.lblPath.TabIndex = 1;
            this.lblPath.Text = "Path :";
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Location = new System.Drawing.Point(50, 97);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(83, 20);
            this.lblFileName.TabIndex = 2;
            this.lblFileName.Text = "File Name :";
            // 
            // lblNewFileName
            // 
            this.lblNewFileName.AutoSize = true;
            this.lblNewFileName.Location = new System.Drawing.Point(50, 148);
            this.lblNewFileName.Name = "lblNewFileName";
            this.lblNewFileName.Size = new System.Drawing.Size(117, 20);
            this.lblNewFileName.TabIndex = 3;
            this.lblNewFileName.Text = "New File Name :";
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(185, 46);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(474, 27);
            this.txtPath.TabIndex = 4;
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(185, 97);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(474, 27);
            this.txtFileName.TabIndex = 5;
            // 
            // txtNewFileName
            // 
            this.txtNewFileName.Location = new System.Drawing.Point(185, 145);
            this.txtNewFileName.Name = "txtNewFileName";
            this.txtNewFileName.Size = new System.Drawing.Size(474, 27);
            this.txtNewFileName.TabIndex = 6;
            this.txtNewFileName.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // btnRename
            // 
            this.btnRename.Location = new System.Drawing.Point(310, 226);
            this.btnRename.Name = "btnRename";
            this.btnRename.Size = new System.Drawing.Size(94, 48);
            this.btnRename.TabIndex = 7;
            this.btnRename.Text = "Re-Name";
            this.btnRename.UseVisualStyleBackColor = true;
            this.btnRename.Click += new System.EventHandler(this.btnRename_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRename);
            this.Controls.Add(this.txtNewFileName);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.lblNewFileName);
            this.Controls.Add(this.lblFileName);
            this.Controls.Add(this.lblPath);
            this.Controls.Add(this.btnBrowse);
            this.Name = "Form1";
            this.Text = "Rename File Name";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.Label lblNewFileName;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.TextBox txtNewFileName;
        private System.Windows.Forms.Button btnRename;
    }
}

