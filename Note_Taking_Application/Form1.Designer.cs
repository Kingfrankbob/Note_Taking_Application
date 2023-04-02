namespace Note_Taking_Application
{
    partial class Notepad_C_Creator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Notepad_C_Creator));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.SaveFile = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.txtDirectoryPath = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.NewFile = new System.Windows.Forms.Button();
            this.refresh = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Load = new System.Windows.Forms.Button();
            this.Select = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.NewF = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.rename = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBox1.Location = new System.Drawing.Point(314, 11);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(624, 678);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.treeView1.Location = new System.Drawing.Point(13, 380);
            this.treeView1.Margin = new System.Windows.Forms.Padding(4);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(231, 298);
            this.treeView1.TabIndex = 2;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // SaveFile
            // 
            this.SaveFile.Location = new System.Drawing.Point(13, 213);
            this.SaveFile.Margin = new System.Windows.Forms.Padding(4);
            this.SaveFile.Name = "SaveFile";
            this.SaveFile.Size = new System.Drawing.Size(280, 65);
            this.SaveFile.TabIndex = 4;
            this.SaveFile.Text = "Save";
            this.SaveFile.UseVisualStyleBackColor = true;
            this.SaveFile.Click += new System.EventHandler(this.SaveFile_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(13, 342);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(278, 30);
            this.progressBar1.TabIndex = 10;
            // 
            // txtDirectoryPath
            // 
            this.txtDirectoryPath.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtDirectoryPath.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDirectoryPath.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtDirectoryPath.Location = new System.Drawing.Point(13, 290);
            this.txtDirectoryPath.Margin = new System.Windows.Forms.Padding(4);
            this.txtDirectoryPath.Multiline = true;
            this.txtDirectoryPath.Name = "txtDirectoryPath";
            this.txtDirectoryPath.ReadOnly = true;
            this.txtDirectoryPath.Size = new System.Drawing.Size(233, 46);
            this.txtDirectoryPath.TabIndex = 11;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBox2.Location = new System.Drawing.Point(13, 13);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(295, 111);
            this.textBox2.TabIndex = 12;
            this.textBox2.Text = "Title:";
            // 
            // NewFile
            // 
            this.NewFile.AutoSize = true;
            this.NewFile.Image = global::Note_Taking_Application.Properties.Resources.NewFolder_1_png_1_png_1_png;
            this.NewFile.Location = new System.Drawing.Point(249, 489);
            this.NewFile.Margin = new System.Windows.Forms.Padding(4);
            this.NewFile.Name = "NewFile";
            this.NewFile.Size = new System.Drawing.Size(42, 42);
            this.NewFile.TabIndex = 15;
            this.NewFile.UseVisualStyleBackColor = true;
            this.NewFile.Click += new System.EventHandler(this.NewFile_Click);
            // 
            // refresh
            // 
            this.refresh.AutoSize = true;
            this.refresh.Image = global::Note_Taking_Application.Properties.Resources.OpenFolder_1_png_1_png_1_png__1_;
            this.refresh.Location = new System.Drawing.Point(249, 639);
            this.refresh.Margin = new System.Windows.Forms.Padding(4);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(42, 42);
            this.refresh.TabIndex = 14;
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // button1
            // 
            this.button1.Image = global::Note_Taking_Application.Properties.Resources.DELETE_1_png;
            this.button1.Location = new System.Drawing.Point(-471, -268);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(31, 31);
            this.button1.TabIndex = 13;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Load
            // 
            this.Load.Image = global::Note_Taking_Application.Properties.Resources.Check_1_png_1_png;
            this.Load.Location = new System.Drawing.Point(249, 380);
            this.Load.Margin = new System.Windows.Forms.Padding(4);
            this.Load.Name = "Load";
            this.Load.Size = new System.Drawing.Size(42, 44);
            this.Load.TabIndex = 9;
            this.Load.UseVisualStyleBackColor = true;
            this.Load.Click += new System.EventHandler(this.button6_Click);
            // 
            // Select
            // 
            this.Select.AutoSize = true;
            this.Select.Image = global::Note_Taking_Application.Properties.Resources.OpenFolder_1_png_1_png_1_png;
            this.Select.Location = new System.Drawing.Point(249, 589);
            this.Select.Margin = new System.Windows.Forms.Padding(4);
            this.Select.Name = "Select";
            this.Select.Size = new System.Drawing.Size(42, 42);
            this.Select.TabIndex = 8;
            this.Select.UseVisualStyleBackColor = true;
            this.Select.Click += new System.EventHandler(this.Select_Click);
            // 
            // Delete
            // 
            this.Delete.AutoSize = true;
            this.Delete.Image = global::Note_Taking_Application.Properties.Resources.DELETE_1_png__1_;
            this.Delete.Location = new System.Drawing.Point(249, 432);
            this.Delete.Margin = new System.Windows.Forms.Padding(4);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(42, 50);
            this.Delete.TabIndex = 7;
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.button4_Click);
            // 
            // NewF
            // 
            this.NewF.AutoSize = true;
            this.NewF.Image = global::Note_Taking_Application.Properties.Resources.NewFolder_1_png_1_png;
            this.NewF.Location = new System.Drawing.Point(249, 539);
            this.NewF.Margin = new System.Windows.Forms.Padding(4);
            this.NewF.Name = "NewF";
            this.NewF.Size = new System.Drawing.Size(42, 42);
            this.NewF.TabIndex = 6;
            this.NewF.UseVisualStyleBackColor = true;
            this.NewF.Click += new System.EventHandler(this.NewF_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(13, 61);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(278, 72);
            this.textBox3.TabIndex = 16;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // rename
            // 
            this.rename.Location = new System.Drawing.Point(13, 139);
            this.rename.Name = "rename";
            this.rename.Size = new System.Drawing.Size(278, 67);
            this.rename.TabIndex = 17;
            this.rename.Text = "Rename";
            this.rename.UseVisualStyleBackColor = true;
            this.rename.Click += new System.EventHandler(this.rename_Click);
            // 
            // Notepad_C_Creator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(950, 702);
            this.Controls.Add(this.rename);
            this.Controls.Add(this.textBox3);
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
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.textBox1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Notepad_C_Creator";
            this.Text = "NotepadCCreator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TreeView treeView1;
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
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button rename;
    }
}

