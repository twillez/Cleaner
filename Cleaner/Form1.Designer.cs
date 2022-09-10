namespace Cleaner
{
    partial class Form1
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
            this.CLOSE = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.wins = new System.Windows.Forms.Label();
            this.WindowsPath = new System.Windows.Forms.Button();
            this.AppDataPath = new System.Windows.Forms.Button();
            this.WinSxSPath = new System.Windows.Forms.Button();
            this.Pref = new System.Windows.Forms.Button();
            this.SWD = new System.Windows.Forms.Button();
            this.ReceDir = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CLOSE
            // 
            this.CLOSE.AutoSize = true;
            this.CLOSE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CLOSE.ForeColor = System.Drawing.Color.Snow;
            this.CLOSE.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CLOSE.Location = new System.Drawing.Point(356, 4);
            this.CLOSE.Name = "CLOSE";
            this.CLOSE.Size = new System.Drawing.Size(27, 25);
            this.CLOSE.TabIndex = 1;
            this.CLOSE.Text = "X";
            this.CLOSE.Click += new System.EventHandler(this.CLOSE_Click);
            this.CLOSE.MouseEnter += new System.EventHandler(this.CLOSE_MouseEnter);
            this.CLOSE.MouseLeave += new System.EventHandler(this.CLOSE_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CLOSE);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(382, 33);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.MenuText;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 51);
            this.label1.TabIndex = 3;
            this.label1.Text = "Clean";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            this.label1.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
            this.label1.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
            // 
            // wins
            // 
            this.wins.AutoSize = true;
            this.wins.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.wins.ForeColor = System.Drawing.Color.White;
            this.wins.Location = new System.Drawing.Point(8, 99);
            this.wins.Name = "wins";
            this.wins.Size = new System.Drawing.Size(151, 42);
            this.wins.TabIndex = 4;
            this.wins.Text = "WinSxS";
            this.wins.Click += new System.EventHandler(this.wins_Click);
            this.wins.MouseEnter += new System.EventHandler(this.wins_MouseEnter);
            this.wins.MouseLeave += new System.EventHandler(this.wins_MouseLeave);
            // 
            // WindowsPath
            // 
            this.WindowsPath.Location = new System.Drawing.Point(165, 31);
            this.WindowsPath.Name = "WindowsPath";
            this.WindowsPath.Size = new System.Drawing.Size(101, 36);
            this.WindowsPath.TabIndex = 5;
            this.WindowsPath.Text = "WinTemp";
            this.WindowsPath.UseVisualStyleBackColor = true;
            this.WindowsPath.Click += new System.EventHandler(this.WindowsPath_Click);
            // 
            // AppDataPath
            // 
            this.AppDataPath.Location = new System.Drawing.Point(165, 74);
            this.AppDataPath.Name = "AppDataPath";
            this.AppDataPath.Size = new System.Drawing.Size(101, 36);
            this.AppDataPath.TabIndex = 6;
            this.AppDataPath.Text = "AppTemp";
            this.AppDataPath.UseVisualStyleBackColor = true;
            this.AppDataPath.Click += new System.EventHandler(this.AppDataPath_Click);
            // 
            // WinSxSPath
            // 
            this.WinSxSPath.Location = new System.Drawing.Point(164, 120);
            this.WinSxSPath.Name = "WinSxSPath";
            this.WinSxSPath.Size = new System.Drawing.Size(101, 36);
            this.WinSxSPath.TabIndex = 7;
            this.WinSxSPath.Text = "WinSxS";
            this.WinSxSPath.UseVisualStyleBackColor = true;
            this.WinSxSPath.Click += new System.EventHandler(this.WinSxSPath_Click);
            // 
            // Pref
            // 
            this.Pref.Location = new System.Drawing.Point(272, 32);
            this.Pref.Name = "Pref";
            this.Pref.Size = new System.Drawing.Size(101, 36);
            this.Pref.TabIndex = 8;
            this.Pref.Text = "Prefetch";
            this.Pref.UseVisualStyleBackColor = true;
            this.Pref.Click += new System.EventHandler(this.Pref_Click);
            // 
            // SWD
            // 
            this.SWD.Location = new System.Drawing.Point(272, 75);
            this.SWD.Name = "SWD";
            this.SWD.Size = new System.Drawing.Size(101, 36);
            this.SWD.TabIndex = 9;
            this.SWD.Text = "SoftDire";
            this.SWD.UseVisualStyleBackColor = true;
            this.SWD.Click += new System.EventHandler(this.SWD_Click);
            // 
            // ReceDir
            // 
            this.ReceDir.Location = new System.Drawing.Point(272, 120);
            this.ReceDir.Name = "ReceDir";
            this.ReceDir.Size = new System.Drawing.Size(101, 36);
            this.ReceDir.TabIndex = 10;
            this.ReceDir.Text = "Recent";
            this.ReceDir.UseVisualStyleBackColor = true;
            this.ReceDir.Click += new System.EventHandler(this.ReceDir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(382, 165);
            this.Controls.Add(this.ReceDir);
            this.Controls.Add(this.SWD);
            this.Controls.Add(this.Pref);
            this.Controls.Add(this.WinSxSPath);
            this.Controls.Add(this.AppDataPath);
            this.Controls.Add(this.WindowsPath);
            this.Controls.Add(this.wins);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label CLOSE;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label wins;
        private System.Windows.Forms.Button WindowsPath;
        private System.Windows.Forms.Button AppDataPath;
        private System.Windows.Forms.Button WinSxSPath;
        private System.Windows.Forms.Button Pref;
        private System.Windows.Forms.Button SWD;
        private System.Windows.Forms.Button ReceDir;
    }
}

