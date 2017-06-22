namespace Lab4
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lbl_LeftPartEquation = new System.Windows.Forms.Label();
            this.txB_A = new System.Windows.Forms.TextBox();
            this.cmB_RightPartEquation = new System.Windows.Forms.ComboBox();
            this.txB_y0 = new System.Windows.Forms.TextBox();
            this.txB_x0 = new System.Windows.Forms.TextBox();
            this.txB_B = new System.Windows.Forms.TextBox();
            this.lbl_y_ = new System.Windows.Forms.Label();
            this.lbl___ = new System.Windows.Forms.Label();
            this.grB_MethodsOfSolution = new System.Windows.Forms.GroupBox();
            this.chB_RungeKuttaGraph = new System.Windows.Forms.CheckBox();
            this.chB_AdamsGraph = new System.Windows.Forms.CheckBox();
            this.chB_EulerCauchyGraph = new System.Windows.Forms.CheckBox();
            this.chB_EulerWithCorrGraph = new System.Windows.Forms.CheckBox();
            this.chB_EulerGraph = new System.Windows.Forms.CheckBox();
            this.rdB_Adams = new System.Windows.Forms.RadioButton();
            this.rdB_RungeKutta = new System.Windows.Forms.RadioButton();
            this.rdB_EulerWithCorrection = new System.Windows.Forms.RadioButton();
            this.rdB_EulerCauchy = new System.Windows.Forms.RadioButton();
            this.rdB_Euler = new System.Windows.Forms.RadioButton();
            this.lblCountPartition = new System.Windows.Forms.Label();
            this.lblA = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.dGV_Results = new System.Windows.Forms.DataGridView();
            this.btnResolve = new System.Windows.Forms.Button();
            this.btnAddCauchyProblem = new System.Windows.Forms.Button();
            this.lbl_ExactSolution = new System.Windows.Forms.Label();
            this.txB_ExactSolution = new System.Windows.Forms.TextBox();
            this.btnEditExactSolution = new System.Windows.Forms.Button();
            this.chtGraph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.nUD_CountPartition = new System.Windows.Forms.NumericUpDown();
            this.lbl_Eps = new System.Windows.Forms.Label();
            this.txB_Eps = new System.Windows.Forms.TextBox();
            this.chB_AutoStep = new System.Windows.Forms.CheckBox();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.chB_ExactSolGraph = new System.Windows.Forms.CheckBox();
            this.clnX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnExactSol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnEuler = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnEulerCauchy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnEulerWithCorrection = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnRungeKutta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnAdams = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grB_MethodsOfSolution.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Results)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtGraph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_CountPartition)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_LeftPartEquation
            // 
            this.lbl_LeftPartEquation.AutoSize = true;
            this.lbl_LeftPartEquation.Font = new System.Drawing.Font("Buxton Sketch", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_LeftPartEquation.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_LeftPartEquation.Location = new System.Drawing.Point(11, 9);
            this.lbl_LeftPartEquation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_LeftPartEquation.Name = "lbl_LeftPartEquation";
            this.lbl_LeftPartEquation.Size = new System.Drawing.Size(133, 25);
            this.lbl_LeftPartEquation.TabIndex = 0;
            this.lbl_LeftPartEquation.Text = "y\'(x) = f (x, y) = ";
            // 
            // txB_A
            // 
            this.txB_A.BackColor = System.Drawing.Color.White;
            this.txB_A.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txB_A.Font = new System.Drawing.Font("Buxton Sketch", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txB_A.Location = new System.Drawing.Point(68, 83);
            this.txB_A.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txB_A.Name = "txB_A";
            this.txB_A.ReadOnly = true;
            this.txB_A.Size = new System.Drawing.Size(60, 25);
            this.txB_A.TabIndex = 1;
            this.txB_A.Text = "0";
            this.txB_A.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmB_RightPartEquation
            // 
            this.cmB_RightPartEquation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmB_RightPartEquation.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmB_RightPartEquation.Font = new System.Drawing.Font("Buxton Sketch", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmB_RightPartEquation.Location = new System.Drawing.Point(137, 4);
            this.cmB_RightPartEquation.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmB_RightPartEquation.Name = "cmB_RightPartEquation";
            this.cmB_RightPartEquation.Size = new System.Drawing.Size(287, 33);
            this.cmB_RightPartEquation.TabIndex = 2;
            this.cmB_RightPartEquation.SelectedIndexChanged += new System.EventHandler(this.cmB_RightPartEquation_SelectedIndexChanged);
            // 
            // txB_y0
            // 
            this.txB_y0.BackColor = System.Drawing.Color.White;
            this.txB_y0.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txB_y0.Font = new System.Drawing.Font("Buxton Sketch", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txB_y0.Location = new System.Drawing.Point(148, 46);
            this.txB_y0.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txB_y0.Name = "txB_y0";
            this.txB_y0.ReadOnly = true;
            this.txB_y0.Size = new System.Drawing.Size(63, 25);
            this.txB_y0.TabIndex = 4;
            this.txB_y0.Text = "0";
            this.txB_y0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txB_x0
            // 
            this.txB_x0.BackColor = System.Drawing.Color.White;
            this.txB_x0.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txB_x0.Font = new System.Drawing.Font("Buxton Sketch", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txB_x0.Location = new System.Drawing.Point(42, 46);
            this.txB_x0.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txB_x0.Name = "txB_x0";
            this.txB_x0.ReadOnly = true;
            this.txB_x0.Size = new System.Drawing.Size(60, 25);
            this.txB_x0.TabIndex = 5;
            this.txB_x0.Text = "0";
            this.txB_x0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txB_x0.TextChanged += new System.EventHandler(this.txB_x0_TextChanged);
            this.txB_x0.Validated += new System.EventHandler(this.txB_x0_Validated);
            // 
            // txB_B
            // 
            this.txB_B.BackColor = System.Drawing.Color.White;
            this.txB_B.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txB_B.Font = new System.Drawing.Font("Buxton Sketch", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txB_B.Location = new System.Drawing.Point(195, 84);
            this.txB_B.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txB_B.Name = "txB_B";
            this.txB_B.ReadOnly = true;
            this.txB_B.Size = new System.Drawing.Size(60, 25);
            this.txB_B.TabIndex = 6;
            this.txB_B.Text = "1";
            this.txB_B.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txB_B.Validated += new System.EventHandler(this.txB_B_Validated);
            // 
            // lbl_y_
            // 
            this.lbl_y_.AutoSize = true;
            this.lbl_y_.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_y_.Font = new System.Drawing.Font("Buxton Sketch", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_y_.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_y_.Location = new System.Drawing.Point(6, 46);
            this.lbl_y_.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_y_.Name = "lbl_y_";
            this.lbl_y_.Size = new System.Drawing.Size(32, 25);
            this.lbl_y_.TabIndex = 7;
            this.lbl_y_.Text = "y (";
            // 
            // lbl___
            // 
            this.lbl___.AutoSize = true;
            this.lbl___.Font = new System.Drawing.Font("Buxton Sketch", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl___.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl___.Location = new System.Drawing.Point(106, 46);
            this.lbl___.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl___.Name = "lbl___";
            this.lbl___.Size = new System.Drawing.Size(38, 25);
            this.lbl___.TabIndex = 8;
            this.lbl___.Text = ") = ";
            // 
            // grB_MethodsOfSolution
            // 
            this.grB_MethodsOfSolution.Controls.Add(this.chB_RungeKuttaGraph);
            this.grB_MethodsOfSolution.Controls.Add(this.chB_AdamsGraph);
            this.grB_MethodsOfSolution.Controls.Add(this.chB_EulerCauchyGraph);
            this.grB_MethodsOfSolution.Controls.Add(this.chB_EulerWithCorrGraph);
            this.grB_MethodsOfSolution.Controls.Add(this.chB_EulerGraph);
            this.grB_MethodsOfSolution.Controls.Add(this.rdB_Adams);
            this.grB_MethodsOfSolution.Controls.Add(this.rdB_RungeKutta);
            this.grB_MethodsOfSolution.Controls.Add(this.rdB_EulerWithCorrection);
            this.grB_MethodsOfSolution.Controls.Add(this.rdB_EulerCauchy);
            this.grB_MethodsOfSolution.Controls.Add(this.rdB_Euler);
            this.grB_MethodsOfSolution.Font = new System.Drawing.Font("Buxton Sketch", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.grB_MethodsOfSolution.ForeColor = System.Drawing.Color.MidnightBlue;
            this.grB_MethodsOfSolution.Location = new System.Drawing.Point(14, 115);
            this.grB_MethodsOfSolution.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.grB_MethodsOfSolution.Name = "grB_MethodsOfSolution";
            this.grB_MethodsOfSolution.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.grB_MethodsOfSolution.Size = new System.Drawing.Size(220, 140);
            this.grB_MethodsOfSolution.TabIndex = 13;
            this.grB_MethodsOfSolution.TabStop = false;
            this.grB_MethodsOfSolution.Text = "Методи розв\'язання";
            // 
            // chB_RungeKuttaGraph
            // 
            this.chB_RungeKuttaGraph.AutoSize = true;
            this.chB_RungeKuttaGraph.BackColor = System.Drawing.Color.Blue;
            this.chB_RungeKuttaGraph.Checked = true;
            this.chB_RungeKuttaGraph.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chB_RungeKuttaGraph.Location = new System.Drawing.Point(192, 93);
            this.chB_RungeKuttaGraph.Name = "chB_RungeKuttaGraph";
            this.chB_RungeKuttaGraph.Size = new System.Drawing.Size(15, 14);
            this.chB_RungeKuttaGraph.TabIndex = 9;
            this.chB_RungeKuttaGraph.UseVisualStyleBackColor = false;
            this.chB_RungeKuttaGraph.CheckedChanged += new System.EventHandler(this.chB_RungeKuttaGraph_CheckedChanged);
            // 
            // chB_AdamsGraph
            // 
            this.chB_AdamsGraph.AutoSize = true;
            this.chB_AdamsGraph.BackColor = System.Drawing.Color.Magenta;
            this.chB_AdamsGraph.Checked = true;
            this.chB_AdamsGraph.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chB_AdamsGraph.Location = new System.Drawing.Point(192, 116);
            this.chB_AdamsGraph.Name = "chB_AdamsGraph";
            this.chB_AdamsGraph.Size = new System.Drawing.Size(15, 14);
            this.chB_AdamsGraph.TabIndex = 8;
            this.chB_AdamsGraph.UseVisualStyleBackColor = false;
            this.chB_AdamsGraph.CheckedChanged += new System.EventHandler(this.chB_AdamsGraph_CheckedChanged);
            // 
            // chB_EulerCauchyGraph
            // 
            this.chB_EulerCauchyGraph.AutoSize = true;
            this.chB_EulerCauchyGraph.BackColor = System.Drawing.Color.Red;
            this.chB_EulerCauchyGraph.Checked = true;
            this.chB_EulerCauchyGraph.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chB_EulerCauchyGraph.Location = new System.Drawing.Point(192, 47);
            this.chB_EulerCauchyGraph.Name = "chB_EulerCauchyGraph";
            this.chB_EulerCauchyGraph.Size = new System.Drawing.Size(15, 14);
            this.chB_EulerCauchyGraph.TabIndex = 7;
            this.chB_EulerCauchyGraph.UseVisualStyleBackColor = false;
            this.chB_EulerCauchyGraph.CheckedChanged += new System.EventHandler(this.chB_EulerCauchyGraph_CheckedChanged);
            // 
            // chB_EulerWithCorrGraph
            // 
            this.chB_EulerWithCorrGraph.AutoSize = true;
            this.chB_EulerWithCorrGraph.BackColor = System.Drawing.Color.Gold;
            this.chB_EulerWithCorrGraph.Checked = true;
            this.chB_EulerWithCorrGraph.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chB_EulerWithCorrGraph.Location = new System.Drawing.Point(192, 70);
            this.chB_EulerWithCorrGraph.Name = "chB_EulerWithCorrGraph";
            this.chB_EulerWithCorrGraph.Size = new System.Drawing.Size(15, 14);
            this.chB_EulerWithCorrGraph.TabIndex = 6;
            this.chB_EulerWithCorrGraph.UseVisualStyleBackColor = false;
            this.chB_EulerWithCorrGraph.CheckedChanged += new System.EventHandler(this.chB_EulerWithCorrGraph_CheckedChanged);
            // 
            // chB_EulerGraph
            // 
            this.chB_EulerGraph.AutoSize = true;
            this.chB_EulerGraph.BackColor = System.Drawing.Color.GreenYellow;
            this.chB_EulerGraph.Checked = true;
            this.chB_EulerGraph.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chB_EulerGraph.Location = new System.Drawing.Point(192, 24);
            this.chB_EulerGraph.Name = "chB_EulerGraph";
            this.chB_EulerGraph.Size = new System.Drawing.Size(15, 14);
            this.chB_EulerGraph.TabIndex = 5;
            this.chB_EulerGraph.UseVisualStyleBackColor = false;
            this.chB_EulerGraph.CheckedChanged += new System.EventHandler(this.chB_EulerGraph_CheckedChanged);
            // 
            // rdB_Adams
            // 
            this.rdB_Adams.AutoSize = true;
            this.rdB_Adams.Font = new System.Drawing.Font("Buxton Sketch", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rdB_Adams.ForeColor = System.Drawing.Color.MidnightBlue;
            this.rdB_Adams.Location = new System.Drawing.Point(6, 111);
            this.rdB_Adams.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rdB_Adams.Name = "rdB_Adams";
            this.rdB_Adams.Size = new System.Drawing.Size(109, 24);
            this.rdB_Adams.TabIndex = 4;
            this.rdB_Adams.Text = "метод Адамса";
            this.rdB_Adams.UseVisualStyleBackColor = true;
            this.rdB_Adams.CheckedChanged += new System.EventHandler(this.rdB_Adams_CheckedChanged);
            // 
            // rdB_RungeKutta
            // 
            this.rdB_RungeKutta.AutoSize = true;
            this.rdB_RungeKutta.Font = new System.Drawing.Font("Buxton Sketch", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rdB_RungeKutta.ForeColor = System.Drawing.Color.MidnightBlue;
            this.rdB_RungeKutta.Location = new System.Drawing.Point(6, 88);
            this.rdB_RungeKutta.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rdB_RungeKutta.Name = "rdB_RungeKutta";
            this.rdB_RungeKutta.Size = new System.Drawing.Size(151, 24);
            this.rdB_RungeKutta.TabIndex = 3;
            this.rdB_RungeKutta.Text = "метод Рунге-Кутта";
            this.rdB_RungeKutta.UseVisualStyleBackColor = true;
            this.rdB_RungeKutta.CheckedChanged += new System.EventHandler(this.rdB_RungeKutta_CheckedChanged);
            // 
            // rdB_EulerWithCorrection
            // 
            this.rdB_EulerWithCorrection.AutoSize = true;
            this.rdB_EulerWithCorrection.Font = new System.Drawing.Font("Buxton Sketch", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rdB_EulerWithCorrection.ForeColor = System.Drawing.Color.MidnightBlue;
            this.rdB_EulerWithCorrection.Location = new System.Drawing.Point(6, 65);
            this.rdB_EulerWithCorrection.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rdB_EulerWithCorrection.Name = "rdB_EulerWithCorrection";
            this.rdB_EulerWithCorrection.Size = new System.Drawing.Size(195, 24);
            this.rdB_EulerWithCorrection.TabIndex = 2;
            this.rdB_EulerWithCorrection.Text = "метод Ейлера з уточненням";
            this.rdB_EulerWithCorrection.UseVisualStyleBackColor = true;
            this.rdB_EulerWithCorrection.CheckedChanged += new System.EventHandler(this.rdB_EulerWithCorrection_CheckedChanged);
            // 
            // rdB_EulerCauchy
            // 
            this.rdB_EulerCauchy.AutoSize = true;
            this.rdB_EulerCauchy.Font = new System.Drawing.Font("Buxton Sketch", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rdB_EulerCauchy.ForeColor = System.Drawing.Color.MidnightBlue;
            this.rdB_EulerCauchy.Location = new System.Drawing.Point(6, 42);
            this.rdB_EulerCauchy.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rdB_EulerCauchy.Name = "rdB_EulerCauchy";
            this.rdB_EulerCauchy.Size = new System.Drawing.Size(142, 24);
            this.rdB_EulerCauchy.TabIndex = 1;
            this.rdB_EulerCauchy.Text = "метод Ейлера-Коші";
            this.rdB_EulerCauchy.UseVisualStyleBackColor = true;
            this.rdB_EulerCauchy.CheckedChanged += new System.EventHandler(this.rdB_EulerCauchy_CheckedChanged);
            // 
            // rdB_Euler
            // 
            this.rdB_Euler.AutoSize = true;
            this.rdB_Euler.Checked = true;
            this.rdB_Euler.Font = new System.Drawing.Font("Buxton Sketch", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rdB_Euler.ForeColor = System.Drawing.Color.MidnightBlue;
            this.rdB_Euler.Location = new System.Drawing.Point(6, 19);
            this.rdB_Euler.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rdB_Euler.Name = "rdB_Euler";
            this.rdB_Euler.Size = new System.Drawing.Size(108, 24);
            this.rdB_Euler.TabIndex = 0;
            this.rdB_Euler.TabStop = true;
            this.rdB_Euler.Text = "метод Ейлера";
            this.rdB_Euler.UseVisualStyleBackColor = true;
            this.rdB_Euler.CheckedChanged += new System.EventHandler(this.rdB_Euler_CheckedChanged);
            // 
            // lblCountPartition
            // 
            this.lblCountPartition.AutoSize = true;
            this.lblCountPartition.Font = new System.Drawing.Font("Buxton Sketch", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCountPartition.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblCountPartition.Location = new System.Drawing.Point(267, 135);
            this.lblCountPartition.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCountPartition.Name = "lblCountPartition";
            this.lblCountPartition.Size = new System.Drawing.Size(33, 23);
            this.lblCountPartition.TabIndex = 10;
            this.lblCountPartition.Text = "N =";
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Font = new System.Drawing.Font("Buxton Sketch", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblA.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblA.Location = new System.Drawing.Point(31, 83);
            this.lblA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(38, 25);
            this.lblA.TabIndex = 11;
            this.lblA.Text = "a = ";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Font = new System.Drawing.Font("Buxton Sketch", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblB.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblB.Location = new System.Drawing.Point(137, 83);
            this.lblB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(54, 25);
            this.lblB.TabIndex = 9;
            this.lblB.Text = ";  b = ";
            // 
            // dGV_Results
            // 
            this.dGV_Results.AllowUserToOrderColumns = true;
            this.dGV_Results.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dGV_Results.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dGV_Results.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dGV_Results.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Monotype Corsiva", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGV_Results.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dGV_Results.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_Results.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnX,
            this.clnExactSol,
            this.clnEuler,
            this.clnEulerCauchy,
            this.clnEulerWithCorrection,
            this.clnRungeKutta,
            this.clnAdams});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Monotype Corsiva", 13F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGV_Results.DefaultCellStyle = dataGridViewCellStyle2;
            this.dGV_Results.Location = new System.Drawing.Point(14, 265);
            this.dGV_Results.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dGV_Results.Name = "dGV_Results";
            this.dGV_Results.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGV_Results.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dGV_Results.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dGV_Results.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dGV_Results.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dGV_Results.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dGV_Results.Size = new System.Drawing.Size(404, 331);
            this.dGV_Results.TabIndex = 14;
            this.dGV_Results.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV_Results_CellContentClick);
            // 
            // btnResolve
            // 
            this.btnResolve.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnResolve.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnResolve.ForeColor = System.Drawing.Color.Black;
            this.btnResolve.Location = new System.Drawing.Point(250, 226);
            this.btnResolve.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnResolve.Name = "btnResolve";
            this.btnResolve.Size = new System.Drawing.Size(168, 29);
            this.btnResolve.TabIndex = 15;
            this.btnResolve.Text = "Розв\'язати";
            this.btnResolve.UseVisualStyleBackColor = true;
            this.btnResolve.Click += new System.EventHandler(this.btnResolve_Click);
            // 
            // btnAddCauchyProblem
            // 
            this.btnAddCauchyProblem.BackColor = System.Drawing.Color.LightYellow;
            this.btnAddCauchyProblem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddCauchyProblem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddCauchyProblem.ForeColor = System.Drawing.Color.Black;
            this.btnAddCauchyProblem.Location = new System.Drawing.Point(316, 43);
            this.btnAddCauchyProblem.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAddCauchyProblem.Name = "btnAddCauchyProblem";
            this.btnAddCauchyProblem.Size = new System.Drawing.Size(108, 69);
            this.btnAddCauchyProblem.TabIndex = 16;
            this.btnAddCauchyProblem.Text = "Додати нову задачу";
            this.btnAddCauchyProblem.UseVisualStyleBackColor = false;
            this.btnAddCauchyProblem.Click += new System.EventHandler(this.btnAddCauchyProblem_Click);
            // 
            // lbl_ExactSolution
            // 
            this.lbl_ExactSolution.AutoSize = true;
            this.lbl_ExactSolution.Font = new System.Drawing.Font("Buxton Sketch", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ExactSolution.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_ExactSolution.Location = new System.Drawing.Point(540, 11);
            this.lbl_ExactSolution.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_ExactSolution.Name = "lbl_ExactSolution";
            this.lbl_ExactSolution.Size = new System.Drawing.Size(201, 23);
            this.lbl_ExactSolution.TabIndex = 17;
            this.lbl_ExactSolution.Text = "Точний розв\'язок:    y(x) = ";
            // 
            // txB_ExactSolution
            // 
            this.txB_ExactSolution.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txB_ExactSolution.BackColor = System.Drawing.Color.White;
            this.txB_ExactSolution.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txB_ExactSolution.Font = new System.Drawing.Font("Buxton Sketch", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txB_ExactSolution.Location = new System.Drawing.Point(745, 9);
            this.txB_ExactSolution.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txB_ExactSolution.Name = "txB_ExactSolution";
            this.txB_ExactSolution.ReadOnly = true;
            this.txB_ExactSolution.Size = new System.Drawing.Size(281, 24);
            this.txB_ExactSolution.TabIndex = 18;
            this.txB_ExactSolution.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txB_ExactSolution_KeyUp);
            this.txB_ExactSolution.Leave += new System.EventHandler(this.txB_ExactSolution_Leave);
            // 
            // btnEditExactSolution
            // 
            this.btnEditExactSolution.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditExactSolution.BackColor = System.Drawing.Color.MintCream;
            this.btnEditExactSolution.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditExactSolution.Font = new System.Drawing.Font("Times New Roman", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEditExactSolution.ForeColor = System.Drawing.Color.Black;
            this.btnEditExactSolution.Location = new System.Drawing.Point(1028, 9);
            this.btnEditExactSolution.Margin = new System.Windows.Forms.Padding(0);
            this.btnEditExactSolution.Name = "btnEditExactSolution";
            this.btnEditExactSolution.Size = new System.Drawing.Size(28, 22);
            this.btnEditExactSolution.TabIndex = 19;
            this.btnEditExactSolution.Text = "...";
            this.btnEditExactSolution.UseVisualStyleBackColor = false;
            this.btnEditExactSolution.Click += new System.EventHandler(this.btnEditExactSolution_Click);
            // 
            // chtGraph
            // 
            this.chtGraph.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.AxisX.MajorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.AcrossAxis;
            chartArea1.AxisX.MinorGrid.Enabled = true;
            chartArea1.AxisX.MinorGrid.LineColor = System.Drawing.Color.DarkGray;
            chartArea1.AxisX.MinorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea1.AxisX.MinorTickMark.Enabled = true;
            chartArea1.AxisX.MinorTickMark.LineColor = System.Drawing.Color.DimGray;
            chartArea1.AxisX.MinorTickMark.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDot;
            chartArea1.AxisX.MinorTickMark.Size = 0.5F;
            chartArea1.AxisX.MinorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.AcrossAxis;
            chartArea1.AxisX.ScaleView.SmallScrollMinSize = 1E-05D;
            chartArea1.AxisX.ScrollBar.Size = 10D;
            chartArea1.AxisX.Title = "x";
            chartArea1.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.AxisY.MajorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.AcrossAxis;
            chartArea1.AxisY.MinorGrid.Enabled = true;
            chartArea1.AxisY.MinorGrid.LineColor = System.Drawing.Color.DarkGray;
            chartArea1.AxisY.MinorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea1.AxisY.MinorTickMark.Enabled = true;
            chartArea1.AxisY.MinorTickMark.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea1.AxisY.MinorTickMark.Size = 0.5F;
            chartArea1.AxisY.MinorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.AcrossAxis;
            chartArea1.AxisY.ScaleView.SmallScrollMinSize = 1E-05D;
            chartArea1.AxisY.ScrollBar.Size = 10D;
            chartArea1.AxisY.Title = "y(x)";
            chartArea1.BackColor = System.Drawing.Color.White;
            chartArea1.CursorX.Interval = 0.0001D;
            chartArea1.CursorX.IsUserSelectionEnabled = true;
            chartArea1.CursorY.Interval = 0.0001D;
            chartArea1.CursorY.IsUserSelectionEnabled = true;
            chartArea1.Name = "ChartArea";
            this.chtGraph.ChartAreas.Add(chartArea1);
            legend1.BorderColor = System.Drawing.Color.Transparent;
            legend1.BorderWidth = 0;
            legend1.DockedToChartArea = "ChartArea";
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.IsDockedInsideChartArea = false;
            legend1.MaximumAutoSize = 25F;
            legend1.Name = "lgnSolutions";
            this.chtGraph.Legends.Add(legend1);
            this.chtGraph.Location = new System.Drawing.Point(439, 46);
            this.chtGraph.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.chtGraph.Name = "chtGraph";
            this.chtGraph.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.Sienna;
            series1.Legend = "lgnSolutions";
            series1.LegendText = "точний розв\'язок";
            series1.Name = "srsExactSol";
            series2.ChartArea = "ChartArea";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.GreenYellow;
            series2.Legend = "lgnSolutions";
            series2.LegendText = "метод Ейлера";
            series2.Name = "srsEuler";
            series3.ChartArea = "ChartArea";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Color = System.Drawing.Color.Red;
            series3.Legend = "lgnSolutions";
            series3.LegendText = "метод Ейлера-Коші";
            series3.Name = "srsEulerCauchy";
            series4.ChartArea = "ChartArea";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Color = System.Drawing.Color.Gold;
            series4.Legend = "lgnSolutions";
            series4.LegendText = "метод Ейлера з уточненням";
            series4.Name = "srsEulerWithCorrection";
            series5.ChartArea = "ChartArea";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Color = System.Drawing.Color.Blue;
            series5.Legend = "lgnSolutions";
            series5.LegendText = "метод Рунге-Кутта";
            series5.Name = "srsRungeKutta";
            series6.ChartArea = "ChartArea";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Color = System.Drawing.Color.Magenta;
            series6.Legend = "lgnSolutions";
            series6.LegendText = "метод Адамса";
            series6.Name = "srsAdams";
            this.chtGraph.Series.Add(series1);
            this.chtGraph.Series.Add(series2);
            this.chtGraph.Series.Add(series3);
            this.chtGraph.Series.Add(series4);
            this.chtGraph.Series.Add(series5);
            this.chtGraph.Series.Add(series6);
            this.chtGraph.Size = new System.Drawing.Size(664, 559);
            this.chtGraph.TabIndex = 20;
            // 
            // nUD_CountPartition
            // 
            this.nUD_CountPartition.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nUD_CountPartition.Font = new System.Drawing.Font("Buxton Sketch", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nUD_CountPartition.Location = new System.Drawing.Point(305, 134);
            this.nUD_CountPartition.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nUD_CountPartition.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nUD_CountPartition.Name = "nUD_CountPartition";
            this.nUD_CountPartition.Size = new System.Drawing.Size(82, 27);
            this.nUD_CountPartition.TabIndex = 21;
            this.nUD_CountPartition.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nUD_CountPartition.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // lbl_Eps
            // 
            this.lbl_Eps.AutoSize = true;
            this.lbl_Eps.Font = new System.Drawing.Font("Buxton Sketch", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Eps.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_Eps.Location = new System.Drawing.Point(266, 165);
            this.lbl_Eps.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Eps.Name = "lbl_Eps";
            this.lbl_Eps.Size = new System.Drawing.Size(36, 27);
            this.lbl_Eps.TabIndex = 22;
            this.lbl_Eps.Text = "𝞮 =";
            this.lbl_Eps.Visible = false;
            // 
            // txB_Eps
            // 
            this.txB_Eps.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txB_Eps.Font = new System.Drawing.Font("Buxton Sketch", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txB_Eps.Location = new System.Drawing.Point(305, 167);
            this.txB_Eps.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txB_Eps.Name = "txB_Eps";
            this.txB_Eps.Size = new System.Drawing.Size(113, 25);
            this.txB_Eps.TabIndex = 23;
            this.txB_Eps.Text = "0,0001";
            this.txB_Eps.Visible = false;
            this.txB_Eps.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txB_Eps_KeyUp);
            this.txB_Eps.Validated += new System.EventHandler(this.txB_Eps_Validated);
            // 
            // chB_AutoStep
            // 
            this.chB_AutoStep.AutoSize = true;
            this.chB_AutoStep.Font = new System.Drawing.Font("Buxton Sketch", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chB_AutoStep.Location = new System.Drawing.Point(271, 198);
            this.chB_AutoStep.Name = "chB_AutoStep";
            this.chB_AutoStep.Size = new System.Drawing.Size(128, 24);
            this.chB_AutoStep.TabIndex = 24;
            this.chB_AutoStep.Text = "автовибір кроку";
            this.chB_AutoStep.UseVisualStyleBackColor = true;
            this.chB_AutoStep.Visible = false;
            this.chB_AutoStep.CheckedChanged += new System.EventHandler(this.chB_AutoStep_CheckedChanged);
            // 
            // btnAccept
            // 
            this.btnAccept.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnAccept.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAccept.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAccept.Location = new System.Drawing.Point(316, 43);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(108, 28);
            this.btnAccept.TabIndex = 25;
            this.btnAccept.Text = "Підтвердити";
            this.btnAccept.UseVisualStyleBackColor = false;
            this.btnAccept.Visible = false;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Coral;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCancel.Location = new System.Drawing.Point(316, 84);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(108, 28);
            this.btnCancel.TabIndex = 26;
            this.btnCancel.Text = "Скасувати";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // chB_ExactSolGraph
            // 
            this.chB_ExactSolGraph.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chB_ExactSolGraph.AutoSize = true;
            this.chB_ExactSolGraph.BackColor = System.Drawing.Color.Sienna;
            this.chB_ExactSolGraph.Checked = true;
            this.chB_ExactSolGraph.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chB_ExactSolGraph.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chB_ExactSolGraph.Location = new System.Drawing.Point(1068, 13);
            this.chB_ExactSolGraph.Name = "chB_ExactSolGraph";
            this.chB_ExactSolGraph.Size = new System.Drawing.Size(15, 14);
            this.chB_ExactSolGraph.TabIndex = 10;
            this.chB_ExactSolGraph.UseVisualStyleBackColor = false;
            this.chB_ExactSolGraph.CheckedChanged += new System.EventHandler(this.chB_ExactSolGraph_CheckedChanged);
            // 
            // clnX
            // 
            this.clnX.Frozen = true;
            this.clnX.HeaderText = "x";
            this.clnX.Name = "clnX";
            this.clnX.ReadOnly = true;
            this.clnX.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clnX.Width = 23;
            // 
            // clnExactSol
            // 
            this.clnExactSol.HeaderText = "Точне значення";
            this.clnExactSol.Name = "clnExactSol";
            this.clnExactSol.ReadOnly = true;
            this.clnExactSol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clnExactSol.Width = 116;
            // 
            // clnEuler
            // 
            this.clnEuler.HeaderText = "м. Ейлера";
            this.clnEuler.Name = "clnEuler";
            this.clnEuler.ReadOnly = true;
            this.clnEuler.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clnEuler.Width = 77;
            // 
            // clnEulerCauchy
            // 
            this.clnEulerCauchy.HeaderText = "м. Ейлера-Коші";
            this.clnEulerCauchy.Name = "clnEulerCauchy";
            this.clnEulerCauchy.ReadOnly = true;
            this.clnEulerCauchy.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clnEulerCauchy.Width = 113;
            // 
            // clnEulerWithCorrection
            // 
            this.clnEulerWithCorrection.HeaderText = "м. Ейлера з уточн.";
            this.clnEulerWithCorrection.Name = "clnEulerWithCorrection";
            this.clnEulerWithCorrection.ReadOnly = true;
            this.clnEulerWithCorrection.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clnEulerWithCorrection.Width = 91;
            // 
            // clnRungeKutta
            // 
            this.clnRungeKutta.HeaderText = "м. Рунге-Кутта";
            this.clnRungeKutta.Name = "clnRungeKutta";
            this.clnRungeKutta.ReadOnly = true;
            this.clnRungeKutta.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clnRungeKutta.Width = 114;
            // 
            // clnAdams
            // 
            this.clnAdams.HeaderText = "м. Адамса";
            this.clnAdams.Name = "clnAdams";
            this.clnAdams.ReadOnly = true;
            this.clnAdams.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clnAdams.Width = 77;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(1105, 608);
            this.Controls.Add(this.chB_ExactSolGraph);
            this.Controls.Add(this.dGV_Results);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.chB_AutoStep);
            this.Controls.Add(this.txB_Eps);
            this.Controls.Add(this.lbl_Eps);
            this.Controls.Add(this.nUD_CountPartition);
            this.Controls.Add(this.chtGraph);
            this.Controls.Add(this.btnEditExactSolution);
            this.Controls.Add(this.txB_ExactSolution);
            this.Controls.Add(this.lbl_ExactSolution);
            this.Controls.Add(this.btnAddCauchyProblem);
            this.Controls.Add(this.btnResolve);
            this.Controls.Add(this.grB_MethodsOfSolution);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.lblCountPartition);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lbl___);
            this.Controls.Add(this.lbl_y_);
            this.Controls.Add(this.txB_B);
            this.Controls.Add(this.txB_x0);
            this.Controls.Add(this.txB_y0);
            this.Controls.Add(this.cmB_RightPartEquation);
            this.Controls.Add(this.txB_A);
            this.Controls.Add(this.lbl_LeftPartEquation);
            this.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "frmMain";
            this.Text = "Методи розв\'язання задачі Коші";
            this.grB_MethodsOfSolution.ResumeLayout(false);
            this.grB_MethodsOfSolution.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Results)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtGraph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_CountPartition)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_LeftPartEquation;
        private System.Windows.Forms.TextBox txB_A;
        private System.Windows.Forms.ComboBox cmB_RightPartEquation;
        private System.Windows.Forms.TextBox txB_y0;
        private System.Windows.Forms.TextBox txB_x0;
        private System.Windows.Forms.TextBox txB_B;
        private System.Windows.Forms.Label lbl_y_;
        private System.Windows.Forms.Label lbl___;
        private System.Windows.Forms.GroupBox grB_MethodsOfSolution;
        private System.Windows.Forms.RadioButton rdB_Adams;
        private System.Windows.Forms.RadioButton rdB_RungeKutta;
        private System.Windows.Forms.RadioButton rdB_EulerWithCorrection;
        private System.Windows.Forms.RadioButton rdB_EulerCauchy;
        private System.Windows.Forms.RadioButton rdB_Euler;
        private System.Windows.Forms.Label lblCountPartition;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.DataGridView dGV_Results;
        private System.Windows.Forms.Button btnResolve;
        private System.Windows.Forms.Button btnAddCauchyProblem;
        private System.Windows.Forms.Label lbl_ExactSolution;
        private System.Windows.Forms.TextBox txB_ExactSolution;
        private System.Windows.Forms.Button btnEditExactSolution;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtGraph;
        private System.Windows.Forms.CheckBox chB_RungeKuttaGraph;
        private System.Windows.Forms.CheckBox chB_AdamsGraph;
        private System.Windows.Forms.CheckBox chB_EulerCauchyGraph;
        private System.Windows.Forms.CheckBox chB_EulerWithCorrGraph;
        private System.Windows.Forms.CheckBox chB_EulerGraph;
        private System.Windows.Forms.NumericUpDown nUD_CountPartition;
        private System.Windows.Forms.Label lbl_Eps;
        private System.Windows.Forms.TextBox txB_Eps;
        private System.Windows.Forms.CheckBox chB_AutoStep;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox chB_ExactSolGraph;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnX;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnExactSol;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnEuler;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnEulerCauchy;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnEulerWithCorrection;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnRungeKutta;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnAdams;
    }
}

