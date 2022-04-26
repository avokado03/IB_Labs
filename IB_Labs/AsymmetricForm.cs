using AsymetricLib.Common;
using Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IB_Labs
{
    /// <summary>
    /// Лабораторная работа № 3 
    /// «Изучение возможностей реализации 
    /// асимметричного шифрования в .NET»
    /// </summary>
    public partial class AsymmetricForm : Form
    {
        private readonly KeyGenerator _keyGenerator;

        public AsymmetricForm()
        {
            InitializeComponent();
            _keyGenerator = new KeyGenerator();
        }

        // Запускае процесс генерации ключей
        private void generateBtn_Click(object sender, EventArgs e)
        {
            string dirPath;
            try
            {
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    dirPath = folderBrowserDialog.SelectedPath;
                    _keyGenerator.Generate(dirPath);
                    MessageBox.Show("Готово!", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (NotSupportedException)
            {
                errorLabel.Text = ExceptionMessages.NOT_SUPPORTED_PATH_ERROR_MESSAGE;
            }
            catch (Exception ex) 
            {
                errorLabel.Text = ex.Message;
            }
        }

        private void fileChoiseBtn_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
                MessageBox.Show(openFileDialog.FileName);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void encryptBtn_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void decryptBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
