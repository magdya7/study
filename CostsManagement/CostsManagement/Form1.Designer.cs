namespace CostsManagement
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитькакToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.печатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.предварительныйпросмотрToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.правкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отменадействияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отменадействияToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.вырезатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.копироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вставкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.выделитьвсеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сервисToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.параметрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.содержаниеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.индексToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поискToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.опрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnSave = new System.Windows.Forms.Button();
            this.tb_Sum = new System.Windows.Forms.TextBox();
            this.tb_Note = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_Account = new System.Windows.Forms.ComboBox();
            this.cb_Category = new System.Windows.Forms.ComboBox();
            this.dtp_OperationDate = new System.Windows.Forms.DateTimePicker();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgv_History = new System.Windows.Forms.DataGridView();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Account = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.treeHistory = new System.Windows.Forms.TreeView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chart_Analysis = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gb_Analysis = new System.Windows.Forms.GroupBox();
            this.cb_TypeOfDate = new System.Windows.Forms.ComboBox();
            this.label_TypeOfDate = new System.Windows.Forms.Label();
            this.dtp_DateTo = new System.Windows.Forms.DateTimePicker();
            this.label_DateTo = new System.Windows.Forms.Label();
            this.dtp_DateFrom = new System.Windows.Forms.DateTimePicker();
            this.label_DateFrom = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_History)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Analysis)).BeginInit();
            this.panel3.SuspendLayout();
            this.gb_Analysis.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.правкаToolStripMenuItem,
            this.сервисToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(542, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьToolStripMenuItem,
            this.открытьToolStripMenuItem,
            this.toolStripSeparator,
            this.сохранитьToolStripMenuItem,
            this.сохранитькакToolStripMenuItem,
            this.toolStripSeparator1,
            this.печатьToolStripMenuItem,
            this.предварительныйпросмотрToolStripMenuItem,
            this.toolStripSeparator2,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "&Файл";
            // 
            // создатьToolStripMenuItem
            // 
            this.создатьToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("создатьToolStripMenuItem.Image")));
            this.создатьToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            this.создатьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.создатьToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.создатьToolStripMenuItem.Text = "&Создать";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("открытьToolStripMenuItem.Image")));
            this.открытьToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.открытьToolStripMenuItem.Text = "&Открыть";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(230, 6);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("сохранитьToolStripMenuItem.Image")));
            this.сохранитьToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.сохранитьToolStripMenuItem.Text = "&Сохранить";
            // 
            // сохранитькакToolStripMenuItem
            // 
            this.сохранитькакToolStripMenuItem.Name = "сохранитькакToolStripMenuItem";
            this.сохранитькакToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.сохранитькакToolStripMenuItem.Text = "Сохранить &как";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(230, 6);
            // 
            // печатьToolStripMenuItem
            // 
            this.печатьToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("печатьToolStripMenuItem.Image")));
            this.печатьToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.печатьToolStripMenuItem.Name = "печатьToolStripMenuItem";
            this.печатьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.печатьToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.печатьToolStripMenuItem.Text = "&Печать";
            // 
            // предварительныйпросмотрToolStripMenuItem
            // 
            this.предварительныйпросмотрToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("предварительныйпросмотрToolStripMenuItem.Image")));
            this.предварительныйпросмотрToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.предварительныйпросмотрToolStripMenuItem.Name = "предварительныйпросмотрToolStripMenuItem";
            this.предварительныйпросмотрToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.предварительныйпросмотрToolStripMenuItem.Text = "Предварительный про&смотр";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(230, 6);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.выходToolStripMenuItem.Text = "Вы&ход";
            // 
            // правкаToolStripMenuItem
            // 
            this.правкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.отменадействияToolStripMenuItem,
            this.отменадействияToolStripMenuItem1,
            this.toolStripSeparator3,
            this.вырезатьToolStripMenuItem,
            this.копироватьToolStripMenuItem,
            this.вставкаToolStripMenuItem,
            this.toolStripSeparator4,
            this.выделитьвсеToolStripMenuItem});
            this.правкаToolStripMenuItem.Name = "правкаToolStripMenuItem";
            this.правкаToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.правкаToolStripMenuItem.Text = "&Правка";
            // 
            // отменадействияToolStripMenuItem
            // 
            this.отменадействияToolStripMenuItem.Name = "отменадействияToolStripMenuItem";
            this.отменадействияToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.отменадействияToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.отменадействияToolStripMenuItem.Text = "&Отмена действия";
            // 
            // отменадействияToolStripMenuItem1
            // 
            this.отменадействияToolStripMenuItem1.Name = "отменадействияToolStripMenuItem1";
            this.отменадействияToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.отменадействияToolStripMenuItem1.Size = new System.Drawing.Size(209, 22);
            this.отменадействияToolStripMenuItem1.Text = "&Отмена действия";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(206, 6);
            // 
            // вырезатьToolStripMenuItem
            // 
            this.вырезатьToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("вырезатьToolStripMenuItem.Image")));
            this.вырезатьToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.вырезатьToolStripMenuItem.Name = "вырезатьToolStripMenuItem";
            this.вырезатьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.вырезатьToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.вырезатьToolStripMenuItem.Text = "Вырезат&ь";
            // 
            // копироватьToolStripMenuItem
            // 
            this.копироватьToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("копироватьToolStripMenuItem.Image")));
            this.копироватьToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.копироватьToolStripMenuItem.Name = "копироватьToolStripMenuItem";
            this.копироватьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.копироватьToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.копироватьToolStripMenuItem.Text = "&Копировать";
            // 
            // вставкаToolStripMenuItem
            // 
            this.вставкаToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("вставкаToolStripMenuItem.Image")));
            this.вставкаToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.вставкаToolStripMenuItem.Name = "вставкаToolStripMenuItem";
            this.вставкаToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.вставкаToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.вставкаToolStripMenuItem.Text = "Вст&авка";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(206, 6);
            // 
            // выделитьвсеToolStripMenuItem
            // 
            this.выделитьвсеToolStripMenuItem.Name = "выделитьвсеToolStripMenuItem";
            this.выделитьвсеToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.выделитьвсеToolStripMenuItem.Text = "Выделить &все";
            // 
            // сервисToolStripMenuItem
            // 
            this.сервисToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.настройкиToolStripMenuItem,
            this.параметрыToolStripMenuItem});
            this.сервисToolStripMenuItem.Name = "сервисToolStripMenuItem";
            this.сервисToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.сервисToolStripMenuItem.Text = "&Сервис";
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.настройкиToolStripMenuItem.Text = "&Настройки";
            // 
            // параметрыToolStripMenuItem
            // 
            this.параметрыToolStripMenuItem.Name = "параметрыToolStripMenuItem";
            this.параметрыToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.параметрыToolStripMenuItem.Text = "&Параметры";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.содержаниеToolStripMenuItem,
            this.индексToolStripMenuItem,
            this.поискToolStripMenuItem,
            this.toolStripSeparator5,
            this.опрограммеToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Спра&вка";
            // 
            // содержаниеToolStripMenuItem
            // 
            this.содержаниеToolStripMenuItem.Name = "содержаниеToolStripMenuItem";
            this.содержаниеToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.содержаниеToolStripMenuItem.Text = "&Содержание";
            // 
            // индексToolStripMenuItem
            // 
            this.индексToolStripMenuItem.Name = "индексToolStripMenuItem";
            this.индексToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.индексToolStripMenuItem.Text = "&Индекс";
            // 
            // поискToolStripMenuItem
            // 
            this.поискToolStripMenuItem.Name = "поискToolStripMenuItem";
            this.поискToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.поискToolStripMenuItem.Text = "&Поиск";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(155, 6);
            // 
            // опрограммеToolStripMenuItem
            // 
            this.опрограммеToolStripMenuItem.Name = "опрограммеToolStripMenuItem";
            this.опрограммеToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.опрограммеToolStripMenuItem.Text = "&О программе...";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(221, 486);
            this.panel1.TabIndex = 3;
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(221, 486);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnSave);
            this.tabPage1.Controls.Add(this.tb_Sum);
            this.tabPage1.Controls.Add(this.tb_Note);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.cb_Account);
            this.tabPage1.Controls.Add(this.cb_Category);
            this.tabPage1.Controls.Add(this.dtp_OperationDate);
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(213, 442);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "New costs";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(4, 207);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(203, 23);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tb_Sum
            // 
            this.tb_Sum.Location = new System.Drawing.Point(6, 181);
            this.tb_Sum.MaxLength = 15;
            this.tb_Sum.Name = "tb_Sum";
            this.tb_Sum.Size = new System.Drawing.Size(201, 20);
            this.tb_Sum.TabIndex = 8;
            this.tb_Sum.Text = "0,00";
            this.tb_Sum.Enter += new System.EventHandler(this.tb_Sum_Enter);
            this.tb_Sum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Sum_KeyPress);
            this.tb_Sum.Leave += new System.EventHandler(this.tb_Sum_Leave);
            // 
            // tb_Note
            // 
            this.tb_Note.Location = new System.Drawing.Point(6, 138);
            this.tb_Note.MaxLength = 256;
            this.tb_Note.Name = "tb_Note";
            this.tb_Note.Size = new System.Drawing.Size(201, 20);
            this.tb_Note.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Sum";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Note";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Account";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Category";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Date";
            // 
            // cb_Account
            // 
            this.cb_Account.FormattingEnabled = true;
            this.cb_Account.Location = new System.Drawing.Point(6, 98);
            this.cb_Account.Name = "cb_Account";
            this.cb_Account.Size = new System.Drawing.Size(201, 21);
            this.cb_Account.TabIndex = 1;
            // 
            // cb_Category
            // 
            this.cb_Category.FormattingEnabled = true;
            this.cb_Category.Location = new System.Drawing.Point(6, 58);
            this.cb_Category.Name = "cb_Category";
            this.cb_Category.Size = new System.Drawing.Size(201, 21);
            this.cb_Category.TabIndex = 1;
            // 
            // dtp_OperationDate
            // 
            this.dtp_OperationDate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtp_OperationDate.Location = new System.Drawing.Point(6, 19);
            this.dtp_OperationDate.Name = "dtp_OperationDate";
            this.dtp_OperationDate.Size = new System.Drawing.Size(201, 20);
            this.dtp_OperationDate.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgv_History);
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(213, 442);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "History of operation";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgv_History
            // 
            this.dgv_History.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_History.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.Account,
            this.Category,
            this.Sum,
            this.Note});
            this.dgv_History.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_History.Location = new System.Drawing.Point(3, 3);
            this.dgv_History.Name = "dgv_History";
            this.dgv_History.Size = new System.Drawing.Size(207, 436);
            this.dgv_History.TabIndex = 0;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            // 
            // Account
            // 
            this.Account.HeaderText = "Account";
            this.Account.Name = "Account";
            // 
            // Category
            // 
            this.Category.HeaderText = "Category";
            this.Category.Name = "Category";
            // 
            // Sum
            // 
            this.Sum.HeaderText = "Sum";
            this.Sum.Name = "Sum";
            // 
            // Note
            // 
            this.Note.HeaderText = "Note";
            this.Note.Name = "Note";
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(213, 442);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Transfer";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.treeHistory);
            this.tabPage4.Location = new System.Drawing.Point(4, 4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(213, 442);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Tree";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // treeHistory
            // 
            this.treeHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeHistory.Location = new System.Drawing.Point(0, 0);
            this.treeHistory.Name = "treeHistory";
            this.treeHistory.Size = new System.Drawing.Size(213, 442);
            this.treeHistory.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.chart_Analysis);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(221, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(321, 486);
            this.panel2.TabIndex = 4;
            // 
            // chart_Analysis
            // 
            chartArea1.Name = "ChartArea1";
            this.chart_Analysis.ChartAreas.Add(chartArea1);
            this.chart_Analysis.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart_Analysis.Legends.Add(legend1);
            this.chart_Analysis.Location = new System.Drawing.Point(0, 0);
            this.chart_Analysis.Name = "chart_Analysis";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.Legend = "Legend1";
            series1.Name = "SeriesAnalysis";
            this.chart_Analysis.Series.Add(series1);
            this.chart_Analysis.Size = new System.Drawing.Size(321, 374);
            this.chart_Analysis.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.gb_Analysis);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 374);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(321, 112);
            this.panel3.TabIndex = 0;
            // 
            // gb_Analysis
            // 
            this.gb_Analysis.Controls.Add(this.cb_TypeOfDate);
            this.gb_Analysis.Controls.Add(this.label_TypeOfDate);
            this.gb_Analysis.Controls.Add(this.dtp_DateTo);
            this.gb_Analysis.Controls.Add(this.label_DateTo);
            this.gb_Analysis.Controls.Add(this.dtp_DateFrom);
            this.gb_Analysis.Controls.Add(this.label_DateFrom);
            this.gb_Analysis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb_Analysis.Location = new System.Drawing.Point(0, 0);
            this.gb_Analysis.Name = "gb_Analysis";
            this.gb_Analysis.Size = new System.Drawing.Size(321, 112);
            this.gb_Analysis.TabIndex = 0;
            this.gb_Analysis.TabStop = false;
            this.gb_Analysis.Text = "Analysis";
            // 
            // cb_TypeOfDate
            // 
            this.cb_TypeOfDate.FormattingEnabled = true;
            this.cb_TypeOfDate.Items.AddRange(new object[] {
            "Day",
            "Week",
            "Month",
            "Year",
            "Other"});
            this.cb_TypeOfDate.Location = new System.Drawing.Point(6, 32);
            this.cb_TypeOfDate.Name = "cb_TypeOfDate";
            this.cb_TypeOfDate.Size = new System.Drawing.Size(143, 21);
            this.cb_TypeOfDate.TabIndex = 1;
            this.cb_TypeOfDate.Text = "Day";
            this.cb_TypeOfDate.SelectedIndexChanged += new System.EventHandler(this.cb_TypeOfDate_SelectedIndexChanged);
            // 
            // label_TypeOfDate
            // 
            this.label_TypeOfDate.AutoSize = true;
            this.label_TypeOfDate.Location = new System.Drawing.Point(6, 16);
            this.label_TypeOfDate.Name = "label_TypeOfDate";
            this.label_TypeOfDate.Size = new System.Drawing.Size(67, 13);
            this.label_TypeOfDate.TabIndex = 5;
            this.label_TypeOfDate.Text = "Type of date";
            // 
            // dtp_DateTo
            // 
            this.dtp_DateTo.CustomFormat = "";
            this.dtp_DateTo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtp_DateTo.Location = new System.Drawing.Point(155, 70);
            this.dtp_DateTo.Name = "dtp_DateTo";
            this.dtp_DateTo.Size = new System.Drawing.Size(143, 20);
            this.dtp_DateTo.TabIndex = 0;
            this.dtp_DateTo.Value = new System.DateTime(2017, 10, 1, 0, 0, 0, 0);
            this.dtp_DateTo.Visible = false;
            this.dtp_DateTo.ValueChanged += new System.EventHandler(this.dtp_DateTo_ValueChanged);
            // 
            // label_DateTo
            // 
            this.label_DateTo.AutoSize = true;
            this.label_DateTo.Location = new System.Drawing.Point(155, 54);
            this.label_DateTo.Name = "label_DateTo";
            this.label_DateTo.Size = new System.Drawing.Size(42, 13);
            this.label_DateTo.TabIndex = 4;
            this.label_DateTo.Text = "Date to";
            this.label_DateTo.Visible = false;
            // 
            // dtp_DateFrom
            // 
            this.dtp_DateFrom.CustomFormat = "";
            this.dtp_DateFrom.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtp_DateFrom.Location = new System.Drawing.Point(6, 70);
            this.dtp_DateFrom.Name = "dtp_DateFrom";
            this.dtp_DateFrom.Size = new System.Drawing.Size(143, 20);
            this.dtp_DateFrom.TabIndex = 0;
            this.dtp_DateFrom.Value = new System.DateTime(2017, 10, 1, 0, 0, 0, 0);
            this.dtp_DateFrom.ValueChanged += new System.EventHandler(this.dtp_DateFrom_ValueChanged);
            // 
            // label_DateFrom
            // 
            this.label_DateFrom.AutoSize = true;
            this.label_DateFrom.Location = new System.Drawing.Point(6, 54);
            this.label_DateFrom.Name = "label_DateFrom";
            this.label_DateFrom.Size = new System.Drawing.Size(30, 13);
            this.label_DateFrom.TabIndex = 4;
            this.label_DateFrom.Text = "Date";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 510);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Cost managment";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_History)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart_Analysis)).EndInit();
            this.panel3.ResumeLayout(false);
            this.gb_Analysis.ResumeLayout(false);
            this.gb_Analysis.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитькакToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem печатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem предварительныйпросмотрToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem правкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отменадействияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отменадействияToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem вырезатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem копироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вставкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem выделитьвсеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сервисToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem параметрыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem содержаниеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem индексToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поискToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem опрограммеToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_Category;
        private System.Windows.Forms.DateTimePicker dtp_OperationDate;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox gb_Analysis;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_Analysis;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_Account;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox tb_Note;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_TypeOfDate;
        private System.Windows.Forms.Label label_TypeOfDate;
        private System.Windows.Forms.DateTimePicker dtp_DateFrom;
        private System.Windows.Forms.Label label_DateFrom;
        private System.Windows.Forms.DateTimePicker dtp_DateTo;
        private System.Windows.Forms.Label label_DateTo;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgv_History;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Account;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Note;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TreeView treeHistory;
        private System.Windows.Forms.TextBox tb_Sum;
        private System.Windows.Forms.ImageList imageList1;
    }
}

