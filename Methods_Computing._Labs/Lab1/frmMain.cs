using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class frmMain : Form
    {
        #region Поля
        private LibraryFunc _libFunction;

        #endregion

        public frmMain()
        {
            InitializeComponent();
            _libFunction = new LibraryFunc();
            _libFunction.AddFuncAsText(cmB_ListFunc.Items[0].ToString());
            _libFunction.AddDerivativeOfFuncAsText(0, 1, "3*x*x + 3");
            _libFunction.AddDerivativeOfFuncAsText(0, 2, "6*x");           
            //_libFunction.AddIterFormAsText(0, 

            _libFunction.AddFuncAsText(cmB_ListFunc.Items[1].ToString());
            _libFunction.AddDerivativeOfFuncAsText(1, 1, "Math.Log(2) * Math.Pow(2, x) + 2 * x");
            _libFunction.AddDerivativeOfFuncAsText(1, 2, "Math.Log(2) * Math.Log(2) * Math.Pow(2, x) + 2");
            //_libFunction.AddIterFormAsText(1, 

            txB_InpA.Text = (-2).ToString();
            MethodsСorrectionValueZero_of_Function.A = -2;
            txB_InpB.Text = (2).ToString();
            MethodsСorrectionValueZero_of_Function.B = 2;
            txB_InpEps.Text = (0.001).ToString();
            MethodsСorrectionValueZero_of_Function.Eps = 0.001;
            cmB_ListFunc.SelectedIndex = 0;
        }        

        private void btnAddFunc_Click(object sender, EventArgs e)
        {
            txB_InpFunc.Visible = true;
            cmB_ListFunc.Visible = false;
            btnAddFunc.Visible = false;
            btnAcceptFunc.Visible = true;
            btnCancelInpFunc.Visible = true;
        }

        private void btnAcceptFunc_Click(object sender, EventArgs e)
        {
            if (_libFunction.AddFuncAsText(txB_InpFunc.Text))
            {
                cmB_ListFunc.Items.Add(txB_InpFunc.Text);
                cmB_ListFunc.SelectedIndex = cmB_ListFunc.Items.Count - 1;
                txB_InpFunc.Visible = false;
                cmB_ListFunc.Visible = true;
                btnAddFunc.Visible = true;
                btnAcceptFunc.Visible = false;
                btnCancelInpFunc.Visible = false;
            }
            else
            {
                txB_InpFunc.ForeColor = Color.Red;
                txB_InpFunc.Focus();
            }
        }

        private void btnCancelInpFunc_Click(object sender, EventArgs e)
        {
            txB_InpFunc.Visible = false;
            cmB_ListFunc.Visible = true;
            btnAddFunc.Visible = true;
            btnAcceptFunc.Visible = false;
            btnCancelInpFunc.Visible = false;
        }

        private void cmB_ListFunc_SelectedIndexChanged(object sender, EventArgs e)
        {
            txB_Inp_derF.Text = _libFunction.GetTextDerivativeOfFunc((uint)cmB_ListFunc.SelectedIndex, 1);
            txB_Inp_der2F.Text = _libFunction.GetTextDerivativeOfFunc((uint)cmB_ListFunc.SelectedIndex, 2);
            txB_Inp_iterForm.Text = _libFunction.GetTextIterForm((uint)cmB_ListFunc.SelectedIndex);
            try
            {
                //double a = Convert.ToDouble(txB_InpA.Text);
                //double b = Convert.ToDouble(txB_InpB.Text);
                //double eps = Convert.ToDouble(txB_InpEps.Text);
                //ReDrawGraphics(a, b, eps);
                ReDrawGraphics(MethodsСorrectionValueZero_of_Function.A, MethodsСorrectionValueZero_of_Function.B, MethodsСorrectionValueZero_of_Function.Eps);
            }
            catch (Exception)
            {
            }            
        }

        private void ReDrawGraphics(double a, double b, double eps)
        {
            chtGraph.Series["srs_Ox"].Points.Clear();
            if (! double.IsNaN(a))
                chtGraph.Series["srs_Ox"].Points.AddXY(a, 0);
            if (! double.IsNaN(b))
                chtGraph.Series["srs_Ox"].Points.AddXY(b, 0);
            DrawGraph(_libFunction.GetFunc((uint)cmB_ListFunc.SelectedIndex), chtGraph.Series[0].Name, a, b, eps);
            DrawGraph(_libFunction.GetDerivativeOfFunc((uint)cmB_ListFunc.SelectedIndex, 1), chtGraph.Series[1].Name, a, b, eps);
            DrawGraph(_libFunction.GetDerivativeOfFunc((uint)cmB_ListFunc.SelectedIndex, 2), chtGraph.Series[2].Name, a, b, eps);
            DrawGraph(_libFunction.GetIterForm((uint)cmB_ListFunc.SelectedIndex), chtGraph.Series[3].Name, a, b, eps);
            //chtGraph.Series["srs_Oy"].Points.Clear();
            //chtGraph.Series["srs_Oy"].Points.AddXY(0, chtGraph.ChartAreas[0].Axes[1].Minimum);
            //chtGraph.Series["srs_Oy"].Points.AddXY(0, chtGraph.ChartAreas[0].Axes[1].Maximum);
        }

        private void cmB_ListFunc_Leave(object sender, EventArgs e)
        {

        }

        private void DrawGraph(Func<double, double> f, string nameSeries, double a, double b, double step)
        {
            if (chtGraph.Series.IndexOf(nameSeries) >= 0)
            {                
                chtGraph.Series[nameSeries].Points.Clear();
                if ((f != null) && (a <= b) && (step > 0))
                {
                    chtGraph.ChartAreas[0].Axes[0].Minimum = a;
                    chtGraph.ChartAreas[0].Axes[0].Maximum = b;
                    int i = 0;
                    double i_value_x = a;
                    do
                    {
                        try
                        {                            
                            chtGraph.Series[nameSeries].Points.AddXY(i_value_x, f(i_value_x));
                        }
                        catch (Exception) { }                        
                        i_value_x += ++i * step;
                    }
                    while (i_value_x < b);
                    try
                    {
                        chtGraph.Series[nameSeries].Points.AddXY(b, f(b));
                    }
                    catch (Exception) { }
                }
            }
        }

        private void chB_drawDerivFunc_CheckedChanged(object sender, EventArgs e)
        {
            chtGraph.Series[1].Enabled = chB_drawDerivFunc.Checked;
        }

        private void chB_drawDeriv2Func_CheckedChanged(object sender, EventArgs e)
        {
            chtGraph.Series[2].Enabled = chB_drawDeriv2Func.Checked;
        }

        private void btnChangeDerFunc_Click(object sender, EventArgs e)
        {
            btnChangeDerFunc.Visible = false;
            txB_Inp_derF.ReadOnly = false;
            txB_Inp_derF.Focus();
        }

        private void txB_Inp_derF_Leave(object sender, EventArgs e)
        {
            if (txB_Inp_derF.ReadOnly == false)
                try
                {
                    if (_libFunction.GetDerivativeOfFunc((uint)cmB_ListFunc.SelectedIndex, 1) == null)
                        if (_libFunction.AddDerivativeOfFuncAsText((uint)cmB_ListFunc.SelectedIndex, 1, txB_Inp_derF.Text))
                        {
                            btnChangeDerFunc.BackColor = Color.FromArgb(200, 255, 200);
                            DrawGraph(_libFunction.GetDerivativeOfFunc((uint)cmB_ListFunc.SelectedIndex, 1), chtGraph.Series[1].Name, Convert.ToDouble(txB_InpA.Text), Convert.ToDouble(txB_InpB.Text), Convert.ToDouble(txB_InpEps.Text));
                        }
                        else
                        {
                            btnChangeDerFunc.BackColor = Color.FromArgb(255, 200, 200);
                            txB_Inp_derF.Text = "";
                        }
                    else
                        if (_libFunction.ChangeDerivativeOfFuncAsText((uint)cmB_ListFunc.SelectedIndex, 1, txB_Inp_derF.Text))
                        {
                            btnChangeDerFunc.BackColor = Color.FromArgb(200, 255, 200);
                            DrawGraph(_libFunction.GetDerivativeOfFunc((uint)cmB_ListFunc.SelectedIndex, 1), chtGraph.Series[1].Name, Convert.ToDouble(txB_InpA.Text), Convert.ToDouble(txB_InpB.Text), Convert.ToDouble(txB_InpEps.Text));
                        }
                        else
                        {
                            btnChangeDerFunc.BackColor = Color.FromArgb(255, 200, 200);
                            txB_Inp_derF.Text = _libFunction.GetTextDerivativeOfFunc((uint)cmB_ListFunc.SelectedIndex, 1);
                        }
                }
                finally
                {
                    txB_Inp_derF.ReadOnly = true;
                    btnChangeDerFunc.Visible = true;
                }
        }

        private void btnChangeDer2Func_Click(object sender, EventArgs e)
        {
            btnChangeDer2Func.Visible = false;
            txB_Inp_der2F.ReadOnly = false;
            txB_Inp_der2F.Focus();
        }

        private void txB_Inp_der2F_Leave(object sender, EventArgs e)
        {
            if (txB_Inp_der2F.ReadOnly == false)
                try
                {
                    if (_libFunction.GetDerivativeOfFunc((uint)cmB_ListFunc.SelectedIndex, 2) == null)
                        if (_libFunction.AddDerivativeOfFuncAsText((uint)cmB_ListFunc.SelectedIndex, 2, txB_Inp_der2F.Text))
                        {
                            btnChangeDer2Func.BackColor = Color.FromArgb(200, 255, 200);
                            DrawGraph(_libFunction.GetDerivativeOfFunc((uint)cmB_ListFunc.SelectedIndex, 2), chtGraph.Series[2].Name, Convert.ToDouble(txB_InpA.Text), Convert.ToDouble(txB_InpB.Text), Convert.ToDouble(txB_InpEps.Text));
                        }
                        else
                        {
                            btnChangeDer2Func.BackColor = Color.FromArgb(255, 200, 200);
                            txB_Inp_der2F.Text = "";
                        }
                    else
                        if (_libFunction.ChangeDerivativeOfFuncAsText((uint)cmB_ListFunc.SelectedIndex, 2, txB_Inp_der2F.Text))
                        {
                            btnChangeDer2Func.BackColor = Color.FromArgb(200, 255, 200);
                            DrawGraph(_libFunction.GetDerivativeOfFunc((uint)cmB_ListFunc.SelectedIndex, 2), chtGraph.Series[2].Name, Convert.ToDouble(txB_InpA.Text), Convert.ToDouble(txB_InpB.Text), Convert.ToDouble(txB_InpEps.Text));
                        }
                        else
                        {
                            btnChangeDer2Func.BackColor = Color.FromArgb(255, 200, 200);
                            txB_Inp_der2F.Text = _libFunction.GetTextDerivativeOfFunc((uint)cmB_ListFunc.SelectedIndex, 2);
                        }
                }
                finally
                {
                    txB_Inp_der2F.ReadOnly = true;
                    btnChangeDer2Func.Visible = true;
                }
        }        

        private void txB_Inp_derF_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.txB_Inp_derF_Leave(sender, new EventArgs());
        }

        private void txB_Inp_der2F_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.txB_Inp_der2F_Leave(sender, new EventArgs());
        }

        private void txB_InpIterForm_Leave(object sender, EventArgs e)
        {
            if (txB_Inp_iterForm.ReadOnly == false)
                try
                {
                    if (_libFunction.GetIterForm((uint)cmB_ListFunc.SelectedIndex) == null)
                        if (_libFunction.AddIterFormAsText((uint)cmB_ListFunc.SelectedIndex, txB_Inp_iterForm.Text))
                        {
                            btnChangeIterForm.BackColor = Color.FromArgb(200, 255, 200);
                            DrawGraph(_libFunction.GetIterForm((uint)cmB_ListFunc.SelectedIndex), chtGraph.Series[3].Name, Convert.ToDouble(txB_InpA.Text), Convert.ToDouble(txB_InpB.Text), Convert.ToDouble(txB_InpEps.Text));
                        }
                        else
                        {
                            btnChangeIterForm.BackColor = Color.FromArgb(255, 200, 200);
                            txB_Inp_iterForm.Text = "";
                        }
                    else
                        if (_libFunction.ChangeIterFormAsText((uint)cmB_ListFunc.SelectedIndex, txB_Inp_iterForm.Text))
                        {
                            btnChangeIterForm.BackColor = Color.FromArgb(200, 255, 200);
                            DrawGraph(_libFunction.GetIterForm((uint)cmB_ListFunc.SelectedIndex), chtGraph.Series[3].Name, Convert.ToDouble(txB_InpA.Text), Convert.ToDouble(txB_InpB.Text), Convert.ToDouble(txB_InpEps.Text));
                        }
                        else
                        {
                            btnChangeIterForm.BackColor = Color.FromArgb(255, 200, 200);
                            txB_Inp_iterForm.Text = _libFunction.GetTextIterForm((uint)cmB_ListFunc.SelectedIndex);
                        }
                }
                finally
                {
                    txB_Inp_iterForm.ReadOnly = true;
                    btnChangeIterForm.Visible = true;
                }
        }

        private void btnChangeIterForm_Click(object sender, EventArgs e)
        {
            btnChangeIterForm.Visible = false;
            txB_Inp_iterForm.ReadOnly = false;
            txB_Inp_iterForm.Focus();
        }

        private void chB_drawIterForm_CheckedChanged(object sender, EventArgs e)
        {
            chtGraph.Series[3].Enabled = chB_drawIterForm.Checked;
        }

        private void btnCalc_mHalfInterval_Click(object sender, EventArgs e)
        {                
            List<MethodsСorrectionValueZero_of_Function.M_Info> info;
            try
            {
                double result = MethodsСorrectionValueZero_of_Function.M_HalfInterval(_libFunction.GetFunc((uint)cmB_ListFunc.SelectedIndex), out info);
                if (! double.IsNaN(result))
                    lbl_Result_mHalfInterval.Text = "x* = " + result.ToString();
                dGV_mHalfInterval.RowCount = info.Count;
                for (int i = 0; i < info.Count; i++)
                {
                    dGV_mHalfInterval.Rows[i].Cells[0].Value = info[i].Iteration;
                    dGV_mHalfInterval.Rows[i].Cells[1].Value = info[i].Value_x;
                    dGV_mHalfInterval.Rows[i].Cells[2].Value = info[i].Estim;
                }
            }
            catch (Exception) { }
        }

        private void btnCalc_mFixedPointIteration_Click(object sender, EventArgs e)
        {   
            Func<double, double> itF;
            if ((itF = _libFunction.GetIterForm((uint)cmB_ListFunc.SelectedIndex)) != null)
            {
                List<MethodsСorrectionValueZero_of_Function.M_Info> info;
                try
                {
                    double result = MethodsСorrectionValueZero_of_Function.M_FixedPointIteration(itF, out info);
                    if (! double.IsNaN(result))
                        lbl_Result_mFixedPointIteration.Text = "x* = " + result.ToString();
                    dGV_mFixedPointIteration.RowCount = info.Count;
                    for (int i = 0; i < info.Count; i++)
                    {
                        dGV_mFixedPointIteration.Rows[i].Cells[0].Value = info[i].Iteration;
                        dGV_mFixedPointIteration.Rows[i].Cells[1].Value = info[i].Value_x;
                        dGV_mFixedPointIteration.Rows[i].Cells[2].Value = info[i].Estim;
                    }
                }
                catch (Exception) { }
            }
            else
                MessageBox.Show("Введіть коректне значення текстового вигляду ітераційної формулы для цієї функції");
        }

        private void btnCalc_mChord_Click(object sender, EventArgs e)
        {
            Func<double, double> der2F;
            if ((der2F = _libFunction.GetDerivativeOfFunc((uint)cmB_ListFunc.SelectedIndex, 2)) != null)
            {
                try
                {
                    List<MethodsСorrectionValueZero_of_Function.M_Info> info;
                    double result = MethodsСorrectionValueZero_of_Function.M_Chord(_libFunction.GetFunc((uint)cmB_ListFunc.SelectedIndex), der2F, out info);
                    if (! double.IsNaN(result))
                        lbl_Result_mChord.Text = "x* = " + result.ToString();
                    dGV_mChord.RowCount = info.Count;
                    for (int i = 0; i < info.Count; i++)
                    {
                        dGV_mChord.Rows[i].Cells[0].Value = info[i].Iteration;
                        dGV_mChord.Rows[i].Cells[1].Value = info[i].Value_x;
                        dGV_mChord.Rows[i].Cells[2].Value = info[i].Estim;
                    }
                }
                catch (Exception) { }
            }
            else
                MessageBox.Show("Введіть коректне значення текстового вигляду другої похідної для цієї функції");
        }

        private void btnCalc_mNewton_Click(object sender, EventArgs e)
        {
            Func<double, double> der2F;
            if ((der2F = _libFunction.GetDerivativeOfFunc((uint)cmB_ListFunc.SelectedIndex, 2)) != null)
            {
                Func<double, double> derF;
                if ((derF = _libFunction.GetDerivativeOfFunc((uint)cmB_ListFunc.SelectedIndex, 1)) != null)
                {
                    try
                    {
                        List<MethodsСorrectionValueZero_of_Function.M_Info> info;
                        double result = MethodsСorrectionValueZero_of_Function.M_Newton(_libFunction.GetFunc((uint)cmB_ListFunc.SelectedIndex), derF, der2F, out info);
                        if (! double.IsNaN(result))
                            lbl_Result_mNewton.Text = "x* = " + result.ToString();
                        dGV_mNewton.RowCount = info.Count;
                        for (int i = 0; i < info.Count; i++)
                        {
                            dGV_mNewton.Rows[i].Cells[0].Value = info[i].Iteration;
                            dGV_mNewton.Rows[i].Cells[1].Value = info[i].Value_x;
                            dGV_mNewton.Rows[i].Cells[2].Value = info[i].Estim;
                        }
                    }
                    catch (Exception) { }
                }
                else
                    MessageBox.Show("Введіть коректне значення текстового вигляду другої похідної для цієї функції");
            }
            else
                MessageBox.Show("Введіть коректне значення текстового вигляду другої похідної для цієї функції");
        }
        
        private void txB_InpA_Leave(object sender, EventArgs e)
        {
            try
            {
                MethodsСorrectionValueZero_of_Function.A = Convert.ToDouble(txB_InpA.Text);
                ReDrawGraphics(MethodsСorrectionValueZero_of_Function.A, MethodsСorrectionValueZero_of_Function.B, MethodsСorrectionValueZero_of_Function.Eps);
            }
            catch (Exception)
            {
                txB_InpA.Text = MethodsСorrectionValueZero_of_Function.A.ToString();
            }
        }

        private void txB_InpB_Leave(object sender, EventArgs e)
        {
            try
            {
                MethodsСorrectionValueZero_of_Function.B = Convert.ToDouble(txB_InpB.Text);
                ReDrawGraphics(MethodsСorrectionValueZero_of_Function.A, MethodsСorrectionValueZero_of_Function.B, MethodsСorrectionValueZero_of_Function.Eps);
            }
            catch (Exception)
            {
                txB_InpB.Text = MethodsСorrectionValueZero_of_Function.B.ToString();
            }
        }

        private void txB_InpEps_Leave(object sender, EventArgs e)
        {
            try
            {
                MethodsСorrectionValueZero_of_Function.Eps = Convert.ToDouble(txB_InpEps.Text);
                ReDrawGraphics(MethodsСorrectionValueZero_of_Function.A, MethodsСorrectionValueZero_of_Function.B, MethodsСorrectionValueZero_of_Function.Eps);
            }
            catch (Exception)
            {
                txB_InpEps.Text = MethodsСorrectionValueZero_of_Function.Eps.ToString();
            }
        }        
    }
}
