namespace StormbreakerApp
{
    partial class Main
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
            this.barMenu = new System.Windows.Forms.ToolStrip();
            this.arquivoButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportarComoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importButton = new System.Windows.Forms.ToolStripLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.genButton = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label11 = new System.Windows.Forms.Label();
            this.radiationBox = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.areaBox = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.powerBox = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.coefGenBox = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.genLabel = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lossLabel = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.barMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radiationBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.areaBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.powerBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coefGenBox)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // barMenu
            // 
            this.barMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoButton,
            this.importButton});
            this.barMenu.Location = new System.Drawing.Point(0, 0);
            this.barMenu.Name = "barMenu";
            this.barMenu.Size = new System.Drawing.Size(1046, 25);
            this.barMenu.TabIndex = 0;
            this.barMenu.Text = "toolStrip1";
            // 
            // arquivoButton
            // 
            this.arquivoButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.arquivoButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem,
            this.exportarComoToolStripMenuItem});
            this.arquivoButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.arquivoButton.Name = "arquivoButton";
            this.arquivoButton.Size = new System.Drawing.Size(62, 22);
            this.arquivoButton.Text = "Arquivo";
            this.arquivoButton.ToolTipText = "Arquivo";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.AbrirToolStripMenuItem_Click);
            // 
            // exportarComoToolStripMenuItem
            // 
            this.exportarComoToolStripMenuItem.Name = "exportarComoToolStripMenuItem";
            this.exportarComoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exportarComoToolStripMenuItem.Text = "Exportar Como";
            this.exportarComoToolStripMenuItem.Click += new System.EventHandler(this.ExportarComoToolStripMenuItem_Click);
            // 
            // importButton
            // 
            this.importButton.Name = "importButton";
            this.importButton.Size = new System.Drawing.Size(47, 22);
            this.importButton.Text = "Estação";
            this.importButton.Click += new System.EventHandler(this.ImportButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Arquivo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "nenhum";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(516, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(518, 409);
            this.dataGridView1.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(130, 44);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(178, 20);
            this.dateTimePicker1.TabIndex = 4;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.DateTimePicker1_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(314, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "a";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mostrar resultados de:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(332, 43);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(178, 20);
            this.dateTimePicker2.TabIndex = 7;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.DateTimePicker2_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.genButton);
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.radiationBox);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.areaBox);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.powerBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.coefGenBox);
            this.groupBox1.Location = new System.Drawing.Point(16, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(295, 163);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cálculo de Geração";
            // 
            // genButton
            // 
            this.genButton.Location = new System.Drawing.Point(175, 134);
            this.genButton.Name = "genButton";
            this.genButton.Size = new System.Drawing.Size(114, 23);
            this.genButton.TabIndex = 12;
            this.genButton.Text = "Gerar Resultados";
            this.genButton.UseVisualStyleBackColor = true;
            this.genButton.Click += new System.EventHandler(this.GenButton_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel1.Location = new System.Drawing.Point(7, 144);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(131, 13);
            this.linkLabel1.TabIndex = 11;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Referências para Cálculos";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(234, 98);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "kWh/m².a";
            // 
            // radiationBox
            // 
            this.radiationBox.DecimalPlaces = 1;
            this.radiationBox.Location = new System.Drawing.Point(150, 96);
            this.radiationBox.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.radiationBox.Name = "radiationBox";
            this.radiationBox.Size = new System.Drawing.Size(78, 20);
            this.radiationBox.TabIndex = 9;
            this.radiationBox.Value = new decimal(new int[] {
            1825,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 98);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Radiação Solar Anual";
            this.toolTip.SetToolTip(this.label10, "Incidência de radiação solar por metro quadrado anual do local onde o painel está" +
        " instalado. O valor médio brasileiro é 1825 kWh/m² por ano. Clique para mais inf" +
        "ormações.");
            this.label10.Click += new System.EventHandler(this.Label10_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(234, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "m²";
            // 
            // areaBox
            // 
            this.areaBox.DecimalPlaces = 1;
            this.areaBox.Location = new System.Drawing.Point(150, 71);
            this.areaBox.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.areaBox.Name = "areaBox";
            this.areaBox.Size = new System.Drawing.Size(78, 20);
            this.areaBox.TabIndex = 6;
            this.areaBox.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Área do Painel";
            this.toolTip.SetToolTip(this.label8, "Área utilizável do painel.");
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(234, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "kWp";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Potência do Painel";
            this.toolTip.SetToolTip(this.label6, "Potência elétrica do painel. Recomenda-se checar com o fabricante");
            // 
            // powerBox
            // 
            this.powerBox.DecimalPlaces = 3;
            this.powerBox.Location = new System.Drawing.Point(150, 45);
            this.powerBox.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.powerBox.Name = "powerBox";
            this.powerBox.Size = new System.Drawing.Size(78, 20);
            this.powerBox.TabIndex = 2;
            this.powerBox.Value = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Coeficiente de Performance";
            this.toolTip.SetToolTip(this.label5, "Coeficiente de Performance/Perdas de seu painel. O valor médio é 0,75. Recomenda-" +
        "se checar com o fabricante caso não exista certeza.");
            // 
            // coefGenBox
            // 
            this.coefGenBox.DecimalPlaces = 3;
            this.coefGenBox.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.coefGenBox.Location = new System.Drawing.Point(150, 19);
            this.coefGenBox.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            65536});
            this.coefGenBox.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.coefGenBox.Name = "coefGenBox";
            this.coefGenBox.Size = new System.Drawing.Size(78, 20);
            this.coefGenBox.TabIndex = 0;
            this.coefGenBox.Value = new decimal(new int[] {
            75,
            0,
            0,
            131072});
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lossLabel);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.genLabel);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Location = new System.Drawing.Point(317, 83);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(193, 163);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resultados";
            // 
            // genLabel
            // 
            this.genLabel.AutoSize = true;
            this.genLabel.Location = new System.Drawing.Point(7, 65);
            this.genLabel.Name = "genLabel";
            this.genLabel.Size = new System.Drawing.Size(53, 13);
            this.genLabel.TabIndex = 1;
            this.genLabel.Text = "N/A kWh";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(181, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Geração média ao longo do período:";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "Planilha do Excel|*.csv|Arquivo de Texto|*.txt";
            this.saveFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.SaveFileDialog_FileOk);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 52);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(117, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "Valor Máximo Possível:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 103);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(134, 13);
            this.label14.TabIndex = 3;
            this.label14.Text = "Valor com Perdas Comuns:";
            this.toolTip.SetToolTip(this.label14, "Valor corrigido considerando perdas comuns para poeira, sombras não-planejadas e " +
        "falta de manutenção que desviam das perdas comuns. Geralmente 4.7% em média");
            // 
            // lossLabel
            // 
            this.lossLabel.AutoSize = true;
            this.lossLabel.Location = new System.Drawing.Point(7, 116);
            this.lossLabel.Name = "lossLabel";
            this.lossLabel.Size = new System.Drawing.Size(53, 13);
            this.lossLabel.TabIndex = 4;
            this.lossLabel.Text = "N/A kWh";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(12, 249);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(501, 13);
            this.label15.TabIndex = 10;
            this.label15.Text = "Os resultados mostrados podem não corresponder completamente à realidade, utilize" +
    "-os como estimativa.";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 450);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.barMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "Stormbreaker";
            this.barMenu.ResumeLayout(false);
            this.barMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radiationBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.areaBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.powerBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coefGenBox)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip barMenu;
        private System.Windows.Forms.ToolStripDropDownButton arquivoButton;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripLabel importButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown coefGenBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown radiationBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown areaBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown powerBox;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Button genButton;
        private System.Windows.Forms.Label genLabel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ToolStripMenuItem exportarComoToolStripMenuItem;
        private System.Windows.Forms.Label lossLabel;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
    }
}

