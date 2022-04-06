using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;
using SymmetricLib.Common;

namespace IB_Labs
{
    // Форма задания для лабораторной №2
    // (Сравнение производительности симметричных алгоритмов шифрования)
    public partial class SymmetricForm : Form
    {
        public SymmetricForm()
        {
            InitializeComponent();
        }

        // Кнопка, открывающая диалог выбора файла
        private void fileChoiseBtn_Click(object sender, EventArgs e)
        {
            if(openFileDialog.ShowDialog() == DialogResult.OK)
                filePathTextBox.Text = openFileDialog.FileName;
        }

        // Выбор файла
        private void openFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            filePathTextBox.Text = string.Empty;
            ErrorLabel.Text = string.Empty;
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
                ErrorLabel.Text = ex.Message;
            }
        }

        // Запускает шифрацию/дешифрацию
        private void startBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
