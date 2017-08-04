using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class frmMain : Form
    {        
        enum Option { Edit, Add } 

        Dictionary<string, SystemOfLinearAlgebraicEquations> _SLAEs = new Dictionary<string, SystemOfLinearAlgebraicEquations>();
        SystemOfLinearAlgebraicEquations _currSLAE;

        Option _optionOfEditor;

        public frmMain()
        {
            InitializeComponent();
            _SLAEs.Add("Завдання 2.1 (Варіант 5)", 
                SystemOfLinearAlgebraicEquations.CreateSystem(
                    Matrix2D.CreateMatrix(new double[3, 3]{ {-1,  5,    3},
                                                            { 1,  1, -2.5}, 
                                                            { 4, -2,   -1}}), 
                    Vector.CreateVector(new double[3]{ 2, -1.5, 3})));
            cmB_ListSLAEs.Items.Add("Завдання 2.1 (Варіант 5)");

            _SLAEs.Add("Завдання 2.2 (Варіант 5)",
                SystemOfLinearAlgebraicEquations.CreateSystem(
                    Matrix2D.CreateMatrix(new double[3, 3]{ { 9,  3, -6},
                                                            { 3,  5, -4}, 
                                                            {-6, -4,  6}}),
                    Vector.CreateVector(new double[3] { 9, -12, 5 })));
            cmB_ListSLAEs.Items.Add("Завдання 2.2 (Варіант 5)");

            _SLAEs.Add("Завдання 2.3 (Варіант 5)",
                SystemOfLinearAlgebraicEquations.CreateSystem(
                    Matrix2D.CreateMatrix(new double[5, 5]{ { 8,  4,   0,  0,  0},
                                                            {-5, 22,   8,  0,  0}, 
                                                            { 0, -5, -11,  1,  0},
                                                            { 0,  0,   6, 20, -5},
                                                            { 0,  0,   0,  1,  7} }),
                    Vector.CreateVector(new double[5] { 48, 125, -43, 18, -23 })));
            cmB_ListSLAEs.Items.Add("Завдання 2.3 (Варіант 5)");

            _SLAEs.Add("Завдання 2.4 (Варіант 5)", 
                SystemOfLinearAlgebraicEquations.CreateSystem(
                    Matrix2D.CreateMatrix(new double[4, 4]{ { 20,  5,  7,   1},
                                                            { -1, 13,  0,  -7}, 
                                                            {  4, -6, 17,   5},
                                                            { -9,  8,  4, -25} }),
                    Vector.CreateVector(new double[4] { -117, -1, 49, -21 })));
            cmB_ListSLAEs.Items.Add("Завдання 2.4 (Варіант 5)");
            
            cmB_ListSLAEs.SelectedIndex = 0;
        }        

        public static string NumberToLowIndex(int number)
        {
            string result = "",
                   source = number.ToString();
            for (int i = 0; i < source.Length; i++)
                switch (source[i])
                {
                    case '1':
                        result += '₁';
                        break;
                    case '2':
                        result += '₂';
                        break;
                    case '3':
                        result += '₃';
                        break;
                    case '4':
                        result += '₄';
                        break;
                    case '5':
                        result += '₅';
                        break;
                    case '6':
                        result += '₆';
                        break;
                    case '7':
                        result += '₇';
                        break;
                    case '8':
                        result += '₈';
                        break;
                    case '9':
                        result += '₉';
                        break;
                    case '0':
                        result += '₀';
                        break;
                    case '-':
                        result += '₋';
                        break;
                    default:
                        break;
                }
            return result;
        }

        private void dGV_MatrixOfSLAE_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (!dGV_MatrixOfSLAE.ReadOnly)
                dGV_MatrixOfSLAE.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = (e.RowIndex < _currSLAE.A.RowCount && e.ColumnIndex < _currSLAE.A.ColCount) ? _currSLAE.A.GetElement(e.RowIndex, e.ColumnIndex) : 0;
        }

        private void dGV_MatrixOfSLAE_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            if (!dGV_MatrixOfSLAE.ReadOnly)
            {
                double realValue;
                if (dGV_MatrixOfSLAE.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    if (!double.TryParse(dGV_MatrixOfSLAE.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString(), out realValue))
                        realValue = (e.RowIndex < _currSLAE.A.RowCount && e.ColumnIndex < _currSLAE.A.ColCount) ? _currSLAE.A.GetElement(e.RowIndex, e.ColumnIndex) : 0;
                    dGV_MatrixOfSLAE.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = ((e.ColumnIndex == 0) ? (e.RowIndex + 1 + ") ") : ((realValue < 0) ? "" : "+")) + realValue + "*x" + NumberToLowIndex(e.ColumnIndex + 1);
                }
            }
        }

        private void dGV_ConstantTermsOfSLAE_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (! dGV_ConstantTermsOfSLAE.ReadOnly)
                dGV_ConstantTermsOfSLAE.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = (e.RowIndex < _currSLAE.F.Length) ? _currSLAE.F[e.RowIndex] : 0;
        }

        private void dGV_ConstantTermsOfSLAE_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            if (!dGV_ConstantTermsOfSLAE.ReadOnly)
            {
                double realValue;
                if (dGV_ConstantTermsOfSLAE.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                    if (double.TryParse(dGV_ConstantTermsOfSLAE.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString(), out realValue))
                        dGV_ConstantTermsOfSLAE.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = " = " + realValue;
                    else
                        dGV_ConstantTermsOfSLAE.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = " = " + ((e.RowIndex < _currSLAE.F.Length) ? _currSLAE.F[e.RowIndex] : 0);
            }
        }

        private void dGV_Sync_Scroll(object sender, ScrollEventArgs e)
        {
            if (e.ScrollOrientation == ScrollOrientation.VerticalScroll)
                if (object.ReferenceEquals(sender, dGV_ConstantTermsOfSLAE))
                    dGV_MatrixOfSLAE.FirstDisplayedScrollingRowIndex = dGV_ConstantTermsOfSLAE.FirstDisplayedScrollingRowIndex;
                else
                    dGV_ConstantTermsOfSLAE.FirstDisplayedScrollingRowIndex = dGV_MatrixOfSLAE.FirstDisplayedScrollingRowIndex;
            //dGV_MatrixOfSLAE.Refresh();
        }

        private void cmB_ListSLAEs_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currSLAE = _SLAEs[cmB_ListSLAEs.SelectedItem.ToString()];            
            nUD_CountVariables.Value = _currSLAE.A.ColCount;
            //nUD_CountEquations.Value = _currSLAE.A.RowCount;
            WriteSLAE_InDGV();
        }

        private void nUD_CountEquations_ValueChanged(object sender, EventArgs e)
        {
            dGV_ConstantTermsOfSLAE.RowCount = dGV_MatrixOfSLAE.RowCount = (int)nUD_CountEquations.Value;
        }

        private void nUD_CountVariables_ValueChanged(object sender, EventArgs e)
        {
            nUD_CountEquations.Value = dGV_MatrixOfSLAE.ColumnCount = (int)nUD_CountVariables.Value;             
        }

        private void btnAddSLAE_Click(object sender, EventArgs e)
        {
            btnAddSLAE.Visible = false;
            btnChangeSLAE.Visible = false;            
            grB_SolvingSelectedSLAE.Enabled = false;
            _optionOfEditor = Option.Add;
            txB_NameNewSystem.Visible = true;
            dGV_ConstantTermsOfSLAE.ReadOnly = false;
            dGV_MatrixOfSLAE.ReadOnly = false;
            nUD_CountVariables.Enabled = true;
            //nUD_CountEquations.Enabled = true;
            btnAccept.Visible = true;
            btnCancel.Visible = true;
            txB_NameNewSystem.Focus();
        }

        private void btnChangeSLAE_Click(object sender, EventArgs e)
        {
            btnAddSLAE.Visible = false;
            btnChangeSLAE.Visible = false;
            grB_SolvingSelectedSLAE.Enabled = false;
            _optionOfEditor = Option.Edit;
            cmB_ListSLAEs.Enabled = false;
            dGV_ConstantTermsOfSLAE.ReadOnly = false;
            dGV_MatrixOfSLAE.ReadOnly = false;
            btnAccept.Visible = true;
            btnCancel.Visible = true;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            switch (_optionOfEditor)
            {
                case Option.Add:
                    if ((txB_NameNewSystem.Text == "") || _SLAEs.ContainsKey(txB_NameNewSystem.Text))
                    {
                        MessageBox.Show("Введіть унікальний ідентифікатор нової системи.", "Недопустимий ідентифікатор");
                        txB_NameNewSystem.Focus();
                        return;
                    }
                    else
                    {
                        _SLAEs.Add(txB_NameNewSystem.Text, ReadSLAE_FromDGV());
                        cmB_ListSLAEs.Items.Add(txB_NameNewSystem.Text);
                        cmB_ListSLAEs.SelectedIndex = cmB_ListSLAEs.Items.Count - 1;
                    }
                    break;
                case Option.Edit:
                    _currSLAE = _SLAEs[cmB_ListSLAEs.SelectedItem.ToString()] = ReadSLAE_FromDGV();
                    break;

                default:
                    throw new NotImplementedException();
            }

            btnCancel.Visible = false;
            btnAccept.Visible = false;
            dGV_MatrixOfSLAE.ReadOnly = true;
            dGV_ConstantTermsOfSLAE.ReadOnly = true;
            switch (_optionOfEditor)
            {
                case Option.Add:
                    txB_NameNewSystem.Visible = false;
                    nUD_CountVariables.Enabled = false;
                    //nUD_CountEquations.Enabled = false;
                    break;

                case Option.Edit:
                    cmB_ListSLAEs.Enabled = true;
                    break;

                default:
                    throw new NotImplementedException();
            }
            grB_SolvingSelectedSLAE.Enabled = true;
            btnAddSLAE.Visible = true;
            btnChangeSLAE.Visible = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnCancel.Visible = false;
            btnAccept.Visible = false;            
            dGV_MatrixOfSLAE.ReadOnly = true;            
            dGV_ConstantTermsOfSLAE.ReadOnly = true;
            switch (_optionOfEditor)
            {
                case Option.Add:
                    txB_NameNewSystem.Visible = false;
                    nUD_CountVariables.Enabled = false;
                    //nUD_CountEquations.Enabled = false;
                    break;

                case Option.Edit:
                    cmB_ListSLAEs.Enabled = true;
                    break;

                default:
                    throw new NotImplementedException();
            }
            grB_SolvingSelectedSLAE.Enabled = true;
            btnAddSLAE.Visible = true;
            btnChangeSLAE.Visible = true;

            cmB_ListSLAEs_SelectedIndexChanged(cmB_ListSLAEs, new EventArgs());
        }

        private SystemOfLinearAlgebraicEquations ReadSLAE_FromDGV()
        {
            int m, n;
            double[,] matrixNewSystem = new double[m = dGV_MatrixOfSLAE.RowCount, n = dGV_MatrixOfSLAE.ColumnCount];
            double[] constantTermsNewSystem = new double[m];            
            for (int i = 0; i < m; i++)
            {
                if ((dGV_MatrixOfSLAE.Rows[i].Cells[0].Value != null) && (dGV_MatrixOfSLAE.Rows[i].Cells[0].Value.ToString() != ""))
                    matrixNewSystem[i, 0] = double.Parse(dGV_MatrixOfSLAE.Rows[i].Cells[0].Value.ToString().Split(' ', '*')[1]);
                else
                    matrixNewSystem[i, 0] = 0;
                for (int j = 1; j < n; j++)
                    if ((dGV_MatrixOfSLAE.Rows[i].Cells[j].Value != null) && (dGV_MatrixOfSLAE.Rows[i].Cells[j].Value.ToString() != ""))
                        matrixNewSystem[i, j] = double.Parse(dGV_MatrixOfSLAE.Rows[i].Cells[j].Value.ToString().Split('*')[0]);
                    else
                        matrixNewSystem[i, j] = 0;
                if ((dGV_ConstantTermsOfSLAE.Rows[i].Cells[0].Value != null) && (dGV_ConstantTermsOfSLAE.Rows[i].Cells[0].Value.ToString() != ""))
                    constantTermsNewSystem[i] = double.Parse(dGV_ConstantTermsOfSLAE.Rows[i].Cells[0].Value.ToString().Substring(3));
            }
            return SystemOfLinearAlgebraicEquations.CreateSystem(Matrix2D.CreateMatrix(matrixNewSystem), Vector.CreateVector(constantTermsNewSystem));
        }

        private void WriteSLAE_InDGV()
        {
            int m = _currSLAE.A.RowCount,
                n = _currSLAE.A.ColCount;
            for (int i = 0; i < m; i++)
            {
                dGV_MatrixOfSLAE.Rows[i].Cells[0].Value = i + 1 + ") " + _currSLAE.A.GetElement(i, 0) + "*x" + NumberToLowIndex(1);
                for (int j = 1; j < n; j++)
                    dGV_MatrixOfSLAE.Rows[i].Cells[j].Value = ((_currSLAE.A.GetElement(i, j) < 0) ? "" : "+") + _currSLAE.A.GetElement(i, j) + "*x" + NumberToLowIndex(j + 1);
                dGV_ConstantTermsOfSLAE.Rows[i].Cells[0].Value = " = " + _currSLAE.F[i];
            }
        }

        private void rdB_SelectionMethod_CheckedChanged(object sender, EventArgs e)
        {            
            switch ((sender as RadioButton).Name)
            {
                case "rdB_mThreediagonalMatrixAlgorithm":
                case "rdB_mSquare_RootMethod":
                case "rdB_mMethodOfGaussianElimination":
                    lblСorrectnessOfIterMethods.Visible = false;
                    txB_СorrectnessOfIterMethods.Visible = false;
                    break;

                case "rdB_mMethodOfSuccessiveIteration":
                case "rdB_mSeidelMethod":
                    lblСorrectnessOfIterMethods.Visible = true;
                    txB_СorrectnessOfIterMethods.Visible = true;
                    break;

                default:
                    throw new NotImplementedException();
            }
        }

        private void txB_СorrectnessOfIterMethods_Leave(object sender, EventArgs e)
        {
            double help_variable;
            if (double.TryParse(txB_СorrectnessOfIterMethods.Text, out help_variable))
                SystemOfLinearAlgebraicEquations.EpsInSolution = help_variable;
            else
                txB_СorrectnessOfIterMethods.Text = SystemOfLinearAlgebraicEquations.EpsInSolution.ToString();
        }

        private void btnSolveSLAE_Click(object sender, EventArgs e)
        {            
            Vector resultSolution = null;
            if (rdB_mThreediagonalMatrixAlgorithm.Checked)
                resultSolution = _currSLAE.GetSolution(SystemOfLinearAlgebraicEquations.MethodsForSolution.ThreediagonalMatrixAlgorithm);

            if (rdB_mSquare_RootMethod.Checked)
                resultSolution = _currSLAE.GetSolution(SystemOfLinearAlgebraicEquations.MethodsForSolution.Square_RootMethod);

            if (rdB_mMethodOfGaussianElimination.Checked)
                resultSolution = _currSLAE.GetSolution(SystemOfLinearAlgebraicEquations.MethodsForSolution.MethodOfGaussianElimination);

            if (rdB_mMethodOfSuccessiveIteration.Checked)
                resultSolution = _currSLAE.GetSolution(SystemOfLinearAlgebraicEquations.MethodsForSolution.MethodOfSuccessiveIteration);

            if (rdB_mSeidelMethod.Checked)
                resultSolution = _currSLAE.GetSolution(SystemOfLinearAlgebraicEquations.MethodsForSolution.SeidelMethod);

            pnl_InfoAboutSolution.Visible = true;
            ltB_InfoAboutSolution.Items.Clear();
            if (resultSolution == null)            
                ltB_InfoAboutSolution.Items.Add("Задана система не має розв'язку.");
            else
            {
                if (!double.IsNaN(resultSolution[0]))
                {
                    for (int i = 0; i < resultSolution.Length; i++)
                        ltB_InfoAboutSolution.Items.Add("x" + NumberToLowIndex(i + 1) + " = " + resultSolution[i] + ";");

                    Vector teta = _currSLAE.A * resultSolution + (-_currSLAE.F);
                    for (int i = 0; i < teta.Length; i++)
                        ltB_InfoAboutSolution.Items[i] += "     θ" + NumberToLowIndex(i + 1) + " = " + teta[i] + ";";
                }
                else
                    ltB_InfoAboutSolution.Items.Add("Даним методом не вдається розв'язати задану систему.");
            }            
        }

        private void rdB_AutoFormatWidthColumns_CheckedChanged(object sender, EventArgs e)
        {
            switch ((sender as RadioButton).Name)
            {
                case "rdB_AllCells":
                    dGV_MatrixOfSLAE.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    break;

                case "rdB_Fill":
                    dGV_MatrixOfSLAE.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    break;

                default:
                    throw new NotImplementedException();
            }
        }
    }
}
