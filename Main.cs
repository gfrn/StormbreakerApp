using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace StormbreakerApp
{
    public partial class Main : Form
    {
        private List<Value> ValueList = new List<Value>();
        private bool pathSelected = false;
        CultureInfo culture = CultureInfo.InvariantCulture;
        public Main()
        {
            InitializeComponent();
        }

        private void AbrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();

            if (openFileDialog.CheckFileExists)
            {
                pathSelected = true;
                RefreshCells();
            }

        }

        private void ImportButton_Click(object sender, EventArgs e)
        {
            Import import = new Import();
            import.Show();
        }

        private void DateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            RefreshCells(dateTimePicker1.Value, dateTimePicker2.Value);
        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker2.MinDate = dateTimePicker1.Value;
            RefreshCells(dateTimePicker1.Value, dateTimePicker2.Value);
        }

        private void RefreshCells(DateTime minValue, DateTime maxValue)
        {
            if (pathSelected)
            {
                ValueList.Clear();
                using (StreamReader sr = File.OpenText(openFileDialog.FileName))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        if (line.Contains('|') && !line.Contains('@') && !line.Contains("nan"))
                        {
                            Value value = new Value();

                            MatchCollection matches = Regex.Matches(line, @"(?<=\||^)(.*?)(?=\||$)");

                            DateTime Data = DateTime.ParseExact(matches[0].ToString(), "dd/MM/yyyy - HH:mm:ss", culture);
                            if (Data > minValue && maxValue > Data)
                            {
                                value.Data = Data;
                                value.Temperatura = decimal.Parse(matches[1].ToString(), CultureInfo.InvariantCulture);
                                value.Umidade = decimal.Parse(matches[2].ToString(), CultureInfo.InvariantCulture);
                                value.Vento = decimal.Parse(matches[3].ToString(), CultureInfo.InvariantCulture) * 3.14159265m * 2 * 2.8m / 6000;
                                value.UV = decimal.Parse(matches[4].ToString(), CultureInfo.InvariantCulture);
                                value.Luminosidade = decimal.Parse(matches[5].ToString(), CultureInfo.InvariantCulture) / 1024 * 100;

                                ValueList.Add(value);
                            }
                        }
                    }
                    dataGridView1.DataSource = ValueList.Select(Value => new { Value.Data, Value.Temperatura, Value.Umidade, Value.Vento, Value.UV, Value.Luminosidade }).ToList();
                }
            }
        }


        private void RefreshCells()
        {
            RefreshCells(DateTime.MinValue, DateTime.MaxValue);
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://photovoltaic-software.com/principle-ressources/how-calculate-solar-energy-power-pv-systems");
        }

        private void Label10_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://americadosol.org/en/solar-potential-brazil/");
        }

        private void GenButton_Click(object sender, EventArgs e)
        {
            decimal sumLuminosity = 0;
            foreach (Value value in ValueList)
            {
                sumLuminosity += value.Luminosidade > 65 ? 1 : 0;
            }
            decimal baseAnual = coefGenBox.Value * powerBox.Value * radiationBox.Value * areaBox.Value;
            decimal finalValue = Math.Round((sumLuminosity / 525960 * baseAnual), 5);
            genLabel.Text = finalValue.ToString() + " kWh";
            lossLabel.Text = (finalValue * 0.963m).ToString() + " kWh";
        }

        private void Main_Load(object sender, EventArgs e)
        {
            dateTimePicker2.MinDate = dateTimePicker1.Value;
        }

        private void SaveFileDialog_FileOk(object sender, CancelEventArgs e)
        {

            StreamWriter sw = new StreamWriter(saveFileDialog.FileName, false);

            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                sw.Write(dataGridView1.Columns[i].Name + ";");
                if (i > dataGridView1.Columns.Count - 1)
                {
                    sw.WriteLine(";");
                }
            }
            sw.Write(sw.NewLine);
            foreach (Value value in ValueList)
            {
                for (int i = 0; i < dataGridView1.Columns.Count; i++)
                {
                    sw.Write(value.Data + ";" + value.Temperatura + ";" + value.Umidade + ";" + value.Vento + ";" + value.UV + ";" + value.Luminosidade + ";\n");
                }
            }
            sw.Close();
        }

        private void ExportarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog.ShowDialog();
        }
    }
}
