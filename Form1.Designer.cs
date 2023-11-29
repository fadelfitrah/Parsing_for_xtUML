namespace Parsing_for_xtUML_model
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
            label1 = new Label();
            srcFile = new Button();
            textPath = new TextBox();
            startCheck = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(80, 156);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
            label1.TabIndex = 0;
            label1.Text = "Nama File : ";
            // 
            // srcFile
            // 
            srcFile.Location = new Point(603, 152);
            srcFile.Name = "srcFile";
            srcFile.Size = new Size(94, 29);
            srcFile.TabIndex = 1;
            srcFile.Text = "Cari";
            srcFile.UseVisualStyleBackColor = true;
            srcFile.Click += srcFile_Click;
            // 
            // textPath
            // 
            textPath.Location = new Point(170, 152);
            textPath.Name = "textPath";
            textPath.Size = new Size(423, 27);
            textPath.TabIndex = 2;
            textPath.TextChanged += textPath_TextChanged;
            // 
            // startCheck
            // 
            startCheck.BackColor = Color.Chartreuse;
            startCheck.Cursor = Cursors.Hand;
            startCheck.ForeColor = SystemColors.ActiveCaptionText;
            startCheck.Location = new Point(311, 371);
            startCheck.Name = "startCheck";
            startCheck.Size = new Size(177, 52);
            startCheck.TabIndex = 3;
            startCheck.Text = "Mulai Parsing";
            startCheck.UseVisualStyleBackColor = false;
            startCheck.Click += startCheck_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(801, 468);
            Controls.Add(startCheck);
            Controls.Add(textPath);
            Controls.Add(srcFile);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button srcFile;
        private TextBox textPath;
        private Button startCheck;
    }
}
