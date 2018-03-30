namespace ImageTransfer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.filepathLabel = new System.Windows.Forms.Label();
            this.filePath = new System.Windows.Forms.Label();
            this.filePathButton = new System.Windows.Forms.Button();
            this.seFilePath = new System.Windows.Forms.Label();
            this.seFilePathLabel = new System.Windows.Forms.Label();
            this.seFilePathButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("PMingLiU", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(211, 111);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(705, 96);
            this.button1.TabIndex = 0;
            this.button1.Text = "A:html的base64抽出存jpeg與無base64的html";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("PMingLiU", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button2.Location = new System.Drawing.Point(211, 264);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(705, 102);
            this.button2.TabIndex = 1;
            this.button2.Text = "B:html讀jpeg轉base64";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // filepathLabel
            // 
            this.filepathLabel.AutoSize = true;
            this.filepathLabel.Font = new System.Drawing.Font("PMingLiU", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.filepathLabel.Location = new System.Drawing.Point(16, 61);
            this.filepathLabel.Name = "filepathLabel";
            this.filepathLabel.Size = new System.Drawing.Size(319, 24);
            this.filepathLabel.TabIndex = 2;
            this.filepathLabel.Text = "jpeg及無base64html存放路徑：";
            // 
            // filePath
            // 
            this.filePath.AutoSize = true;
            this.filePath.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.filePath.Location = new System.Drawing.Point(335, 65);
            this.filePath.Name = "filePath";
            this.filePath.Size = new System.Drawing.Size(0, 20);
            this.filePath.TabIndex = 3;
            // 
            // filePathButton
            // 
            this.filePathButton.Font = new System.Drawing.Font("PMingLiU", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.filePathButton.Location = new System.Drawing.Point(29, 111);
            this.filePathButton.Name = "filePathButton";
            this.filePathButton.Size = new System.Drawing.Size(154, 96);
            this.filePathButton.TabIndex = 4;
            this.filePathButton.Text = "1:設定儲存路徑";
            this.filePathButton.UseVisualStyleBackColor = true;
            this.filePathButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // seFilePath
            // 
            this.seFilePath.AutoSize = true;
            this.seFilePath.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.seFilePath.Location = new System.Drawing.Point(207, 237);
            this.seFilePath.Name = "seFilePath";
            this.seFilePath.Size = new System.Drawing.Size(0, 20);
            this.seFilePath.TabIndex = 6;
            // 
            // seFilePathLabel
            // 
            this.seFilePathLabel.AutoSize = true;
            this.seFilePathLabel.Font = new System.Drawing.Font("PMingLiU", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.seFilePathLabel.Location = new System.Drawing.Point(16, 237);
            this.seFilePathLabel.Name = "seFilePathLabel";
            this.seFilePathLabel.Size = new System.Drawing.Size(197, 24);
            this.seFilePathLabel.TabIndex = 5;
            this.seFilePathLabel.Text = "還原se存放路徑：";
            // 
            // seFilePathButton
            // 
            this.seFilePathButton.Font = new System.Drawing.Font("PMingLiU", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.seFilePathButton.Location = new System.Drawing.Point(34, 270);
            this.seFilePathButton.Name = "seFilePathButton";
            this.seFilePathButton.Size = new System.Drawing.Size(154, 96);
            this.seFilePathButton.TabIndex = 7;
            this.seFilePathButton.Text = "2:設定儲存路徑";
            this.seFilePathButton.UseVisualStyleBackColor = true;
            this.seFilePathButton.Click += new System.EventHandler(this.seFilePathButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(31, 406);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(812, 300);
            this.label1.TabIndex = 8;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 762);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.seFilePathButton);
            this.Controls.Add(this.seFilePath);
            this.Controls.Add(this.seFilePathLabel);
            this.Controls.Add(this.filePathButton);
            this.Controls.Add(this.filePath);
            this.Controls.Add(this.filepathLabel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label filepathLabel;
        private System.Windows.Forms.Label filePath;
        private System.Windows.Forms.Button filePathButton;
        private System.Windows.Forms.Label seFilePath;
        private System.Windows.Forms.Label seFilePathLabel;
        private System.Windows.Forms.Button seFilePathButton;
        private System.Windows.Forms.Label label1;
    }
}

