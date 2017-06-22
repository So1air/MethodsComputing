using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DelegateGenerator;

namespace Lab4
{
    public partial class frmMain : Form
    {
        private double _oldEps;
        private CauchyProblem _currCauchyTask;
        private int _oldSelectedIndex;
        const int COUNT_POINTS_FOR_GRAPH = 1000;

        public frmMain()
        {
            InitializeComponent();
            _oldEps = double.Parse(txB_Eps.Text);
            this.cmB_RightPartEquation.Items.Add(CauchyProblem.CreateInstance("x - Math.Sqrt(x*y)", 0, 0, 0, 1));
            this.cmB_RightPartEquation.Items.Add(CauchyProblem.CreateInstance("1 - x * Math.Sqrt(y)", 0, 1, 0, 1));
            this.cmB_RightPartEquation.Items.Add(CauchyProblem.CreateInstance("1 - Math.Sin(x*y)", 0, 2, 0, 1));
            this.cmB_RightPartEquation.Items.Add(CauchyProblem.CreateInstance("x - Math.Sqrt(y)", 0, 0, 0, 1));
            this.cmB_RightPartEquation.Items.Add(CauchyProblem.CreateInstance("1 - Math.Sqrt(x + y)", 0, 0, 0, 1));
            this.cmB_RightPartEquation.Items.Add(CauchyProblem.CreateInstance("1 - Math.Sqrt(x*x + y*y)", 0, 0, 0, 1));
            this.cmB_RightPartEquation.Items.Add(CauchyProblem.CreateInstance("x - x / y", 0, 1, 0, 1));
            this.cmB_RightPartEquation.SelectedIndex = 0;
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

        private void chB_EulerGraph_CheckedChanged(object sender, EventArgs e)
        {
            this.chtGraph.Series["srsEuler"].Enabled = this.chB_EulerGraph.Checked;
        }

        private void chB_EulerCauchyGraph_CheckedChanged(object sender, EventArgs e)
        {
            this.chtGraph.Series["srsEulerCauchy"].Enabled = this.chB_EulerCauchyGraph.Checked;
        }

        private void chB_EulerWithCorrGraph_CheckedChanged(object sender, EventArgs e)
        {
            this.chtGraph.Series["srsEulerWithCorrection"].Enabled = this.chB_EulerWithCorrGraph.Checked;
        }

        private void chB_RungeKuttaGraph_CheckedChanged(object sender, EventArgs e)
        {
            this.chtGraph.Series["srsRungeKutta"].Enabled = this.chB_RungeKuttaGraph.Checked;
        }

        private void chB_AdamsGraph_CheckedChanged(object sender, EventArgs e)
        {
            this.chtGraph.Series["srsAdams"].Enabled = this.chB_AdamsGraph.Checked;
        }

        private void btnEditExactSolution_Click(object sender, EventArgs e)
        {
            if (_currCauchyTask != null)
            {
                txB_ExactSolution.ReadOnly = false;
                txB_ExactSolution.Focus();
            }
        }

        private void txB_ExactSolution_Leave(object sender, EventArgs e)
        {
            if (!txB_ExactSolution.ReadOnly)
            {
                if (_currCauchyTask.SetExactSolution(this.txB_ExactSolution.Text))
                {
                    btnEditExactSolution.BackColor = Color.MintCream;
                    ReDrawGraphOfExactSol();
                    if (dGV_Results.RowCount > 1)
                        for (int i = 0, n = dGV_Results.RowCount - 1; i < n; i++)
                            dGV_Results.Rows[i].Cells["clnExactSol"].Value = _currCauchyTask.ExactSolution((double)dGV_Results.Rows[i].Cells["clnX"].Value);
                }
                else
                {   
                    txB_ExactSolution.Text = _currCauchyTask.TextExactSolution;
                    btnEditExactSolution.BackColor = Color.Coral;
                    MessageBox.Show("Перевірте коректність введення точного розв'язку або його відповідність умові задачі(невідповідність може проявлятися у тому, що введене значення не задовольняє початковій умові");
                   
                }
                txB_ExactSolution.ReadOnly = true;
            }
        }

        private void ReDrawGraphOfExactSol()
        {
            this.chtGraph.Series["srsExactSol"].Points.Clear();
            try
            {
                double x = this._currCauchyTask.A,
                       h = (this._currCauchyTask.B - x) / COUNT_POINTS_FOR_GRAPH;
                for (int i = 0; i <= COUNT_POINTS_FOR_GRAPH; i++, x += h)
                    this.chtGraph.Series["srsExactSol"].Points.AddXY(x, _currCauchyTask.ExactSolution(x));
            }
            catch (OverflowException)
            {
                MessageBox.Show("Занадто велике значення функції на відрізку!");
            }
            catch (Exception)
            {
                MessageBox.Show("Помилка при відрисовуванні графіка точного розв'язку задачі!");
            }
        }

        private void txB_x0_TextChanged(object sender, EventArgs e)
        {
            txB_A.Text = txB_x0.Text;     //временно
        }

        private void btnAddCauchyProblem_Click(object sender, EventArgs e)
        {   
            cmB_RightPartEquation.DropDownStyle = ComboBoxStyle.Simple;
            btnResolve.Visible = false;
            btnEditExactSolution.Visible = false;
            grB_MethodsOfSolution.Visible = false;
            chtGraph.Visible = false;
            dGV_Results.Visible = false;
            txB_ExactSolution.Visible = false;
            lbl_ExactSolution.Visible = false;
            rdB_Euler.Checked = true;
            lblCountPartition.Visible = false;
            nUD_CountPartition.Visible = false;

            txB_B.ReadOnly = false; txB_B.Text = "";
            txB_x0.ReadOnly = false; txB_x0.Text = "";
            txB_y0.ReadOnly = false; txB_y0.Text = "";
            cmB_RightPartEquation.Text = "";
            btnAccept.Visible = true;
            btnCancel.Visible = true;
            this._oldSelectedIndex = cmB_RightPartEquation.SelectedIndex;
        }
        
        private void btnCancel_Click(object sender, EventArgs e)
        { 
            btnCancel.Visible = false;
            btnAccept.Visible = false;
            txB_y0.ReadOnly = true; 
            txB_x0.ReadOnly = true;
            txB_B.ReadOnly = true;

            nUD_CountPartition.Visible = true;
            lblCountPartition.Visible = true;            
            rdB_Euler.Checked = true;
            lbl_ExactSolution.Visible = true;
            txB_ExactSolution.Visible = true;
            dGV_Results.Visible = true;
            chtGraph.Visible = true; 
            grB_MethodsOfSolution.Visible = true;
            btnEditExactSolution.Visible = true;
            btnResolve.Visible = true;
            cmB_RightPartEquation.DropDownStyle = ComboBoxStyle.DropDownList;
            cmB_RightPartEquation.SelectedIndex = this._oldSelectedIndex;
            cmB_RightPartEquation_SelectedIndexChanged(cmB_RightPartEquation, new EventArgs());
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            double a;
            if (!double.TryParse(txB_A.Text, out a))
            {
                MessageBox.Show("Некоректне значення нижньої межі відрізка");
                txB_A.Focus();
                return;
            }

            double b;
            if (!double.TryParse(txB_B.Text, out b))
            {
                MessageBox.Show("Некоректне значення верхньої межі відрізка");
                txB_B.Focus();
                return;
            }

            if (b <= a)
            {
                MessageBox.Show("Логічна помилка: верхня межа відрізку - b, менше або дорівнює нижній межі - a");
                txB_B.Focus();
                return;
            }

            double x0;
            if (!double.TryParse(txB_x0.Text, out x0))
            {
                MessageBox.Show("Некоректне значення x0 у початковій умові задачі Коші");
                txB_x0.Focus();
                return;
            }
            double y0;
            if (!double.TryParse(txB_y0.Text, out y0))
            {
                MessageBox.Show("Некоректне значення y0 у початковій умові задачі Коші");
                txB_y0.Focus();
                return;
            }
            
            CauchyProblem newCauchyTask;
            if ((newCauchyTask = CauchyProblem.CreateInstance(cmB_RightPartEquation.Text, x0, y0, a, b)) != null)
            {
                //cmB_RightPartEquation.DropDownStyle = ComboBoxStyle.DropDownList;
                cmB_RightPartEquation.Items.Add(newCauchyTask);
                _oldSelectedIndex = cmB_RightPartEquation.Items.Count - 1;
                btnCancel_Click(btnCancel, new EventArgs());
            }
            else
            {
                MessageBox.Show("Некоректний текст правої частини рівняння задачі Коші");
                cmB_RightPartEquation.Focus();                
            }
        }       
  
        private void rdB_Euler_CheckedChanged(object sender, EventArgs e)
        {
            if (rdB_Euler.Checked)
            {
                this.lbl_Eps.Visible = false;
                this.txB_Eps.Visible = false;
                this.chB_AutoStep.Visible = false;
                this.nUD_CountPartition.Visible = true;
                this.lblCountPartition.Visible = true;
            }
        }

        private void rdB_EulerCauchy_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rdB_EulerCauchy.Checked)
            {
                this.lbl_Eps.Visible = false;
                this.txB_Eps.Visible = false;
                this.chB_AutoStep.Visible = false;
                this.nUD_CountPartition.Visible = true;
                this.lblCountPartition.Visible = true;
            }
        }

        private void rdB_EulerWithCorrection_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rdB_EulerWithCorrection.Checked)
            {
                this.lbl_Eps.Visible = true;
                this.txB_Eps.Visible = true;
                this.chB_AutoStep.Visible = false;
                this.nUD_CountPartition.Visible = true;
                this.lblCountPartition.Visible = true;
            }
        }

        private void rdB_RungeKutta_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rdB_RungeKutta.Checked)
            {
                this.lblCountPartition.Visible = this.nUD_CountPartition.Visible = !(this.txB_Eps.Visible = this.lbl_Eps.Visible = chB_AutoStep.Checked);
                this.chB_AutoStep.Visible = true;                
            }
        }

        private void rdB_Adams_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rdB_Adams.Checked)
            {
                this.lbl_Eps.Visible = true;
                this.txB_Eps.Visible = true;
                this.chB_AutoStep.Visible = true;
                this.chB_AutoStep.Enabled = false;
                this.chB_AutoStep.Checked = true;
                this.nUD_CountPartition.Visible = true;
                this.lblCountPartition.Visible = true;
            }
            else
                chB_AutoStep.Enabled = true;
        }

        private void txB_Eps_Validated(object sender, EventArgs e)
        {
            double newEps;
            if (double.TryParse(txB_Eps.Text, out newEps) && (newEps > 0) && (newEps < Convert.ToDouble(this.txB_B.Text) - Convert.ToDouble(this.txB_A.Text)))
                _oldEps = newEps;
            else
                txB_Eps.Text = _oldEps.ToString();
        }

        private void chB_AutoStep_CheckedChanged(object sender, EventArgs e)
        {
            this.lblCountPartition.Visible = this.nUD_CountPartition.Visible = ! (this.txB_Eps.Visible = this.lbl_Eps.Visible = chB_AutoStep.Checked);
        }

        private void txB_Eps_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.btnResolve.Focus();
        }

        private void txB_ExactSolution_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.chtGraph.Focus();
        }

        private void cmB_RightPartEquation_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currCauchyTask = this.cmB_RightPartEquation.SelectedItem as CauchyProblem;
            txB_x0.Text = _currCauchyTask.InitialValue.Arg.ToString();
            txB_y0.Text = _currCauchyTask.InitialValue.Func.ToString();
            txB_A.Text = _currCauchyTask.A.ToString();
            txB_B.Text = _currCauchyTask.B.ToString();
            txB_ExactSolution.Text = _currCauchyTask.TextExactSolution;
            FillTable();
            if (_currCauchyTask.ResultEulerMethod != null)
                ReDrawGraphOfEuler();
            else
                this.chtGraph.Series["srsEuler"].Points.Clear();

            if (_currCauchyTask.ResultEulerCauchyMethod != null)
                ReDrawGraphOfEulerCauchy();
            else
                this.chtGraph.Series["srsEulerCauchy"].Points.Clear();

            if (_currCauchyTask.ResultEulerMethodCorr != null)
                ReDrawGraphOfEulerCorr();
            else
                this.chtGraph.Series["srsEulerWithCorrection"].Points.Clear();
  
            if (_currCauchyTask.ResultRungeKuttaMethod != null)
                ReDrawGraphOfRungeKutta();
            else
                this.chtGraph.Series["srsRungeKutta"].Points.Clear();

            if (_currCauchyTask.ResultAdamsMethod != null)
                ReDrawGraphOfAdams();
            else
                this.chtGraph.Series["srsAdams"].Points.Clear();

            if (_currCauchyTask.ExactSolution != null)
                ReDrawGraphOfExactSol();
            else
                this.chtGraph.Series["srsExactSol"].Points.Clear();
        }
        
        private void ReDrawGraphOfEuler()
        {
            this.chtGraph.Series["srsEuler"].Points.Clear();

            for (int i = 0, n = _currCauchyTask.ResultEulerMethod.Length; i < n; i++)
                this.chtGraph.Series["srsEuler"].Points.AddXY(_currCauchyTask.ResultEulerMethod[i].Arg, _currCauchyTask.ResultEulerMethod[i].Func);  
        }

        private void ReDrawGraphOfEulerCauchy()
        {
            this.chtGraph.Series["srsEulerCauchy"].Points.Clear();

            for (int i = 0, n = _currCauchyTask.ResultEulerCauchyMethod.Length; i < n; i++)
                this.chtGraph.Series["srsEulerCauchy"].Points.AddXY(_currCauchyTask.ResultEulerCauchyMethod[i].Arg, _currCauchyTask.ResultEulerCauchyMethod[i].Func);  
        }

        private void ReDrawGraphOfEulerCorr()
        {
            this.chtGraph.Series["srsEulerWithCorrection"].Points.Clear();           
                
            for (int i = 0, n = _currCauchyTask.ResultEulerMethodCorr.Length; i < n; i++)
                this.chtGraph.Series["srsEulerWithCorrection"].Points.AddXY(_currCauchyTask.ResultEulerMethodCorr[i].Arg, _currCauchyTask.ResultEulerMethodCorr[i].Func);            
        }

        private void ReDrawGraphOfRungeKutta()
        {
            this.chtGraph.Series["srsRungeKutta"].Points.Clear();

            for (int i = 0, n = _currCauchyTask.ResultRungeKuttaMethod.Length; i < n; i++)
                this.chtGraph.Series["srsRungeKutta"].Points.AddXY(_currCauchyTask.ResultRungeKuttaMethod[i].Arg, _currCauchyTask.ResultRungeKuttaMethod[i].Func);   
        }

        private void ReDrawGraphOfAdams()
        {
            this.chtGraph.Series["srsAdams"].Points.Clear();

            for (int i = 0, n = _currCauchyTask.ResultAdamsMethod.Length; i < n; i++)
                this.chtGraph.Series["srsAdams"].Points.AddXY(_currCauchyTask.ResultAdamsMethod[i].Arg, _currCauchyTask.ResultAdamsMethod[i].Func);  
        }
       
        private void FillTable()
        {
            dGV_Results.Rows.Clear();
            SortedSet<double> args = new SortedSet<double>();
            if (_currCauchyTask.ResultEulerMethod != null)
                for (int i = 0, n = _currCauchyTask.ResultEulerMethod.Length; i < n; i++)
                    args.Add(_currCauchyTask.ResultEulerMethod[i].Arg);

            if (_currCauchyTask.ResultEulerCauchyMethod != null)
                for (int i = 0, n = _currCauchyTask.ResultEulerCauchyMethod.Length; i < n; i++)
                    args.Add(_currCauchyTask.ResultEulerCauchyMethod[i].Arg);

            if (_currCauchyTask.ResultEulerMethodCorr != null)
                for (int i = 0, n = _currCauchyTask.ResultEulerMethodCorr.Length; i < n; i++)
                    args.Add(_currCauchyTask.ResultEulerMethodCorr[i].Arg);

            if (_currCauchyTask.ResultRungeKuttaMethod != null)
                for (int i = 0, n = _currCauchyTask.ResultRungeKuttaMethod.Length; i < n; i++)
                    args.Add(_currCauchyTask.ResultRungeKuttaMethod[i].Arg);

            if (_currCauchyTask.ResultAdamsMethod != null)
                for (int i = 0, n = _currCauchyTask.ResultAdamsMethod.Length; i < n; i++)
                    args.Add(_currCauchyTask.ResultAdamsMethod[i].Arg);
            if (args.Count > 0)
            {
                dGV_Results.RowCount = args.Count + 1;
                int numRow = 0;
                bool  theres_exact_sol;
                foreach (double arg in args)
                {
                    dGV_Results.Rows[numRow].HeaderCell.Value = numRow;
                    dGV_Results.Rows[numRow++].Cells["clnX"].Value = arg;
                }
                if (theres_exact_sol = (_currCauchyTask.ExactSolution != null))
                {                
                    numRow = 0;
                    foreach (double arg in args)
                        dGV_Results.Rows[numRow++].Cells["clnExactSol"].Value = _currCauchyTask.ExactSolution(arg);
                }
                
                int numPoint = -1;
                if (_currCauchyTask.ResultEulerMethod != null)
                {
                    numRow = 0;
                    foreach (double arg in args)
                    {
                        if (arg == _currCauchyTask.ResultEulerMethod[numPoint + 1].Arg)
                        {
                            dGV_Results.Rows[numRow++].Cells["clnEuler"].Value = _currCauchyTask.ResultEulerMethod[++numPoint].Func 
                                + ((theres_exact_sol) ? "\n (" + (_currCauchyTask.ExactSolution(_currCauchyTask.ResultEulerMethod[numPoint].Arg) - _currCauchyTask.ResultEulerMethod[numPoint].Func) + ")" : "");
                            if (numPoint == _currCauchyTask.ResultEulerMethod.Length - 1)
                                break;
                        }
                        else
                            numRow++;
                    }
                }

                if (_currCauchyTask.ResultEulerCauchyMethod != null)
                {
                    numRow = 0; numPoint = -1;
                    foreach (double arg in args)
                    {
                        if (arg == _currCauchyTask.ResultEulerCauchyMethod[numPoint + 1].Arg)
                        {
                            dGV_Results.Rows[numRow++].Cells["clnEulerCauchy"].Value = _currCauchyTask.ResultEulerCauchyMethod[++numPoint].Func
                                + ((theres_exact_sol) ? "\n (" + (_currCauchyTask.ExactSolution(_currCauchyTask.ResultEulerCauchyMethod[numPoint].Arg) - _currCauchyTask.ResultEulerCauchyMethod[numPoint].Func) + ")" : ""); 
                            if (numPoint == _currCauchyTask.ResultEulerCauchyMethod.Length - 1)
                                break;
                        }
                        else
                            numRow++;
                    }
                }

                if (_currCauchyTask.ResultEulerMethodCorr != null)
                {
                    numRow = 0; numPoint = -1;
                    foreach (double arg in args)
                    {
                        if (arg == _currCauchyTask.ResultEulerMethodCorr[numPoint + 1].Arg)
                        {
                            dGV_Results.Rows[numRow++].Cells["clnEulerWithCorrection"].Value = _currCauchyTask.ResultEulerMethodCorr[++numPoint].Func
                                + ((theres_exact_sol) ? "\n (" + (_currCauchyTask.ExactSolution(_currCauchyTask.ResultEulerMethodCorr[numPoint].Arg) - _currCauchyTask.ResultEulerMethodCorr[numPoint].Func) + ")" : "");
                            if (numPoint == _currCauchyTask.ResultEulerMethodCorr.Length - 1)
                                break;
                        }
                        else
                            numRow++;
                    }
                }

                if (_currCauchyTask.ResultRungeKuttaMethod != null)
                {
                    numRow = 0; numPoint = -1;
                    foreach (double arg in args)
                    {
                        if (arg == _currCauchyTask.ResultRungeKuttaMethod[numPoint + 1].Arg)
                        {
                            dGV_Results.Rows[numRow++].Cells["clnRungeKutta"].Value = _currCauchyTask.ResultRungeKuttaMethod[++numPoint].Func
                                + ((theres_exact_sol) ? "\n (" + (_currCauchyTask.ExactSolution(_currCauchyTask.ResultRungeKuttaMethod[numPoint].Arg) - _currCauchyTask.ResultRungeKuttaMethod[numPoint].Func) + ")" : "");
                            if (numPoint == _currCauchyTask.ResultRungeKuttaMethod.Length - 1)
                                break;
                        }
                        else
                            numRow++;
                    }
                }

                if (_currCauchyTask.ResultAdamsMethod != null)
                {
                    numRow = 0; numPoint = -1;
                    foreach (double arg in args)
                    {
                        if (arg == _currCauchyTask.ResultAdamsMethod[numPoint + 1].Arg)
                        {
                            dGV_Results.Rows[numRow++].Cells["clnAdams"].Value = _currCauchyTask.ResultAdamsMethod[++numPoint].Func
                                + ((theres_exact_sol) ? "\n (" + (_currCauchyTask.ExactSolution(_currCauchyTask.ResultAdamsMethod[numPoint].Arg) - _currCauchyTask.ResultAdamsMethod[numPoint].Func) + ")" : "");
                            if (numPoint == _currCauchyTask.ResultAdamsMethod.Length - 1)
                                break;
                        }
                        else
                            numRow++;
                    }
                }
                dGV_Results.Rows[dGV_Results.RowCount - 1].Cells["clnX"].Value = "Кількість точок: ";
                dGV_Results.Rows[dGV_Results.RowCount - 1].Cells["clnExactSol"].Value = (this._currCauchyTask.ExactSolution != null) ? args.Count.ToString() : "";
                dGV_Results.Rows[dGV_Results.RowCount - 1].Cells["clnEuler"].Value = (this._currCauchyTask.ResultEulerMethod != null) ? this._currCauchyTask.ResultEulerMethod.Length : 0;
                dGV_Results.Rows[dGV_Results.RowCount - 1].Cells["clnEulerCauchy"].Value = (this._currCauchyTask.ResultEulerCauchyMethod != null) ? this._currCauchyTask.ResultEulerCauchyMethod.Length : 0;
                dGV_Results.Rows[dGV_Results.RowCount - 1].Cells["clnEulerWithCorrection"].Value = (this._currCauchyTask.ResultEulerMethodCorr != null) ? this._currCauchyTask.ResultEulerMethodCorr.Length : 0;
                dGV_Results.Rows[dGV_Results.RowCount - 1].Cells["clnRungeKutta"].Value = (this._currCauchyTask.ResultRungeKuttaMethod != null) ? this._currCauchyTask.ResultRungeKuttaMethod.Length : 0;
                dGV_Results.Rows[dGV_Results.RowCount - 1].Cells["clnAdams"].Value = (this._currCauchyTask.ResultAdamsMethod != null) ? this._currCauchyTask.ResultAdamsMethod.Length : 0;
            }
        }

        private void txB_B_Validated(object sender, EventArgs e)
        {

        }

        private void txB_x0_Validated(object sender, EventArgs e)
        {

        }

        private void btnResolve_Click(object sender, EventArgs e)
        {
            if (_currCauchyTask == null)
            {
                MessageBox.Show("Оберіть зі списку або додайте нову задачу");
                return;
            }

            if (rdB_Euler.Checked)
                if (_currCauchyTask.ReSolutionEulerMethod((ushort)nUD_CountPartition.Value))
                {
                    FillTable();
                    ReDrawGraphOfEuler();
                }
                else                
                    MessageBox.Show("Помилка у методі Ейлера");
                

            if (rdB_EulerCauchy.Checked)
                if (_currCauchyTask.ReSolutionEulerCauchyMethod((ushort)nUD_CountPartition.Value))
                {
                    FillTable();
                    ReDrawGraphOfEulerCauchy();                    
                }
                else
                    MessageBox.Show("Помилка у методі Ейлера-Коші");

            if (rdB_EulerWithCorrection.Checked)
            {
                uint k;
                if (_currCauchyTask.ReSolutionEulerMethodCorr((ushort)nUD_CountPartition.Value, _oldEps, out k))
                {
                    FillTable();
                    ReDrawGraphOfEulerCorr();
                    MessageBox.Show("Метод Ейлера з уточненням здійснив " + k + " ітерацій");
                }
                else
                    MessageBox.Show("Помилка у методі Ейлера з уточненням");
            }
            if (rdB_RungeKutta.Checked)
                if (chB_AutoStep.Checked)
                {
                    double[,] k;
                    if (_currCauchyTask.ReSolutionRungeKutta((ushort)nUD_CountPartition.Value, _oldEps, true, out k))
                    {
                        FillTable();
                        ReDrawGraphOfRungeKutta();
                        MessageBox.Show("Кількість кроків у методі Рунге-Кутта з автовибором кроку: " + _currCauchyTask.ResultRungeKuttaMethod.Length);
                        //string coefficients = "";
                        //for (int i = 0, n = k.GetLength(0); i < n; i++)
                        //    coefficients += "\n к" + NumberToLowIndex(i + 1) + "," + NumberToLowIndex(1) + " = " + k[i, 0]
                        //                   + "; k" + NumberToLowIndex(i + 1) + "," + NumberToLowIndex(2) + " = " + k[i, 1]
                        //                   + "; k" + NumberToLowIndex(i + 1) + "," + NumberToLowIndex(3) + " = " + k[i, 2] + ";";   

                        //MessageBox.Show("Коефіціенти у методі Рунге-Кутта:" + coefficients);
                    }
                    else
                        MessageBox.Show("Помилка у методі Рунге-Кутта з автокроком");
                }
                else
                {
                    double[,] k;
                    if (_currCauchyTask.ReSolutionRungeKutta((ushort)nUD_CountPartition.Value, _oldEps, false, out k))
                    {
                        FillTable();
                        ReDrawGraphOfRungeKutta();
                        string coefficients = "";
                        for (int i = 0, n = k.GetLength(0); i < n; i++)
                            coefficients += "\n к" + NumberToLowIndex(i + 1) + "," + NumberToLowIndex(1) + " = " + k[i, 0]
                                           + "; k" + NumberToLowIndex(i + 1) + "," + NumberToLowIndex(2) + " = " + k[i, 1]
                                           + "; k" + NumberToLowIndex(i + 1) + "," + NumberToLowIndex(3) + " = " + k[i, 2] + ";";

                        MessageBox.Show("Коефіціенти у методі Рунге-Кутта:" + coefficients);
                    }
                    else
                        MessageBox.Show("Помилка у методі Рунге-Кутта з фіксованим кроком");
                }
            if (rdB_Adams.Checked)
                if (_currCauchyTask.ReSolutionAdams((ushort)nUD_CountPartition.Value, _oldEps))
                {
                    FillTable();
                    ReDrawGraphOfAdams();
                }
                else
                    MessageBox.Show("Помилка у методі Aдамса");
        }

        private void dGV_Results_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dGV_Results.Dock = (dGV_Results.Dock == DockStyle.None) ? DockStyle.Bottom : DockStyle.None;
        }

        private void chB_ExactSolGraph_CheckedChanged(object sender, EventArgs e)
        {
            chtGraph.Series["srsExactSol"].Enabled = chB_ExactSolGraph.Checked;
        }       
    }
}
