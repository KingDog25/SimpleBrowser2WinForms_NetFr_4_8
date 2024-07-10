namespace SimpleBrowser2WinForms_NetFr_4_8
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonMain = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonFowardClick = new System.Windows.Forms.Button();
            this.buttonBackClick = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtbox_address_bar = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.tableLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.09259F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.90741F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 88F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.Controls.Add(this.buttonMain, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonRefresh, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonFowardClick, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonBackClick, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(384, 43);
            this.tableLayoutPanel1.TabIndex = 1;
            this.tableLayoutPanel1.MouseEnter += new System.EventHandler(this.tableLayoutPanel1_MouseEnter);
            this.tableLayoutPanel1.MouseLeave += new System.EventHandler(this.tableLayoutPanel1_MouseLeave);
            this.tableLayoutPanel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tableLayoutPanel1_MouseMove);
            // 
            // buttonMain
            // 
            this.buttonMain.AutoSize = true;
            this.buttonMain.BackColor = System.Drawing.Color.PaleGreen;
            this.buttonMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMain.Location = new System.Drawing.Point(3, 3);
            this.buttonMain.Name = "buttonMain";
            this.buttonMain.Size = new System.Drawing.Size(101, 37);
            this.buttonMain.TabIndex = 10;
            this.buttonMain.Text = "На главную";
            this.buttonMain.UseVisualStyleBackColor = false;
            this.buttonMain.Click += new System.EventHandler(this.buttonMain_Click);
            this.buttonMain.MouseEnter += new System.EventHandler(this.buttonMain_MouseEnter);
            this.buttonMain.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttonMain_MouseMove);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.AutoSize = true;
            this.buttonRefresh.BackColor = System.Drawing.SystemColors.Info;
            this.buttonRefresh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonRefresh.Location = new System.Drawing.Point(286, 3);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(95, 37);
            this.buttonRefresh.TabIndex = 12;
            this.buttonRefresh.Text = "Обновить";
            this.buttonRefresh.UseVisualStyleBackColor = false;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            this.buttonRefresh.MouseEnter += new System.EventHandler(this.buttonRefresh_MouseEnter);
            this.buttonRefresh.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttonRefresh_MouseMove);
            // 
            // buttonFowardClick
            // 
            this.buttonFowardClick.AutoSize = true;
            this.buttonFowardClick.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonFowardClick.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonFowardClick.Location = new System.Drawing.Point(198, 3);
            this.buttonFowardClick.Name = "buttonFowardClick";
            this.buttonFowardClick.Size = new System.Drawing.Size(82, 37);
            this.buttonFowardClick.TabIndex = 9;
            this.buttonFowardClick.Text = "Вперед";
            this.buttonFowardClick.UseVisualStyleBackColor = false;
            this.buttonFowardClick.Click += new System.EventHandler(this.buttonFowardClick_Click);
            this.buttonFowardClick.MouseEnter += new System.EventHandler(this.buttonFowardClick_MouseEnter);
            this.buttonFowardClick.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttonFowardClick_MouseMove);
            // 
            // buttonBackClick
            // 
            this.buttonBackClick.AutoSize = true;
            this.buttonBackClick.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonBackClick.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonBackClick.Location = new System.Drawing.Point(110, 3);
            this.buttonBackClick.Name = "buttonBackClick";
            this.buttonBackClick.Size = new System.Drawing.Size(82, 37);
            this.buttonBackClick.TabIndex = 11;
            this.buttonBackClick.Text = "Назад";
            this.buttonBackClick.UseVisualStyleBackColor = false;
            this.buttonBackClick.Click += new System.EventHandler(this.buttonBackClick_Click);
            this.buttonBackClick.MouseEnter += new System.EventHandler(this.buttonBackClick_MouseEnter);
            this.buttonBackClick.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttonBackClick_MouseMove);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.настройкиToolStripMenuItem,
            this.оПрограммеToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(996, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.MouseEnter += new System.EventHandler(this.menuStrip1_MouseEnter);
            this.menuStrip1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.menuStrip1_MouseMove);
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(98, 24);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            this.настройкиToolStripMenuItem.Click += new System.EventHandler(this.настройкиToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(118, 24);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.справкаToolStripMenuItem.Text = "Справка";
            this.справкаToolStripMenuItem.Click += new System.EventHandler(this.справкаToolStripMenuItem_Click);
            // 
            // txtbox_address_bar
            // 
            this.txtbox_address_bar.AccessibleDescription = "Адресная строка";
            this.txtbox_address_bar.AccessibleName = "Address name";
            this.txtbox_address_bar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtbox_address_bar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtbox_address_bar.Location = new System.Drawing.Point(393, 3);
            this.txtbox_address_bar.Name = "txtbox_address_bar";
            this.txtbox_address_bar.Size = new System.Drawing.Size(600, 27);
            this.txtbox_address_bar.TabIndex = 8;
            this.txtbox_address_bar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbox_address_bar_KeyDown_1);
            this.txtbox_address_bar.MouseEnter += new System.EventHandler(this.txtbox_address_bar_MouseEnter);
            this.txtbox_address_bar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.txtbox_address_bar_MouseMove);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.15663F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.84337F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtbox_address_bar, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 28);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(996, 49);
            this.tableLayoutPanel2.TabIndex = 9;
            this.tableLayoutPanel2.MouseEnter += new System.EventHandler(this.tableLayoutPanel2_MouseEnter);
            this.tableLayoutPanel2.MouseLeave += new System.EventHandler(this.tableLayoutPanel2_MouseLeave);
            this.tableLayoutPanel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tableLayoutPanel2_MouseMove);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 77);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(996, 400);
            this.webBrowser1.TabIndex = 10;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 477);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.menuStrip1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Браузер простой (Simple Browser)";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttonMain;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonFowardClick;
        private System.Windows.Forms.Button buttonBackClick;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.TextBox txtbox_address_bar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}

