
namespace AudioConverter {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.btn_chooseFile = new System.Windows.Forms.Button();
            this.txt_inFile = new System.Windows.Forms.Label();
            this.txt_inFileType = new System.Windows.Forms.Label();
            this.lbl_inFileType = new System.Windows.Forms.Label();
            this.lbl_inFile = new System.Windows.Forms.Label();
            this.combo_outFileType = new System.Windows.Forms.ComboBox();
            this.lbl_outFileType = new System.Windows.Forms.Label();
            this.btn_convert = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_info = new System.Windows.Forms.Label();
            this.lbl_warning = new System.Windows.Forms.Label();
            this.btn_chooseOutputFolder = new System.Windows.Forms.Button();
            this.lbl_destFolder = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_chooseFile
            // 
            this.btn_chooseFile.Location = new System.Drawing.Point(12, 28);
            this.btn_chooseFile.Name = "btn_chooseFile";
            this.btn_chooseFile.Size = new System.Drawing.Size(75, 23);
            this.btn_chooseFile.TabIndex = 0;
            this.btn_chooseFile.Text = "Choose File";
            this.btn_chooseFile.UseVisualStyleBackColor = true;
            this.btn_chooseFile.Click += new System.EventHandler(this.ChooseFileButton_Click);
            // 
            // txt_inFile
            // 
            this.txt_inFile.AutoSize = true;
            this.txt_inFile.Location = new System.Drawing.Point(93, 28);
            this.txt_inFile.MaximumSize = new System.Drawing.Size(360, 39);
            this.txt_inFile.MinimumSize = new System.Drawing.Size(360, 39);
            this.txt_inFile.Name = "txt_inFile";
            this.txt_inFile.Size = new System.Drawing.Size(360, 39);
            this.txt_inFile.TabIndex = 1;
            this.txt_inFile.Text = "...";
            // 
            // txt_inFileType
            // 
            this.txt_inFileType.AutoSize = true;
            this.txt_inFileType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_inFileType.Location = new System.Drawing.Point(3, 13);
            this.txt_inFileType.Name = "txt_inFileType";
            this.txt_inFileType.Size = new System.Drawing.Size(16, 13);
            this.txt_inFileType.TabIndex = 2;
            this.txt_inFileType.Text = "...";
            // 
            // lbl_inFileType
            // 
            this.lbl_inFileType.AutoSize = true;
            this.lbl_inFileType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_inFileType.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_inFileType.Location = new System.Drawing.Point(3, 0);
            this.lbl_inFileType.Name = "lbl_inFileType";
            this.lbl_inFileType.Size = new System.Drawing.Size(103, 13);
            this.lbl_inFileType.TabIndex = 3;
            this.lbl_inFileType.Text = "Source File Type";
            // 
            // lbl_inFile
            // 
            this.lbl_inFile.AutoSize = true;
            this.lbl_inFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_inFile.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_inFile.Location = new System.Drawing.Point(9, 12);
            this.lbl_inFile.Name = "lbl_inFile";
            this.lbl_inFile.Size = new System.Drawing.Size(27, 13);
            this.lbl_inFile.TabIndex = 4;
            this.lbl_inFile.Text = "File";
            // 
            // combo_outFileType
            // 
            this.combo_outFileType.FormattingEnabled = true;
            this.combo_outFileType.Location = new System.Drawing.Point(69, 56);
            this.combo_outFileType.Name = "combo_outFileType";
            this.combo_outFileType.Size = new System.Drawing.Size(61, 21);
            this.combo_outFileType.TabIndex = 5;
            // 
            // lbl_outFileType
            // 
            this.lbl_outFileType.AutoSize = true;
            this.lbl_outFileType.Location = new System.Drawing.Point(3, 59);
            this.lbl_outFileType.Name = "lbl_outFileType";
            this.lbl_outFileType.Size = new System.Drawing.Size(60, 13);
            this.lbl_outFileType.TabIndex = 6;
            this.lbl_outFileType.Text = "Convert To";
            // 
            // btn_convert
            // 
            this.btn_convert.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_convert.Location = new System.Drawing.Point(12, 215);
            this.btn_convert.Name = "btn_convert";
            this.btn_convert.Size = new System.Drawing.Size(619, 53);
            this.btn_convert.TabIndex = 7;
            this.btn_convert.Text = "Convert";
            this.btn_convert.UseVisualStyleBackColor = true;
            this.btn_convert.Click += new System.EventHandler(this.btn_convert_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.lbl_inFileType);
            this.panel1.Controls.Add(this.txt_inFileType);
            this.panel1.Controls.Add(this.lbl_outFileType);
            this.panel1.Controls.Add(this.combo_outFileType);
            this.panel1.Location = new System.Drawing.Point(471, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(160, 83);
            this.panel1.TabIndex = 8;
            // 
            // lbl_info
            // 
            this.lbl_info.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_info.AutoSize = true;
            this.lbl_info.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_info.Location = new System.Drawing.Point(9, 271);
            this.lbl_info.Name = "lbl_info";
            this.lbl_info.Size = new System.Drawing.Size(16, 13);
            this.lbl_info.TabIndex = 9;
            this.lbl_info.Text = "---";
            // 
            // lbl_warning
            // 
            this.lbl_warning.AutoSize = true;
            this.lbl_warning.Location = new System.Drawing.Point(12, 165);
            this.lbl_warning.Name = "lbl_warning";
            this.lbl_warning.Size = new System.Drawing.Size(0, 13);
            this.lbl_warning.TabIndex = 10;
            // 
            // btn_chooseOutputFolder
            // 
            this.btn_chooseOutputFolder.Location = new System.Drawing.Point(471, 101);
            this.btn_chooseOutputFolder.Name = "btn_chooseOutputFolder";
            this.btn_chooseOutputFolder.Size = new System.Drawing.Size(154, 23);
            this.btn_chooseOutputFolder.TabIndex = 11;
            this.btn_chooseOutputFolder.Text = "Choose Output Folder";
            this.btn_chooseOutputFolder.UseVisualStyleBackColor = true;
            this.btn_chooseOutputFolder.Click += new System.EventHandler(this.btn_chooseOutputFolder_Click);
            // 
            // lbl_destFolder
            // 
            this.lbl_destFolder.AutoSize = true;
            this.lbl_destFolder.Location = new System.Drawing.Point(471, 131);
            this.lbl_destFolder.MaximumSize = new System.Drawing.Size(154, 0);
            this.lbl_destFolder.Name = "lbl_destFolder";
            this.lbl_destFolder.Size = new System.Drawing.Size(16, 13);
            this.lbl_destFolder.TabIndex = 12;
            this.lbl_destFolder.Text = "...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 293);
            this.Controls.Add(this.lbl_destFolder);
            this.Controls.Add(this.btn_chooseOutputFolder);
            this.Controls.Add(this.lbl_warning);
            this.Controls.Add(this.lbl_info);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_convert);
            this.Controls.Add(this.lbl_inFile);
            this.Controls.Add(this.txt_inFile);
            this.Controls.Add(this.btn_chooseFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Audio Converter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_chooseFile;
        private System.Windows.Forms.Label txt_inFile;
        private System.Windows.Forms.Label txt_inFileType;
        private System.Windows.Forms.Label lbl_inFileType;
        private System.Windows.Forms.Label lbl_inFile;
        private System.Windows.Forms.ComboBox combo_outFileType;
        private System.Windows.Forms.Label lbl_outFileType;
        private System.Windows.Forms.Button btn_convert;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_info;
        private System.Windows.Forms.Label lbl_warning;
        private System.Windows.Forms.Button btn_chooseOutputFolder;
        private System.Windows.Forms.Label lbl_destFolder;
    }
}

