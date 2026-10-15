namespace MIB_IDB_23_06_Baranov_VG
{
    partial class Form5
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

        #region Код, автоматически созданный конструктором форм Windows

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Edit1 = new System.Windows.Forms.TextBox();
            this.Edit2 = new System.Windows.Forms.TextBox();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.OKBtn = new System.Windows.Forms.Button();
            this.OldLabel = new System.Windows.Forms.Label();
            this.OldPass = new System.Windows.Forms.TextBox();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.headerLabel = new System.Windows.Forms.Label();
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
            this.headerPanel.Size = new System.Drawing.Size(628, 70);
            this.headerPanel.TabIndex = 0;
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.headerLabel.ForeColor = System.Drawing.Color.White;
            this.headerLabel.Location = new System.Drawing.Point(20, 18);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(180, 37);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "Смена пароля";
            // 
            // OldLabel
            // 
            this.OldLabel.AutoSize = true;
            this.OldLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.OldLabel.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.OldLabel.Location = new System.Drawing.Point(45, 100);
            this.OldLabel.Name = "OldLabel";
            this.OldLabel.Size = new System.Drawing.Size(150, 23);
            this.OldLabel.TabIndex = 1;
            this.OldLabel.Text = "Старый пароль:";
            // 
            // OldPass
            // 
            this.OldPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OldPass.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.OldPass.Location = new System.Drawing.Point(49, 130);
            this.OldPass.MaxLength = 10;
            this.OldPass.Name = "OldPass";
            this.OldPass.PasswordChar = '*';
            this.OldPass.Size = new System.Drawing.Size(520, 32);
            this.OldPass.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.label1.Location = new System.Drawing.Point(45, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Новый пароль:";
            // 
            // Edit1
            // 
            this.Edit1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Edit1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.Edit1.Location = new System.Drawing.Point(49, 215);
            this.Edit1.MaxLength = 10;
            this.Edit1.Name = "Edit1";
            this.Edit1.PasswordChar = '*';
            this.Edit1.Size = new System.Drawing.Size(520, 32);
            this.Edit1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.label2.Location = new System.Drawing.Point(45, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Подтверждение:";
            // 
            // Edit2
            // 
            this.Edit2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Edit2.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.Edit2.Location = new System.Drawing.Point(49, 300);
            this.Edit2.MaxLength = 10;
            this.Edit2.Name = "Edit2";
            this.Edit2.PasswordChar = '*';
            this.Edit2.Size = new System.Drawing.Size(520, 32);
            this.Edit2.TabIndex = 6;
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
            this.OKBtn.Location = new System.Drawing.Point(49, 370);
            this.OKBtn.Name = "OKBtn";
            this.OKBtn.Size = new System.Drawing.Size(250, 55);
            this.OKBtn.TabIndex = 7;
            this.OKBtn.Text = "Сохранить";
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
            this.CancelBtn.Location = new System.Drawing.Point(319, 370);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(250, 55);
            this.CancelBtn.TabIndex = 8;
            this.CancelBtn.Text = "Отмена";
            this.CancelBtn.UseVisualStyleBackColor = false;
            // 
            // Form5
            // 
            this.AcceptButton = this.OKBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(236, 240, 241);
            this.CancelButton = this.CancelBtn;
            this.ClientSize = new System.Drawing.Size(628, 450);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.OKBtn);
            this.Controls.Add(this.Edit2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Edit1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OldPass);
            this.Controls.Add(this.OldLabel);
            this.Controls.Add(this.headerPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form5";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Смена пароля";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form5_FormClosing);
            this.VisibleChanged += new System.EventHandler(this.Form5_VisibleChanged);
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Edit2;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button OKBtn;
        private System.Windows.Forms.Label OldLabel;
        private System.Windows.Forms.TextBox OldPass;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label headerLabel;
        public System.Windows.Forms.TextBox Edit1;
    }
}