using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace MergeFiles {

    public partial class frmMain: Form {

        private const string AppName = "MergeFiles";
        private const string AppTitle = "Merge Files";
        private const string AppRegistryKey = @"Software\JGhost\" + AppName;

        #region public frmMain()
        public frmMain() {
            InitializeComponent();
        }
        #endregion

        #region private void frmMain_Load(...)
        private void frmMain_Load(object sender, EventArgs e) {
            this.Icon = Icon.ExtractAssociatedIcon(System.Reflection.Assembly.GetExecutingAssembly().Location);
            this.Text = AppTitle;
            Reg.LoadWindowPos(AppRegistryKey, this);
            edtInputPath.Text = Reg.Read(AppRegistryKey, "InputPath", Path.GetDirectoryName(Application.ExecutablePath));
            edtOutputs.Text = Reg.Read(AppRegistryKey, "OutputPath", "");
        }
        #endregion

        #region private void frmMain_FormClosed(...)
        private void frmMain_FormClosed(object sender, FormClosedEventArgs e) {
            Reg.SaveWindowPos(AppRegistryKey, this);
            Reg.Write(AppRegistryKey, "InputPath", edtInputPath.Text);
            Reg.Write(AppRegistryKey, "OutputPath", edtOutputs.Text);
        }
        #endregion

        #region private void btnGetList_Click(...)
        private void btnGetList_Click(object sender, EventArgs e) {
            if (!edtInputPath.Text.EndsWith("\\"))
                edtInputPath.Text = edtInputPath.Text + "\\";
            List<string> files = GetFolderFiles(edtInputPath.Text);
            files.Sort();
            edtPaths.Text = string.Join(Environment.NewLine, files);
        }
        #endregion

        #region private void btnMerge_Click(...)
        private void btnMerge_Click(object sender, EventArgs e) {
            Merge(edtPaths.Text, edtOutputs.Text);
        }
        #endregion

        #region protected void GetFolderFiles(...)
        protected List<string> GetFolderFiles(string path) {
            List<string> file_list = new List<string> { };
            if (Directory.Exists(path)) {
                file_list.AddRange(Directory.GetFiles(path));
                string[] directories = Directory.GetDirectories(path);
                foreach (string path2 in directories) {
                    file_list.AddRange(GetFolderFiles(path2));
                }
            }
            return file_list;
        }
        #endregion

        #region private void Merge(...)
        private void Merge(string InputPath, string OutputPath) {
            try {
                edtFilesToProcess.Text = InputPath;
                edtFilesToProcess.Visible = true;
                edtPaths.Visible = false;

                string Save_Folder = Path.GetDirectoryName(OutputPath);
                if (!Directory.Exists(Save_Folder))
                    Directory.CreateDirectory(Save_Folder);
                if (File.Exists(OutputPath) && MessageBox.Show("Output file already exists, Do you want to overwrite it?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) != DialogResult.OK)
                    return;

                string[] files_to_process = InputPath.Split(new char[2] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

                using (FileStream outStream = new FileStream(OutputPath, FileMode.Create, FileAccess.Write, FileShare.Read)) {
                    foreach (string file_name in files_to_process) {
                        if (file_name.Trim() == "" && !File.Exists(file_name.Trim()))
                            continue;

                        using (FileStream inStream = new FileStream(file_name.Trim(), FileMode.Open, FileAccess.Read, FileShare.Read)) {
                            inStream.CopyTo(outStream);
                            inStream.Close();
                        }
                        edtFilesToProcess.Text = edtFilesToProcess.Text.Replace(file_name + Environment.NewLine, "");
                        Application.DoEvents();
                    }
                    outStream.Close();
                }
                MessageBox.Show("Done!");
            } catch (Exception ex) {
                MessageBox.Show("Error: " + ex.Message);
            } finally {
                edtFilesToProcess.Visible = false;
                edtPaths.Visible = true;
            }
        }

        #endregion
    }
}
