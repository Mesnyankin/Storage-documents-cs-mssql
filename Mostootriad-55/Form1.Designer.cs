namespace Mostootriad_55
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.видToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HorizToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.VerticToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CascadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.lstConsole = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.покупателиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.продавцыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.покупателиToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.продавцыToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.соединениеСБДToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.объектыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.компанииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.объектToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CompanyAddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.документыПокупательToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.покупательToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.продавецToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.параметрыSQLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкаПапкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.мО55БухгалтерияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.соединениеСБДToolStripMenuItem,
            this.OpenToolStripMenuItem,
            this.SaveToolStripMenuItem,
            this.AddToolStripMenuItem,
            this.toolStripSeparator2,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "&Файл";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(165, 6);
            // 
            // видToolStripMenuItem
            // 
            this.видToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HorizToolStripMenuItem,
            this.VerticToolStripMenuItem,
            this.CascadToolStripMenuItem});
            this.видToolStripMenuItem.Name = "видToolStripMenuItem";
            this.видToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.видToolStripMenuItem.Text = "&Вид";
            this.видToolStripMenuItem.Visible = false;
            // 
            // HorizToolStripMenuItem
            // 
            this.HorizToolStripMenuItem.Name = "HorizToolStripMenuItem";
            this.HorizToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.HorizToolStripMenuItem.Text = "Горизонтально";
            this.HorizToolStripMenuItem.Click += new System.EventHandler(this.HorizToolStripMenuItem_Click);
            // 
            // VerticToolStripMenuItem
            // 
            this.VerticToolStripMenuItem.Name = "VerticToolStripMenuItem";
            this.VerticToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.VerticToolStripMenuItem.Text = "Вертикально";
            this.VerticToolStripMenuItem.Click += new System.EventHandler(this.VerticToolStripMenuItem_Click);
            // 
            // CascadToolStripMenuItem
            // 
            this.CascadToolStripMenuItem.Name = "CascadToolStripMenuItem";
            this.CascadToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.CascadToolStripMenuItem.Text = "Расположить каскадом";
            this.CascadToolStripMenuItem.Click += new System.EventHandler(this.CascadToolStripMenuItem_Click);
            // 
            // редактироватьToolStripMenuItem
            // 
            this.редактироватьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.параметрыSQLToolStripMenuItem,
            this.настройкаПапкиToolStripMenuItem});
            this.редактироватьToolStripMenuItem.Name = "редактироватьToolStripMenuItem";
            this.редактироватьToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.редактироватьToolStripMenuItem.Text = "&Настройки";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.мО55БухгалтерияToolStripMenuItem});
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.оПрограммеToolStripMenuItem.Text = "&О программе";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.видToolStripMenuItem,
            this.редактироватьToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(998, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // lstConsole
            // 
            this.lstConsole.Name = "lstConsole";
            this.lstConsole.Size = new System.Drawing.Size(50, 17);
            this.lstConsole.Text = "Console";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lstConsole});
            this.statusStrip1.Location = new System.Drawing.Point(0, 509);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(998, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "Console";
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripSeparator1,
            this.toolStripDropDownButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripComboBox1,
            this.toolStripSeparator3,
            this.toolStripDropDownButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(998, 45);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 45);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.AutoSize = false;
            this.toolStripDropDownButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.покупателиToolStripMenuItem,
            this.продавцыToolStripMenuItem});
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(42, 30);
            this.toolStripDropDownButton1.Text = "Добавить документы";
            this.toolStripDropDownButton1.Click += new System.EventHandler(this.toolStripDropDownButton1_Click);
            // 
            // покупателиToolStripMenuItem
            // 
            this.покупателиToolStripMenuItem.Name = "покупателиToolStripMenuItem";
            this.покупателиToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.покупателиToolStripMenuItem.Text = "Покупатели";
            this.покупателиToolStripMenuItem.Click += new System.EventHandler(this.покупателиToolStripMenuItem_Click);
            // 
            // продавцыToolStripMenuItem
            // 
            this.продавцыToolStripMenuItem.Name = "продавцыToolStripMenuItem";
            this.продавцыToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.продавцыToolStripMenuItem.Text = "Продавцы";
            this.продавцыToolStripMenuItem.Click += new System.EventHandler(this.продавцыToolStripMenuItem_Click);
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 45);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 45);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.AutoSize = false;
            this.toolStripButton1.BackgroundImage = global::Mostootriad_55.Properties.Resources.connect;
            this.toolStripButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Maroon;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.RightToLeftAutoMirrorImage = true;
            this.toolStripButton1.Size = new System.Drawing.Size(32, 32);
            this.toolStripButton1.Text = "Соединиться";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.AutoSize = false;
            this.toolStripButton2.BackgroundImage = global::Mostootriad_55.Properties.Resources.zayiobibkflhigzucaru;
            this.toolStripButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(32, 32);
            this.toolStripButton2.Text = "Список компаний";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.AutoSize = false;
            this.toolStripButton3.BackgroundImage = global::Mostootriad_55.Properties.Resources.wheel;
            this.toolStripButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(32, 32);
            this.toolStripButton3.Text = "Объекты";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.AutoSize = false;
            this.toolStripDropDownButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.покупателиToolStripMenuItem2,
            this.продавцыToolStripMenuItem2});
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(47, 32);
            this.toolStripDropDownButton2.Text = "Сканировать документ";
            // 
            // покупателиToolStripMenuItem2
            // 
            this.покупателиToolStripMenuItem2.Name = "покупателиToolStripMenuItem2";
            this.покупателиToolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.покупателиToolStripMenuItem2.Text = "Покупатели";
            this.покупателиToolStripMenuItem2.Click += new System.EventHandler(this.покупателиToolStripMenuItem2_Click);
            // 
            // продавцыToolStripMenuItem2
            // 
            this.продавцыToolStripMenuItem2.Name = "продавцыToolStripMenuItem2";
            this.продавцыToolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.продавцыToolStripMenuItem2.Text = "Продавцы";
            this.продавцыToolStripMenuItem2.Click += new System.EventHandler(this.продавцыToolStripMenuItem2_Click);
            // 
            // соединениеСБДToolStripMenuItem
            // 
            this.соединениеСБДToolStripMenuItem.Image = global::Mostootriad_55.Properties.Resources.connect;
            this.соединениеСБДToolStripMenuItem.Name = "соединениеСБДToolStripMenuItem";
            this.соединениеСБДToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.соединениеСБДToolStripMenuItem.Text = "Соединение с БД";
            this.соединениеСБДToolStripMenuItem.Click += new System.EventHandler(this.соединениеСБДToolStripMenuItem_Click);
            // 
            // OpenToolStripMenuItem
            // 
            this.OpenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.объектыToolStripMenuItem,
            this.компанииToolStripMenuItem});
            this.OpenToolStripMenuItem.Enabled = false;
            this.OpenToolStripMenuItem.Image = global::Mostootriad_55.Properties.Resources.folder_008;
            this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            this.OpenToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.OpenToolStripMenuItem.Text = "Открыть";
            // 
            // объектыToolStripMenuItem
            // 
            this.объектыToolStripMenuItem.Name = "объектыToolStripMenuItem";
            this.объектыToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.объектыToolStripMenuItem.Text = "Объекты";
            this.объектыToolStripMenuItem.Click += new System.EventHandler(this.объектыToolStripMenuItem_Click);
            // 
            // компанииToolStripMenuItem
            // 
            this.компанииToolStripMenuItem.Name = "компанииToolStripMenuItem";
            this.компанииToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.компанииToolStripMenuItem.Text = "Компании";
            this.компанииToolStripMenuItem.Click += new System.EventHandler(this.компанииToolStripMenuItem_Click);
            // 
            // SaveToolStripMenuItem
            // 
            this.SaveToolStripMenuItem.Enabled = false;
            this.SaveToolStripMenuItem.Image = global::Mostootriad_55.Properties.Resources.save_icon_9;
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            this.SaveToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.SaveToolStripMenuItem.Text = "Сохранить";
            // 
            // AddToolStripMenuItem
            // 
            this.AddToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.объектToolStripMenuItem,
            this.CompanyAddToolStripMenuItem,
            this.документыПокупательToolStripMenuItem});
            this.AddToolStripMenuItem.Enabled = false;
            this.AddToolStripMenuItem.Image = global::Mostootriad_55.Properties.Resources.document_add_icon;
            this.AddToolStripMenuItem.Name = "AddToolStripMenuItem";
            this.AddToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.AddToolStripMenuItem.Text = "Добавить";
            // 
            // объектToolStripMenuItem
            // 
            this.объектToolStripMenuItem.Image = global::Mostootriad_55.Properties.Resources.wheel;
            this.объектToolStripMenuItem.Name = "объектToolStripMenuItem";
            this.объектToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.объектToolStripMenuItem.Text = "Новый объект";
            this.объектToolStripMenuItem.Click += new System.EventHandler(this.объектToolStripMenuItem_Click);
            // 
            // CompanyAddToolStripMenuItem
            // 
            this.CompanyAddToolStripMenuItem.Image = global::Mostootriad_55.Properties.Resources._1;
            this.CompanyAddToolStripMenuItem.Name = "CompanyAddToolStripMenuItem";
            this.CompanyAddToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.CompanyAddToolStripMenuItem.Text = "Компанию";
            this.CompanyAddToolStripMenuItem.Click += new System.EventHandler(this.CompanyAddToolStripMenuItem_Click);
            // 
            // документыПокупательToolStripMenuItem
            // 
            this.документыПокупательToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.покупательToolStripMenuItem,
            this.продавецToolStripMenuItem});
            this.документыПокупательToolStripMenuItem.Image = global::Mostootriad_55.Properties.Resources._1731089;
            this.документыПокупательToolStripMenuItem.Name = "документыПокупательToolStripMenuItem";
            this.документыПокупательToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.документыПокупательToolStripMenuItem.Text = "Документы";
            // 
            // покупательToolStripMenuItem
            // 
            this.покупательToolStripMenuItem.Name = "покупательToolStripMenuItem";
            this.покупательToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.покупательToolStripMenuItem.Text = "Покупатель";
            this.покупательToolStripMenuItem.Click += new System.EventHandler(this.покупательToolStripMenuItem_Click);
            // 
            // продавецToolStripMenuItem
            // 
            this.продавецToolStripMenuItem.Name = "продавецToolStripMenuItem";
            this.продавецToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.продавецToolStripMenuItem.Text = "Продавец";
            this.продавецToolStripMenuItem.Click += new System.EventHandler(this.продавецToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Image = global::Mostootriad_55.Properties.Resources.w256h2561339252558DeleteRed;
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.выходToolStripMenuItem.Text = "&Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // параметрыSQLToolStripMenuItem
            // 
            this.параметрыSQLToolStripMenuItem.Image = global::Mostootriad_55.Properties.Resources.sql_server_icon_png_28;
            this.параметрыSQLToolStripMenuItem.Name = "параметрыSQLToolStripMenuItem";
            this.параметрыSQLToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.параметрыSQLToolStripMenuItem.Text = "Параметры SQL";
            this.параметрыSQLToolStripMenuItem.Click += new System.EventHandler(this.параметрыSQLToolStripMenuItem_Click);
            // 
            // настройкаПапкиToolStripMenuItem
            // 
            this.настройкаПапкиToolStripMenuItem.Image = global::Mostootriad_55.Properties.Resources.Icloud_579a6e7c5f9b589aa94a599b;
            this.настройкаПапкиToolStripMenuItem.Name = "настройкаПапкиToolStripMenuItem";
            this.настройкаПапкиToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.настройкаПапкиToolStripMenuItem.Text = "Сетевой каталог";
            this.настройкаПапкиToolStripMenuItem.Click += new System.EventHandler(this.настройкаПапкиToolStripMenuItem_Click);
            // 
            // мО55БухгалтерияToolStripMenuItem
            // 
            this.мО55БухгалтерияToolStripMenuItem.Image = global::Mostootriad_55.Properties.Resources.sign_info_icon;
            this.мО55БухгалтерияToolStripMenuItem.Name = "мО55БухгалтерияToolStripMenuItem";
            this.мО55БухгалтерияToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.мО55БухгалтерияToolStripMenuItem.Text = "МО-55 Бухгалтерия";
            this.мО55БухгалтерияToolStripMenuItem.Click += new System.EventHandler(this.мО55БухгалтерияToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(998, 531);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "МО-55 Бухгалтерия";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem соединениеСБДToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem объектыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem компанииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem объектToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CompanyAddToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem документыПокупательToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem покупательToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem продавецToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem видToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HorizToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem VerticToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CascadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem параметрыSQLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкаПапкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem мО55БухгалтерияToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem покупателиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem продавцыToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lstConsole;
        private System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem покупателиToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem продавцыToolStripMenuItem2;
        public System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
    }
}

