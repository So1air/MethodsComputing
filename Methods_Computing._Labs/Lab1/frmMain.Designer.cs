namespace Lab1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series25 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series26 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series27 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series28 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series29 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series30 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chtGraph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cmB_ListFunc = new System.Windows.Forms.ComboBox();
            this.lblF = new System.Windows.Forms.Label();
            this.btnAddFunc = new System.Windows.Forms.Button();
            this.tbC_MethodsApproxZeroOfFunc = new System.Windows.Forms.TabControl();
            this.tbP_mHalfInterval = new System.Windows.Forms.TabPage();
            this.lbl_Result_mHalfInterval = new System.Windows.Forms.Label();
            this.btnCalc_mHalfInterval = new System.Windows.Forms.Button();
            this.dGV_mHalfInterval = new System.Windows.Forms.DataGridView();
            this.NumIter_mHalfInterval = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value_x_k_mHalfInterval = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estim_mHalfInterval = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbP_mFixedPointIteration = new System.Windows.Forms.TabPage();
            this.btnChangeIterForm = new System.Windows.Forms.Button();
            this.chB_drawIterForm = new System.Windows.Forms.CheckBox();
            this.txB_Inp_iterForm = new System.Windows.Forms.TextBox();
            this.lbl_Result_mFixedPointIteration = new System.Windows.Forms.Label();
            this.btnCalc_mFixedPointIteration = new System.Windows.Forms.Button();
            this.dGV_mFixedPointIteration = new System.Windows.Forms.DataGridView();
            this.lbl_IterForm = new System.Windows.Forms.Label();
            this.tbP_mChord = new System.Windows.Forms.TabPage();
            this.lbl_Result_mChord = new System.Windows.Forms.Label();
            this.btnCalc_mChord = new System.Windows.Forms.Button();
            this.dGV_mChord = new System.Windows.Forms.DataGridView();
            this.tbP_mNewton = new System.Windows.Forms.TabPage();
            this.lbl_Result_mNewton = new System.Windows.Forms.Label();
            this.btnCalc_mNewton = new System.Windows.Forms.Button();
            this.dGV_mNewton = new System.Windows.Forms.DataGridView();
            this.txB_InpA = new System.Windows.Forms.TextBox();
            this.txB_InpB = new System.Windows.Forms.TextBox();
            this.lblA = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.lblEps = new System.Windows.Forms.Label();
            this.txB_InpEps = new System.Windows.Forms.TextBox();
            this.txB_Inp_derF = new System.Windows.Forms.TextBox();
            this.txB_Inp_der2F = new System.Windows.Forms.TextBox();
            this.lbl_derF = new System.Windows.Forms.Label();
            this.lbl_der2F = new System.Windows.Forms.Label();
            this.txB_InpFunc = new System.Windows.Forms.TextBox();
            this.btnAcceptFunc = new System.Windows.Forms.Button();
            this.btnCancelInpFunc = new System.Windows.Forms.Button();
            this.chB_drawDerivFunc = new System.Windows.Forms.CheckBox();
            this.chB_drawDeriv2Func = new System.Windows.Forms.CheckBox();
            this.btnChangeDerFunc = new System.Windows.Forms.Button();
            this.btnChangeDer2Func = new System.Windows.Forms.Button();
            this.NumIter_mFixedPointIteration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value_x_k_mFixedPointIteration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estim_mFixedPointIteration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumIter_mChord = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value_x_k_mChord = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estim_mChord = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumIter_mNewton = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value_x_k_mNewton = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estim_mNewton = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.chtGraph)).BeginInit();
            this.tbC_MethodsApproxZeroOfFunc.SuspendLayout();
            this.tbP_mHalfInterval.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_mHalfInterval)).BeginInit();
            this.tbP_mFixedPointIteration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_mFixedPointIteration)).BeginInit();
            this.tbP_mChord.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_mChord)).BeginInit();
            this.tbP_mNewton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_mNewton)).BeginInit();
            this.SuspendLayout();
            // 
            // chtGraph
            // 
            this.chtGraph.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea5.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea5.AxisX.MajorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.AcrossAxis;
            chartArea5.AxisX.MinorGrid.Enabled = true;
            chartArea5.AxisX.MinorGrid.LineColor = System.Drawing.Color.DarkGray;
            chartArea5.AxisX.MinorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea5.AxisX.MinorTickMark.Enabled = true;
            chartArea5.AxisX.MinorTickMark.LineColor = System.Drawing.Color.DimGray;
            chartArea5.AxisX.MinorTickMark.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDot;
            chartArea5.AxisX.MinorTickMark.Size = 0.5F;
            chartArea5.AxisX.MinorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.AcrossAxis;
            chartArea5.AxisX.ScaleView.SmallScrollMinSize = 1E-05D;
            chartArea5.AxisX.ScrollBar.Size = 10D;
            chartArea5.AxisX.Title = "x";
            chartArea5.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea5.AxisY.MajorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.AcrossAxis;
            chartArea5.AxisY.MinorGrid.Enabled = true;
            chartArea5.AxisY.MinorGrid.LineColor = System.Drawing.Color.DarkGray;
            chartArea5.AxisY.MinorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea5.AxisY.MinorTickMark.Enabled = true;
            chartArea5.AxisY.MinorTickMark.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea5.AxisY.MinorTickMark.Size = 0.5F;
            chartArea5.AxisY.MinorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.AcrossAxis;
            chartArea5.AxisY.ScaleView.SmallScrollMinSize = 1E-05D;
            chartArea5.AxisY.ScrollBar.Size = 10D;
            chartArea5.AxisY.Title = "f(x)";
            chartArea5.BackColor = System.Drawing.Color.White;
            chartArea5.CursorX.Interval = 0.0001D;
            chartArea5.CursorX.IsUserSelectionEnabled = true;
            chartArea5.CursorY.Interval = 0.0001D;
            chartArea5.CursorY.IsUserSelectionEnabled = true;
            chartArea5.Name = "ChartArea1";
            this.chtGraph.ChartAreas.Add(chartArea5);
            legend5.BorderColor = System.Drawing.Color.Transparent;
            legend5.BorderWidth = 0;
            legend5.DockedToChartArea = "ChartArea1";
            legend5.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend5.IsDockedInsideChartArea = false;
            legend5.MaximumAutoSize = 25F;
            legend5.Name = "lgnFunctions";
            this.chtGraph.Legends.Add(legend5);
            this.chtGraph.Location = new System.Drawing.Point(511, 0);
            this.chtGraph.Name = "chtGraph";
            series25.BorderWidth = 2;
            series25.ChartArea = "ChartArea1";
            series25.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series25.Legend = "lgnFunctions";
            series25.LegendText = "функція";
            series25.Name = "srsGraphFunc";
            series26.ChartArea = "ChartArea1";
            series26.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series26.Color = System.Drawing.Color.GreenYellow;
            series26.Enabled = false;
            series26.Legend = "lgnFunctions";
            series26.LegendText = "перша похідна";
            series26.Name = "srs_derivFunc";
            series27.ChartArea = "ChartArea1";
            series27.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series27.Color = System.Drawing.Color.Red;
            series27.Enabled = false;
            series27.Legend = "lgnFunctions";
            series27.LegendText = "друга похідна";
            series27.Name = "srs_deriv2Func";
            series28.ChartArea = "ChartArea1";
            series28.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series28.Color = System.Drawing.Color.Gold;
            series28.Enabled = false;
            series28.Legend = "lgnFunctions";
            series28.LegendText = "ітераційна форма";
            series28.Name = "srs_iterForm";
            series29.ChartArea = "ChartArea1";
            series29.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series29.Color = System.Drawing.Color.Black;
            series29.IsVisibleInLegend = false;
            series29.Legend = "lgnFunctions";
            series29.Name = "srs_Ox";
            series30.ChartArea = "ChartArea1";
            series30.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series30.Color = System.Drawing.Color.Black;
            series30.IsVisibleInLegend = false;
            series30.Legend = "lgnFunctions";
            series30.Name = "srs_Oy";
            this.chtGraph.Series.Add(series25);
            this.chtGraph.Series.Add(series26);
            this.chtGraph.Series.Add(series27);
            this.chtGraph.Series.Add(series28);
            this.chtGraph.Series.Add(series29);
            this.chtGraph.Series.Add(series30);
            this.chtGraph.Size = new System.Drawing.Size(544, 529);
            this.chtGraph.TabIndex = 0;
            // 
            // cmB_ListFunc
            // 
            this.cmB_ListFunc.BackColor = System.Drawing.Color.White;
            this.cmB_ListFunc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmB_ListFunc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmB_ListFunc.FormattingEnabled = true;
            this.cmB_ListFunc.Items.AddRange(new object[] {
            "Math.Pow(x, 3) + 3 * x + 1",
            "Math.Pow(2, x) + x * x - 2"});
            this.cmB_ListFunc.Location = new System.Drawing.Point(53, 19);
            this.cmB_ListFunc.Name = "cmB_ListFunc";
            this.cmB_ListFunc.Size = new System.Drawing.Size(282, 21);
            this.cmB_ListFunc.TabIndex = 1;
            this.cmB_ListFunc.SelectedIndexChanged += new System.EventHandler(this.cmB_ListFunc_SelectedIndexChanged);
            this.cmB_ListFunc.Leave += new System.EventHandler(this.cmB_ListFunc_Leave);
            // 
            // lblF
            // 
            this.lblF.AutoSize = true;
            this.lblF.Font = new System.Drawing.Font("Gabriola", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblF.Location = new System.Drawing.Point(9, 11);
            this.lblF.Name = "lblF";
            this.lblF.Size = new System.Drawing.Size(43, 35);
            this.lblF.TabIndex = 2;
            this.lblF.Text = "f(x)=";
            // 
            // btnAddFunc
            // 
            this.btnAddFunc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnAddFunc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddFunc.Location = new System.Drawing.Point(341, 17);
            this.btnAddFunc.Name = "btnAddFunc";
            this.btnAddFunc.Size = new System.Drawing.Size(142, 23);
            this.btnAddFunc.TabIndex = 3;
            this.btnAddFunc.Text = "Додати нову функцію";
            this.btnAddFunc.UseVisualStyleBackColor = false;
            this.btnAddFunc.Click += new System.EventHandler(this.btnAddFunc_Click);
            // 
            // tbC_MethodsApproxZeroOfFunc
            // 
            this.tbC_MethodsApproxZeroOfFunc.Controls.Add(this.tbP_mHalfInterval);
            this.tbC_MethodsApproxZeroOfFunc.Controls.Add(this.tbP_mFixedPointIteration);
            this.tbC_MethodsApproxZeroOfFunc.Controls.Add(this.tbP_mChord);
            this.tbC_MethodsApproxZeroOfFunc.Controls.Add(this.tbP_mNewton);
            this.tbC_MethodsApproxZeroOfFunc.Location = new System.Drawing.Point(15, 171);
            this.tbC_MethodsApproxZeroOfFunc.Name = "tbC_MethodsApproxZeroOfFunc";
            this.tbC_MethodsApproxZeroOfFunc.SelectedIndex = 0;
            this.tbC_MethodsApproxZeroOfFunc.Size = new System.Drawing.Size(468, 346);
            this.tbC_MethodsApproxZeroOfFunc.TabIndex = 4;
            // 
            // tbP_mHalfInterval
            // 
            this.tbP_mHalfInterval.Controls.Add(this.lbl_Result_mHalfInterval);
            this.tbP_mHalfInterval.Controls.Add(this.btnCalc_mHalfInterval);
            this.tbP_mHalfInterval.Controls.Add(this.dGV_mHalfInterval);
            this.tbP_mHalfInterval.Location = new System.Drawing.Point(4, 22);
            this.tbP_mHalfInterval.Name = "tbP_mHalfInterval";
            this.tbP_mHalfInterval.Padding = new System.Windows.Forms.Padding(3);
            this.tbP_mHalfInterval.Size = new System.Drawing.Size(460, 320);
            this.tbP_mHalfInterval.TabIndex = 0;
            this.tbP_mHalfInterval.Text = "Метод дихотомії";
            this.tbP_mHalfInterval.UseVisualStyleBackColor = true;
            // 
            // lbl_Result_mHalfInterval
            // 
            this.lbl_Result_mHalfInterval.AutoSize = true;
            this.lbl_Result_mHalfInterval.Location = new System.Drawing.Point(6, 268);
            this.lbl_Result_mHalfInterval.Name = "lbl_Result_mHalfInterval";
            this.lbl_Result_mHalfInterval.Size = new System.Drawing.Size(37, 13);
            this.lbl_Result_mHalfInterval.TabIndex = 2;
            this.lbl_Result_mHalfInterval.Text = "Result";
            // 
            // btnCalc_mHalfInterval
            // 
            this.btnCalc_mHalfInterval.Location = new System.Drawing.Point(285, 291);
            this.btnCalc_mHalfInterval.Name = "btnCalc_mHalfInterval";
            this.btnCalc_mHalfInterval.Size = new System.Drawing.Size(169, 23);
            this.btnCalc_mHalfInterval.TabIndex = 1;
            this.btnCalc_mHalfInterval.Text = "Знайти корінь";
            this.btnCalc_mHalfInterval.UseVisualStyleBackColor = true;
            this.btnCalc_mHalfInterval.Click += new System.EventHandler(this.btnCalc_mHalfInterval_Click);
            // 
            // dGV_mHalfInterval
            // 
            this.dGV_mHalfInterval.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_mHalfInterval.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumIter_mHalfInterval,
            this.Value_x_k_mHalfInterval,
            this.Estim_mHalfInterval});
            this.dGV_mHalfInterval.Location = new System.Drawing.Point(6, 55);
            this.dGV_mHalfInterval.Name = "dGV_mHalfInterval";
            this.dGV_mHalfInterval.RowHeadersVisible = false;
            this.dGV_mHalfInterval.Size = new System.Drawing.Size(448, 210);
            this.dGV_mHalfInterval.TabIndex = 0;
            // 
            // NumIter_mHalfInterval
            // 
            this.NumIter_mHalfInterval.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NumIter_mHalfInterval.FillWeight = 50F;
            this.NumIter_mHalfInterval.HeaderText = "Номер ітерації";
            this.NumIter_mHalfInterval.Name = "NumIter_mHalfInterval";
            // 
            // Value_x_k_mHalfInterval
            // 
            this.Value_x_k_mHalfInterval.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Value_x_k_mHalfInterval.FillWeight = 150F;
            this.Value_x_k_mHalfInterval.HeaderText = "Наближення";
            this.Value_x_k_mHalfInterval.Name = "Value_x_k_mHalfInterval";
            // 
            // Estim_mHalfInterval
            // 
            this.Estim_mHalfInterval.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Estim_mHalfInterval.FillWeight = 125F;
            this.Estim_mHalfInterval.HeaderText = "Оцінка похибки";
            this.Estim_mHalfInterval.Name = "Estim_mHalfInterval";
            // 
            // tbP_mFixedPointIteration
            // 
            this.tbP_mFixedPointIteration.Controls.Add(this.btnChangeIterForm);
            this.tbP_mFixedPointIteration.Controls.Add(this.chB_drawIterForm);
            this.tbP_mFixedPointIteration.Controls.Add(this.txB_Inp_iterForm);
            this.tbP_mFixedPointIteration.Controls.Add(this.lbl_Result_mFixedPointIteration);
            this.tbP_mFixedPointIteration.Controls.Add(this.btnCalc_mFixedPointIteration);
            this.tbP_mFixedPointIteration.Controls.Add(this.dGV_mFixedPointIteration);
            this.tbP_mFixedPointIteration.Controls.Add(this.lbl_IterForm);
            this.tbP_mFixedPointIteration.Location = new System.Drawing.Point(4, 22);
            this.tbP_mFixedPointIteration.Name = "tbP_mFixedPointIteration";
            this.tbP_mFixedPointIteration.Padding = new System.Windows.Forms.Padding(3);
            this.tbP_mFixedPointIteration.Size = new System.Drawing.Size(460, 320);
            this.tbP_mFixedPointIteration.TabIndex = 1;
            this.tbP_mFixedPointIteration.Text = "Метод простої ітерації";
            this.tbP_mFixedPointIteration.UseVisualStyleBackColor = true;
            // 
            // btnChangeIterForm
            // 
            this.btnChangeIterForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChangeIterForm.AutoSize = true;
            this.btnChangeIterForm.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnChangeIterForm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChangeIterForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnChangeIterForm.Location = new System.Drawing.Point(391, 19);
            this.btnChangeIterForm.Name = "btnChangeIterForm";
            this.btnChangeIterForm.Size = new System.Drawing.Size(23, 17);
            this.btnChangeIterForm.TabIndex = 22;
            this.btnChangeIterForm.Text = "...";
            this.btnChangeIterForm.UseVisualStyleBackColor = true;
            this.btnChangeIterForm.Click += new System.EventHandler(this.btnChangeIterForm_Click);
            // 
            // chB_drawIterForm
            // 
            this.chB_drawIterForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chB_drawIterForm.AutoSize = true;
            this.chB_drawIterForm.BackColor = System.Drawing.Color.Gold;
            this.chB_drawIterForm.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chB_drawIterForm.Location = new System.Drawing.Point(422, 19);
            this.chB_drawIterForm.Name = "chB_drawIterForm";
            this.chB_drawIterForm.Size = new System.Drawing.Size(15, 14);
            this.chB_drawIterForm.TabIndex = 21;
            this.chB_drawIterForm.UseVisualStyleBackColor = false;
            this.chB_drawIterForm.CheckedChanged += new System.EventHandler(this.chB_drawIterForm_CheckedChanged);
            // 
            // txB_Inp_iterForm
            // 
            this.txB_Inp_iterForm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txB_Inp_iterForm.Location = new System.Drawing.Point(67, 17);
            this.txB_Inp_iterForm.Name = "txB_Inp_iterForm";
            this.txB_Inp_iterForm.ReadOnly = true;
            this.txB_Inp_iterForm.Size = new System.Drawing.Size(349, 20);
            this.txB_Inp_iterForm.TabIndex = 20;
            this.txB_Inp_iterForm.Leave += new System.EventHandler(this.txB_InpIterForm_Leave);
            // 
            // lbl_Result_mFixedPointIteration
            // 
            this.lbl_Result_mFixedPointIteration.AutoSize = true;
            this.lbl_Result_mFixedPointIteration.Location = new System.Drawing.Point(6, 268);
            this.lbl_Result_mFixedPointIteration.Name = "lbl_Result_mFixedPointIteration";
            this.lbl_Result_mFixedPointIteration.Size = new System.Drawing.Size(37, 13);
            this.lbl_Result_mFixedPointIteration.TabIndex = 7;
            this.lbl_Result_mFixedPointIteration.Text = "Result";
            // 
            // btnCalc_mFixedPointIteration
            // 
            this.btnCalc_mFixedPointIteration.Location = new System.Drawing.Point(285, 291);
            this.btnCalc_mFixedPointIteration.Name = "btnCalc_mFixedPointIteration";
            this.btnCalc_mFixedPointIteration.Size = new System.Drawing.Size(169, 23);
            this.btnCalc_mFixedPointIteration.TabIndex = 6;
            this.btnCalc_mFixedPointIteration.Text = "Знайти корінь";
            this.btnCalc_mFixedPointIteration.UseVisualStyleBackColor = true;
            this.btnCalc_mFixedPointIteration.Click += new System.EventHandler(this.btnCalc_mFixedPointIteration_Click);
            // 
            // dGV_mFixedPointIteration
            // 
            this.dGV_mFixedPointIteration.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_mFixedPointIteration.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumIter_mFixedPointIteration,
            this.Value_x_k_mFixedPointIteration,
            this.Estim_mFixedPointIteration});
            this.dGV_mFixedPointIteration.Location = new System.Drawing.Point(6, 55);
            this.dGV_mFixedPointIteration.Name = "dGV_mFixedPointIteration";
            this.dGV_mFixedPointIteration.RowHeadersVisible = false;
            this.dGV_mFixedPointIteration.Size = new System.Drawing.Size(448, 210);
            this.dGV_mFixedPointIteration.TabIndex = 5;
            // 
            // lbl_IterForm
            // 
            this.lbl_IterForm.AutoSize = true;
            this.lbl_IterForm.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_IterForm.Location = new System.Drawing.Point(6, 15);
            this.lbl_IterForm.Name = "lbl_IterForm";
            this.lbl_IterForm.Size = new System.Drawing.Size(55, 22);
            this.lbl_IterForm.TabIndex = 2;
            this.lbl_IterForm.Text = "φ (x) =";
            // 
            // tbP_mChord
            // 
            this.tbP_mChord.Controls.Add(this.lbl_Result_mChord);
            this.tbP_mChord.Controls.Add(this.btnCalc_mChord);
            this.tbP_mChord.Controls.Add(this.dGV_mChord);
            this.tbP_mChord.Location = new System.Drawing.Point(4, 22);
            this.tbP_mChord.Name = "tbP_mChord";
            this.tbP_mChord.Padding = new System.Windows.Forms.Padding(3);
            this.tbP_mChord.Size = new System.Drawing.Size(460, 320);
            this.tbP_mChord.TabIndex = 2;
            this.tbP_mChord.Text = "Метод хорд";
            this.tbP_mChord.UseVisualStyleBackColor = true;
            // 
            // lbl_Result_mChord
            // 
            this.lbl_Result_mChord.AutoSize = true;
            this.lbl_Result_mChord.Location = new System.Drawing.Point(6, 268);
            this.lbl_Result_mChord.Name = "lbl_Result_mChord";
            this.lbl_Result_mChord.Size = new System.Drawing.Size(37, 13);
            this.lbl_Result_mChord.TabIndex = 5;
            this.lbl_Result_mChord.Text = "Result";
            // 
            // btnCalc_mChord
            // 
            this.btnCalc_mChord.Location = new System.Drawing.Point(285, 291);
            this.btnCalc_mChord.Name = "btnCalc_mChord";
            this.btnCalc_mChord.Size = new System.Drawing.Size(169, 23);
            this.btnCalc_mChord.TabIndex = 4;
            this.btnCalc_mChord.Text = "Знайти корінь";
            this.btnCalc_mChord.UseVisualStyleBackColor = true;
            this.btnCalc_mChord.Click += new System.EventHandler(this.btnCalc_mChord_Click);
            // 
            // dGV_mChord
            // 
            this.dGV_mChord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_mChord.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumIter_mChord,
            this.Value_x_k_mChord,
            this.Estim_mChord});
            this.dGV_mChord.Location = new System.Drawing.Point(6, 55);
            this.dGV_mChord.Name = "dGV_mChord";
            this.dGV_mChord.RowHeadersVisible = false;
            this.dGV_mChord.Size = new System.Drawing.Size(448, 210);
            this.dGV_mChord.TabIndex = 3;
            // 
            // tbP_mNewton
            // 
            this.tbP_mNewton.Controls.Add(this.lbl_Result_mNewton);
            this.tbP_mNewton.Controls.Add(this.btnCalc_mNewton);
            this.tbP_mNewton.Controls.Add(this.dGV_mNewton);
            this.tbP_mNewton.Location = new System.Drawing.Point(4, 22);
            this.tbP_mNewton.Name = "tbP_mNewton";
            this.tbP_mNewton.Padding = new System.Windows.Forms.Padding(3);
            this.tbP_mNewton.Size = new System.Drawing.Size(460, 320);
            this.tbP_mNewton.TabIndex = 3;
            this.tbP_mNewton.Text = "Метод Ньютона";
            this.tbP_mNewton.UseVisualStyleBackColor = true;
            // 
            // lbl_Result_mNewton
            // 
            this.lbl_Result_mNewton.AutoSize = true;
            this.lbl_Result_mNewton.Location = new System.Drawing.Point(6, 268);
            this.lbl_Result_mNewton.Name = "lbl_Result_mNewton";
            this.lbl_Result_mNewton.Size = new System.Drawing.Size(37, 13);
            this.lbl_Result_mNewton.TabIndex = 3;
            this.lbl_Result_mNewton.Text = "Result";
            // 
            // btnCalc_mNewton
            // 
            this.btnCalc_mNewton.Location = new System.Drawing.Point(285, 291);
            this.btnCalc_mNewton.Name = "btnCalc_mNewton";
            this.btnCalc_mNewton.Size = new System.Drawing.Size(169, 23);
            this.btnCalc_mNewton.TabIndex = 2;
            this.btnCalc_mNewton.Text = "Знайти корінь";
            this.btnCalc_mNewton.UseVisualStyleBackColor = true;
            this.btnCalc_mNewton.Click += new System.EventHandler(this.btnCalc_mNewton_Click);
            // 
            // dGV_mNewton
            // 
            this.dGV_mNewton.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_mNewton.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumIter_mNewton,
            this.Value_x_k_mNewton,
            this.Estim_mNewton});
            this.dGV_mNewton.Location = new System.Drawing.Point(6, 55);
            this.dGV_mNewton.Name = "dGV_mNewton";
            this.dGV_mNewton.RowHeadersVisible = false;
            this.dGV_mNewton.Size = new System.Drawing.Size(448, 210);
            this.dGV_mNewton.TabIndex = 1;
            // 
            // txB_InpA
            // 
            this.txB_InpA.Location = new System.Drawing.Point(74, 57);
            this.txB_InpA.Name = "txB_InpA";
            this.txB_InpA.Size = new System.Drawing.Size(100, 20);
            this.txB_InpA.TabIndex = 5;
            this.txB_InpA.Leave += new System.EventHandler(this.txB_InpA_Leave);
            // 
            // txB_InpB
            // 
            this.txB_InpB.Location = new System.Drawing.Point(235, 57);
            this.txB_InpB.Name = "txB_InpB";
            this.txB_InpB.Size = new System.Drawing.Size(100, 20);
            this.txB_InpB.TabIndex = 6;
            this.txB_InpB.Leave += new System.EventHandler(this.txB_InpB_Leave);
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(43, 60);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(25, 13);
            this.lblA.TabIndex = 7;
            this.lblA.Text = "a = ";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(204, 60);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(25, 13);
            this.lblB.TabIndex = 8;
            this.lblB.Text = "b = ";
            // 
            // lblEps
            // 
            this.lblEps.AutoSize = true;
            this.lblEps.Location = new System.Drawing.Point(156, 86);
            this.lblEps.Name = "lblEps";
            this.lblEps.Size = new System.Drawing.Size(33, 13);
            this.lblEps.TabIndex = 9;
            this.lblEps.Text = "eps =";
            // 
            // txB_InpEps
            // 
            this.txB_InpEps.Location = new System.Drawing.Point(197, 83);
            this.txB_InpEps.Name = "txB_InpEps";
            this.txB_InpEps.Size = new System.Drawing.Size(100, 20);
            this.txB_InpEps.TabIndex = 10;
            this.txB_InpEps.Leave += new System.EventHandler(this.txB_InpEps_Leave);
            // 
            // txB_Inp_derF
            // 
            this.txB_Inp_derF.Location = new System.Drawing.Point(53, 109);
            this.txB_Inp_derF.Name = "txB_Inp_derF";
            this.txB_Inp_derF.ReadOnly = true;
            this.txB_Inp_derF.Size = new System.Drawing.Size(282, 20);
            this.txB_Inp_derF.TabIndex = 11;
            this.txB_Inp_derF.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txB_Inp_derF_KeyDown);
            this.txB_Inp_derF.Leave += new System.EventHandler(this.txB_Inp_derF_Leave);
            // 
            // txB_Inp_der2F
            // 
            this.txB_Inp_der2F.Location = new System.Drawing.Point(53, 135);
            this.txB_Inp_der2F.Name = "txB_Inp_der2F";
            this.txB_Inp_der2F.ReadOnly = true;
            this.txB_Inp_der2F.Size = new System.Drawing.Size(282, 20);
            this.txB_Inp_der2F.TabIndex = 12;
            this.txB_Inp_der2F.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txB_Inp_der2F_KeyDown);
            this.txB_Inp_der2F.Leave += new System.EventHandler(this.txB_Inp_der2F_Leave);
            // 
            // lbl_derF
            // 
            this.lbl_derF.AutoSize = true;
            this.lbl_derF.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_derF.Location = new System.Drawing.Point(5, 107);
            this.lbl_derF.Name = "lbl_derF";
            this.lbl_derF.Size = new System.Drawing.Size(52, 22);
            this.lbl_derF.TabIndex = 13;
            this.lbl_derF.Text = "f\' (x) =";
            // 
            // lbl_der2F
            // 
            this.lbl_der2F.AutoSize = true;
            this.lbl_der2F.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_der2F.Location = new System.Drawing.Point(-2, 133);
            this.lbl_der2F.Name = "lbl_der2F";
            this.lbl_der2F.Size = new System.Drawing.Size(59, 22);
            this.lbl_der2F.TabIndex = 0;
            this.lbl_der2F.Text = "f \'\' (x) =";
            // 
            // txB_InpFunc
            // 
            this.txB_InpFunc.Location = new System.Drawing.Point(53, 19);
            this.txB_InpFunc.Name = "txB_InpFunc";
            this.txB_InpFunc.Size = new System.Drawing.Size(282, 20);
            this.txB_InpFunc.TabIndex = 14;
            this.txB_InpFunc.Visible = false;
            // 
            // btnAcceptFunc
            // 
            this.btnAcceptFunc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAcceptFunc.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAcceptFunc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAcceptFunc.Location = new System.Drawing.Point(341, 5);
            this.btnAcceptFunc.Name = "btnAcceptFunc";
            this.btnAcceptFunc.Size = new System.Drawing.Size(142, 23);
            this.btnAcceptFunc.TabIndex = 15;
            this.btnAcceptFunc.Text = "Підтвердити";
            this.btnAcceptFunc.UseVisualStyleBackColor = false;
            this.btnAcceptFunc.Visible = false;
            this.btnAcceptFunc.Click += new System.EventHandler(this.btnAcceptFunc_Click);
            // 
            // btnCancelInpFunc
            // 
            this.btnCancelInpFunc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCancelInpFunc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelInpFunc.Location = new System.Drawing.Point(341, 34);
            this.btnCancelInpFunc.Name = "btnCancelInpFunc";
            this.btnCancelInpFunc.Size = new System.Drawing.Size(142, 24);
            this.btnCancelInpFunc.TabIndex = 16;
            this.btnCancelInpFunc.Text = "Скасувати";
            this.btnCancelInpFunc.UseVisualStyleBackColor = false;
            this.btnCancelInpFunc.Visible = false;
            this.btnCancelInpFunc.Click += new System.EventHandler(this.btnCancelInpFunc_Click);
            // 
            // chB_drawDerivFunc
            // 
            this.chB_drawDerivFunc.AutoSize = true;
            this.chB_drawDerivFunc.BackColor = System.Drawing.Color.GreenYellow;
            this.chB_drawDerivFunc.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chB_drawDerivFunc.Location = new System.Drawing.Point(341, 111);
            this.chB_drawDerivFunc.Name = "chB_drawDerivFunc";
            this.chB_drawDerivFunc.Size = new System.Drawing.Size(15, 14);
            this.chB_drawDerivFunc.TabIndex = 17;
            this.chB_drawDerivFunc.UseVisualStyleBackColor = false;
            this.chB_drawDerivFunc.CheckedChanged += new System.EventHandler(this.chB_drawDerivFunc_CheckedChanged);
            // 
            // chB_drawDeriv2Func
            // 
            this.chB_drawDeriv2Func.AutoSize = true;
            this.chB_drawDeriv2Func.BackColor = System.Drawing.Color.Red;
            this.chB_drawDeriv2Func.Location = new System.Drawing.Point(341, 137);
            this.chB_drawDeriv2Func.Name = "chB_drawDeriv2Func";
            this.chB_drawDeriv2Func.Size = new System.Drawing.Size(15, 14);
            this.chB_drawDeriv2Func.TabIndex = 18;
            this.chB_drawDeriv2Func.UseVisualStyleBackColor = false;
            this.chB_drawDeriv2Func.CheckedChanged += new System.EventHandler(this.chB_drawDeriv2Func_CheckedChanged);
            // 
            // btnChangeDerFunc
            // 
            this.btnChangeDerFunc.AutoSize = true;
            this.btnChangeDerFunc.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnChangeDerFunc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChangeDerFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnChangeDerFunc.Location = new System.Drawing.Point(310, 111);
            this.btnChangeDerFunc.Name = "btnChangeDerFunc";
            this.btnChangeDerFunc.Size = new System.Drawing.Size(23, 17);
            this.btnChangeDerFunc.TabIndex = 19;
            this.btnChangeDerFunc.Text = "...";
            this.btnChangeDerFunc.UseVisualStyleBackColor = true;
            this.btnChangeDerFunc.Click += new System.EventHandler(this.btnChangeDerFunc_Click);
            // 
            // btnChangeDer2Func
            // 
            this.btnChangeDer2Func.AutoSize = true;
            this.btnChangeDer2Func.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnChangeDer2Func.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChangeDer2Func.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnChangeDer2Func.Location = new System.Drawing.Point(310, 137);
            this.btnChangeDer2Func.Name = "btnChangeDer2Func";
            this.btnChangeDer2Func.Size = new System.Drawing.Size(23, 17);
            this.btnChangeDer2Func.TabIndex = 20;
            this.btnChangeDer2Func.Text = "...";
            this.btnChangeDer2Func.UseVisualStyleBackColor = true;
            this.btnChangeDer2Func.Click += new System.EventHandler(this.btnChangeDer2Func_Click);
            // 
            // NumIter_mFixedPointIteration
            // 
            this.NumIter_mFixedPointIteration.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NumIter_mFixedPointIteration.FillWeight = 50F;
            this.NumIter_mFixedPointIteration.HeaderText = "Номер ітерації";
            this.NumIter_mFixedPointIteration.Name = "NumIter_mFixedPointIteration";
            // 
            // Value_x_k_mFixedPointIteration
            // 
            this.Value_x_k_mFixedPointIteration.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Value_x_k_mFixedPointIteration.FillWeight = 150F;
            this.Value_x_k_mFixedPointIteration.HeaderText = "Наближення";
            this.Value_x_k_mFixedPointIteration.Name = "Value_x_k_mFixedPointIteration";
            // 
            // Estim_mFixedPointIteration
            // 
            this.Estim_mFixedPointIteration.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Estim_mFixedPointIteration.FillWeight = 125F;
            this.Estim_mFixedPointIteration.HeaderText = "Оцінка похибки";
            this.Estim_mFixedPointIteration.Name = "Estim_mFixedPointIteration";
            // 
            // NumIter_mChord
            // 
            this.NumIter_mChord.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NumIter_mChord.FillWeight = 50F;
            this.NumIter_mChord.HeaderText = "Номер ітерації";
            this.NumIter_mChord.Name = "NumIter_mChord";
            // 
            // Value_x_k_mChord
            // 
            this.Value_x_k_mChord.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Value_x_k_mChord.FillWeight = 150F;
            this.Value_x_k_mChord.HeaderText = "Наближення";
            this.Value_x_k_mChord.Name = "Value_x_k_mChord";
            // 
            // Estim_mChord
            // 
            this.Estim_mChord.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Estim_mChord.FillWeight = 125F;
            this.Estim_mChord.HeaderText = "Оцінка похибки";
            this.Estim_mChord.Name = "Estim_mChord";
            // 
            // NumIter_mNewton
            // 
            this.NumIter_mNewton.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NumIter_mNewton.FillWeight = 50F;
            this.NumIter_mNewton.HeaderText = "Номер ітерації";
            this.NumIter_mNewton.Name = "NumIter_mNewton";
            // 
            // Value_x_k_mNewton
            // 
            this.Value_x_k_mNewton.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Value_x_k_mNewton.FillWeight = 150F;
            this.Value_x_k_mNewton.HeaderText = "Наближення";
            this.Value_x_k_mNewton.Name = "Value_x_k_mNewton";
            // 
            // Estim_mNewton
            // 
            this.Estim_mNewton.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Estim_mNewton.FillWeight = 125F;
            this.Estim_mNewton.HeaderText = "Оцінка похибки";
            this.Estim_mNewton.Name = "Estim_mNewton";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 529);
            this.Controls.Add(this.btnChangeDer2Func);
            this.Controls.Add(this.btnChangeDerFunc);
            this.Controls.Add(this.chB_drawDeriv2Func);
            this.Controls.Add(this.chB_drawDerivFunc);
            this.Controls.Add(this.btnCancelInpFunc);
            this.Controls.Add(this.btnAcceptFunc);
            this.Controls.Add(this.txB_Inp_der2F);
            this.Controls.Add(this.txB_Inp_derF);
            this.Controls.Add(this.txB_InpEps);
            this.Controls.Add(this.lblEps);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.txB_InpB);
            this.Controls.Add(this.txB_InpA);
            this.Controls.Add(this.tbC_MethodsApproxZeroOfFunc);
            this.Controls.Add(this.btnAddFunc);
            this.Controls.Add(this.lblF);
            this.Controls.Add(this.chtGraph);
            this.Controls.Add(this.txB_InpFunc);
            this.Controls.Add(this.cmB_ListFunc);
            this.Controls.Add(this.lbl_derF);
            this.Controls.Add(this.lbl_der2F);
            this.Name = "frmMain";
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.chtGraph)).EndInit();
            this.tbC_MethodsApproxZeroOfFunc.ResumeLayout(false);
            this.tbP_mHalfInterval.ResumeLayout(false);
            this.tbP_mHalfInterval.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_mHalfInterval)).EndInit();
            this.tbP_mFixedPointIteration.ResumeLayout(false);
            this.tbP_mFixedPointIteration.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_mFixedPointIteration)).EndInit();
            this.tbP_mChord.ResumeLayout(false);
            this.tbP_mChord.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_mChord)).EndInit();
            this.tbP_mNewton.ResumeLayout(false);
            this.tbP_mNewton.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_mNewton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chtGraph;
        private System.Windows.Forms.ComboBox cmB_ListFunc;
        private System.Windows.Forms.Label lblF;
        private System.Windows.Forms.Button btnAddFunc;
        private System.Windows.Forms.TabControl tbC_MethodsApproxZeroOfFunc;
        private System.Windows.Forms.TabPage tbP_mHalfInterval;
        private System.Windows.Forms.TabPage tbP_mFixedPointIteration;
        private System.Windows.Forms.TabPage tbP_mChord;
        private System.Windows.Forms.TabPage tbP_mNewton;
        private System.Windows.Forms.TextBox txB_InpA;
        private System.Windows.Forms.TextBox txB_InpB;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblEps;
        private System.Windows.Forms.TextBox txB_InpEps;
        private System.Windows.Forms.TextBox txB_Inp_derF;
        private System.Windows.Forms.TextBox txB_Inp_der2F;
        private System.Windows.Forms.Label lbl_derF;
        private System.Windows.Forms.Label lbl_der2F;
        private System.Windows.Forms.TextBox txB_InpFunc;
        private System.Windows.Forms.Button btnAcceptFunc;
        private System.Windows.Forms.Button btnCancelInpFunc;
        private System.Windows.Forms.Label lbl_Result_mHalfInterval;
        private System.Windows.Forms.Button btnCalc_mHalfInterval;
        private System.Windows.Forms.DataGridView dGV_mHalfInterval;
        private System.Windows.Forms.Label lbl_IterForm;
        private System.Windows.Forms.Button btnCalc_mFixedPointIteration;
        private System.Windows.Forms.DataGridView dGV_mFixedPointIteration;
        private System.Windows.Forms.Button btnCalc_mChord;
        private System.Windows.Forms.DataGridView dGV_mChord;
        private System.Windows.Forms.Button btnCalc_mNewton;
        private System.Windows.Forms.DataGridView dGV_mNewton;
        private System.Windows.Forms.Label lbl_Result_mFixedPointIteration;
        private System.Windows.Forms.Label lbl_Result_mChord;
        private System.Windows.Forms.Label lbl_Result_mNewton;
        private System.Windows.Forms.CheckBox chB_drawDerivFunc;
        private System.Windows.Forms.CheckBox chB_drawDeriv2Func;
        private System.Windows.Forms.Button btnChangeDerFunc;
        private System.Windows.Forms.Button btnChangeDer2Func;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumIter_mHalfInterval;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value_x_k_mHalfInterval;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estim_mHalfInterval;
        private System.Windows.Forms.Button btnChangeIterForm;
        private System.Windows.Forms.CheckBox chB_drawIterForm;
        private System.Windows.Forms.TextBox txB_Inp_iterForm;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumIter_mFixedPointIteration;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value_x_k_mFixedPointIteration;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estim_mFixedPointIteration;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumIter_mChord;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value_x_k_mChord;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estim_mChord;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumIter_mNewton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value_x_k_mNewton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estim_mNewton;
    }
}

