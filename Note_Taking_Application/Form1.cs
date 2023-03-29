using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Note_Taking_Application
{
    public partial class Form1 : Form
    {
        public string selectedNodeText = "";
        public string selectedNodePath = "";
        public string currentWorkingPath = "";
        public Form1()
        {
            InitializeComponent();
            string pathCur = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Notes\\";
            if (Directory.Exists(pathCur))
            {
                txtDirectoryPath.Text = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)+"\\Notes";
                LoadDirectory(pathCur);
            }
            else
            {
                DirectoryInfo di = Directory.CreateDirectory(pathCur);
                txtDirectoryPath.Text = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Notes";
                LoadDirectory(pathCur);
            }
            currentWorkingPath = pathCur;
        }


        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            this.selectedNodeText = e.Node.Text;
            TreeNode CurrentNode = e.Node;
            selectedNodePath = CurrentNode.FullPath;
        }


        private void button4_Click(object sender, EventArgs e)
        {
            string currentPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\" + selectedNodePath;
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete\n"+currentPath+"\nand all its contents?", "Some Title", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    File.Delete(currentPath);
                    Directory.Delete(currentPath);
                }
                catch { } //Do Nothing
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            // Clear All Nodes if Already Exists
            toolTip1.ShowAlways = true;
            if (Directory.Exists(txtDirectoryPath.Text))
            {
                treeView1.Nodes.Clear();
                LoadDirectory(txtDirectoryPath.Text);
                txtDirectoryPath.Text = currentWorkingPath;
            }
            else
            {
                MessageBox.Show("SELECT A DIRECTORY FOR CRYING OUT LOUD!!");
            }
                
        }

        private void Select_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.SelectedPath = txtDirectoryPath.Text;
            DialogResult drResult = folderBrowserDialog1.ShowDialog();
            if (drResult == System.Windows.Forms.DialogResult.OK)
                currentWorkingPath = folderBrowserDialog1.SelectedPath;
        }
        public void LoadDirectory(string Dir)
        {
            DirectoryInfo di = new DirectoryInfo(Dir);
            //Setting ProgressBar Maximum Value
            progressBar1.Maximum = Directory.GetFiles(Dir, "*.txt", SearchOption.AllDirectories).Length + Directory.GetDirectories(Dir, "**", SearchOption.AllDirectories).Length;
            TreeNode tds = treeView1.Nodes.Add(di.Name);
            tds.Tag = di.FullName;
            tds.StateImageIndex = 0;
            LoadFiles(Dir, tds);
            LoadSubDirectories(Dir, tds);
        }
        private void LoadSubDirectories(string dir, TreeNode td)
        {
            // Get all subdirectories
            string[] subdirectoryEntries = Directory.GetDirectories(dir);
            // Loop through them to see if they have any other subdirectories
            foreach (string subdirectory in subdirectoryEntries)
            {
                DirectoryInfo di = new DirectoryInfo(subdirectory);
                TreeNode tds = td.Nodes.Add(di.Name);
                tds.StateImageIndex = 0;
                tds.Tag = di.FullName;
                LoadFiles(subdirectory, tds);
                LoadSubDirectories(subdirectory, tds);
                UpdateProgress();
            }
        }
        private void LoadFiles(string dir, TreeNode td)
        {
            string[] Files = Directory.GetFiles(dir, "*.txt");
            // Loop through them to see files
            foreach (string file in Files)
            {
                FileInfo fi = new FileInfo(file);
                TreeNode tds = td.Nodes.Add(fi.Name);
                tds.Tag = fi.FullName;
                tds.StateImageIndex = 1;
                UpdateProgress();
            }
        }
        private void UpdateProgress()
        {
            if (progressBar1.Value < progressBar1.Maximum)
            {
                progressBar1.Value++;
                int percent = (int)(((double)progressBar1.Value / (double)progressBar1.Maximum) * 100);
                progressBar1.CreateGraphics().DrawString(percent.ToString() + "%", new Font("Arial", (float)8.25, FontStyle.Regular), Brushes.Black, new PointF(progressBar1.Width / 2 - 10, progressBar1.Height / 2 - 7));
                Application.DoEvents();
            }
        }

        private void LoadFile_Click(object sender, EventArgs e)
        {
            if (!selectedNodeText.Contains('.')) { textBox2.Text = "Invalid"; return; }
            string currentPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\" + selectedNodePath;
            var lines = File.ReadAllLines(currentPath);
            textBox2.Text = "Title: \n" + selectedNodeText;
            textBox1.Lines = lines;
            //MessageBox.Show(currentPath);
        }

        private void SaveFile_Click(object sender, EventArgs e)
        {
            string[] allLines = textBox1.Text.Split('\n');
            string currentPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\" + selectedNodePath;
            File.WriteAllLines(currentPath, allLines);

        }

        private void refresh_Click(object sender, EventArgs e)
        {
            txtDirectoryPath.Text = currentWorkingPath;
            LoadDirectory(currentWorkingPath);
        }

        private void NewFile_Click(object sender, EventArgs e)
        {


        }
    }
}
