namespace PonTest
{
    partial class PonTest
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.statusStripPonTest = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusCurrent = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusCurrentText = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusCurrentDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerStatusCurrentDate = new System.Windows.Forms.Timer(this.components);
            this.menuStripPonTest = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemAutoTest = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemPauseTest = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemPmodelSelect = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemExitTest = new System.Windows.Forms.ToolStripMenuItem();
            this.labelWorkSheetNumber = new System.Windows.Forms.Label();
            this.labelProductModel = new System.Windows.Forms.Label();
            this.labelBatchNumber = new System.Windows.Forms.Label();
            this.labelTestcontroler = new System.Windows.Forms.Label();
            this.richTextBoxWorkSheetNumber = new System.Windows.Forms.RichTextBox();
            this.richTextBoxProductModel = new System.Windows.Forms.RichTextBox();
            this.richTextBoxBatchNumber = new System.Windows.Forms.RichTextBox();
            this.richTextBoxTestcontroler = new System.Windows.Forms.RichTextBox();
            this.labelTemperatureOption = new System.Windows.Forms.Label();
            this.richTextBoxTemperatureOptions = new System.Windows.Forms.RichTextBox();
            this.labelVoltageOption = new System.Windows.Forms.Label();
            this.richTextBoxVoltageOptions = new System.Windows.Forms.RichTextBox();
            this.checkBoxC25 = new System.Windows.Forms.CheckBox();
            this.checkBoxV3p3 = new System.Windows.Forms.CheckBox();
            this.labelSerialNumber = new System.Windows.Forms.Label();
            this.richTextBoxSerialNumber = new System.Windows.Forms.RichTextBox();
            this.tabControlTestResult = new System.Windows.Forms.TabControl();
            this.tabPageTestResult = new System.Windows.Forms.TabPage();
            this.dataGridViewTestResult = new System.Windows.Forms.DataGridView();
            this.ColumnTemperature = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnVoltage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTestItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTarget = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTrueVal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDAADC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnResult = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSpend = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnComments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPageTestItemSelect = new System.Windows.Forms.TabPage();
            this.labelPass = new System.Windows.Forms.Label();
            this.labelTestCounter = new System.Windows.Forms.Label();
            this.statusStripPonTest.SuspendLayout();
            this.menuStripPonTest.SuspendLayout();
            this.tabControlTestResult.SuspendLayout();
            this.tabPageTestResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTestResult)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStripPonTest
            // 
            this.statusStripPonTest.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusCurrentDate,
            this.toolStripStatusCurrent,
            this.toolStripStatusCurrentText});
            this.statusStripPonTest.Location = new System.Drawing.Point(0, 515);
            this.statusStripPonTest.Name = "statusStripPonTest";
            this.statusStripPonTest.Size = new System.Drawing.Size(1183, 22);
            this.statusStripPonTest.TabIndex = 0;
            this.statusStripPonTest.Text = "statusStripPonTest";
            // 
            // toolStripStatusCurrent
            // 
            this.toolStripStatusCurrent.AutoSize = false;
            this.toolStripStatusCurrent.Margin = new System.Windows.Forms.Padding(0);
            this.toolStripStatusCurrent.Name = "toolStripStatusCurrent";
            this.toolStripStatusCurrent.Size = new System.Drawing.Size(80, 22);
            this.toolStripStatusCurrent.Text = "当前状态：";
            // 
            // toolStripStatusCurrentText
            // 
            this.toolStripStatusCurrentText.Margin = new System.Windows.Forms.Padding(0);
            this.toolStripStatusCurrentText.Name = "toolStripStatusCurrentText";
            this.toolStripStatusCurrentText.Size = new System.Drawing.Size(72, 22);
            this.toolStripStatusCurrentText.Text = "正在初始化";
            // 
            // toolStripStatusCurrentDate
            // 
            this.toolStripStatusCurrentDate.AutoSize = false;
            this.toolStripStatusCurrentDate.Margin = new System.Windows.Forms.Padding(0);
            this.toolStripStatusCurrentDate.Name = "toolStripStatusCurrentDate";
            this.toolStripStatusCurrentDate.Size = new System.Drawing.Size(132, 22);
            // 
            // timerStatusCurrentDate
            // 
            this.timerStatusCurrentDate.Interval = 1000;
            this.timerStatusCurrentDate.Tick += new System.EventHandler(this.TimerStatusCurrentDate_Tick);
            // 
            // menuStripPonTest
            // 
            this.menuStripPonTest.GripMargin = new System.Windows.Forms.Padding(0);
            this.menuStripPonTest.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemAutoTest,
            this.toolStripMenuItemPauseTest,
            this.toolStripMenuItemPmodelSelect,
            this.toolStripMenuItemAbout,
            this.toolStripMenuItemExitTest});
            this.menuStripPonTest.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.menuStripPonTest.Location = new System.Drawing.Point(0, 0);
            this.menuStripPonTest.Name = "menuStripPonTest";
            this.menuStripPonTest.Padding = new System.Windows.Forms.Padding(0);
            this.menuStripPonTest.Size = new System.Drawing.Size(1183, 40);
            this.menuStripPonTest.Stretch = false;
            this.menuStripPonTest.TabIndex = 1;
            this.menuStripPonTest.Text = "menuStripPonTest";
            // 
            // toolStripMenuItemAutoTest
            // 
            this.toolStripMenuItemAutoTest.AutoSize = false;
            this.toolStripMenuItemAutoTest.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.toolStripMenuItemAutoTest.Name = "toolStripMenuItemAutoTest";
            this.toolStripMenuItemAutoTest.Padding = new System.Windows.Forms.Padding(0);
            this.toolStripMenuItemAutoTest.Size = new System.Drawing.Size(80, 40);
            this.toolStripMenuItemAutoTest.Text = "自动调测";
            this.toolStripMenuItemAutoTest.Click += new System.EventHandler(this.ToolStripMenuItemAutoTest_Click);
            // 
            // toolStripMenuItemPauseTest
            // 
            this.toolStripMenuItemPauseTest.AutoSize = false;
            this.toolStripMenuItemPauseTest.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.toolStripMenuItemPauseTest.Name = "toolStripMenuItemPauseTest";
            this.toolStripMenuItemPauseTest.Padding = new System.Windows.Forms.Padding(0);
            this.toolStripMenuItemPauseTest.Size = new System.Drawing.Size(80, 40);
            this.toolStripMenuItemPauseTest.Text = "暂停调测";
            this.toolStripMenuItemPauseTest.Click += new System.EventHandler(this.ToolStripMenuItemPauseTest_Click);
            // 
            // toolStripMenuItemPmodelSelect
            // 
            this.toolStripMenuItemPmodelSelect.AutoSize = false;
            this.toolStripMenuItemPmodelSelect.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.toolStripMenuItemPmodelSelect.Name = "toolStripMenuItemPmodelSelect";
            this.toolStripMenuItemPmodelSelect.Padding = new System.Windows.Forms.Padding(0);
            this.toolStripMenuItemPmodelSelect.Size = new System.Drawing.Size(120, 40);
            this.toolStripMenuItemPmodelSelect.Text = "产品型号选择";
            this.toolStripMenuItemPmodelSelect.Click += new System.EventHandler(this.ToolStripMenuItemPmodelSelect_Click);
            // 
            // toolStripMenuItemAbout
            // 
            this.toolStripMenuItemAbout.AutoSize = false;
            this.toolStripMenuItemAbout.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.toolStripMenuItemAbout.Name = "toolStripMenuItemAbout";
            this.toolStripMenuItemAbout.Padding = new System.Windows.Forms.Padding(0);
            this.toolStripMenuItemAbout.Size = new System.Drawing.Size(80, 40);
            this.toolStripMenuItemAbout.Text = "关于";
            this.toolStripMenuItemAbout.Click += new System.EventHandler(this.ToolStripMenuItemAbout_Click);
            // 
            // toolStripMenuItemExitTest
            // 
            this.toolStripMenuItemExitTest.AutoSize = false;
            this.toolStripMenuItemExitTest.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.toolStripMenuItemExitTest.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.toolStripMenuItemExitTest.Name = "toolStripMenuItemExitTest";
            this.toolStripMenuItemExitTest.Padding = new System.Windows.Forms.Padding(0);
            this.toolStripMenuItemExitTest.Size = new System.Drawing.Size(80, 40);
            this.toolStripMenuItemExitTest.Text = "退出程序";
            this.toolStripMenuItemExitTest.Click += new System.EventHandler(this.ToolStripMenuItemExitPonTest_Click);
            // 
            // labelWorkSheetNumber
            // 
            this.labelWorkSheetNumber.AutoSize = true;
            this.labelWorkSheetNumber.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelWorkSheetNumber.Location = new System.Drawing.Point(12, 58);
            this.labelWorkSheetNumber.Name = "labelWorkSheetNumber";
            this.labelWorkSheetNumber.Size = new System.Drawing.Size(56, 16);
            this.labelWorkSheetNumber.TabIndex = 2;
            this.labelWorkSheetNumber.Text = "工单号";
            // 
            // labelProductModel
            // 
            this.labelProductModel.AutoSize = true;
            this.labelProductModel.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelProductModel.Location = new System.Drawing.Point(12, 93);
            this.labelProductModel.Name = "labelProductModel";
            this.labelProductModel.Size = new System.Drawing.Size(72, 16);
            this.labelProductModel.TabIndex = 3;
            this.labelProductModel.Text = "产品型号";
            // 
            // labelBatchNumber
            // 
            this.labelBatchNumber.AutoSize = true;
            this.labelBatchNumber.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelBatchNumber.Location = new System.Drawing.Point(12, 127);
            this.labelBatchNumber.Name = "labelBatchNumber";
            this.labelBatchNumber.Size = new System.Drawing.Size(56, 16);
            this.labelBatchNumber.TabIndex = 4;
            this.labelBatchNumber.Text = "批次号";
            // 
            // labelTestcontroler
            // 
            this.labelTestcontroler.AutoSize = true;
            this.labelTestcontroler.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelTestcontroler.Location = new System.Drawing.Point(12, 159);
            this.labelTestcontroler.Name = "labelTestcontroler";
            this.labelTestcontroler.Size = new System.Drawing.Size(72, 16);
            this.labelTestcontroler.TabIndex = 5;
            this.labelTestcontroler.Text = "测试员ID";
            // 
            // richTextBoxWorkSheetNumber
            // 
            this.richTextBoxWorkSheetNumber.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.richTextBoxWorkSheetNumber.Location = new System.Drawing.Point(90, 58);
            this.richTextBoxWorkSheetNumber.MaxLength = 32;
            this.richTextBoxWorkSheetNumber.Name = "richTextBoxWorkSheetNumber";
            this.richTextBoxWorkSheetNumber.Size = new System.Drawing.Size(181, 26);
            this.richTextBoxWorkSheetNumber.TabIndex = 6;
            this.richTextBoxWorkSheetNumber.Text = "";
            this.richTextBoxWorkSheetNumber.TextChanged += new System.EventHandler(this.RichTextBox_TextChanged);
            // 
            // richTextBoxProductModel
            // 
            this.richTextBoxProductModel.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.richTextBoxProductModel.Location = new System.Drawing.Point(90, 93);
            this.richTextBoxProductModel.MaxLength = 32;
            this.richTextBoxProductModel.Name = "richTextBoxProductModel";
            this.richTextBoxProductModel.Size = new System.Drawing.Size(181, 26);
            this.richTextBoxProductModel.TabIndex = 7;
            this.richTextBoxProductModel.Text = "";
            this.richTextBoxProductModel.TextChanged += new System.EventHandler(this.RichTextBox_TextChanged);
            // 
            // richTextBoxBatchNumber
            // 
            this.richTextBoxBatchNumber.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.richTextBoxBatchNumber.Location = new System.Drawing.Point(90, 127);
            this.richTextBoxBatchNumber.MaxLength = 32;
            this.richTextBoxBatchNumber.Name = "richTextBoxBatchNumber";
            this.richTextBoxBatchNumber.Size = new System.Drawing.Size(181, 26);
            this.richTextBoxBatchNumber.TabIndex = 8;
            this.richTextBoxBatchNumber.Text = "";
            this.richTextBoxBatchNumber.TextChanged += new System.EventHandler(this.RichTextBox_TextChanged);
            // 
            // richTextBoxTestcontroler
            // 
            this.richTextBoxTestcontroler.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.richTextBoxTestcontroler.Location = new System.Drawing.Point(90, 159);
            this.richTextBoxTestcontroler.MaxLength = 32;
            this.richTextBoxTestcontroler.Name = "richTextBoxTestcontroler";
            this.richTextBoxTestcontroler.Size = new System.Drawing.Size(181, 26);
            this.richTextBoxTestcontroler.TabIndex = 9;
            this.richTextBoxTestcontroler.Text = "";
            this.richTextBoxTestcontroler.TextChanged += new System.EventHandler(this.RichTextBox_TextChanged);
            // 
            // labelTemperatureOption
            // 
            this.labelTemperatureOption.AutoSize = true;
            this.labelTemperatureOption.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelTemperatureOption.Location = new System.Drawing.Point(12, 208);
            this.labelTemperatureOption.Name = "labelTemperatureOption";
            this.labelTemperatureOption.Size = new System.Drawing.Size(88, 16);
            this.labelTemperatureOption.TabIndex = 10;
            this.labelTemperatureOption.Text = "温度点选择";
            // 
            // richTextBoxTemperatureOptions
            // 
            this.richTextBoxTemperatureOptions.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.richTextBoxTemperatureOptions.Location = new System.Drawing.Point(12, 227);
            this.richTextBoxTemperatureOptions.MaxLength = 512;
            this.richTextBoxTemperatureOptions.Name = "richTextBoxTemperatureOptions";
            this.richTextBoxTemperatureOptions.Size = new System.Drawing.Size(259, 47);
            this.richTextBoxTemperatureOptions.TabIndex = 11;
            this.richTextBoxTemperatureOptions.Text = "";
            // 
            // labelVoltageOption
            // 
            this.labelVoltageOption.AutoSize = true;
            this.labelVoltageOption.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelVoltageOption.Location = new System.Drawing.Point(12, 286);
            this.labelVoltageOption.Name = "labelVoltageOption";
            this.labelVoltageOption.Size = new System.Drawing.Size(88, 16);
            this.labelVoltageOption.TabIndex = 12;
            this.labelVoltageOption.Text = "电压点选择";
            // 
            // richTextBoxVoltageOptions
            // 
            this.richTextBoxVoltageOptions.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.richTextBoxVoltageOptions.Location = new System.Drawing.Point(12, 305);
            this.richTextBoxVoltageOptions.MaxLength = 512;
            this.richTextBoxVoltageOptions.Name = "richTextBoxVoltageOptions";
            this.richTextBoxVoltageOptions.Size = new System.Drawing.Size(259, 47);
            this.richTextBoxVoltageOptions.TabIndex = 13;
            this.richTextBoxVoltageOptions.Text = "";
            // 
            // checkBoxC25
            // 
            this.checkBoxC25.AutoSize = true;
            this.checkBoxC25.Location = new System.Drawing.Point(15, 233);
            this.checkBoxC25.Name = "checkBoxC25";
            this.checkBoxC25.Size = new System.Drawing.Size(36, 16);
            this.checkBoxC25.TabIndex = 15;
            this.checkBoxC25.Text = "25";
            this.checkBoxC25.UseVisualStyleBackColor = true;
            this.checkBoxC25.CheckedChanged += new System.EventHandler(this.CheckBoxC25_CheckedChanged);
            // 
            // checkBoxV3p3
            // 
            this.checkBoxV3p3.AutoSize = true;
            this.checkBoxV3p3.Location = new System.Drawing.Point(15, 311);
            this.checkBoxV3p3.Name = "checkBoxV3p3";
            this.checkBoxV3p3.Size = new System.Drawing.Size(42, 16);
            this.checkBoxV3p3.TabIndex = 16;
            this.checkBoxV3p3.Text = "3.3";
            this.checkBoxV3p3.UseVisualStyleBackColor = true;
            this.checkBoxV3p3.CheckedChanged += new System.EventHandler(this.CheckBoxV3p3_CheckedChanged);
            // 
            // labelSerialNumber
            // 
            this.labelSerialNumber.AutoSize = true;
            this.labelSerialNumber.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelSerialNumber.Location = new System.Drawing.Point(12, 365);
            this.labelSerialNumber.Name = "labelSerialNumber";
            this.labelSerialNumber.Size = new System.Drawing.Size(88, 16);
            this.labelSerialNumber.TabIndex = 17;
            this.labelSerialNumber.Text = "输入序列号";
            // 
            // richTextBoxSerialNumber
            // 
            this.richTextBoxSerialNumber.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.richTextBoxSerialNumber.Location = new System.Drawing.Point(12, 384);
            this.richTextBoxSerialNumber.MaxLength = 8;
            this.richTextBoxSerialNumber.Name = "richTextBoxSerialNumber";
            this.richTextBoxSerialNumber.Size = new System.Drawing.Size(259, 28);
            this.richTextBoxSerialNumber.TabIndex = 18;
            this.richTextBoxSerialNumber.Text = "12345678";
            this.richTextBoxSerialNumber.TextChanged += new System.EventHandler(this.RichTextBox_TextChanged);
            // 
            // tabControlTestResult
            // 
            this.tabControlTestResult.Controls.Add(this.tabPageTestResult);
            this.tabControlTestResult.Controls.Add(this.tabPageTestItemSelect);
            this.tabControlTestResult.Location = new System.Drawing.Point(277, 58);
            this.tabControlTestResult.Name = "tabControlTestResult";
            this.tabControlTestResult.SelectedIndex = 0;
            this.tabControlTestResult.Size = new System.Drawing.Size(906, 454);
            this.tabControlTestResult.TabIndex = 19;
            this.tabControlTestResult.SelectedIndexChanged += new System.EventHandler(this.TabControl_SelectedIndexChanged);
            // 
            // tabPageTestResult
            // 
            this.tabPageTestResult.Controls.Add(this.dataGridViewTestResult);
            this.tabPageTestResult.Location = new System.Drawing.Point(4, 22);
            this.tabPageTestResult.Name = "tabPageTestResult";
            this.tabPageTestResult.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTestResult.Size = new System.Drawing.Size(898, 428);
            this.tabPageTestResult.TabIndex = 0;
            this.tabPageTestResult.Text = "测试结果";
            this.tabPageTestResult.UseVisualStyleBackColor = true;
            // 
            // dataGridViewTestResult
            // 
            this.dataGridViewTestResult.AllowUserToAddRows = false;
            this.dataGridViewTestResult.AllowUserToDeleteRows = false;
            this.dataGridViewTestResult.AllowUserToResizeColumns = false;
            this.dataGridViewTestResult.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTestResult.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTestResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnTemperature,
            this.ColumnVoltage,
            this.ColumnTestItem,
            this.ColumnTarget,
            this.ColumnMax,
            this.ColumnMin,
            this.ColumnTrueVal,
            this.ColumnDAADC,
            this.ColumnResult,
            this.ColumnSpend,
            this.ColumnComments});
            this.dataGridViewTestResult.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewTestResult.Name = "dataGridViewTestResult";
            this.dataGridViewTestResult.RowTemplate.Height = 23;
            this.dataGridViewTestResult.Size = new System.Drawing.Size(893, 390);
            this.dataGridViewTestResult.TabIndex = 0;
            // 
            // ColumnTemperature
            // 
            this.ColumnTemperature.Frozen = true;
            this.ColumnTemperature.HeaderText = "温度";
            this.ColumnTemperature.MaxInputLength = 8;
            this.ColumnTemperature.MinimumWidth = 32;
            this.ColumnTemperature.Name = "ColumnTemperature";
            this.ColumnTemperature.ReadOnly = true;
            this.ColumnTemperature.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColumnTemperature.Width = 40;
            // 
            // ColumnVoltage
            // 
            this.ColumnVoltage.Frozen = true;
            this.ColumnVoltage.HeaderText = "电压";
            this.ColumnVoltage.MaxInputLength = 8;
            this.ColumnVoltage.MinimumWidth = 32;
            this.ColumnVoltage.Name = "ColumnVoltage";
            this.ColumnVoltage.ReadOnly = true;
            this.ColumnVoltage.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColumnVoltage.Width = 40;
            // 
            // ColumnTestItem
            // 
            this.ColumnTestItem.Frozen = true;
            this.ColumnTestItem.HeaderText = "测试项目";
            this.ColumnTestItem.MaxInputLength = 256;
            this.ColumnTestItem.MinimumWidth = 32;
            this.ColumnTestItem.Name = "ColumnTestItem";
            this.ColumnTestItem.ReadOnly = true;
            this.ColumnTestItem.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColumnTestItem.Width = 160;
            // 
            // ColumnTarget
            // 
            this.ColumnTarget.Frozen = true;
            this.ColumnTarget.HeaderText = "目标值";
            this.ColumnTarget.MaxInputLength = 8;
            this.ColumnTarget.MinimumWidth = 32;
            this.ColumnTarget.Name = "ColumnTarget";
            this.ColumnTarget.ReadOnly = true;
            this.ColumnTarget.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColumnTarget.Width = 66;
            // 
            // ColumnMax
            // 
            this.ColumnMax.Frozen = true;
            this.ColumnMax.HeaderText = "最大值";
            this.ColumnMax.MaxInputLength = 8;
            this.ColumnMax.MinimumWidth = 32;
            this.ColumnMax.Name = "ColumnMax";
            this.ColumnMax.ReadOnly = true;
            this.ColumnMax.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColumnMax.Width = 66;
            // 
            // ColumnMin
            // 
            this.ColumnMin.Frozen = true;
            this.ColumnMin.HeaderText = "最小值";
            this.ColumnMin.MaxInputLength = 8;
            this.ColumnMin.MinimumWidth = 32;
            this.ColumnMin.Name = "ColumnMin";
            this.ColumnMin.ReadOnly = true;
            this.ColumnMin.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColumnMin.Width = 66;
            // 
            // ColumnTrueVal
            // 
            this.ColumnTrueVal.Frozen = true;
            this.ColumnTrueVal.HeaderText = "实际值";
            this.ColumnTrueVal.MaxInputLength = 8;
            this.ColumnTrueVal.MinimumWidth = 32;
            this.ColumnTrueVal.Name = "ColumnTrueVal";
            this.ColumnTrueVal.ReadOnly = true;
            this.ColumnTrueVal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColumnTrueVal.Width = 66;
            // 
            // ColumnDAADC
            // 
            this.ColumnDAADC.Frozen = true;
            this.ColumnDAADC.HeaderText = "DA/ADC";
            this.ColumnDAADC.MaxInputLength = 8;
            this.ColumnDAADC.MinimumWidth = 32;
            this.ColumnDAADC.Name = "ColumnDAADC";
            this.ColumnDAADC.ReadOnly = true;
            this.ColumnDAADC.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColumnDAADC.Width = 48;
            // 
            // ColumnResult
            // 
            this.ColumnResult.Frozen = true;
            this.ColumnResult.HeaderText = "结果";
            this.ColumnResult.MaxInputLength = 8;
            this.ColumnResult.MinimumWidth = 32;
            this.ColumnResult.Name = "ColumnResult";
            this.ColumnResult.ReadOnly = true;
            this.ColumnResult.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColumnResult.Width = 60;
            // 
            // ColumnSpend
            // 
            this.ColumnSpend.Frozen = true;
            this.ColumnSpend.HeaderText = "耗时(秒)";
            this.ColumnSpend.MaxInputLength = 8;
            this.ColumnSpend.MinimumWidth = 32;
            this.ColumnSpend.Name = "ColumnSpend";
            this.ColumnSpend.ReadOnly = true;
            this.ColumnSpend.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColumnSpend.Width = 60;
            // 
            // ColumnComments
            // 
            this.ColumnComments.Frozen = true;
            this.ColumnComments.HeaderText = "备注";
            this.ColumnComments.MaxInputLength = 32;
            this.ColumnComments.MinimumWidth = 32;
            this.ColumnComments.Name = "ColumnComments";
            this.ColumnComments.ReadOnly = true;
            this.ColumnComments.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColumnComments.Width = 200;
            // 
            // tabPageTestItemSelect
            // 
            this.tabPageTestItemSelect.Location = new System.Drawing.Point(4, 22);
            this.tabPageTestItemSelect.Name = "tabPageTestItemSelect";
            this.tabPageTestItemSelect.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTestItemSelect.Size = new System.Drawing.Size(916, 432);
            this.tabPageTestItemSelect.TabIndex = 1;
            this.tabPageTestItemSelect.Text = "测试项选择";
            this.tabPageTestItemSelect.UseVisualStyleBackColor = true;
            // 
            // labelPass
            // 
            this.labelPass.Font = new System.Drawing.Font("SimSun", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelPass.Location = new System.Drawing.Point(9, 428);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(99, 42);
            this.labelPass.TabIndex = 20;
            this.labelPass.Text = "N/A";
            this.labelPass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTestCounter
            // 
            this.labelTestCounter.AutoSize = true;
            this.labelTestCounter.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelTestCounter.Location = new System.Drawing.Point(12, 478);
            this.labelTestCounter.Name = "labelTestCounter";
            this.labelTestCounter.Size = new System.Drawing.Size(96, 16);
            this.labelTestCounter.TabIndex = 21;
            this.labelTestCounter.Text = "成功0,失败0";
            // 
            // PonTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 537);
            this.Controls.Add(this.labelTestCounter);
            this.Controls.Add(this.labelPass);
            this.Controls.Add(this.tabControlTestResult);
            this.Controls.Add(this.richTextBoxSerialNumber);
            this.Controls.Add(this.labelSerialNumber);
            this.Controls.Add(this.checkBoxV3p3);
            this.Controls.Add(this.checkBoxC25);
            this.Controls.Add(this.richTextBoxVoltageOptions);
            this.Controls.Add(this.labelVoltageOption);
            this.Controls.Add(this.richTextBoxTemperatureOptions);
            this.Controls.Add(this.labelTemperatureOption);
            this.Controls.Add(this.richTextBoxTestcontroler);
            this.Controls.Add(this.richTextBoxBatchNumber);
            this.Controls.Add(this.richTextBoxProductModel);
            this.Controls.Add(this.richTextBoxWorkSheetNumber);
            this.Controls.Add(this.labelTestcontroler);
            this.Controls.Add(this.labelBatchNumber);
            this.Controls.Add(this.labelProductModel);
            this.Controls.Add(this.labelWorkSheetNumber);
            this.Controls.Add(this.statusStripPonTest);
            this.Controls.Add(this.menuStripPonTest);
            this.MainMenuStrip = this.menuStripPonTest;
            this.Name = "PonTest";
            this.Text = "FormPonTest";
            this.statusStripPonTest.ResumeLayout(false);
            this.statusStripPonTest.PerformLayout();
            this.menuStripPonTest.ResumeLayout(false);
            this.menuStripPonTest.PerformLayout();
            this.tabControlTestResult.ResumeLayout(false);
            this.tabPageTestResult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTestResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStripPonTest;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusCurrent;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusCurrentText;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusCurrentDate;
        private System.Windows.Forms.Timer timerStatusCurrentDate;
        private System.Windows.Forms.MenuStrip menuStripPonTest;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAutoTest;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemPauseTest;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemPmodelSelect;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAbout;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemExitTest;
        private System.Windows.Forms.Label labelWorkSheetNumber;
        private System.Windows.Forms.Label labelProductModel;
        private System.Windows.Forms.Label labelBatchNumber;
        private System.Windows.Forms.Label labelTestcontroler;
        private System.Windows.Forms.RichTextBox richTextBoxWorkSheetNumber;
        private System.Windows.Forms.RichTextBox richTextBoxProductModel;
        private System.Windows.Forms.RichTextBox richTextBoxBatchNumber;
        private System.Windows.Forms.RichTextBox richTextBoxTestcontroler;
        private System.Windows.Forms.Label labelTemperatureOption;
        private System.Windows.Forms.RichTextBox richTextBoxTemperatureOptions;
        private System.Windows.Forms.Label labelVoltageOption;
        private System.Windows.Forms.RichTextBox richTextBoxVoltageOptions;
        private System.Windows.Forms.CheckBox checkBoxC25;
        private System.Windows.Forms.CheckBox checkBoxV3p3;
        private System.Windows.Forms.Label labelSerialNumber;
        private System.Windows.Forms.RichTextBox richTextBoxSerialNumber;
        private System.Windows.Forms.TabControl tabControlTestResult;
        private System.Windows.Forms.TabPage tabPageTestResult;
        private System.Windows.Forms.TabPage tabPageTestItemSelect;
        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.DataGridView dataGridViewTestResult;
        private System.Windows.Forms.Label labelTestCounter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTemperature;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnVoltage;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTestItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTarget;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMax;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMin;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTrueVal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDAADC;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSpend;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnComments;
    }
}

