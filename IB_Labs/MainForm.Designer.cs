
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
            this.symmetricBtn = new System.Windows.Forms.Button();
            this.assymmetricBtn = new System.Windows.Forms.Button();
            this.digitalSignatureBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // symmetricBtn
            // 
            this.symmetricBtn.Location = new System.Drawing.Point(15, 29);
            this.symmetricBtn.Name = "symmetricBtn";
            this.symmetricBtn.Size = new System.Drawing.Size(128, 39);
            this.symmetricBtn.TabIndex = 0;
            this.symmetricBtn.Text = "Symmetric";
            this.symmetricBtn.UseVisualStyleBackColor = true;
            this.symmetricBtn.Click += new System.EventHandler(this.symmetricBtn_Click);
            // 
            // assymmetricBtn
            // 
            this.assymmetricBtn.Location = new System.Drawing.Point(174, 29);
            this.assymmetricBtn.Name = "assymmetricBtn";
            this.assymmetricBtn.Size = new System.Drawing.Size(128, 39);
            this.assymmetricBtn.TabIndex = 1;
            this.assymmetricBtn.Text = "Assymmetric";
            this.assymmetricBtn.UseVisualStyleBackColor = true;
            this.assymmetricBtn.Click += new System.EventHandler(this.assymmetricBtn_Click);
            // 
            // digitalSignatureBtn
            // 
            this.digitalSignatureBtn.Location = new System.Drawing.Point(333, 29);
            this.digitalSignatureBtn.Name = "digitalSignatureBtn";
            this.digitalSignatureBtn.Size = new System.Drawing.Size(128, 39);
            this.digitalSignatureBtn.TabIndex = 2;
            this.digitalSignatureBtn.Text = "DigitalSignature";
            this.digitalSignatureBtn.UseVisualStyleBackColor = true;
            this.digitalSignatureBtn.Click += new System.EventHandler(this.digitalSignatureBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 93);
            this.Controls.Add(this.digitalSignatureBtn);
            this.Controls.Add(this.assymmetricBtn);
            this.Controls.Add(this.symmetricBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "Главная";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button symmetricBtn;
        private System.Windows.Forms.Button assymmetricBtn;
        private System.Windows.Forms.Button digitalSignatureBtn;
    }
}

