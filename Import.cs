using System;
using System.IO;
using System.IO.Ports;
using System.Windows.Forms;

namespace StormbreakerApp
{
    public partial class Import : Form
    {
        private SerialPort serialPort = new SerialPort();
        private string savePath;
        public Import()
        {
            InitializeComponent();
        }

        private void RefreshPorts()
        {
            string[] ports = SerialPort.GetPortNames();

            portBox.Items.AddRange(ports);

            if (ports.Length > 0)
            {
                portBox.SelectedIndex = 0;
            }
        }

        private void Import_Load(object sender, EventArgs e)
        {
            RefreshPorts();
        }

        private void PortBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            serialPort.PortName = portBox.Text;
        }

        private void ImportButton_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                serialPort.BaudRate = 9600;
                serialPort.Open();

                string input;

                while (true)
                {
                    serialPort.Write("l");
                    input = serialPort.ReadExisting();

                    if (input == "")
                    {
                        break;
                    }
                    else if (input.Contains("|"))
                    {
                        importedLog.Text += input;
                    }

                };

                if (importedLog.Text.Length > 5)
                {
                    saveButton.Enabled = true;
                }

                serialPort.Close();
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            saveFileDialog.ShowDialog();

            if (Directory.Exists(saveFileDialog.FileName))
            {
                File.WriteAllText(saveFileDialog.FileName, importedLog.Text);

                importedLog.Clear();
            }
        }

        private void PortBox_TextUpdate(object sender, EventArgs e)
        {
            if (portBox.Text.Length > 3)
            {
                importButton.Enabled = true;
            }
            else
            {
                importButton.Enabled = false;
            }
        }

        private void RtcButton_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                serialPort.BaudRate = 9600;
                serialPort.Open();

                serialPort.Write("d");

                MessageBox.Show("Novo horário estabelecido!", "Sucesso!");

                serialPort.Close();
            }
        }
    }
}
