namespace DatabaseCourse2
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
            this.production_normasdataGridView = new System.Windows.Forms.DataGridView();
            this.idcomponentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idoperationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeworkerprofessionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workerquilificationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tariffcodeworkerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.completetimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemtimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productionnormasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet2 = new DatabaseCourse2.DataSet2();
            this.production_normasTableAdapter = new DatabaseCourse2.DataSet2TableAdapters.production_normasTableAdapter();
            this.worker_experiencedataGridView = new System.Windows.Forms.DataGridView();
            this.idworkerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finishedworkdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idcomponentDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idoperationDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numgoodcomponentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numbadcomponentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.defectproportionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workerexperienceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.worker_experienceTableAdapter = new DatabaseCourse2.DataSet2TableAdapters.worker_experienceTableAdapter();
            this.worker_infodataGridView = new System.Windows.Forms.DataGridView();
            this.idworkerDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idfactoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iddepartmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeworkerprofessionDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workerquilificationDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marriedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workerinfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.worker_infoTableAdapter = new DatabaseCourse2.DataSet2TableAdapters.worker_infoTableAdapter();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.формыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.основнаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.альтернативнаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.задача1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sqlProcedureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.production_normasdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productionnormasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.worker_experiencedataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workerexperienceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.worker_infodataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workerinfoBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // production_normasdataGridView
            // 
            this.production_normasdataGridView.AutoGenerateColumns = false;
            this.production_normasdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.production_normasdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idcomponentDataGridViewTextBoxColumn,
            this.idoperationDataGridViewTextBoxColumn,
            this.codeworkerprofessionDataGridViewTextBoxColumn,
            this.workerquilificationDataGridViewTextBoxColumn,
            this.tariffcodeworkerDataGridViewTextBoxColumn,
            this.completetimeDataGridViewTextBoxColumn,
            this.itemtimeDataGridViewTextBoxColumn});
            this.production_normasdataGridView.DataSource = this.productionnormasBindingSource;
            this.production_normasdataGridView.Location = new System.Drawing.Point(18, 62);
            this.production_normasdataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.production_normasdataGridView.Name = "production_normasdataGridView";
            this.production_normasdataGridView.RowHeadersWidth = 62;
            this.production_normasdataGridView.Size = new System.Drawing.Size(1113, 231);
            this.production_normasdataGridView.TabIndex = 0;
            // 
            // idcomponentDataGridViewTextBoxColumn
            // 
            this.idcomponentDataGridViewTextBoxColumn.DataPropertyName = "id_component";
            this.idcomponentDataGridViewTextBoxColumn.HeaderText = "id_component";
            this.idcomponentDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idcomponentDataGridViewTextBoxColumn.Name = "idcomponentDataGridViewTextBoxColumn";
            this.idcomponentDataGridViewTextBoxColumn.Width = 150;
            // 
            // idoperationDataGridViewTextBoxColumn
            // 
            this.idoperationDataGridViewTextBoxColumn.DataPropertyName = "id_operation";
            this.idoperationDataGridViewTextBoxColumn.HeaderText = "id_operation";
            this.idoperationDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idoperationDataGridViewTextBoxColumn.Name = "idoperationDataGridViewTextBoxColumn";
            this.idoperationDataGridViewTextBoxColumn.Width = 150;
            // 
            // codeworkerprofessionDataGridViewTextBoxColumn
            // 
            this.codeworkerprofessionDataGridViewTextBoxColumn.DataPropertyName = "code_worker_profession";
            this.codeworkerprofessionDataGridViewTextBoxColumn.HeaderText = "code_worker_profession";
            this.codeworkerprofessionDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.codeworkerprofessionDataGridViewTextBoxColumn.Name = "codeworkerprofessionDataGridViewTextBoxColumn";
            this.codeworkerprofessionDataGridViewTextBoxColumn.Width = 150;
            // 
            // workerquilificationDataGridViewTextBoxColumn
            // 
            this.workerquilificationDataGridViewTextBoxColumn.DataPropertyName = "worker_quilification";
            this.workerquilificationDataGridViewTextBoxColumn.HeaderText = "worker_quilification";
            this.workerquilificationDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.workerquilificationDataGridViewTextBoxColumn.Name = "workerquilificationDataGridViewTextBoxColumn";
            this.workerquilificationDataGridViewTextBoxColumn.Width = 150;
            // 
            // tariffcodeworkerDataGridViewTextBoxColumn
            // 
            this.tariffcodeworkerDataGridViewTextBoxColumn.DataPropertyName = "tariff_code_worker";
            this.tariffcodeworkerDataGridViewTextBoxColumn.HeaderText = "tariff_code_worker";
            this.tariffcodeworkerDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.tariffcodeworkerDataGridViewTextBoxColumn.Name = "tariffcodeworkerDataGridViewTextBoxColumn";
            this.tariffcodeworkerDataGridViewTextBoxColumn.Width = 150;
            // 
            // completetimeDataGridViewTextBoxColumn
            // 
            this.completetimeDataGridViewTextBoxColumn.DataPropertyName = "complete_time";
            this.completetimeDataGridViewTextBoxColumn.HeaderText = "complete_time";
            this.completetimeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.completetimeDataGridViewTextBoxColumn.Name = "completetimeDataGridViewTextBoxColumn";
            this.completetimeDataGridViewTextBoxColumn.Width = 150;
            // 
            // itemtimeDataGridViewTextBoxColumn
            // 
            this.itemtimeDataGridViewTextBoxColumn.DataPropertyName = "item_time";
            this.itemtimeDataGridViewTextBoxColumn.HeaderText = "item_time";
            this.itemtimeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.itemtimeDataGridViewTextBoxColumn.Name = "itemtimeDataGridViewTextBoxColumn";
            this.itemtimeDataGridViewTextBoxColumn.Width = 150;
            // 
            // productionnormasBindingSource
            // 
            this.productionnormasBindingSource.DataMember = "production_normas";
            this.productionnormasBindingSource.DataSource = this.dataSet2;
            // 
            // dataSet2
            // 
            this.dataSet2.DataSetName = "DataSet2";
            this.dataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // production_normasTableAdapter
            // 
            this.production_normasTableAdapter.ClearBeforeFill = true;
            // 
            // worker_experiencedataGridView
            // 
            this.worker_experiencedataGridView.AutoGenerateColumns = false;
            this.worker_experiencedataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.worker_experiencedataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idworkerDataGridViewTextBoxColumn,
            this.finishedworkdateDataGridViewTextBoxColumn,
            this.idcomponentDataGridViewTextBoxColumn1,
            this.idoperationDataGridViewTextBoxColumn1,
            this.numgoodcomponentsDataGridViewTextBoxColumn,
            this.numbadcomponentsDataGridViewTextBoxColumn,
            this.defectproportionDataGridViewTextBoxColumn});
            this.worker_experiencedataGridView.DataSource = this.workerexperienceBindingSource;
            this.worker_experiencedataGridView.Location = new System.Drawing.Point(20, 351);
            this.worker_experiencedataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.worker_experiencedataGridView.Name = "worker_experiencedataGridView";
            this.worker_experiencedataGridView.RowHeadersWidth = 62;
            this.worker_experiencedataGridView.Size = new System.Drawing.Size(1112, 234);
            this.worker_experiencedataGridView.TabIndex = 1;
            // 
            // idworkerDataGridViewTextBoxColumn
            // 
            this.idworkerDataGridViewTextBoxColumn.DataPropertyName = "id_worker";
            this.idworkerDataGridViewTextBoxColumn.HeaderText = "id_worker";
            this.idworkerDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idworkerDataGridViewTextBoxColumn.Name = "idworkerDataGridViewTextBoxColumn";
            this.idworkerDataGridViewTextBoxColumn.Width = 150;
            // 
            // finishedworkdateDataGridViewTextBoxColumn
            // 
            this.finishedworkdateDataGridViewTextBoxColumn.DataPropertyName = "finished_work_date";
            this.finishedworkdateDataGridViewTextBoxColumn.HeaderText = "finished_work_date";
            this.finishedworkdateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.finishedworkdateDataGridViewTextBoxColumn.Name = "finishedworkdateDataGridViewTextBoxColumn";
            this.finishedworkdateDataGridViewTextBoxColumn.Width = 150;
            // 
            // idcomponentDataGridViewTextBoxColumn1
            // 
            this.idcomponentDataGridViewTextBoxColumn1.DataPropertyName = "id_component";
            this.idcomponentDataGridViewTextBoxColumn1.HeaderText = "id_component";
            this.idcomponentDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.idcomponentDataGridViewTextBoxColumn1.Name = "idcomponentDataGridViewTextBoxColumn1";
            this.idcomponentDataGridViewTextBoxColumn1.Width = 150;
            // 
            // idoperationDataGridViewTextBoxColumn1
            // 
            this.idoperationDataGridViewTextBoxColumn1.DataPropertyName = "id_operation";
            this.idoperationDataGridViewTextBoxColumn1.HeaderText = "id_operation";
            this.idoperationDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.idoperationDataGridViewTextBoxColumn1.Name = "idoperationDataGridViewTextBoxColumn1";
            this.idoperationDataGridViewTextBoxColumn1.Width = 150;
            // 
            // numgoodcomponentsDataGridViewTextBoxColumn
            // 
            this.numgoodcomponentsDataGridViewTextBoxColumn.DataPropertyName = "num_good_components";
            this.numgoodcomponentsDataGridViewTextBoxColumn.HeaderText = "num_good_components";
            this.numgoodcomponentsDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.numgoodcomponentsDataGridViewTextBoxColumn.Name = "numgoodcomponentsDataGridViewTextBoxColumn";
            this.numgoodcomponentsDataGridViewTextBoxColumn.Width = 150;
            // 
            // numbadcomponentsDataGridViewTextBoxColumn
            // 
            this.numbadcomponentsDataGridViewTextBoxColumn.DataPropertyName = "num_bad_components";
            this.numbadcomponentsDataGridViewTextBoxColumn.HeaderText = "num_bad_components";
            this.numbadcomponentsDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.numbadcomponentsDataGridViewTextBoxColumn.Name = "numbadcomponentsDataGridViewTextBoxColumn";
            this.numbadcomponentsDataGridViewTextBoxColumn.Width = 150;
            // 
            // defectproportionDataGridViewTextBoxColumn
            // 
            this.defectproportionDataGridViewTextBoxColumn.DataPropertyName = "defect_proportion";
            this.defectproportionDataGridViewTextBoxColumn.HeaderText = "defect_proportion";
            this.defectproportionDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.defectproportionDataGridViewTextBoxColumn.Name = "defectproportionDataGridViewTextBoxColumn";
            this.defectproportionDataGridViewTextBoxColumn.Width = 150;
            // 
            // workerexperienceBindingSource
            // 
            this.workerexperienceBindingSource.DataMember = "worker_experience";
            this.workerexperienceBindingSource.DataSource = this.dataSet2;
            // 
            // worker_experienceTableAdapter
            // 
            this.worker_experienceTableAdapter.ClearBeforeFill = true;
            // 
            // worker_infodataGridView
            // 
            this.worker_infodataGridView.AutoGenerateColumns = false;
            this.worker_infodataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.worker_infodataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idworkerDataGridViewTextBoxColumn1,
            this.idfactoryDataGridViewTextBoxColumn,
            this.iddepartmentDataGridViewTextBoxColumn,
            this.codeworkerprofessionDataGridViewTextBoxColumn1,
            this.workerquilificationDataGridViewTextBoxColumn1,
            this.marriedDataGridViewTextBoxColumn,
            this.fioDataGridViewTextBoxColumn});
            this.worker_infodataGridView.DataSource = this.workerinfoBindingSource;
            this.worker_infodataGridView.Location = new System.Drawing.Point(20, 648);
            this.worker_infodataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.worker_infodataGridView.Name = "worker_infodataGridView";
            this.worker_infodataGridView.RowHeadersWidth = 62;
            this.worker_infodataGridView.Size = new System.Drawing.Size(1112, 235);
            this.worker_infodataGridView.TabIndex = 2;
            // 
            // idworkerDataGridViewTextBoxColumn1
            // 
            this.idworkerDataGridViewTextBoxColumn1.DataPropertyName = "id_worker";
            this.idworkerDataGridViewTextBoxColumn1.HeaderText = "id_worker";
            this.idworkerDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.idworkerDataGridViewTextBoxColumn1.Name = "idworkerDataGridViewTextBoxColumn1";
            this.idworkerDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idworkerDataGridViewTextBoxColumn1.Width = 150;
            // 
            // idfactoryDataGridViewTextBoxColumn
            // 
            this.idfactoryDataGridViewTextBoxColumn.DataPropertyName = "id_factory";
            this.idfactoryDataGridViewTextBoxColumn.HeaderText = "id_factory";
            this.idfactoryDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idfactoryDataGridViewTextBoxColumn.Name = "idfactoryDataGridViewTextBoxColumn";
            this.idfactoryDataGridViewTextBoxColumn.Width = 150;
            // 
            // iddepartmentDataGridViewTextBoxColumn
            // 
            this.iddepartmentDataGridViewTextBoxColumn.DataPropertyName = "id_department";
            this.iddepartmentDataGridViewTextBoxColumn.HeaderText = "id_department";
            this.iddepartmentDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.iddepartmentDataGridViewTextBoxColumn.Name = "iddepartmentDataGridViewTextBoxColumn";
            this.iddepartmentDataGridViewTextBoxColumn.Width = 150;
            // 
            // codeworkerprofessionDataGridViewTextBoxColumn1
            // 
            this.codeworkerprofessionDataGridViewTextBoxColumn1.DataPropertyName = "code_worker_profession";
            this.codeworkerprofessionDataGridViewTextBoxColumn1.HeaderText = "code_worker_profession";
            this.codeworkerprofessionDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.codeworkerprofessionDataGridViewTextBoxColumn1.Name = "codeworkerprofessionDataGridViewTextBoxColumn1";
            this.codeworkerprofessionDataGridViewTextBoxColumn1.Width = 150;
            // 
            // workerquilificationDataGridViewTextBoxColumn1
            // 
            this.workerquilificationDataGridViewTextBoxColumn1.DataPropertyName = "worker_quilification";
            this.workerquilificationDataGridViewTextBoxColumn1.HeaderText = "worker_quilification";
            this.workerquilificationDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.workerquilificationDataGridViewTextBoxColumn1.Name = "workerquilificationDataGridViewTextBoxColumn1";
            this.workerquilificationDataGridViewTextBoxColumn1.Width = 150;
            // 
            // marriedDataGridViewTextBoxColumn
            // 
            this.marriedDataGridViewTextBoxColumn.DataPropertyName = "married";
            this.marriedDataGridViewTextBoxColumn.HeaderText = "married";
            this.marriedDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.marriedDataGridViewTextBoxColumn.Name = "marriedDataGridViewTextBoxColumn";
            this.marriedDataGridViewTextBoxColumn.Width = 150;
            // 
            // fioDataGridViewTextBoxColumn
            // 
            this.fioDataGridViewTextBoxColumn.DataPropertyName = "fio";
            this.fioDataGridViewTextBoxColumn.HeaderText = "fio";
            this.fioDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.fioDataGridViewTextBoxColumn.Name = "fioDataGridViewTextBoxColumn";
            this.fioDataGridViewTextBoxColumn.Width = 150;
            // 
            // workerinfoBindingSource
            // 
            this.workerinfoBindingSource.DataMember = "worker_info";
            this.workerinfoBindingSource.DataSource = this.dataSet2;
            // 
            // worker_infoTableAdapter
            // 
            this.worker_infoTableAdapter.ClearBeforeFill = true;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSave.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSave.Location = new System.Drawing.Point(236, 928);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(112, 35);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnRefresh.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnRefresh.Location = new System.Drawing.Point(831, 928);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(112, 35);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "production_normas";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 326);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "worker_experience";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 623);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "worker_info";
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.формыToolStripMenuItem,
            this.задача1ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1176, 35);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // формыToolStripMenuItem
            // 
            this.формыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.основнаяToolStripMenuItem,
            this.альтернативнаяToolStripMenuItem,
            this.sqlProcedureToolStripMenuItem});
            this.формыToolStripMenuItem.Name = "формыToolStripMenuItem";
            this.формыToolStripMenuItem.Size = new System.Drawing.Size(89, 29);
            this.формыToolStripMenuItem.Text = "Формы";
            // 
            // основнаяToolStripMenuItem
            // 
            this.основнаяToolStripMenuItem.Name = "основнаяToolStripMenuItem";
            this.основнаяToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.основнаяToolStripMenuItem.Text = "Основная";
            // 
            // альтернативнаяToolStripMenuItem
            // 
            this.альтернативнаяToolStripMenuItem.Name = "альтернативнаяToolStripMenuItem";
            this.альтернативнаяToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.альтернативнаяToolStripMenuItem.Text = "Альтернативная";
            this.альтернативнаяToolStripMenuItem.Click += new System.EventHandler(this.альтернативнаяToolStripMenuItem_Click);
            // 
            // задача1ToolStripMenuItem
            // 
            this.задача1ToolStripMenuItem.Name = "задача1ToolStripMenuItem";
            this.задача1ToolStripMenuItem.Size = new System.Drawing.Size(100, 29);
            this.задача1ToolStripMenuItem.Text = "Задача 1";
            // 
            // sqlProcedureToolStripMenuItem
            // 
            this.sqlProcedureToolStripMenuItem.Name = "sqlProcedureToolStripMenuItem";
            this.sqlProcedureToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.sqlProcedureToolStripMenuItem.Text = "SqlProcedure";
            this.sqlProcedureToolStripMenuItem.Click += new System.EventHandler(this.sqlProcedureToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 1050);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.worker_infodataGridView);
            this.Controls.Add(this.worker_experiencedataGridView);
            this.Controls.Add(this.production_normasdataGridView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.production_normasdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productionnormasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.worker_experiencedataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workerexperienceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.worker_infodataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workerinfoBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView production_normasdataGridView;
        private DataSet2 dataSet2;
        private System.Windows.Forms.BindingSource productionnormasBindingSource;
        private DataSet2TableAdapters.production_normasTableAdapter production_normasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcomponentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idoperationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeworkerprofessionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workerquilificationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tariffcodeworkerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn completetimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemtimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView worker_experiencedataGridView;
        private System.Windows.Forms.BindingSource workerexperienceBindingSource;
        private DataSet2TableAdapters.worker_experienceTableAdapter worker_experienceTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idworkerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn finishedworkdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcomponentDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idoperationDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn numgoodcomponentsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numbadcomponentsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn defectproportionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView worker_infodataGridView;
        private System.Windows.Forms.BindingSource workerinfoBindingSource;
        private DataSet2TableAdapters.worker_infoTableAdapter worker_infoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idworkerDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idfactoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iddepartmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeworkerprofessionDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn workerquilificationDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn marriedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fioDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem формыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem основнаяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem альтернативнаяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem задача1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sqlProcedureToolStripMenuItem;
    }
}

