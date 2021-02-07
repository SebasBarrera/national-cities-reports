using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_1.model;

namespace Project_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedLetter = comboBox1.GetItemText(comboBox1.SelectedItem);
            MessageBox.Show(selectedLetter);
        }

        private void loadData_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileExplorer = new OpenFileDialog();
            if (fileExplorer.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string absolutePathFile = fileExplorer.FileName;
                    SetPathInLabel(absolutePathFile);

                    if (absolutePathFile.Contains(".csv"))
                    {


                    }
                    else
                    {
                        MessageBox.Show("Error, no se puede leer el archivo seleccionado.");
                        SetPathInLabel("-- Ruta del archivo seleccionado --");
                    }


                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                }

            }
        }

        private void SetPathInLabel(string text)
        {
            path.Text = text;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string labelText = path.Text;
            string textComboBox = comboBox1.GetItemText(comboBox1.SelectedItem);

            if (!(Char.Equals(labelText[0], "-")) && !(String.Equals(textComboBox, "")))
            {

            }
            else
            {
                MessageBox.Show("Error, no has seleccionado una letra o no has cargado un archivo");
            }
        }
    }
}
