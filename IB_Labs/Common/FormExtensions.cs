using System.Windows.Forms;

namespace IB_Labs.Common
{
    /// <summary>
    /// Расширения для компонентов форм
    /// </summary>
    public static class FormExtensions
    {
        /// <summary>
        /// Расширение для диалогового окна выбора файла
        /// с применением фильтрации
        /// </summary>
        public static string GetFilteredFileName(this OpenFileDialog fileDialog, string filter, string defaultName = "")
        {
            fileDialog.Filter = filter;
            fileDialog.FileName = string.Empty;
            if (fileDialog.ShowDialog() == DialogResult.OK)
                return fileDialog.FileName;
            return defaultName;
        }

        /// <summary>
        /// Отображает стандартный результат удачной операции
        /// </summary>
        public static void GetOkMessage()
        {
            MessageBox.Show("Готово!", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
