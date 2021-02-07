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
            string selectedLetter =  comboBox1.GetItemText(comboBox1.SelectedItem);
            MessageBox.Show(selectedLetter);
        }

        private void loadData_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileExplorer = new OpenFileDialog();
            if (fileExplorer.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string names = fileExplorer.FileName;
                    SetPathInLabel(names);
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
    }
}
