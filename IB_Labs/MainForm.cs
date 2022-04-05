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
    // Главная форма приложения
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        // Событие перехода к Лаб2
        private void SymmetricBtn_Click(object sender, EventArgs e)
        {
            var symmetricForm = new SymmetricForm();
            symmetricForm.ShowDialog();
        }

        // Событие перехода к Лаб3
        private void AssymmetricBtn_Click(object sender, EventArgs e)
        {
            var assymetricForm = new AssymmetricForm();
            assymetricForm.ShowDialog();
        }

        // Событие перехода к Лаб4
        private void DigitalSignatureBtn_Click(object sender, EventArgs e)
        {
            var digitalSignatureForm = new DigitalSignatureForm();
            digitalSignatureForm.ShowDialog();
        }
    }
}
