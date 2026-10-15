namespace MIB_IDB_23_06_Baranov_VG
{
    partial class Form6
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.Edit1 = new System.Windows.Forms.TextBox();
            this.OKBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.headerLabel = new System.Windows.Forms.Label();
            this.warningLabel = new System.Windows.Forms.Label();
            this.headerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.headerPanel.Controls.Add(this.headerLabel);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(680, 70);
            this.headerPanel.TabIndex = 0;
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.headerLabel.ForeColor = System.Drawing.Color.White;
            this.headerLabel.Location = new System.Drawing.Point(20, 18);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(400, 37);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "Расшифрование базы данных";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.label1.Location = new System.Drawing.Point(45, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(500, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите парольную фразу для расшифрования:";
            // 
            // Edit1
            // 
            this.Edit1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Edit1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Edit1.Location = new System.Drawing.Point(49, 150);
            this.Edit1.Name = "Edit1";
            this.Edit1.PasswordChar = '*';
            this.Edit1.Size = new System.Drawing.Size(580, 34);
            this.Edit1.TabIndex = 2;
            // 
            // warningLabel
            // 
            this.warningLabel.AutoSize = true;
            this.warningLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.warningLabel.ForeColor = System.Drawing.Color.FromArgb(120, 120, 120);
            this.warningLabel.Location = new System.Drawing.Point(45, 195);
            this.warningLabel.Name = "warningLabel";
            this.warningLabel.Size = new System.Drawing.Size(550, 20);
            this.warningLabel.TabIndex = 3;
            this.warningLabel.Text = "Внимание: при неверной фразе работа программы будет завершена.";
            // 
            // OKBtn
            // 
            this.OKBtn.BackColor = System.Drawing.Color.FromArgb(46, 204, 113);
            this.OKBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OKBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OKBtn.FlatAppearance.BorderSize = 0;
            this.OKBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(39, 174, 96);
            this.OKBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(88, 214, 141);
            this.OKBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OKBtn.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.OKBtn.ForeColor = System.Drawing.Color.White;
            this.OKBtn.Location = new System.Drawing.Point(49, 250);
            this.OKBtn.Name = "OKBtn";
            this.OKBtn.Size = new System.Drawing.Size(280, 60);
            this.OKBtn.TabIndex = 4;
            this.OKBtn.Text = "Продолжить";
            this.OKBtn.UseVisualStyleBackColor = false;
            // 
            // CancelBtn
            // 
            this.CancelBtn.BackColor = System.Drawing.Color.FromArgb(231, 76, 60);
            this.CancelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBtn.FlatAppearance.BorderSize = 0;
            this.CancelBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(192, 57, 43);
            this.CancelBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(236, 112, 99);
            this.CancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelBtn.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.CancelBtn.ForeColor = System.Drawing.Color.White;
            this.CancelBtn.Location = new System.Drawing.Point(349, 250);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(280, 60);
            this.CancelBtn.TabIndex = 5;
            this.CancelBtn.Text = "Выход";
            this.CancelBtn.UseVisualStyleBackColor = false;
            // 
            // Form6
            // 
            this.AcceptButton = this.OKBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(236, 240, 241);
            this.CancelButton = this.CancelBtn;
            this.ClientSize = new System.Drawing.Size(680, 340);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.OKBtn);
            this.Controls.Add(this.warningLabel);
            this.Controls.Add(this.Edit1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.headerPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Расшифрование базы данных";
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button OKBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Label warningLabel;
        public System.Windows.Forms.TextBox Edit1;
    }
}