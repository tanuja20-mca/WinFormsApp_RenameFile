using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp_RenameFile_Test3
{
    public partial class Form1 : Form
    {
        public string r_F;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            DialogResult result = fbd.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtPath.Text = fbd.SelectedPath;
            }

        }

        private void btnRename_Click(object sender, EventArgs e)
        {
            if (txtFileName.Text == "" && txtNewFileName.Text == "")
            {
                MessageBox.Show("Field are empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFileName.Focus();
                return;
            }


    
           
                string folderPath = txtPath.Text;
                DirectoryInfo dir = new DirectoryInfo(folderPath);
                FileInfo[] files = dir.GetFiles(txtFileName.Text + "*.*", SearchOption.AllDirectories);


                for (int i = 0; i <= files.Length - 1; i++)
                {
                              
                    RenameFile();
            }

        }


        private void RenameFile()
        {
            var directoryEntries = Directory.GetFiles(txtPath.Text);
            foreach (var directory in directoryEntries)
            {

                LoadSubDir(directory);
            }
        }

        private void LoadSubDir(string directory)
        {
            string parentDir = "";
            string newDirPath = "";


            string folderPath = txtPath.Text;
            DirectoryInfo dir = new DirectoryInfo(folderPath);
            FileInfo[] files = dir.GetFiles(txtFileName.Text + "*.*", SearchOption.AllDirectories);

            foreach (var item in files)
            {


                if (item.Name == Path.GetFileName(directory))
                {

                    parentDir = Path.GetDirectoryName(directory);
                    newDirPath = Path.Combine(parentDir, txtNewFileName.Text);
                    try {

                        Directory.Move(directory, newDirPath);
                        directory = newDirPath;
                        r_F = "Sucess";
                        FillDataToFile();
                        MessageBox.Show(" Filed Has SuccessFully ReNamed.....!!");
                    }
                    catch(Exception e)
                    {
                        r_F = "Fail";
                        MessageBox.Show("File Name Already Exists....!");
                    }
                    
                    

                }


            }
            

                  
                

            
        }


        private void FillDataToFile()
        {

            FileStream fs = new FileStream("C:/Data/log.txt", FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            string Original_Name = txtFileName.Text;
            string New_File_Name = txtNewFileName.Text;
            DateTime Modification = DateTime.Now;
            string Rename = r_F;
            sw.WriteLine("Original Name : " + Original_Name);
            sw.WriteLine("New File Name : " + New_File_Name);
            sw.WriteLine("ReName : " + Rename);
            sw.WriteLine("Modification : " + Modification);
            sw.WriteLine();
            sw.Flush();
            sw.Close();
            fs.Close();
        }


    }
}
