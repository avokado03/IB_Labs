
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
            this.summaryDataGridView = new System.Windows.Forms.DataGridView();
            this.Algorithm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EncryptionTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DecryptionTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AllTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.summaryGroupBox = new System.Windows.Forms.GroupBox();
            this.testingGroupBox = new System.Windows.Forms.GroupBox();
            this.startBtn = new System.Windows.Forms.Button();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.fileChoiseBtn = new System.Windows.Forms.Button();
            this.filePathTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.summaryDataGridView)).BeginInit();
            this.summaryGroupBox.SuspendLayout();
            this.testingGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // summaryDataGridView
            // 
            this.summaryDataGridView.AllowUserToAddRows = false;
            this.summaryDataGridView.AllowUserToDeleteRows = false;
            this.summaryDataGridView.AllowUserToOrderColumns = true;
            this.summaryDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.summaryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.summaryDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.summaryDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.summaryDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.summaryDataGridView.Location = new System.Drawing.Point(3, 18);
            this.summaryDataGridView.Name = "summaryDataGridView";
            this.summaryDataGridView.ReadOnly = true;
            this.summaryDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.summaryDataGridView.RowHeadersWidth = 10;
            this.summaryDataGridView.RowTemplate.Height = 24;
            this.summaryDataGridView.Size = new System.Drawing.Size(915, 199);
            this.summaryDataGridView.TabIndex = 0;
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
            // summaryGroupBox
            // 
            this.summaryGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.summaryGroupBox.Controls.Add(this.summaryDataGridView);
            this.summaryGroupBox.Location = new System.Drawing.Point(3, 130);
            this.summaryGroupBox.Name = "summaryGroupBox";
            this.summaryGroupBox.Size = new System.Drawing.Size(921, 220);
            this.summaryGroupBox.TabIndex = 2;
            this.summaryGroupBox.TabStop = false;
            this.summaryGroupBox.Text = "Результаты";
            // 
            // testingGroupBox
            // 
            this.testingGroupBox.Controls.Add(this.startBtn);
            this.testingGroupBox.Controls.Add(this.ErrorLabel);
            this.testingGroupBox.Controls.Add(this.fileChoiseBtn);
            this.testingGroupBox.Controls.Add(this.filePathTextBox);
            this.testingGroupBox.Controls.Add(this.label1);
            this.testingGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.testingGroupBox.Location = new System.Drawing.Point(0, 0);
            this.testingGroupBox.Name = "testingGroupBox";
            this.testingGroupBox.Size = new System.Drawing.Size(924, 124);
            this.testingGroupBox.TabIndex = 3;
            this.testingGroupBox.TabStop = false;
            this.testingGroupBox.Text = "Тестирование";
            // 
            // startBtn
            // 
            this.startBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.startBtn.Location = new System.Drawing.Point(818, 41);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(92, 31);
            this.startBtn.TabIndex = 6;
            this.startBtn.Text = "Старт";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
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
            // fileChoiseBtn
            // 
            this.fileChoiseBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fileChoiseBtn.Location = new System.Drawing.Point(700, 41);
            this.fileChoiseBtn.Name = "fileChoiseBtn";
            this.fileChoiseBtn.Size = new System.Drawing.Size(92, 31);
            this.fileChoiseBtn.TabIndex = 4;
            this.fileChoiseBtn.Text = "Выбор";
            this.fileChoiseBtn.UseVisualStyleBackColor = true;
            this.fileChoiseBtn.Click += new System.EventHandler(this.fileChoiseBtn_Click);
            // 
            // filePathTextBox
            // 
            this.filePathTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filePathTextBox.Location = new System.Drawing.Point(251, 45);
            this.filePathTextBox.Name = "filePathTextBox";
            this.filePathTextBox.ReadOnly = true;
            this.filePathTextBox.Size = new System.Drawing.Size(420, 22);
            this.filePathTextBox.TabIndex = 3;
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
            // openFileDialog
            // 
            this.openFileDialog.InitialDirectory = "C:\\";
            this.openFileDialog.Title = "Выбор файла";
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_FileOk);
            // 
            // SymmetricForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 350);
            this.Controls.Add(this.testingGroupBox);
            this.Controls.Add(this.summaryGroupBox);
            this.Name = "SymmetricForm";
            this.Text = "Сравнение симметричных алгоритмов шифрования";
            ((System.ComponentModel.ISupportInitialize)(this.summaryDataGridView)).EndInit();
            this.summaryGroupBox.ResumeLayout(false);
            this.testingGroupBox.ResumeLayout(false);
            this.testingGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView summaryDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Algorithm;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mode;
        private System.Windows.Forms.DataGridViewTextBoxColumn EncryptionTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn DecryptionTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn AllTime;
        private System.Windows.Forms.GroupBox summaryGroupBox;
        private System.Windows.Forms.GroupBox testingGroupBox;
        private System.Windows.Forms.Button fileChoiseBtn;
        private System.Windows.Forms.TextBox filePathTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ErrorLabel;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button startBtn;
    }
}