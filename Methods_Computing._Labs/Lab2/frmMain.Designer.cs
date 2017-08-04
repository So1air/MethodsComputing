namespace Lab2
{
    partial class frmMain
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grB_EditSLAEs = new System.Windows.Forms.GroupBox();
            this.grB_AutoFormatWidthColumns = new System.Windows.Forms.GroupBox();
            this.rdB_Fill = new System.Windows.Forms.RadioButton();
            this.rdB_AllCells = new System.Windows.Forms.RadioButton();
            this.txB_NameNewSystem = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAccept = new System.Windows.Forms.Button();
            this.lbl_CountEquations = new System.Windows.Forms.Label();
            this.lbl_CountVariables = new System.Windows.Forms.Label();
            this.nUD_CountEquations = new System.Windows.Forms.NumericUpDown();
            this.nUD_CountVariables = new System.Windows.Forms.NumericUpDown();
            this.btnChangeSLAE = new System.Windows.Forms.Button();
            this.cmB_ListSLAEs = new System.Windows.Forms.ComboBox();
            this.btnAddSLAE = new System.Windows.Forms.Button();
            this.dGV_ConstantTermsOfSLAE = new System.Windows.Forms.DataGridView();
            this.f = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dGV_MatrixOfSLAE = new System.Windows.Forms.DataGridView();
            this.grB_SolvingSelectedSLAE = new System.Windows.Forms.GroupBox();
            this.pnl_InfoAboutSolution = new System.Windows.Forms.Panel();
            this.ltB_InfoAboutSolution = new System.Windows.Forms.ListBox();
            this.lblInfoAboutSolution = new System.Windows.Forms.Label();
            this.lblСorrectnessOfIterMethods = new System.Windows.Forms.Label();
            this.txB_СorrectnessOfIterMethods = new System.Windows.Forms.TextBox();
            this.btnSolveSLAE = new System.Windows.Forms.Button();
            this.grB_MethodSolving = new System.Windows.Forms.GroupBox();
            this.rdB_mSeidelMethod = new System.Windows.Forms.RadioButton();
            this.rdB_mMethodOfSuccessiveIteration = new System.Windows.Forms.RadioButton();
            this.rdB_mMethodOfGaussianElimination = new System.Windows.Forms.RadioButton();
            this.rdB_mSquare_RootMethod = new System.Windows.Forms.RadioButton();
            this.rdB_mThreediagonalMatrixAlgorithm = new System.Windows.Forms.RadioButton();
            this.grB_EditSLAEs.SuspendLayout();
            this.grB_AutoFormatWidthColumns.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_CountEquations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_CountVariables)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_ConstantTermsOfSLAE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_MatrixOfSLAE)).BeginInit();
            this.grB_SolvingSelectedSLAE.SuspendLayout();
            this.pnl_InfoAboutSolution.SuspendLayout();
            this.grB_MethodSolving.SuspendLayout();
            this.SuspendLayout();
            // 
            // grB_EditSLAEs
            // 
            this.grB_EditSLAEs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grB_EditSLAEs.BackColor = System.Drawing.Color.GhostWhite;
            this.grB_EditSLAEs.Controls.Add(this.grB_AutoFormatWidthColumns);
            this.grB_EditSLAEs.Controls.Add(this.txB_NameNewSystem);
            this.grB_EditSLAEs.Controls.Add(this.btnCancel);
            this.grB_EditSLAEs.Controls.Add(this.btnAccept);
            this.grB_EditSLAEs.Controls.Add(this.lbl_CountEquations);
            this.grB_EditSLAEs.Controls.Add(this.lbl_CountVariables);
            this.grB_EditSLAEs.Controls.Add(this.nUD_CountEquations);
            this.grB_EditSLAEs.Controls.Add(this.nUD_CountVariables);
            this.grB_EditSLAEs.Controls.Add(this.btnChangeSLAE);
            this.grB_EditSLAEs.Controls.Add(this.cmB_ListSLAEs);
            this.grB_EditSLAEs.Controls.Add(this.btnAddSLAE);
            this.grB_EditSLAEs.Controls.Add(this.dGV_ConstantTermsOfSLAE);
            this.grB_EditSLAEs.Controls.Add(this.dGV_MatrixOfSLAE);
            this.grB_EditSLAEs.Location = new System.Drawing.Point(2, 4);
            this.grB_EditSLAEs.Name = "grB_EditSLAEs";
            this.grB_EditSLAEs.Size = new System.Drawing.Size(901, 359);
            this.grB_EditSLAEs.TabIndex = 0;
            this.grB_EditSLAEs.TabStop = false;
            this.grB_EditSLAEs.Text = "Задання та змінення систем";
            // 
            // grB_AutoFormatWidthColumns
            // 
            this.grB_AutoFormatWidthColumns.Controls.Add(this.rdB_Fill);
            this.grB_AutoFormatWidthColumns.Controls.Add(this.rdB_AllCells);
            this.grB_AutoFormatWidthColumns.Location = new System.Drawing.Point(228, 47);
            this.grB_AutoFormatWidthColumns.Name = "grB_AutoFormatWidthColumns";
            this.grB_AutoFormatWidthColumns.Size = new System.Drawing.Size(221, 46);
            this.grB_AutoFormatWidthColumns.TabIndex = 13;
            this.grB_AutoFormatWidthColumns.TabStop = false;
            this.grB_AutoFormatWidthColumns.Text = "Автоформат ширини стовпців";
            // 
            // rdB_Fill
            // 
            this.rdB_Fill.AutoSize = true;
            this.rdB_Fill.Checked = true;
            this.rdB_Fill.Location = new System.Drawing.Point(93, 21);
            this.rdB_Fill.Name = "rdB_Fill";
            this.rdB_Fill.Size = new System.Drawing.Size(126, 17);
            this.rdB_Fill.TabIndex = 8;
            this.rdB_Fill.TabStop = true;
            this.rdB_Fill.Text = "за шириною таблиці";
            this.rdB_Fill.UseVisualStyleBackColor = true;
            this.rdB_Fill.CheckedChanged += new System.EventHandler(this.rdB_AutoFormatWidthColumns_CheckedChanged);
            // 
            // rdB_AllCells
            // 
            this.rdB_AllCells.AutoSize = true;
            this.rdB_AllCells.Location = new System.Drawing.Point(6, 21);
            this.rdB_AllCells.Name = "rdB_AllCells";
            this.rdB_AllCells.Size = new System.Drawing.Size(81, 17);
            this.rdB_AllCells.TabIndex = 7;
            this.rdB_AllCells.Text = "за вмістом";
            this.rdB_AllCells.UseVisualStyleBackColor = true;
            this.rdB_AllCells.CheckedChanged += new System.EventHandler(this.rdB_AutoFormatWidthColumns_CheckedChanged);
            // 
            // txB_NameNewSystem
            // 
            this.txB_NameNewSystem.Location = new System.Drawing.Point(10, 16);
            this.txB_NameNewSystem.Name = "txB_NameNewSystem";
            this.txB_NameNewSystem.Size = new System.Drawing.Size(439, 20);
            this.txB_NameNewSystem.TabIndex = 1;
            this.txB_NameNewSystem.Visible = false;
            this.txB_NameNewSystem.WordWrap = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Location = new System.Drawing.Point(675, 29);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(220, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Скасувати";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAccept
            // 
            this.btnAccept.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAccept.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAccept.Location = new System.Drawing.Point(675, 8);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(220, 23);
            this.btnAccept.TabIndex = 4;
            this.btnAccept.Text = "Підтвердити";
            this.btnAccept.UseVisualStyleBackColor = false;
            this.btnAccept.Visible = false;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // lbl_CountEquations
            // 
            this.lbl_CountEquations.AutoSize = true;
            this.lbl_CountEquations.Location = new System.Drawing.Point(11, 70);
            this.lbl_CountEquations.Name = "lbl_CountEquations";
            this.lbl_CountEquations.Size = new System.Drawing.Size(97, 13);
            this.lbl_CountEquations.TabIndex = 9;
            this.lbl_CountEquations.Text = "Кількість рівнянь:";
            // 
            // lbl_CountVariables
            // 
            this.lbl_CountVariables.AutoSize = true;
            this.lbl_CountVariables.Location = new System.Drawing.Point(10, 49);
            this.lbl_CountVariables.Name = "lbl_CountVariables";
            this.lbl_CountVariables.Size = new System.Drawing.Size(98, 13);
            this.lbl_CountVariables.TabIndex = 8;
            this.lbl_CountVariables.Text = "Кількість змінних:";
            // 
            // nUD_CountEquations
            // 
            this.nUD_CountEquations.Enabled = false;
            this.nUD_CountEquations.Location = new System.Drawing.Point(114, 73);
            this.nUD_CountEquations.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nUD_CountEquations.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nUD_CountEquations.Name = "nUD_CountEquations";
            this.nUD_CountEquations.Size = new System.Drawing.Size(87, 20);
            this.nUD_CountEquations.TabIndex = 7;
            this.nUD_CountEquations.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nUD_CountEquations.ValueChanged += new System.EventHandler(this.nUD_CountEquations_ValueChanged);
            // 
            // nUD_CountVariables
            // 
            this.nUD_CountVariables.Enabled = false;
            this.nUD_CountVariables.Location = new System.Drawing.Point(114, 47);
            this.nUD_CountVariables.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nUD_CountVariables.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nUD_CountVariables.Name = "nUD_CountVariables";
            this.nUD_CountVariables.Size = new System.Drawing.Size(87, 20);
            this.nUD_CountVariables.TabIndex = 6;
            this.nUD_CountVariables.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nUD_CountVariables.ValueChanged += new System.EventHandler(this.nUD_CountVariables_ValueChanged);
            // 
            // btnChangeSLAE
            // 
            this.btnChangeSLAE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnChangeSLAE.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChangeSLAE.Location = new System.Drawing.Point(455, 29);
            this.btnChangeSLAE.Name = "btnChangeSLAE";
            this.btnChangeSLAE.Size = new System.Drawing.Size(220, 23);
            this.btnChangeSLAE.TabIndex = 3;
            this.btnChangeSLAE.Text = "Змінити";
            this.btnChangeSLAE.UseVisualStyleBackColor = false;
            this.btnChangeSLAE.Click += new System.EventHandler(this.btnChangeSLAE_Click);
            // 
            // cmB_ListSLAEs
            // 
            this.cmB_ListSLAEs.FormattingEnabled = true;
            this.cmB_ListSLAEs.Location = new System.Drawing.Point(10, 16);
            this.cmB_ListSLAEs.Name = "cmB_ListSLAEs";
            this.cmB_ListSLAEs.Size = new System.Drawing.Size(439, 21);
            this.cmB_ListSLAEs.TabIndex = 4;
            this.cmB_ListSLAEs.SelectedIndexChanged += new System.EventHandler(this.cmB_ListSLAEs_SelectedIndexChanged);
            // 
            // btnAddSLAE
            // 
            this.btnAddSLAE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnAddSLAE.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddSLAE.Location = new System.Drawing.Point(455, 8);
            this.btnAddSLAE.Name = "btnAddSLAE";
            this.btnAddSLAE.Size = new System.Drawing.Size(220, 23);
            this.btnAddSLAE.TabIndex = 2;
            this.btnAddSLAE.Text = "Додати";
            this.btnAddSLAE.UseVisualStyleBackColor = false;
            this.btnAddSLAE.Click += new System.EventHandler(this.btnAddSLAE_Click);
            // 
            // dGV_ConstantTermsOfSLAE
            // 
            this.dGV_ConstantTermsOfSLAE.AllowDrop = true;
            this.dGV_ConstantTermsOfSLAE.AllowUserToAddRows = false;
            this.dGV_ConstantTermsOfSLAE.AllowUserToDeleteRows = false;
            this.dGV_ConstantTermsOfSLAE.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGV_ConstantTermsOfSLAE.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGV_ConstantTermsOfSLAE.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dGV_ConstantTermsOfSLAE.BackgroundColor = System.Drawing.Color.Ivory;
            this.dGV_ConstantTermsOfSLAE.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dGV_ConstantTermsOfSLAE.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dGV_ConstantTermsOfSLAE.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.dGV_ConstantTermsOfSLAE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_ConstantTermsOfSLAE.ColumnHeadersVisible = false;
            this.dGV_ConstantTermsOfSLAE.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.f});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 1, 0, 1);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGV_ConstantTermsOfSLAE.DefaultCellStyle = dataGridViewCellStyle1;
            this.dGV_ConstantTermsOfSLAE.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dGV_ConstantTermsOfSLAE.Location = new System.Drawing.Point(769, 99);
            this.dGV_ConstantTermsOfSLAE.Name = "dGV_ConstantTermsOfSLAE";
            this.dGV_ConstantTermsOfSLAE.ReadOnly = true;
            this.dGV_ConstantTermsOfSLAE.RowHeadersVisible = false;
            this.dGV_ConstantTermsOfSLAE.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dGV_ConstantTermsOfSLAE.Size = new System.Drawing.Size(99, 245);
            this.dGV_ConstantTermsOfSLAE.StandardTab = true;
            this.dGV_ConstantTermsOfSLAE.TabIndex = 10;
            this.dGV_ConstantTermsOfSLAE.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV_ConstantTermsOfSLAE_CellEnter);
            this.dGV_ConstantTermsOfSLAE.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV_ConstantTermsOfSLAE_CellValidated);
            this.dGV_ConstantTermsOfSLAE.Scroll += new System.Windows.Forms.ScrollEventHandler(this.dGV_Sync_Scroll);
            // 
            // f
            // 
            this.f.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.f.HeaderText = "f";
            this.f.Name = "f";
            this.f.ReadOnly = true;
            // 
            // dGV_MatrixOfSLAE
            // 
            this.dGV_MatrixOfSLAE.AllowDrop = true;
            this.dGV_MatrixOfSLAE.AllowUserToAddRows = false;
            this.dGV_MatrixOfSLAE.AllowUserToDeleteRows = false;
            this.dGV_MatrixOfSLAE.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGV_MatrixOfSLAE.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGV_MatrixOfSLAE.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dGV_MatrixOfSLAE.BackgroundColor = System.Drawing.Color.Ivory;
            this.dGV_MatrixOfSLAE.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dGV_MatrixOfSLAE.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dGV_MatrixOfSLAE.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.dGV_MatrixOfSLAE.ColumnHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 1, 0, 1);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGV_MatrixOfSLAE.DefaultCellStyle = dataGridViewCellStyle2;
            this.dGV_MatrixOfSLAE.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dGV_MatrixOfSLAE.Location = new System.Drawing.Point(10, 99);
            this.dGV_MatrixOfSLAE.Name = "dGV_MatrixOfSLAE";
            this.dGV_MatrixOfSLAE.ReadOnly = true;
            this.dGV_MatrixOfSLAE.RowHeadersVisible = false;
            this.dGV_MatrixOfSLAE.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dGV_MatrixOfSLAE.Size = new System.Drawing.Size(753, 245);
            this.dGV_MatrixOfSLAE.StandardTab = true;
            this.dGV_MatrixOfSLAE.TabIndex = 9;
            this.dGV_MatrixOfSLAE.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV_MatrixOfSLAE_CellEnter);
            this.dGV_MatrixOfSLAE.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV_MatrixOfSLAE_CellValidated);
            this.dGV_MatrixOfSLAE.Scroll += new System.Windows.Forms.ScrollEventHandler(this.dGV_Sync_Scroll);
            // 
            // grB_SolvingSelectedSLAE
            // 
            this.grB_SolvingSelectedSLAE.BackColor = System.Drawing.Color.GhostWhite;
            this.grB_SolvingSelectedSLAE.Controls.Add(this.pnl_InfoAboutSolution);
            this.grB_SolvingSelectedSLAE.Controls.Add(this.lblСorrectnessOfIterMethods);
            this.grB_SolvingSelectedSLAE.Controls.Add(this.txB_СorrectnessOfIterMethods);
            this.grB_SolvingSelectedSLAE.Controls.Add(this.btnSolveSLAE);
            this.grB_SolvingSelectedSLAE.Controls.Add(this.grB_MethodSolving);
            this.grB_SolvingSelectedSLAE.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grB_SolvingSelectedSLAE.Location = new System.Drawing.Point(0, 369);
            this.grB_SolvingSelectedSLAE.Name = "grB_SolvingSelectedSLAE";
            this.grB_SolvingSelectedSLAE.Size = new System.Drawing.Size(907, 175);
            this.grB_SolvingSelectedSLAE.TabIndex = 1;
            this.grB_SolvingSelectedSLAE.TabStop = false;
            this.grB_SolvingSelectedSLAE.Text = "Розв\'язання обраної системи";
            // 
            // pnl_InfoAboutSolution
            // 
            this.pnl_InfoAboutSolution.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_InfoAboutSolution.Controls.Add(this.ltB_InfoAboutSolution);
            this.pnl_InfoAboutSolution.Controls.Add(this.lblInfoAboutSolution);
            this.pnl_InfoAboutSolution.Location = new System.Drawing.Point(508, 16);
            this.pnl_InfoAboutSolution.Name = "pnl_InfoAboutSolution";
            this.pnl_InfoAboutSolution.Size = new System.Drawing.Size(389, 153);
            this.pnl_InfoAboutSolution.TabIndex = 4;
            this.pnl_InfoAboutSolution.Visible = false;
            // 
            // ltB_InfoAboutSolution
            // 
            this.ltB_InfoAboutSolution.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ltB_InfoAboutSolution.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ltB_InfoAboutSolution.FormattingEnabled = true;
            this.ltB_InfoAboutSolution.ItemHeight = 20;
            this.ltB_InfoAboutSolution.Location = new System.Drawing.Point(13, 26);
            this.ltB_InfoAboutSolution.Name = "ltB_InfoAboutSolution";
            this.ltB_InfoAboutSolution.Size = new System.Drawing.Size(363, 104);
            this.ltB_InfoAboutSolution.TabIndex = 17;
            // 
            // lblInfoAboutSolution
            // 
            this.lblInfoAboutSolution.AutoSize = true;
            this.lblInfoAboutSolution.Location = new System.Drawing.Point(10, 10);
            this.lblInfoAboutSolution.Name = "lblInfoAboutSolution";
            this.lblInfoAboutSolution.Size = new System.Drawing.Size(141, 13);
            this.lblInfoAboutSolution.TabIndex = 0;
            this.lblInfoAboutSolution.Text = "Інформація про розв\'язок:";
            // 
            // lblСorrectnessOfIterMethods
            // 
            this.lblСorrectnessOfIterMethods.AutoSize = true;
            this.lblСorrectnessOfIterMethods.Location = new System.Drawing.Point(283, 32);
            this.lblСorrectnessOfIterMethods.MaximumSize = new System.Drawing.Size(200, 0);
            this.lblСorrectnessOfIterMethods.Name = "lblСorrectnessOfIterMethods";
            this.lblСorrectnessOfIterMethods.Size = new System.Drawing.Size(180, 26);
            this.lblСorrectnessOfIterMethods.TabIndex = 3;
            this.lblСorrectnessOfIterMethods.Text = "Точність розв\'язання ітераційним методом:";
            this.lblСorrectnessOfIterMethods.Visible = false;
            // 
            // txB_СorrectnessOfIterMethods
            // 
            this.txB_СorrectnessOfIterMethods.Location = new System.Drawing.Point(286, 61);
            this.txB_СorrectnessOfIterMethods.Name = "txB_СorrectnessOfIterMethods";
            this.txB_СorrectnessOfIterMethods.Size = new System.Drawing.Size(200, 20);
            this.txB_СorrectnessOfIterMethods.TabIndex = 16;
            this.txB_СorrectnessOfIterMethods.Text = "0,00001";
            this.txB_СorrectnessOfIterMethods.Visible = false;
            this.txB_СorrectnessOfIterMethods.Leave += new System.EventHandler(this.txB_СorrectnessOfIterMethods_Leave);
            // 
            // btnSolveSLAE
            // 
            this.btnSolveSLAE.Location = new System.Drawing.Point(286, 146);
            this.btnSolveSLAE.Name = "btnSolveSLAE";
            this.btnSolveSLAE.Size = new System.Drawing.Size(200, 23);
            this.btnSolveSLAE.TabIndex = 0;
            this.btnSolveSLAE.Text = "Розв\'язати";
            this.btnSolveSLAE.UseVisualStyleBackColor = true;
            this.btnSolveSLAE.Click += new System.EventHandler(this.btnSolveSLAE_Click);
            // 
            // grB_MethodSolving
            // 
            this.grB_MethodSolving.Controls.Add(this.rdB_mSeidelMethod);
            this.grB_MethodSolving.Controls.Add(this.rdB_mMethodOfSuccessiveIteration);
            this.grB_MethodSolving.Controls.Add(this.rdB_mMethodOfGaussianElimination);
            this.grB_MethodSolving.Controls.Add(this.rdB_mSquare_RootMethod);
            this.grB_MethodSolving.Controls.Add(this.rdB_mThreediagonalMatrixAlgorithm);
            this.grB_MethodSolving.Dock = System.Windows.Forms.DockStyle.Left;
            this.grB_MethodSolving.Location = new System.Drawing.Point(3, 16);
            this.grB_MethodSolving.Name = "grB_MethodSolving";
            this.grB_MethodSolving.Size = new System.Drawing.Size(277, 156);
            this.grB_MethodSolving.TabIndex = 0;
            this.grB_MethodSolving.TabStop = false;
            this.grB_MethodSolving.Text = "Метод розв\'язання";
            // 
            // rdB_mSeidelMethod
            // 
            this.rdB_mSeidelMethod.AutoSize = true;
            this.rdB_mSeidelMethod.Dock = System.Windows.Forms.DockStyle.Top;
            this.rdB_mSeidelMethod.Location = new System.Drawing.Point(3, 100);
            this.rdB_mSeidelMethod.Name = "rdB_mSeidelMethod";
            this.rdB_mSeidelMethod.Padding = new System.Windows.Forms.Padding(2);
            this.rdB_mSeidelMethod.Size = new System.Drawing.Size(271, 21);
            this.rdB_mSeidelMethod.TabIndex = 15;
            this.rdB_mSeidelMethod.Text = "метод Зейделя";
            this.rdB_mSeidelMethod.UseVisualStyleBackColor = true;
            this.rdB_mSeidelMethod.CheckedChanged += new System.EventHandler(this.rdB_SelectionMethod_CheckedChanged);
            // 
            // rdB_mMethodOfSuccessiveIteration
            // 
            this.rdB_mMethodOfSuccessiveIteration.AutoSize = true;
            this.rdB_mMethodOfSuccessiveIteration.Dock = System.Windows.Forms.DockStyle.Top;
            this.rdB_mMethodOfSuccessiveIteration.Location = new System.Drawing.Point(3, 79);
            this.rdB_mMethodOfSuccessiveIteration.Name = "rdB_mMethodOfSuccessiveIteration";
            this.rdB_mMethodOfSuccessiveIteration.Padding = new System.Windows.Forms.Padding(2);
            this.rdB_mMethodOfSuccessiveIteration.Size = new System.Drawing.Size(271, 21);
            this.rdB_mMethodOfSuccessiveIteration.TabIndex = 14;
            this.rdB_mMethodOfSuccessiveIteration.Text = "метод простої ітерації";
            this.rdB_mMethodOfSuccessiveIteration.UseVisualStyleBackColor = true;
            this.rdB_mMethodOfSuccessiveIteration.CheckedChanged += new System.EventHandler(this.rdB_SelectionMethod_CheckedChanged);
            // 
            // rdB_mMethodOfGaussianElimination
            // 
            this.rdB_mMethodOfGaussianElimination.AutoSize = true;
            this.rdB_mMethodOfGaussianElimination.Dock = System.Windows.Forms.DockStyle.Top;
            this.rdB_mMethodOfGaussianElimination.Location = new System.Drawing.Point(3, 58);
            this.rdB_mMethodOfGaussianElimination.Name = "rdB_mMethodOfGaussianElimination";
            this.rdB_mMethodOfGaussianElimination.Padding = new System.Windows.Forms.Padding(2);
            this.rdB_mMethodOfGaussianElimination.Size = new System.Drawing.Size(271, 21);
            this.rdB_mMethodOfGaussianElimination.TabIndex = 13;
            this.rdB_mMethodOfGaussianElimination.Text = "метод Гауса(послідовного виключення змінних)";
            this.rdB_mMethodOfGaussianElimination.UseVisualStyleBackColor = true;
            this.rdB_mMethodOfGaussianElimination.CheckedChanged += new System.EventHandler(this.rdB_SelectionMethod_CheckedChanged);
            // 
            // rdB_mSquare_RootMethod
            // 
            this.rdB_mSquare_RootMethod.AutoSize = true;
            this.rdB_mSquare_RootMethod.Dock = System.Windows.Forms.DockStyle.Top;
            this.rdB_mSquare_RootMethod.Location = new System.Drawing.Point(3, 37);
            this.rdB_mSquare_RootMethod.Name = "rdB_mSquare_RootMethod";
            this.rdB_mSquare_RootMethod.Padding = new System.Windows.Forms.Padding(2);
            this.rdB_mSquare_RootMethod.Size = new System.Drawing.Size(271, 21);
            this.rdB_mSquare_RootMethod.TabIndex = 12;
            this.rdB_mSquare_RootMethod.Text = "метод квадратного кореня";
            this.rdB_mSquare_RootMethod.UseVisualStyleBackColor = true;
            this.rdB_mSquare_RootMethod.CheckedChanged += new System.EventHandler(this.rdB_SelectionMethod_CheckedChanged);
            // 
            // rdB_mThreediagonalMatrixAlgorithm
            // 
            this.rdB_mThreediagonalMatrixAlgorithm.AutoSize = true;
            this.rdB_mThreediagonalMatrixAlgorithm.Checked = true;
            this.rdB_mThreediagonalMatrixAlgorithm.Dock = System.Windows.Forms.DockStyle.Top;
            this.rdB_mThreediagonalMatrixAlgorithm.Location = new System.Drawing.Point(3, 16);
            this.rdB_mThreediagonalMatrixAlgorithm.Name = "rdB_mThreediagonalMatrixAlgorithm";
            this.rdB_mThreediagonalMatrixAlgorithm.Padding = new System.Windows.Forms.Padding(2);
            this.rdB_mThreediagonalMatrixAlgorithm.Size = new System.Drawing.Size(271, 21);
            this.rdB_mThreediagonalMatrixAlgorithm.TabIndex = 11;
            this.rdB_mThreediagonalMatrixAlgorithm.TabStop = true;
            this.rdB_mThreediagonalMatrixAlgorithm.Text = "метод прогонки";
            this.rdB_mThreediagonalMatrixAlgorithm.UseVisualStyleBackColor = true;
            this.rdB_mThreediagonalMatrixAlgorithm.CheckedChanged += new System.EventHandler(this.rdB_SelectionMethod_CheckedChanged);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 544);
            this.Controls.Add(this.grB_SolvingSelectedSLAE);
            this.Controls.Add(this.grB_EditSLAEs);
            this.Name = "frmMain";
            this.Text = "Методи розв’язання систем лінійних алгебраїчних рівнянь (СЛАР)";
            this.grB_EditSLAEs.ResumeLayout(false);
            this.grB_EditSLAEs.PerformLayout();
            this.grB_AutoFormatWidthColumns.ResumeLayout(false);
            this.grB_AutoFormatWidthColumns.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_CountEquations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_CountVariables)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_ConstantTermsOfSLAE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_MatrixOfSLAE)).EndInit();
            this.grB_SolvingSelectedSLAE.ResumeLayout(false);
            this.grB_SolvingSelectedSLAE.PerformLayout();
            this.pnl_InfoAboutSolution.ResumeLayout(false);
            this.pnl_InfoAboutSolution.PerformLayout();
            this.grB_MethodSolving.ResumeLayout(false);
            this.grB_MethodSolving.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grB_EditSLAEs;
        private System.Windows.Forms.Button btnAddSLAE;
        private System.Windows.Forms.DataGridView dGV_ConstantTermsOfSLAE;
        private System.Windows.Forms.DataGridView dGV_MatrixOfSLAE;
        private System.Windows.Forms.DataGridViewTextBoxColumn f;
        private System.Windows.Forms.NumericUpDown nUD_CountEquations;
        private System.Windows.Forms.NumericUpDown nUD_CountVariables;
        private System.Windows.Forms.Button btnChangeSLAE;
        private System.Windows.Forms.ComboBox cmB_ListSLAEs;
        private System.Windows.Forms.Label lbl_CountEquations;
        private System.Windows.Forms.Label lbl_CountVariables;
        private System.Windows.Forms.GroupBox grB_SolvingSelectedSLAE;
        private System.Windows.Forms.Panel pnl_InfoAboutSolution;
        private System.Windows.Forms.ListBox ltB_InfoAboutSolution;
        private System.Windows.Forms.Label lblInfoAboutSolution;
        private System.Windows.Forms.Label lblСorrectnessOfIterMethods;
        private System.Windows.Forms.TextBox txB_СorrectnessOfIterMethods;
        private System.Windows.Forms.Button btnSolveSLAE;
        private System.Windows.Forms.GroupBox grB_MethodSolving;
        private System.Windows.Forms.RadioButton rdB_mSeidelMethod;
        private System.Windows.Forms.RadioButton rdB_mMethodOfSuccessiveIteration;
        private System.Windows.Forms.RadioButton rdB_mMethodOfGaussianElimination;
        private System.Windows.Forms.RadioButton rdB_mSquare_RootMethod;
        private System.Windows.Forms.RadioButton rdB_mThreediagonalMatrixAlgorithm;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.TextBox txB_NameNewSystem;
        private System.Windows.Forms.GroupBox grB_AutoFormatWidthColumns;
        private System.Windows.Forms.RadioButton rdB_Fill;
        private System.Windows.Forms.RadioButton rdB_AllCells;
    }
}

