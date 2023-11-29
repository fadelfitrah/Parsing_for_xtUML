using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Parsing_for_xtUML_model
{
    public partial class Form1 : Form
    {
        private string[] fileSelected;

        public Form1()
        {
            InitializeComponent();
        }

        private void textPath_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void srcFile_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDialog = new FolderBrowserDialog();
            folderDialog.ShowDialog();

            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
                string folderName = folderDialog.SelectedPath;
                textPath.Text = folderName;
                ProcessFiles(folderName);
            }
        }

        private void ProcessFiles(string folderName)
        {
            try
            {
                this.fileSelected = Directory.GetFiles(folderName, "*.json");
                if (this.fileSelected.Length == 0)
                {
                    MessageBox.Show("Tidak ada file JSON yang ditemukan di folder ini.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void startCheck_Click(object sender, EventArgs e)
        {
            if (fileSelected.Length == 0 || fileSelected == null)
            {
                MessageBox.Show("Pilih folder yang berisi file JSON terlebih dahulu.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            List<string> jsonArrayList = new List<string>();

            foreach (var fileName in fileSelected)
            {
                try
                {
                    string jsonContent = File.ReadAllText(fileName);
                    jsonArrayList.Add(jsonContent);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error membaca file {Path.GetFileName(fileName)}: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            JArray jsonArray = new JArray(jsonArrayList.Select(JToken.Parse));

            ParsingPoint.Point25(jsonArray);
        }
    }
}
