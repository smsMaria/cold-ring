namespace ColdRing
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
            System.Windows.Forms.SplitContainer splitContainer1;
            System.Windows.Forms.ToolStripContainer toolStripContainer1;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
            System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
            System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
            this.InputTable = new System.Windows.Forms.DataGridView();
            this.ColumnX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.gridVisible = new System.Windows.Forms.ToolStripButton();
            this.OutR = new System.Windows.Forms.Label();
            this.OutY = new System.Windows.Forms.Label();
            this.OutX = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.File = new System.Windows.Forms.ToolStripMenuItem();
            this.Open = new System.Windows.Forms.ToolStripMenuItem();
            this.Save = new System.Windows.Forms.ToolStripMenuItem();
            this.ScreenSave = new System.Windows.Forms.ToolStripMenuItem();
            this.Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.Edition = new System.Windows.Forms.ToolStripMenuItem();
            this.DemonAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.DemonEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.DemonDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.DemonClear = new System.Windows.Forms.ToolStripMenuItem();
            this.Serves = new System.Windows.Forms.ToolStripMenuItem();
            this.Setting = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.About = new System.Windows.Forms.ToolStripMenuItem();
            this.saveDemonsFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openDemonFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveScreenFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.battlefieldScreen1 = new ColdRing.BattlefieldScreen();
            splitContainer1 = new System.Windows.Forms.SplitContainer();
            toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            ((System.ComponentModel.ISupportInitialize)(splitContainer1)).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            toolStripContainer1.ContentPanel.SuspendLayout();
            toolStripContainer1.TopToolStripPanel.SuspendLayout();
            toolStripContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InputTable)).BeginInit();
            this.toolStrip1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainer1.Location = new System.Drawing.Point(0, 30);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(toolStripContainer1);
            splitContainer1.Panel1MinSize = 200;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(tableLayoutPanel1);
            splitContainer1.Size = new System.Drawing.Size(682, 423);
            splitContainer1.SplitterDistance = 200;
            splitContainer1.TabIndex = 0;
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            toolStripContainer1.ContentPanel.Controls.Add(this.InputTable);
            toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(200, 396);
            toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            toolStripContainer1.Name = "toolStripContainer1";
            toolStripContainer1.Size = new System.Drawing.Size(200, 423);
            toolStripContainer1.TabIndex = 0;
            toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip1);
            // 
            // InputTable
            // 
            this.InputTable.AllowUserToAddRows = false;
            this.InputTable.AllowUserToDeleteRows = false;
            this.InputTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.InputTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.InputTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.InputTable.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.InputTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InputTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
            this.InputTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.InputTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.InputTable.ColumnHeadersHeight = 29;
            this.InputTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.InputTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnX,
            this.ColumnY});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.InputTable.DefaultCellStyle = dataGridViewCellStyle5;
            this.InputTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InputTable.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.InputTable.EnableHeadersVisualStyles = false;
            this.InputTable.Location = new System.Drawing.Point(0, 0);
            this.InputTable.MultiSelect = false;
            this.InputTable.Name = "InputTable";
            this.InputTable.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.InputTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.InputTable.RowHeadersVisible = false;
            this.InputTable.RowHeadersWidth = 20;
            this.InputTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.InputTable.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.InputTable.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.InputTable.RowTemplate.Height = 24;
            this.InputTable.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.InputTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.InputTable.ShowCellErrors = false;
            this.InputTable.ShowEditingIcon = false;
            this.InputTable.ShowRowErrors = false;
            this.InputTable.Size = new System.Drawing.Size(200, 396);
            this.InputTable.TabIndex = 0;
            this.InputTable.TabStop = false;
            this.InputTable.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.InputTable_CellEndEdit);
            this.InputTable.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.InputTable_CellValidating);
            this.InputTable.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.InputTable_CellValueChanged);
            this.InputTable.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.InputTable_RowsAdded);
            this.InputTable.SelectionChanged += new System.EventHandler(this.InputTable_SelectionChanged);
            // 
            // ColumnX
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = "0";
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.ColumnX.DefaultCellStyle = dataGridViewCellStyle3;
            this.ColumnX.HeaderText = "x";
            this.ColumnX.MinimumWidth = 6;
            this.ColumnX.Name = "ColumnX";
            this.ColumnX.ReadOnly = true;
            this.ColumnX.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnX.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumnY
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Format = "N0";
            dataGridViewCellStyle4.NullValue = "0";
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.ColumnY.DefaultCellStyle = dataGridViewCellStyle4;
            this.ColumnY.HeaderText = "y";
            this.ColumnY.MinimumWidth = 6;
            this.ColumnY.Name = "ColumnY";
            this.ColumnY.ReadOnly = true;
            this.ColumnY.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnY.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton4,
            this.toolStripButton2,
            this.toolStripSeparator1,
            this.toolStripButton3,
            this.toolStripSeparator4,
            this.gridVisible});
            this.toolStrip1.Location = new System.Drawing.Point(4, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(170, 27);
            this.toolStrip1.TabIndex = 0;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::ColdRing.Properties.Resources.Add;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton1.Text = "Добавить демона";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Enabled = false;
            this.toolStripButton4.Image = global::ColdRing.Properties.Resources.Edit;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton4.Text = "Изменить демона";
            this.toolStripButton4.Click += new System.EventHandler(this.DemonEdit_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Enabled = false;
            this.toolStripButton2.Image = global::ColdRing.Properties.Resources.Delete;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton2.Text = "Удалить выбранного демона";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Enabled = false;
            this.toolStripButton3.Image = global::ColdRing.Properties.Resources.AllDelete;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton3.Text = "Очистить список";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 27);
            // 
            // gridVisible
            // 
            this.gridVisible.Checked = true;
            this.gridVisible.CheckState = System.Windows.Forms.CheckState.Checked;
            this.gridVisible.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.gridVisible.Image = ((System.Drawing.Image)(resources.GetObject("gridVisible.Image")));
            this.gridVisible.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.gridVisible.Name = "gridVisible";
            this.gridVisible.Size = new System.Drawing.Size(29, 24);
            this.gridVisible.Text = "Отображать сетку";
            this.gridVisible.Click += new System.EventHandler(this.gridVisible_Click);
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(this.battlefieldScreen1, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            tableLayoutPanel1.Size = new System.Drawing.Size(478, 423);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.86441F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 88.13559F));
            tableLayoutPanel2.Controls.Add(this.OutR, 1, 2);
            tableLayoutPanel2.Controls.Add(this.OutY, 1, 1);
            tableLayoutPanel2.Controls.Add(this.OutX, 1, 0);
            tableLayoutPanel2.Controls.Add(label3, 0, 2);
            tableLayoutPanel2.Controls.Add(label2, 0, 1);
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel2.Location = new System.Drawing.Point(3, 326);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            tableLayoutPanel2.Size = new System.Drawing.Size(472, 94);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // OutR
            // 
            this.OutR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OutR.Location = new System.Drawing.Point(59, 62);
            this.OutR.Name = "OutR";
            this.OutR.Size = new System.Drawing.Size(410, 32);
            this.OutR.TabIndex = 5;
            this.OutR.Text = "0";
            this.OutR.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // OutY
            // 
            this.OutY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OutY.Location = new System.Drawing.Point(59, 31);
            this.OutY.Name = "OutY";
            this.OutY.Size = new System.Drawing.Size(410, 31);
            this.OutY.TabIndex = 4;
            this.OutY.Text = "0";
            this.OutY.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // OutX
            // 
            this.OutX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OutX.Location = new System.Drawing.Point(59, 0);
            this.OutX.Name = "OutX";
            this.OutX.Size = new System.Drawing.Size(410, 31);
            this.OutX.TabIndex = 3;
            this.OutX.Text = "0";
            this.OutX.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.Dock = System.Windows.Forms.DockStyle.Fill;
            label3.Location = new System.Drawing.Point(3, 62);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(50, 32);
            label3.TabIndex = 2;
            label3.Text = "R =";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.Dock = System.Windows.Forms.DockStyle.Fill;
            label2.Location = new System.Drawing.Point(3, 31);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(50, 31);
            label2.TabIndex = 1;
            label2.Text = "Y =";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.Dock = System.Windows.Forms.DockStyle.Fill;
            label1.Location = new System.Drawing.Point(3, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(50, 31);
            label1.TabIndex = 0;
            label1.Text = "X =";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new System.Drawing.Size(354, 6);
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new System.Drawing.Size(354, 6);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File,
            this.Edition,
            this.Serves});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(682, 30);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // File
            // 
            this.File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Open,
            this.Save,
            toolStripSeparator3,
            this.ScreenSave,
            toolStripSeparator5,
            this.Exit});
            this.File.Name = "File";
            this.File.Size = new System.Drawing.Size(59, 26);
            this.File.Text = "Файл";
            // 
            // Open
            // 
            this.Open.Image = global::ColdRing.Properties.Resources.Open;
            this.Open.Name = "Open";
            this.Open.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.Open.Size = new System.Drawing.Size(357, 26);
            this.Open.Text = "Загрузить координаты";
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // Save
            // 
            this.Save.Image = global::ColdRing.Properties.Resources.Save;
            this.Save.Name = "Save";
            this.Save.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.Save.Size = new System.Drawing.Size(357, 26);
            this.Save.Text = "Сохранить координаты";
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // ScreenSave
            // 
            this.ScreenSave.Name = "ScreenSave";
            this.ScreenSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.ScreenSave.Size = new System.Drawing.Size(357, 26);
            this.ScreenSave.Text = "Сохранить изображение поля";
            this.ScreenSave.Click += new System.EventHandler(this.ScreenSave_Click);
            // 
            // Exit
            // 
            this.Exit.Name = "Exit";
            this.Exit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.Exit.Size = new System.Drawing.Size(357, 26);
            this.Exit.Text = "Выход";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Edition
            // 
            this.Edition.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DemonAdd,
            this.DemonEdit,
            this.DemonDelete,
            this.DemonClear});
            this.Edition.Name = "Edition";
            this.Edition.Size = new System.Drawing.Size(74, 26);
            this.Edition.Text = "Правка";
            // 
            // DemonAdd
            // 
            this.DemonAdd.Image = global::ColdRing.Properties.Resources.Add;
            this.DemonAdd.Name = "DemonAdd";
            this.DemonAdd.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.DemonAdd.Size = new System.Drawing.Size(360, 26);
            this.DemonAdd.Text = "Добавить демона";
            this.DemonAdd.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // DemonEdit
            // 
            this.DemonEdit.Enabled = false;
            this.DemonEdit.Image = global::ColdRing.Properties.Resources.Edit;
            this.DemonEdit.Name = "DemonEdit";
            this.DemonEdit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.DemonEdit.Size = new System.Drawing.Size(360, 26);
            this.DemonEdit.Text = "Изменить выбранного демона";
            this.DemonEdit.Click += new System.EventHandler(this.DemonEdit_Click);
            // 
            // DemonDelete
            // 
            this.DemonDelete.Enabled = false;
            this.DemonDelete.Image = global::ColdRing.Properties.Resources.Delete;
            this.DemonDelete.Name = "DemonDelete";
            this.DemonDelete.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.DemonDelete.Size = new System.Drawing.Size(360, 26);
            this.DemonDelete.Text = "Удалить выбранного демона";
            this.DemonDelete.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // DemonClear
            // 
            this.DemonClear.Enabled = false;
            this.DemonClear.Image = global::ColdRing.Properties.Resources.AllDelete;
            this.DemonClear.Name = "DemonClear";
            this.DemonClear.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.Delete)));
            this.DemonClear.Size = new System.Drawing.Size(360, 26);
            this.DemonClear.Text = "Удалить всех демонов";
            this.DemonClear.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // Serves
            // 
            this.Serves.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Setting,
            this.toolStripSeparator2,
            this.About});
            this.Serves.Name = "Serves";
            this.Serves.Size = new System.Drawing.Size(73, 26);
            this.Serves.Text = "Сервис";
            // 
            // Setting
            // 
            this.Setting.Image = ((System.Drawing.Image)(resources.GetObject("Setting.Image")));
            this.Setting.Name = "Setting";
            this.Setting.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.S)));
            this.Setting.Size = new System.Drawing.Size(245, 26);
            this.Setting.Text = "Настройка";
            this.Setting.Click += new System.EventHandler(this.Setting_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(242, 6);
            // 
            // About
            // 
            this.About.Name = "About";
            this.About.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.About.Size = new System.Drawing.Size(245, 26);
            this.About.Text = "О программе";
            this.About.Click += new System.EventHandler(this.About_Click);
            // 
            // saveDemonsFileDialog
            // 
            this.saveDemonsFileDialog.Filter = "Файл с координатами|*.dcf";
            this.saveDemonsFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.SaveData);
            // 
            // openDemonFileDialog
            // 
            this.openDemonFileDialog.Filter = "Файл с координатами|*.dcf";
            this.openDemonFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.OpenData);
            // 
            // saveScreenFileDialog
            // 
            this.saveScreenFileDialog.Filter = "Рисунок PNG|*.png|Рисунок BMP|*.bmp|Рисунок JPG|*.jpg";
            this.saveScreenFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.SaveImage);
            // 
            // battlefieldScreen1
            // 
            this.battlefieldScreen1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.battlefieldScreen1.Location = new System.Drawing.Point(3, 3);
            this.battlefieldScreen1.Name = "battlefieldScreen1";
            this.battlefieldScreen1.Radius = 0D;
            this.battlefieldScreen1.Size = new System.Drawing.Size(472, 317);
            this.battlefieldScreen1.TabIndex = 0;
            this.battlefieldScreen1.VisibleGrid = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 453);
            this.Controls.Add(splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(700, 500);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Кольцо холода";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(splitContainer1)).EndInit();
            splitContainer1.ResumeLayout(false);
            toolStripContainer1.ContentPanel.ResumeLayout(false);
            toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            toolStripContainer1.TopToolStripPanel.PerformLayout();
            toolStripContainer1.ResumeLayout(false);
            toolStripContainer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InputTable)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView InputTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnX;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnY;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem File;
        private System.Windows.Forms.ToolStripMenuItem Open;
        private System.Windows.Forms.ToolStripMenuItem Save;
        private System.Windows.Forms.ToolStripMenuItem ScreenSave;
        private System.Windows.Forms.ToolStripMenuItem Edition;
        private System.Windows.Forms.ToolStripMenuItem DemonAdd;
        private System.Windows.Forms.ToolStripMenuItem DemonEdit;
        private System.Windows.Forms.ToolStripMenuItem DemonDelete;
        private System.Windows.Forms.ToolStripMenuItem DemonClear;
        private System.Windows.Forms.ToolStripMenuItem Serves;
        private System.Windows.Forms.ToolStripMenuItem Setting;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem About;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.Label OutR;
        private System.Windows.Forms.Label OutY;
        private System.Windows.Forms.Label OutX;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.SaveFileDialog saveDemonsFileDialog;
        private System.Windows.Forms.ToolStripMenuItem Exit;
        private System.Windows.Forms.OpenFileDialog openDemonFileDialog;
        private System.Windows.Forms.SaveFileDialog saveScreenFileDialog;
        public BattlefieldScreen battlefieldScreen1;
        public System.Windows.Forms.ToolStripButton gridVisible;
    }
}

