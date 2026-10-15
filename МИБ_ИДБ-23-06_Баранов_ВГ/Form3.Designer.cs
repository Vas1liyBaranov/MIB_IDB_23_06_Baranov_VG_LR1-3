namespace MIB_IDB_23_06_Baranov_VG
{
    partial class Form3
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
            this.Button1 = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.Next = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.CheckBox2 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CheckBox1 = new System.Windows.Forms.CheckBox();
            this.Button2 = new System.Windows.Forms.Button();
            this.Prev = new System.Windows.Forms.Button();
            this.UserName = new System.Windows.Forms.TextBox();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.headerLabel = new System.Windows.Forms.Label();
            this.infoPanel = new System.Windows.Forms.Panel();
            this.headerPanel.SuspendLayout();
            this.infoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.headerPanel.Controls.Add(this.headerLabel);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(700, 70);
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
            this.headerLabel.Text = "Управление пользователями";
            // 
            // infoPanel
            // 
            this.infoPanel.BackColor = System.Drawing.Color.White;
            this.infoPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.infoPanel.Controls.Add(this.label2);
            this.infoPanel.Controls.Add(this.UserName);
            this.infoPanel.Controls.Add(this.label1);
            this.infoPanel.Controls.Add(this.CheckBox1);
            this.infoPanel.Controls.Add(this.label3);
            this.infoPanel.Controls.Add(this.CheckBox2);
            this.infoPanel.Location = new System.Drawing.Point(30, 95);
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.Size = new System.Drawing.Size(640, 240);
            this.infoPanel.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.label2.Location = new System.Drawing.Point(25, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Имя пользователя:";
            // 
            // UserName
            // 
            this.UserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UserName.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.UserName.Location = new System.Drawing.Point(230, 25);
            this.UserName.MaxLength = 20;
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            this.UserName.Size = new System.Drawing.Size(380, 32);
            this.UserName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.label1.Location = new System.Drawing.Point(25, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Блокировка:";
            // 
            // CheckBox1
            // 
            this.CheckBox1.AutoSize = true;
            this.CheckBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CheckBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CheckBox1.Location = new System.Drawing.Point(230, 100);
            this.CheckBox1.Name = "CheckBox1";
            this.CheckBox1.Size = new System.Drawing.Size(300, 27);
            this.CheckBox1.TabIndex = 3;
            this.CheckBox1.Text = "Учетная запись заблокирована";
            this.CheckBox1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.label3.Location = new System.Drawing.Point(25, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ограничение пароля:";
            // 
            // CheckBox2
            // 
            this.CheckBox2.AutoSize = true;
            this.CheckBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CheckBox2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CheckBox2.Location = new System.Drawing.Point(230, 170);
            this.CheckBox2.Name = "CheckBox2";
            this.CheckBox2.Size = new System.Drawing.Size(300, 27);
            this.CheckBox2.TabIndex = 5;
            this.CheckBox2.Text = "Требовать буквы и цифры";
            this.CheckBox2.UseVisualStyleBackColor = true;
            // 
            // Save
            // 
            this.Save.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            this.Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Save.FlatAppearance.BorderSize = 0;
            this.Save.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(31, 97, 141);
            this.Save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            this.Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.Save.ForeColor = System.Drawing.Color.White;
            this.Save.Location = new System.Drawing.Point(30, 360);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(200, 55);
            this.Save.TabIndex = 2;
            this.Save.Text = "Сохранить";
            this.Save.UseVisualStyleBackColor = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Prev
            // 
            this.Prev.BackColor = System.Drawing.Color.FromArgb(230, 126, 34);
            this.Prev.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Prev.FlatAppearance.BorderSize = 0;
            this.Prev.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(160, 88, 24);
            this.Prev.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(245, 176, 65);
            this.Prev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Prev.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.Prev.ForeColor = System.Drawing.Color.White;
            this.Prev.Location = new System.Drawing.Point(250, 360);
            this.Prev.Name = "Prev";
            this.Prev.Size = new System.Drawing.Size(200, 55);
            this.Prev.TabIndex = 3;
            this.Prev.Text = "Предыдущий";
            this.Prev.UseVisualStyleBackColor = false;
            this.Prev.Click += new System.EventHandler(this.Prev_Click);
            // 
            // Next
            // 
            this.Next.BackColor = System.Drawing.Color.FromArgb(155, 89, 182);
            this.Next.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Next.FlatAppearance.BorderSize = 0;
            this.Next.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(108, 52, 131);
            this.Next.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(187, 143, 206);
            this.Next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Next.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.Next.ForeColor = System.Drawing.Color.White;
            this.Next.Location = new System.Drawing.Point(470, 360);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(200, 55);
            this.Next.TabIndex = 4;
            this.Next.Text = "Следующий";
            this.Next.UseVisualStyleBackColor = false;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // Button1
            // 
            this.Button1.BackColor = System.Drawing.Color.FromArgb(46, 204, 113);
            this.Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Button1.FlatAppearance.BorderSize = 0;
            this.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(39, 174, 96);
            this.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(88, 214, 141);
            this.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.Button1.ForeColor = System.Drawing.Color.White;
            this.Button1.Location = new System.Drawing.Point(30, 435);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(300, 55);
            this.Button1.TabIndex = 5;
            this.Button1.Text = "Готово";
            this.Button1.UseVisualStyleBackColor = false;
            // 
            // Button2
            // 
            this.Button2.BackColor = System.Drawing.Color.FromArgb(231, 76, 60);
            this.Button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Button2.FlatAppearance.BorderSize = 0;
            this.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(192, 57, 43);
            this.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(236, 112, 99);
            this.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.Button2.ForeColor = System.Drawing.Color.White;
            this.Button2.Location = new System.Drawing.Point(370, 435);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(300, 55);
            this.Button2.TabIndex = 6;
            this.Button2.Text = "Отмена";
            this.Button2.UseVisualStyleBackColor = false;
            // 
            // Form3
            // 
            this.AcceptButton = this.Button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(236, 240, 241);
            this.CancelButton = this.Button2;
            this.ClientSize = new System.Drawing.Size(700, 520);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.Prev);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.infoPanel);
            this.Controls.Add(this.headerPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form3";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Управление пользователями";
            this.VisibleChanged += new System.EventHandler(this.Form3_VisibleChanged);
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.infoPanel.ResumeLayout(false);
            this.infoPanel.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button Button1;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Button2;
        public System.Windows.Forms.TextBox UserName;
        public System.Windows.Forms.CheckBox CheckBox2;
        public System.Windows.Forms.CheckBox CheckBox1;
        public System.Windows.Forms.Button Next;
        public System.Windows.Forms.Button Prev;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Panel infoPanel;
    }
}