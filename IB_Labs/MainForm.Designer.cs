
namespace IB_Labs
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.SymmetricBtn = new System.Windows.Forms.Button();
            this.AssymmetricBtn = new System.Windows.Forms.Button();
            this.DigitalSignatureBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SymmetricBtn
            // 
            this.SymmetricBtn.Location = new System.Drawing.Point(15, 29);
            this.SymmetricBtn.Name = "SymmetricBtn";
            this.SymmetricBtn.Size = new System.Drawing.Size(128, 39);
            this.SymmetricBtn.TabIndex = 0;
            this.SymmetricBtn.Text = "Symmetric";
            this.SymmetricBtn.UseVisualStyleBackColor = true;
            this.SymmetricBtn.Click += new System.EventHandler(this.SymmetricBtn_Click);
            // 
            // AssymmetricBtn
            // 
            this.AssymmetricBtn.Location = new System.Drawing.Point(174, 29);
            this.AssymmetricBtn.Name = "AssymmetricBtn";
            this.AssymmetricBtn.Size = new System.Drawing.Size(128, 39);
            this.AssymmetricBtn.TabIndex = 1;
            this.AssymmetricBtn.Text = "Assymmetric";
            this.AssymmetricBtn.UseVisualStyleBackColor = true;
            this.AssymmetricBtn.Click += new System.EventHandler(this.AssymmetricBtn_Click);
            // 
            // DigitalSignatureBtn
            // 
            this.DigitalSignatureBtn.Location = new System.Drawing.Point(333, 29);
            this.DigitalSignatureBtn.Name = "DigitalSignatureBtn";
            this.DigitalSignatureBtn.Size = new System.Drawing.Size(128, 39);
            this.DigitalSignatureBtn.TabIndex = 2;
            this.DigitalSignatureBtn.Text = "DigitalSignature";
            this.DigitalSignatureBtn.UseVisualStyleBackColor = true;
            this.DigitalSignatureBtn.Click += new System.EventHandler(this.DigitalSignatureBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 93);
            this.Controls.Add(this.DigitalSignatureBtn);
            this.Controls.Add(this.AssymmetricBtn);
            this.Controls.Add(this.SymmetricBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "Главная";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SymmetricBtn;
        private System.Windows.Forms.Button AssymmetricBtn;
        private System.Windows.Forms.Button DigitalSignatureBtn;
    }
}

