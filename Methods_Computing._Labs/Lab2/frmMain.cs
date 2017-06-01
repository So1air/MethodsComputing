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
        Dictionary<string, SystemOfLinearAlgebraicEquations> _SLAEs = new Dictionary<string,SystemOfLinearAlgebraicEquations>();

        string oldTextCell;

        public frmMain()
        {
            InitializeComponent();
            dataGridView1.ColumnCount = 20;
            dataGridView1.RowCount = 2;
            for(int i = 0; i < dataGridView1.ColumnCount; i++)            
                dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
        }

        private void dataGridView1_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs e)
        {
            if (e.StateChanged == DataGridViewElementStates.Selected)
                ;
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            oldTextCell = (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null) ? ("") : (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
            dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "";
            listBox1.Items.Add("CellEnter " + e.RowIndex + ":" + e.ColumnIndex);
        }

        private void dataGridView1_CellLeave(object sender, DataGridViewCellEventArgs e)
        {            
            listBox1.Items.Add("CellLeave " + e.RowIndex + ":" + e.ColumnIndex);
        }

        private void dataGridView1_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            double coef;
            if (double.TryParse(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString(), out coef))
                dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = ((e.ColumnIndex > 0) ? " + " : "") + coef.ToString() + "*x" + NumberToLowIndex(e.ColumnIndex + 1);
            else
                dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = oldTextCell;
            listBox1.Items.Add("CellValidated " + e.RowIndex + ":" + e.ColumnIndex);
        }

        private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {            
            listBox1.Items.Add("CellValidating " + e.RowIndex + ":" + e.ColumnIndex + " " + e.Cancel);
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
    }
}
