
namespace IB_Labs
{
    partial class SymmetricForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.SummaryDataGridView = new System.Windows.Forms.DataGridView();
            this.Algorithm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EncryptionTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DecryptionTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AllTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SummaryGroupBox = new System.Windows.Forms.GroupBox();
            this.TestingGroupBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FilePathTextBox = new System.Windows.Forms.TextBox();
            this.TestStartBtn = new System.Windows.Forms.Button();
            this.ErrorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SummaryDataGridView)).BeginInit();
            this.SummaryGroupBox.SuspendLayout();
            this.TestingGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // SummaryDataGridView
            // 
            this.SummaryDataGridView.AllowUserToAddRows = false;
            this.SummaryDataGridView.AllowUserToDeleteRows = false;
            this.SummaryDataGridView.AllowUserToOrderColumns = true;
            this.SummaryDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SummaryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SummaryDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Algorithm,
            this.Mode,
            this.EncryptionTime,
            this.DecryptionTime,
            this.AllTime});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.SummaryDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.SummaryDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SummaryDataGridView.Location = new System.Drawing.Point(3, 18);
            this.SummaryDataGridView.Name = "SummaryDataGridView";
            this.SummaryDataGridView.ReadOnly = true;
            this.SummaryDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.SummaryDataGridView.RowHeadersWidth = 10;
            this.SummaryDataGridView.RowTemplate.Height = 24;
            this.SummaryDataGridView.Size = new System.Drawing.Size(915, 199);
            this.SummaryDataGridView.TabIndex = 0;
            // 
            // Algorithm
            // 
            this.Algorithm.HeaderText = "Алгоритм";
            this.Algorithm.MinimumWidth = 6;
            this.Algorithm.Name = "Algorithm";
            this.Algorithm.ReadOnly = true;
            // 
            // Mode
            // 
            this.Mode.HeaderText = "Режим";
            this.Mode.MinimumWidth = 6;
            this.Mode.Name = "Mode";
            this.Mode.ReadOnly = true;
            // 
            // EncryptionTime
            // 
            this.EncryptionTime.HeaderText = "Время на шифрование, c";
            this.EncryptionTime.MinimumWidth = 6;
            this.EncryptionTime.Name = "EncryptionTime";
            this.EncryptionTime.ReadOnly = true;
            // 
            // DecryptionTime
            // 
            this.DecryptionTime.HeaderText = "Время на дешифрование, с";
            this.DecryptionTime.MinimumWidth = 6;
            this.DecryptionTime.Name = "DecryptionTime";
            this.DecryptionTime.ReadOnly = true;
            // 
            // AllTime
            // 
            this.AllTime.HeaderText = "Общее время, с";
            this.AllTime.MinimumWidth = 6;
            this.AllTime.Name = "AllTime";
            this.AllTime.ReadOnly = true;
            // 
            // SummaryGroupBox
            // 
            this.SummaryGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SummaryGroupBox.Controls.Add(this.SummaryDataGridView);
            this.SummaryGroupBox.Location = new System.Drawing.Point(3, 130);
            this.SummaryGroupBox.Name = "SummaryGroupBox";
            this.SummaryGroupBox.Size = new System.Drawing.Size(921, 220);
            this.SummaryGroupBox.TabIndex = 2;
            this.SummaryGroupBox.TabStop = false;
            this.SummaryGroupBox.Text = "Результаты";
            // 
            // TestingGroupBox
            // 
            this.TestingGroupBox.Controls.Add(this.ErrorLabel);
            this.TestingGroupBox.Controls.Add(this.TestStartBtn);
            this.TestingGroupBox.Controls.Add(this.FilePathTextBox);
            this.TestingGroupBox.Controls.Add(this.label1);
            this.TestingGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.TestingGroupBox.Location = new System.Drawing.Point(0, 0);
            this.TestingGroupBox.Name = "TestingGroupBox";
            this.TestingGroupBox.Size = new System.Drawing.Size(924, 124);
            this.TestingGroupBox.TabIndex = 3;
            this.TestingGroupBox.TabStop = false;
            this.TestingGroupBox.Text = "Тестирование";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Файл данных для тестирования:";
            // 
            // FilePathTextBox
            // 
            this.FilePathTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FilePathTextBox.Location = new System.Drawing.Point(251, 45);
            this.FilePathTextBox.Name = "FilePathTextBox";
            this.FilePathTextBox.ReadOnly = true;
            this.FilePathTextBox.Size = new System.Drawing.Size(530, 22);
            this.FilePathTextBox.TabIndex = 3;
            // 
            // TestStartBtn
            // 
            this.TestStartBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TestStartBtn.Location = new System.Drawing.Point(795, 41);
            this.TestStartBtn.Name = "TestStartBtn";
            this.TestStartBtn.Size = new System.Drawing.Size(116, 31);
            this.TestStartBtn.TabIndex = 4;
            this.TestStartBtn.Text = "Старт";
            this.TestStartBtn.UseVisualStyleBackColor = true;
            this.TestStartBtn.Click += new System.EventHandler(this.TestStartBtn_Click);
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorLabel.Location = new System.Drawing.Point(15, 85);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(0, 17);
            this.ErrorLabel.TabIndex = 5;
            this.ErrorLabel.Visible = false;
            // 
            // SymmetricForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 350);
            this.Controls.Add(this.TestingGroupBox);
            this.Controls.Add(this.SummaryGroupBox);
            this.Name = "SymmetricForm";
            this.Text = "Сравнение симметричных алгоритмов шифрования";
            ((System.ComponentModel.ISupportInitialize)(this.SummaryDataGridView)).EndInit();
            this.SummaryGroupBox.ResumeLayout(false);
            this.TestingGroupBox.ResumeLayout(false);
            this.TestingGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView SummaryDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Algorithm;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mode;
        private System.Windows.Forms.DataGridViewTextBoxColumn EncryptionTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn DecryptionTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn AllTime;
        private System.Windows.Forms.GroupBox SummaryGroupBox;
        private System.Windows.Forms.GroupBox TestingGroupBox;
        private System.Windows.Forms.Button TestStartBtn;
        private System.Windows.Forms.TextBox FilePathTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ErrorLabel;
    }
}