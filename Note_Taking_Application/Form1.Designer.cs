﻿namespace Note_Taking_Application
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.LoadFile = new System.Windows.Forms.Button();
            this.SaveFile = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.txtDirectoryPath = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Load = new System.Windows.Forms.Button();
            this.Select = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.NewF = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.refresh = new System.Windows.Forms.Button();
            this.NewFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBox1.Location = new System.Drawing.Point(314, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(623, 678);
            this.textBox1.TabIndex = 0;
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.treeView1.Location = new System.Drawing.Point(12, 380);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(232, 297);
            this.treeView1.TabIndex = 2;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // LoadFile
            // 
            this.LoadFile.Location = new System.Drawing.Point(12, 140);
            this.LoadFile.Name = "LoadFile";
            this.LoadFile.Size = new System.Drawing.Size(232, 64);
            this.LoadFile.TabIndex = 3;
            this.LoadFile.Text = "Load";
            this.LoadFile.UseVisualStyleBackColor = true;
            this.LoadFile.Click += new System.EventHandler(this.LoadFile_Click);
            // 
            // SaveFile
            // 
            this.SaveFile.Location = new System.Drawing.Point(12, 219);
            this.SaveFile.Name = "SaveFile";
            this.SaveFile.Size = new System.Drawing.Size(232, 64);
            this.SaveFile.TabIndex = 4;
            this.SaveFile.Text = "Save";
            this.SaveFile.UseVisualStyleBackColor = true;
            this.SaveFile.Click += new System.EventHandler(this.SaveFile_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 342);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(232, 32);
            this.progressBar1.TabIndex = 10;
            // 
            // txtDirectoryPath
            // 
            this.txtDirectoryPath.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtDirectoryPath.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDirectoryPath.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtDirectoryPath.Location = new System.Drawing.Point(12, 289);
            this.txtDirectoryPath.Multiline = true;
            this.txtDirectoryPath.Name = "txtDirectoryPath";
            this.txtDirectoryPath.ReadOnly = true;
            this.txtDirectoryPath.Size = new System.Drawing.Size(232, 47);
            this.txtDirectoryPath.TabIndex = 11;
            // 
            // Load
            // 
            this.Load.Image = global::Note_Taking_Application.Properties.Resources.Check_1_png;
            this.Load.Location = new System.Drawing.Point(250, 569);
            this.Load.Name = "Load";
            this.Load.Size = new System.Drawing.Size(32, 32);
            this.Load.TabIndex = 9;
            this.Load.UseVisualStyleBackColor = true;
            this.Load.Click += new System.EventHandler(this.button6_Click);
            // 
            // Select
            // 
            this.Select.Image = global::Note_Taking_Application.Properties.Resources.OpenFolder_1_png;
            this.Select.Location = new System.Drawing.Point(250, 607);
            this.Select.Name = "Select";
            this.Select.Size = new System.Drawing.Size(32, 32);
            this.Select.TabIndex = 8;
            this.Select.UseVisualStyleBackColor = true;
            this.Select.Click += new System.EventHandler(this.Select_Click);
            // 
            // Delete
            // 
            this.Delete.Image = global::Note_Taking_Application.Properties.Resources.DELETE_1_png;
            this.Delete.Location = new System.Drawing.Point(250, 455);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(32, 32);
            this.Delete.TabIndex = 7;
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.button4_Click);
            // 
            // NewF
            // 
            this.NewF.Image = global::Note_Taking_Application.Properties.Resources.NewFolder_1_png;
            this.NewF.Location = new System.Drawing.Point(250, 531);
            this.NewF.Name = "NewF";
            this.NewF.Size = new System.Drawing.Size(32, 32);
            this.NewF.TabIndex = 6;
            this.NewF.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBox2.Location = new System.Drawing.Point(12, 13);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(296, 111);
            this.textBox2.TabIndex = 12;
            this.textBox2.Text = "Title:";
            // 
            // button1
            // 
            this.button1.Image = global::Note_Taking_Application.Properties.Resources.DELETE_1_png;
            this.button1.Location = new System.Drawing.Point(-471, -267);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 32);
            this.button1.TabIndex = 13;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // refresh
            // 
            this.refresh.Image = global::Note_Taking_Application.Properties.Resources.OpenFolder;
            this.refresh.Location = new System.Drawing.Point(250, 645);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(32, 32);
            this.refresh.TabIndex = 14;
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // NewFile
            // 
            this.NewFile.Image = global::Note_Taking_Application.Properties.Resources.NewFolder_1_png;
            this.NewFile.Location = new System.Drawing.Point(250, 493);
            this.NewFile.Name = "NewFile";
            this.NewFile.Size = new System.Drawing.Size(32, 32);
            this.NewFile.TabIndex = 15;
            this.NewFile.UseVisualStyleBackColor = true;
            this.NewFile.Click += new System.EventHandler(this.NewFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(949, 702);
            this.Controls.Add(this.NewFile);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtDirectoryPath);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.Load);
            this.Controls.Add(this.Select);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.NewF);
            this.Controls.Add(this.SaveFile);
            this.Controls.Add(this.LoadFile);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.textBox1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button LoadFile;
        private System.Windows.Forms.Button SaveFile;
        private System.Windows.Forms.Button NewF;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Select;
        private System.Windows.Forms.Button Load;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox txtDirectoryPath;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.Button NewFile;
    }
}

