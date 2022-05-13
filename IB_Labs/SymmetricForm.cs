using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;
using SymmetricLib.Models;
using System.Threading.Tasks;
using IB_Labs.Common;
using SymmetricLib.Services;

namespace IB_Labs
{
    // Форма задания для лабораторной №2
    // (Сравнение производительности симметричных алгоритмов шифрования)
    public partial class SymmetricForm : Form
    {
        private readonly SymmetricDataService _dataService;

        public SymmetricForm()
        {
            InitializeComponent();
            _dataService = new SymmetricDataService();
        }

        // Кнопка, открывающая диалог выбора файла
        private void fileChoiseBtn_Click(object sender, EventArgs e)
        {
            filePathTextBox.Text = openFileDialog.GetFilteredFileName(FileFilters.ALL, filePathTextBox.Text);
        }

        // Выбор файла
        private void openFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            filePathTextBox.Text = string.Empty;
            errorLabel.Text = string.Empty;
            var fileName = openFileDialog.FileName;
            try
            {
                bool isFileCorrect = openFileDialog.CheckFileExists && openFileDialog.CheckPathExists;                
                if (!isFileCorrect)
                    throw new FileNotFoundException
                        (ExceptionMessages.FILE_NOT_FOUND_ERROR_MESSAGE, fileName);
            }
            catch (Exception ex)
            {
                errorLabel.Text = ex.Message;
            }
        }

        // Запускает шифрацию/дешифрацию
        private void startBtn_Click(object sender, EventArgs e)
        {
            string path = filePathTextBox.Text;
            string password = passwordTextBox.Text;
            Action<string, bool> setBtnsParams = (string text, bool enabled) => 
            {
                startBtn.Text = text;
                fileChoiseBtn.Enabled = enabled;
                startBtn.Enabled = enabled;
            };
            

            Action getData = async () => 
            {
                try
                {
                    summaryDataGridView.DataSource = null;

                    if (password == string.Empty || string.IsNullOrWhiteSpace(password))
                        throw new ArgumentException(ExceptionMessages.PASSWORD_ERROR_MESSAGE);

                    var parameters = new AlgorithmParametersModel(path, password);
                    setBtnsParams.Invoke("Подождите...", false);
                    summaryDataGridView.DataSource = await _dataService.GetAlgorithmResults(parameters);
                }
                catch (Exception ex)
                {
                    errorLabel.Text = ex.Message;
                    summaryDataGridView.DataSource = null;
                }
                finally
                {
                    setBtnsParams.Invoke("Старт", true);
                }
            };

            Task.Run(() => summaryDataGridView.BeginInvoke(getData));
        }
    }
}
