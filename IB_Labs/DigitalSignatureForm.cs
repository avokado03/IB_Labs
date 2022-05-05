﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IB_Labs.Common;

namespace IB_Labs
{
    public partial class DigitalSignatureForm : Form
    {
        public DigitalSignatureForm()
        {
            InitializeComponent();
        }

        private void signBtn_Click(object sender, EventArgs e)
        {
        //https://social.msdn.microsoft.com/Forums/vstudio/en-US/57b1f383-37dd-46dc-9bee-2cb6c6b73691/cryptography-ecdsa-how-to-save-private-key-to-the-file?forum=csharpgeneral
        }

        private void signFileChoiseBtn_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = FileFilters.ALL;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
                filePathTextBox.Text = openFileDialog.FileName;
        }

        private void checkSignFileChoiseBtn_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = FileFilters.ALL;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
                checkSignFilePathTextBox.Text = openFileDialog.FileName;
        }

        private void importSignatureBtn_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = FileFilters.DSA_KEYS;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
                signFilePathTextBox.Text = openFileDialog.FileName;
        }

        private void encryptBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
