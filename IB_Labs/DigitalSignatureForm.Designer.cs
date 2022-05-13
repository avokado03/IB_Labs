
namespace IB_Labs
{
    partial class DigitalSignatureForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.signGroupBox = new System.Windows.Forms.GroupBox();
            this.signBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.signFileChoiseBtn = new System.Windows.Forms.Button();
            this.filePathTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkSignGroupBox = new System.Windows.Forms.GroupBox();
            this.importPublicKeyBtn = new System.Windows.Forms.Button();
            this.publicKeyTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.importSignatureBtn = new System.Windows.Forms.Button();
            this.signFilePathTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.validateBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.checkSignFileChoiseBtn = new System.Windows.Forms.Button();
            this.checkSignFilePathTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.signGroupBox.SuspendLayout();
            this.checkSignGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // signGroupBox
            // 
            this.signGroupBox.Controls.Add(this.signBtn);
            this.signGroupBox.Controls.Add(this.label1);
            this.signGroupBox.Controls.Add(this.signFileChoiseBtn);
            this.signGroupBox.Controls.Add(this.filePathTextBox);
            this.signGroupBox.Controls.Add(this.label3);
            this.signGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.signGroupBox.Location = new System.Drawing.Point(0, 0);
            this.signGroupBox.Name = "signGroupBox";
            this.signGroupBox.Size = new System.Drawing.Size(800, 100);
            this.signGroupBox.TabIndex = 11;
            this.signGroupBox.TabStop = false;
            this.signGroupBox.Text = "Создание подписи";
            // 
            // signBtn
            // 
            this.signBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.signBtn.Location = new System.Drawing.Point(3, 56);
            this.signBtn.Name = "signBtn";
            this.signBtn.Size = new System.Drawing.Size(785, 33);
            this.signBtn.TabIndex = 14;
            this.signBtn.Text = "Подписать файл";
            this.signBtn.UseVisualStyleBackColor = true;
            this.signBtn.Click += new System.EventHandler(this.signBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(15, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 9;
            // 
            // signFileChoiseBtn
            // 
            this.signFileChoiseBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.signFileChoiseBtn.Location = new System.Drawing.Point(693, 20);
            this.signFileChoiseBtn.Name = "signFileChoiseBtn";
            this.signFileChoiseBtn.Size = new System.Drawing.Size(95, 31);
            this.signFileChoiseBtn.TabIndex = 4;
            this.signFileChoiseBtn.Text = "Выбор";
            this.signFileChoiseBtn.UseVisualStyleBackColor = true;
            this.signFileChoiseBtn.Click += new System.EventHandler(this.signFileChoiseBtn_Click);
            // 
            // filePathTextBox
            // 
            this.filePathTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filePathTextBox.Location = new System.Drawing.Point(243, 24);
            this.filePathTextBox.Name = "filePathTextBox";
            this.filePathTextBox.ReadOnly = true;
            this.filePathTextBox.Size = new System.Drawing.Size(444, 22);
            this.filePathTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Файл данных для подписи:";
            // 
            // checkSignGroupBox
            // 
            this.checkSignGroupBox.Controls.Add(this.importPublicKeyBtn);
            this.checkSignGroupBox.Controls.Add(this.publicKeyTextBox);
            this.checkSignGroupBox.Controls.Add(this.label6);
            this.checkSignGroupBox.Controls.Add(this.importSignatureBtn);
            this.checkSignGroupBox.Controls.Add(this.signFilePathTextBox);
            this.checkSignGroupBox.Controls.Add(this.label4);
            this.checkSignGroupBox.Controls.Add(this.validateBtn);
            this.checkSignGroupBox.Controls.Add(this.label2);
            this.checkSignGroupBox.Controls.Add(this.checkSignFileChoiseBtn);
            this.checkSignGroupBox.Controls.Add(this.checkSignFilePathTextBox);
            this.checkSignGroupBox.Controls.Add(this.label5);
            this.checkSignGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkSignGroupBox.Location = new System.Drawing.Point(0, 100);
            this.checkSignGroupBox.Name = "checkSignGroupBox";
            this.checkSignGroupBox.Size = new System.Drawing.Size(800, 172);
            this.checkSignGroupBox.TabIndex = 12;
            this.checkSignGroupBox.TabStop = false;
            this.checkSignGroupBox.Text = "Проверка подписи";
            // 
            // importPublicKeyBtn
            // 
            this.importPublicKeyBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.importPublicKeyBtn.Location = new System.Drawing.Point(695, 55);
            this.importPublicKeyBtn.Name = "importPublicKeyBtn";
            this.importPublicKeyBtn.Size = new System.Drawing.Size(92, 31);
            this.importPublicKeyBtn.TabIndex = 20;
            this.importPublicKeyBtn.Text = "Импорт";
            this.importPublicKeyBtn.UseVisualStyleBackColor = true;
            this.importPublicKeyBtn.Click += new System.EventHandler(this.importPublicKeyBtn_Click);
            // 
            // publicKeyTextBox
            // 
            this.publicKeyTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.publicKeyTextBox.Location = new System.Drawing.Point(242, 59);
            this.publicKeyTextBox.Name = "publicKeyTextBox";
            this.publicKeyTextBox.ReadOnly = true;
            this.publicKeyTextBox.Size = new System.Drawing.Size(444, 22);
            this.publicKeyTextBox.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(174, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "Файл публичного ключа:";
            // 
            // importSignatureBtn
            // 
            this.importSignatureBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.importSignatureBtn.Location = new System.Drawing.Point(696, 92);
            this.importSignatureBtn.Name = "importSignatureBtn";
            this.importSignatureBtn.Size = new System.Drawing.Size(92, 31);
            this.importSignatureBtn.TabIndex = 17;
            this.importSignatureBtn.Text = "Импорт";
            this.importSignatureBtn.UseVisualStyleBackColor = true;
            this.importSignatureBtn.Click += new System.EventHandler(this.importSignatureBtn_Click);
            // 
            // signFilePathTextBox
            // 
            this.signFilePathTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.signFilePathTextBox.Location = new System.Drawing.Point(243, 96);
            this.signFilePathTextBox.Name = "signFilePathTextBox";
            this.signFilePathTextBox.ReadOnly = true;
            this.signFilePathTextBox.Size = new System.Drawing.Size(444, 22);
            this.signFilePathTextBox.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(120, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Файл подписи:";
            // 
            // validateBtn
            // 
            this.validateBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.validateBtn.Location = new System.Drawing.Point(3, 129);
            this.validateBtn.Name = "validateBtn";
            this.validateBtn.Size = new System.Drawing.Size(785, 33);
            this.validateBtn.TabIndex = 14;
            this.validateBtn.Text = "Проверить";
            this.validateBtn.UseVisualStyleBackColor = true;
            this.validateBtn.Click += new System.EventHandler(this.validateBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(15, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 9;
            // 
            // checkSignFileChoiseBtn
            // 
            this.checkSignFileChoiseBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkSignFileChoiseBtn.Location = new System.Drawing.Point(696, 19);
            this.checkSignFileChoiseBtn.Name = "checkSignFileChoiseBtn";
            this.checkSignFileChoiseBtn.Size = new System.Drawing.Size(92, 31);
            this.checkSignFileChoiseBtn.TabIndex = 4;
            this.checkSignFileChoiseBtn.Text = "Выбор";
            this.checkSignFileChoiseBtn.UseVisualStyleBackColor = true;
            this.checkSignFileChoiseBtn.Click += new System.EventHandler(this.checkSignFileChoiseBtn_Click);
            // 
            // checkSignFilePathTextBox
            // 
            this.checkSignFilePathTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkSignFilePathTextBox.Location = new System.Drawing.Point(243, 23);
            this.checkSignFilePathTextBox.Name = "checkSignFilePathTextBox";
            this.checkSignFilePathTextBox.ReadOnly = true;
            this.checkSignFilePathTextBox.Size = new System.Drawing.Size(444, 22);
            this.checkSignFilePathTextBox.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(195, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Файл данных для проверки:";
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(8, 287);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 17);
            this.errorLabel.TabIndex = 13;
            // 
            // DigitalSignatureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 317);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.checkSignGroupBox);
            this.Controls.Add(this.signGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "DigitalSignatureForm";
            this.Text = "Электронные цифровые подписи";
            this.signGroupBox.ResumeLayout(false);
            this.signGroupBox.PerformLayout();
            this.checkSignGroupBox.ResumeLayout(false);
            this.checkSignGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox signGroupBox;
        private System.Windows.Forms.Button signBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button signFileChoiseBtn;
        private System.Windows.Forms.TextBox filePathTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox checkSignGroupBox;
        private System.Windows.Forms.Button importSignatureBtn;
        private System.Windows.Forms.TextBox signFilePathTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button validateBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button checkSignFileChoiseBtn;
        private System.Windows.Forms.TextBox checkSignFilePathTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button importPublicKeyBtn;
        private System.Windows.Forms.TextBox publicKeyTextBox;
        private System.Windows.Forms.Label label6;
    }
}