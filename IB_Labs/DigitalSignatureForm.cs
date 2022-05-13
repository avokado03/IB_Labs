using System;
using System.Windows.Forms;
using IB_Labs.Common;
using DigitalSignatureLibrary;
using System.Linq;

namespace IB_Labs
{
    // Форма задания для лабораторной №4
    // (Изучение возможностей реализации алгоритмов электронной цифровой подписи в .NET)
    public partial class DigitalSignatureForm : Form
    {
        private readonly SignatureService _signatureService;

        public DigitalSignatureForm()
        {
            InitializeComponent();
            _signatureService = new SignatureService();
        }

        // выбор подписываемого файла
        private void signFileChoiseBtn_Click(object sender, EventArgs e)
        {
            filePathTextBox.Text = openFileDialog.GetFilteredFileName(FileFilters.ALL, filePathTextBox.Text);
        }

        // выбор файла для валидации
        private void checkSignFileChoiseBtn_Click(object sender, EventArgs e)
        {
            checkSignFilePathTextBox.Text = openFileDialog.GetFilteredFileName(FileFilters.ALL, checkSignFilePathTextBox.Text);
        }

        // выбор файла ЭЦП-сигнатуры
        private void importSignatureBtn_Click(object sender, EventArgs e)
        {
            signFilePathTextBox.Text = openFileDialog.GetFilteredFileName(FileFilters.ECDSA_SIGNATURE, signFilePathTextBox.Text);
        }

        // выбор файла с публичным ключом для ЭЦП
        private void importPublicKeyBtn_Click(object sender, EventArgs e)
        {
            publicKeyTextBox.Text = openFileDialog.GetFilteredFileName(FileFilters.ECDSA_KEYS, publicKeyTextBox.Text);
        }

        // Запускает генерацию ЭЦП и ее запись в файл
        private void signBtn_Click(object sender, EventArgs e)
        {
            errorLabel.Text = string.Empty;
            var filePath = filePathTextBox.Text;
            try
            {
                if (string.IsNullOrEmpty(filePath))
                    throw new Exception(ExceptionMessages.EMPTY_FIELDS_ERROR_MESSAGE);                
                _signatureService.WriteSignatureToFile(filePath);
                FormExtensions.GetOkMessage();
            }
            catch(Exception ex)
            {
                errorLabel.Text = ex.Message;
            }
        }

        // Запускает проверку ЭЦП
        private void validateBtn_Click(object sender, EventArgs e)
        {
            errorLabel.Text = string.Empty;
            var filePath = checkSignFilePathTextBox.Text;
            var publicKeyPath = publicKeyTextBox.Text;
            var signaturePath = signFilePathTextBox.Text;
            bool condition = new[] { filePath, publicKeyPath, signaturePath }
                             .Any(x => string.IsNullOrEmpty(x));
            try
            {
                if (condition)
                    throw new Exception(ExceptionMessages.EMPTY_FIELDS_ERROR_MESSAGE);
                bool isValid = _signatureService.Validate(filePath, publicKeyPath, signaturePath);
                errorLabel.Text = isValid ? "Подпись валидна" : "Подпись невалидна";
            }
            catch(Exception ex)
            {
                errorLabel.Text = ex.Message;
            }
        }
    }
}
