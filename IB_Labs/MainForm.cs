using System;
using System.Windows.Forms;

namespace IB_Labs
{
    // Главная форма приложения
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        // Событие перехода к Лаб2
        private void symmetricBtn_Click(object sender, EventArgs e)
        {
            var symmetricForm = new SymmetricForm();
            symmetricForm.ShowDialog();
        }

        // Событие перехода к Лаб3
        private void assymmetricBtn_Click(object sender, EventArgs e)
        {
            var assymetricForm = new AsymmetricForm();
            assymetricForm.ShowDialog();
        }

        // Событие перехода к Лаб4
        private void digitalSignatureBtn_Click(object sender, EventArgs e)
        {
            var digitalSignatureForm = new DigitalSignatureForm();
            digitalSignatureForm.ShowDialog();
        }
    }
}
