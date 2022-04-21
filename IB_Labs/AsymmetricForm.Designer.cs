﻿
namespace IB_Labs
{
    partial class AsymmetricForm
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
            this.generateBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.decryptBtn = new System.Windows.Forms.Button();
            this.errorLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.encryptFilePathTextBox = new System.Windows.Forms.TextBox();
            this.fileChoiseBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.testingGroupBox = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.publicKeyTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.encryptBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.decryptTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.decryptFilePathTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.testingGroupBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // generateBtn
            // 
            this.generateBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.generateBtn.Location = new System.Drawing.Point(6, 28);
            this.generateBtn.Name = "generateBtn";
            this.generateBtn.Size = new System.Drawing.Size(933, 31);
            this.generateBtn.TabIndex = 7;
            this.generateBtn.Text = "Генерация и экспорт RSA-ключей";
            this.generateBtn.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.generateBtn);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(951, 80);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Генерация ключей";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // decryptBtn
            // 
            this.decryptBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.decryptBtn.Location = new System.Drawing.Point(6, 96);
            this.decryptBtn.Name = "decryptBtn";
            this.decryptBtn.Size = new System.Drawing.Size(933, 33);
            this.decryptBtn.TabIndex = 10;
            this.decryptBtn.Text = "Расшифровать";
            this.decryptBtn.UseVisualStyleBackColor = true;
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(10, 401);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 17);
            this.errorLabel.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Файл данных для шифрования:";
            // 
            // encryptFilePathTextBox
            // 
            this.encryptFilePathTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.encryptFilePathTextBox.Location = new System.Drawing.Point(246, 23);
            this.encryptFilePathTextBox.Name = "encryptFilePathTextBox";
            this.encryptFilePathTextBox.ReadOnly = true;
            this.encryptFilePathTextBox.Size = new System.Drawing.Size(595, 22);
            this.encryptFilePathTextBox.TabIndex = 3;
            // 
            // fileChoiseBtn
            // 
            this.fileChoiseBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fileChoiseBtn.Location = new System.Drawing.Point(847, 14);
            this.fileChoiseBtn.Name = "fileChoiseBtn";
            this.fileChoiseBtn.Size = new System.Drawing.Size(92, 31);
            this.fileChoiseBtn.TabIndex = 4;
            this.fileChoiseBtn.Text = "Выбор";
            this.fileChoiseBtn.UseVisualStyleBackColor = true;
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
            // testingGroupBox
            // 
            this.testingGroupBox.Controls.Add(this.button1);
            this.testingGroupBox.Controls.Add(this.publicKeyTextBox);
            this.testingGroupBox.Controls.Add(this.label4);
            this.testingGroupBox.Controls.Add(this.encryptBtn);
            this.testingGroupBox.Controls.Add(this.label1);
            this.testingGroupBox.Controls.Add(this.fileChoiseBtn);
            this.testingGroupBox.Controls.Add(this.encryptFilePathTextBox);
            this.testingGroupBox.Controls.Add(this.label3);
            this.testingGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.testingGroupBox.Location = new System.Drawing.Point(0, 80);
            this.testingGroupBox.Name = "testingGroupBox";
            this.testingGroupBox.Size = new System.Drawing.Size(951, 152);
            this.testingGroupBox.TabIndex = 10;
            this.testingGroupBox.TabStop = false;
            this.testingGroupBox.Text = "Шифрование";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(847, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 31);
            this.button1.TabIndex = 17;
            this.button1.Text = "Импорт";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // publicKeyTextBox
            // 
            this.publicKeyTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.publicKeyTextBox.Location = new System.Drawing.Point(246, 63);
            this.publicKeyTextBox.Name = "publicKeyTextBox";
            this.publicKeyTextBox.ReadOnly = true;
            this.publicKeyTextBox.Size = new System.Drawing.Size(595, 22);
            this.publicKeyTextBox.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Файл с публичным ключом:";
            // 
            // encryptBtn
            // 
            this.encryptBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.encryptBtn.Location = new System.Drawing.Point(3, 100);
            this.encryptBtn.Name = "encryptBtn";
            this.encryptBtn.Size = new System.Drawing.Size(936, 33);
            this.encryptBtn.TabIndex = 14;
            this.encryptBtn.Text = "Зашифровать";
            this.encryptBtn.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.decryptFilePathTextBox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.decryptTextBox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.decryptBtn);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 232);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(951, 153);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Дешифрование";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(847, 50);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 31);
            this.button2.TabIndex = 13;
            this.button2.Text = "Импорт";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // decryptTextBox
            // 
            this.decryptTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.decryptTextBox.Location = new System.Drawing.Point(246, 57);
            this.decryptTextBox.Name = "decryptTextBox";
            this.decryptTextBox.ReadOnly = true;
            this.decryptTextBox.Size = new System.Drawing.Size(595, 22);
            this.decryptTextBox.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(191, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Файл с приватным ключом:";
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(847, 13);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(92, 31);
            this.button3.TabIndex = 16;
            this.button3.Text = "Выбор";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // decryptFilePathTextBox
            // 
            this.decryptFilePathTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.decryptFilePathTextBox.Location = new System.Drawing.Point(246, 22);
            this.decryptFilePathTextBox.Name = "decryptFilePathTextBox";
            this.decryptFilePathTextBox.ReadOnly = true;
            this.decryptFilePathTextBox.Size = new System.Drawing.Size(595, 22);
            this.decryptFilePathTextBox.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Файл данных для дешифрования:";
            // 
            // AsymmetricForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 431);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.testingGroupBox);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "AsymmetricForm";
            this.Text = "Изучение возможностей реализации асимметричного шифрования в .NET";
            this.Load += new System.EventHandler(this.AsymmetricForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.testingGroupBox.ResumeLayout(false);
            this.testingGroupBox.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button generateBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button decryptBtn;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox encryptFilePathTextBox;
        private System.Windows.Forms.Button fileChoiseBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox testingGroupBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox publicKeyTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button encryptBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox decryptTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox decryptFilePathTextBox;
        private System.Windows.Forms.Label label2;
    }
}