namespace StormbreakerApp
{
    partial class Import
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
            this.portBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.importedLog = new System.Windows.Forms.TextBox();
            this.importButton = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.saveButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rtcButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // portBox
            // 
            this.portBox.FormattingEnabled = true;
            this.portBox.Location = new System.Drawing.Point(44, 22);
            this.portBox.Name = "portBox";
            this.portBox.Size = new System.Drawing.Size(130, 21);
            this.portBox.TabIndex = 0;
            this.portBox.SelectedIndexChanged += new System.EventHandler(this.PortBox_SelectedIndexChanged);
            this.portBox.TextUpdate += new System.EventHandler(this.PortBox_TextUpdate);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Porta:";
            // 
            // importedLog
            // 
            this.importedLog.Location = new System.Drawing.Point(194, 12);
            this.importedLog.Multiline = true;
            this.importedLog.Name = "importedLog";
            this.importedLog.ReadOnly = true;
            this.importedLog.Size = new System.Drawing.Size(336, 169);
            this.importedLog.TabIndex = 2;
            // 
            // importButton
            // 
            this.importButton.Location = new System.Drawing.Point(6, 57);
            this.importButton.Name = "importButton";
            this.importButton.Size = new System.Drawing.Size(168, 23);
            this.importButton.TabIndex = 3;
            this.importButton.Text = "Importar";
            this.importButton.UseVisualStyleBackColor = true;
            this.importButton.Click += new System.EventHandler(this.ImportButton_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "Arquivo de Texto|*.txt";
            // 
            // saveButton
            // 
            this.saveButton.Enabled = false;
            this.saveButton.Location = new System.Drawing.Point(6, 86);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(168, 23);
            this.saveButton.TabIndex = 7;
            this.saveButton.Text = "Salvar";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.importButton);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.portBox);
            this.groupBox1.Controls.Add(this.saveButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(180, 117);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Importar";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rtcButton);
            this.groupBox2.Location = new System.Drawing.Point(12, 129);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(180, 52);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Configurar";
            // 
            // rtcButton
            // 
            this.rtcButton.Location = new System.Drawing.Point(6, 20);
            this.rtcButton.Name = "rtcButton";
            this.rtcButton.Size = new System.Drawing.Size(168, 23);
            this.rtcButton.TabIndex = 0;
            this.rtcButton.Text = "Atualizar Horário";
            this.rtcButton.UseVisualStyleBackColor = true;
            this.rtcButton.Click += new System.EventHandler(this.RtcButton_Click);
            // 
            // Import
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 191);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.importedLog);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Import";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Estação";
            this.Load += new System.EventHandler(this.Import_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox portBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox importedLog;
        private System.Windows.Forms.Button importButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button rtcButton;
    }
}