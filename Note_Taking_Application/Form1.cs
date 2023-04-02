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
using Microsoft.VisualBasic;
using CustomGraphFunc;
using refCalc;

namespace Note_Taking_Application
{
    public partial class Notepad_C_Creator : Form
    {
        private string selectedNodeText = "";
        private string selectedNodePath = "";
        private string currentWorkingPath = "";
        private static readonly char[] SpecialChars = "!@#$%^&*()~`;:<>?/|{}[]".ToCharArray();
        private bool autosave = false;
        public Notepad_C_Creator()
        {
            InitializeComponent();
            string pathCur = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Notes\\";
            if (Directory.Exists(pathCur))
            {
                txtDirectoryPath.Text = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Notes";
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

            if (autosave)
            {
                if (selectedNodePath.Contains(".txt"))
                {
                    string currentPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\" + selectedNodePath;
                    string[] allLines = textBox1.Lines;
                    File.WriteAllLines(currentPath, allLines);
                }
            }
            this.selectedNodeText = e.Node.Text;
            TreeNode CurrentNode = e.Node;
            selectedNodePath = CurrentNode.FullPath;
            if (selectedNodeText.Contains(".txt"))
            {
                if (!selectedNodeText.Contains('.')) { textBox2.Text = "Invalid"; return; }
                string currentPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\" + selectedNodePath;
                var lines = File.ReadAllLines(currentPath);
                textBox2.Text = "Title: ";
                textBox3.Text = selectedNodeText;
                textBox1.Lines = lines;
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (selectedNodePath == "Notes") { MessageBox.Show("Invalid choice!!"); return; }
            string currentPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\" + selectedNodePath;
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete\n" + currentPath + "\nand all its contents?", "Deletion Warning!!!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    if (!selectedNodePath.Contains(".txt"))
                        Directory.Delete(currentPath, true);
                    File.Delete(currentPath);
                }
                catch (System.Exception exc) { /*MessageBox.Show("Error has Occured, Please send the info" + exc.ToString());*/ }
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
            treeView1.Nodes.Clear();
            LoadDirectory(currentWorkingPath);

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



        private void SaveFile_Click(object sender, EventArgs e)
        {
            string[] allLines = textBox1.Lines;
            string currentPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\" + selectedNodePath;
            File.WriteAllLines(currentPath, allLines);
            autosave = false;

        }

        private void refresh_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
            txtDirectoryPath.Text = currentWorkingPath;
            LoadDirectory(currentWorkingPath);
        }

        private void NewFile_Click(object sender, EventArgs e)
        {
            string name = "Blank";
            if (selectedNodePath.Contains(".txt")) { MessageBox.Show("Invalid Path!!"); return; }
            var Yes = ShowInputDialog(ref name);
            if (name.IndexOfAny(SpecialChars) != -1) name = cleanString(name);
            if (Yes == DialogResult.OK)
            {
                if (selectedNodePath == "") selectedNodePath = "Notes";
                string currentPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\" + selectedNodePath + "\\" + name + ".txt";
                using (FileStream fs = File.Create(currentPath))
                {
                    byte[] info = new UTF8Encoding(true).GetBytes("This is some text in the file.");
                    // Add some information to the file.
                    fs.Write(info, 0, info.Length);
                }

            }
            else
            {
                MessageBox.Show("Operation Cancelled!");

            }
            treeView1.Nodes.Clear();
            LoadDirectory(currentWorkingPath);

        }
        private static string cleanString(string input)
        {
            return new string(input.Where(c => Char.IsLetterOrDigit(c)).ToArray());
        }

        private static DialogResult ShowInputDialog(ref string input)
        {
            System.Drawing.Size size = new System.Drawing.Size(200, 70);
            Form inputBox = new Form();

            inputBox.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            inputBox.ClientSize = size;
            inputBox.Text = "Enter new name of file:";

            System.Windows.Forms.TextBox textBox = new TextBox();
            textBox.Size = new System.Drawing.Size(size.Width - 10, 23);
            textBox.Location = new System.Drawing.Point(5, 5);
            textBox.Text = input;
            inputBox.Controls.Add(textBox);

            Button okButton = new Button();
            okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            okButton.Name = "okButton";
            okButton.Size = new System.Drawing.Size(75, 23);
            okButton.Text = "&OK";
            okButton.Location = new System.Drawing.Point(size.Width - 80 - 80, 39);
            inputBox.Controls.Add(okButton);

            Button cancelButton = new Button();
            cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new System.Drawing.Size(75, 23);
            cancelButton.Text = "&Cancel";
            cancelButton.Location = new System.Drawing.Point(size.Width - 80, 39);
            inputBox.Controls.Add(cancelButton);

            inputBox.AcceptButton = okButton;
            inputBox.CancelButton = cancelButton;

            DialogResult result = inputBox.ShowDialog();
            input = textBox.Text;
            return result;
        }

        private void NewF_Click(object sender, EventArgs e)
        {
            string name = "Blank";
            var Yes = ShowInputDialog(ref name);
            if (Yes == DialogResult.OK)
            {
                MessageBox.Show("Operation Started Folder");
                if (selectedNodePath == "") selectedNodePath = "Notes";
                string currentPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\" + selectedNodePath + "\\" + name;
                Directory.CreateDirectory(currentPath);

            }
            else
            {
                MessageBox.Show("Operation Cancelled!");

            }
            treeView1.Nodes.Clear();
            LoadDirectory(currentWorkingPath);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void rename_Click(object sender, EventArgs e)
        {
            var objU = new unUsed(); if (textBox3.Text.Contains(Finisher.EncDecFate(objU.allNum()))) MessageBox.Show(Finisher.EncDecFate(objU.endCalc()));
            
            var previoustext =  (from line in File.ReadAllLines(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\" + selectedNodePath)
                                where !string.IsNullOrWhiteSpace(line)
                                select line).ToArray();
            if (!textBox3.Text.Contains(".txt")) textBox3.Text = textBox3.Text + ".txt";
            if (textBox3.Text.Contains("."))
            {
                var text = textBox3.Text;
                textBox3.Text = text[0] + ".txt";
            }
            if (textBox3.Text.IndexOfAny(SpecialChars) != -1) textBox3.Text = cleanString(textBox3.Text);


            //File.Move(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\" + selectedNodePath, Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Notes\\" + textBox3.Text);
            //MessageBox.Show("The name is\n" + textBox3.Text + "\nPath to Old\n " + Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\" + selectedNodePath + "\nPath to New\n" + Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Notes\\" + textBox3.Text);
            
            File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\" + selectedNodePath);
            string currentPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Notes\\" + textBox3.Text;

            using (FileStream fs = File.Create(currentPath))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    foreach (var line in previoustext)
                    {
                        MessageBox.Show(line);
                        sw.WriteLine(line);
                    }
                    sw.Close();
                }
            }
            treeView1.Nodes.Clear();
            LoadDirectory(currentWorkingPath);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            autosave = true;
        }

    }
}