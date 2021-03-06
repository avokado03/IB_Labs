using AsymetricLib;
using AsymetricLib.Common;
using IB_Labs.Common;
using System;
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
        private readonly KeyFileService _keyGenerator;
        private readonly RSAEncryptor _encryptor;

        public AsymmetricForm()
        {
            InitializeComponent();
            _keyGenerator = new KeyFileService();
            _encryptor = new RSAEncryptor();
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
                    _keyGenerator.GenerateRSAKeyFiles(dirPath);
                    FormExtensions.GetOkMessage();
                }
            }
            catch (Exception ex)
            {
                errorLabel.Text = ex.Message;
            }
        }

        // выбор файла для шифрования
        private void encryptFileChoiseBtn_Click(object sender, EventArgs e)
        {
            encryptFilePathTextBox.Text = openFileDialog.GetFilteredFileName(FileFilters.ALL, encryptFilePathTextBox.Text);
        }

        // импорт открытого ключа
        private void importPublicKeyBtn_Click(object sender, EventArgs e)
        {
            publicKeyTextBox.Text = openFileDialog.GetFilteredFileName(FileFilters.RSA_KEYS, publicKeyTextBox.Text);
        }

        // выбор файла для дешифрации
        private void decryptFileChoiseBtn_Click(object sender, EventArgs e)
        {
            decryptFilePathTextBox.Text = openFileDialog.GetFilteredFileName(FileFilters.RSA_ENCRYPTED_FILES, decryptFilePathTextBox.Text);
        }

        // импорт закрытого ключа
        private void importPrivateKeyBtn_Click(object sender, EventArgs e)
        {
            privateKeyTextBox.Text = openFileDialog.GetFilteredFileName(FileFilters.RSA_KEYS, privateKeyTextBox.Text);
        }

        // запускает шифрование файла
        private void encryptBtn_Click(object sender, EventArgs e)
        {
            RSARun(encryptFilePathTextBox.Text, publicKeyTextBox.Text, _encryptor.EncryptFile);
        }

        // запускает дешифрацию файла
        private void decryptBtn_Click(object sender, EventArgs e)
        {
            RSARun(decryptFilePathTextBox.Text, privateKeyTextBox.Text, _encryptor.DecryptFile);
        }

        // запускает операции алгоритма RSA
        private void RSARun(string filePath, string key, Action<string, string> operation)
        {
            try
            {
                if (string.IsNullOrEmpty(filePath) || string.IsNullOrEmpty(key))
                    throw new Exception(Common.ExceptionMessages.EMPTY_FIELDS_ERROR_MESSAGE);
                string strKey = _keyGenerator.ReadKeyFile(key);
                operation.Invoke(filePath, strKey);
                errorLabel.Text = "Готово!";
            }
            catch (Exception ex)
            {
                errorLabel.Text = ex.Message;
            }
        }
    }
}
