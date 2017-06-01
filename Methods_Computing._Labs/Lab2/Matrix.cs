using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Matrix2D
    {
        public const int MAXCOUNTROWS = ushort.MaxValue,
                         MAXCOUNTCOLUMNS = ushort.MaxValue;

        private double[,] _matrixElements;

        public int RowCount
        {
            get
            {
                return _matrixElements.GetLength(0);
            }
        }

        public int ColCount
        {
            get
            {
                return _matrixElements.GetLength(1);
            }
        }

        public double GetElement(int indexRow, int indexCol)
        {
            if ((indexRow >= 0) && (indexRow < this.RowCount) && (indexCol >= 0) && (indexCol < this.ColCount))
                return _matrixElements[indexRow, indexCol];
            else
                return double.NaN;
        }

        public double[] GetRow(int index)
        {
            if ((index >= 0) && (index < this.RowCount))
            {
                double[] result = new double[this.ColCount];
                for (int j = 0; j < result.Length; j++)
                    result[j] = this._matrixElements[index, j];
                return result;
            }
            else
                return null;
        }

        public double[] GetColumn(int index)
        {
            if ((index >= 0) && (index < this.ColCount))
            {
                double[] result = new double[this.RowCount];
                for (int i = 0; i < result.Length; i++)
                    result[i] = this._matrixElements[i, index];
                return result;
            }
            else
                return null;
        }

        public bool SetElement(double newValue, int indexRow, int indexCol)
        {
            if ((indexRow >= 0) && (indexRow < this.RowCount) && (indexCol >= 0) && (indexCol < this.ColCount))
            {
                this._matrixElements[indexRow, indexCol] = newValue;
                return true;
            }
            else
                return false;
        }

        public bool SetRow(double[] newRow, int index)
        {
            if ((index >= 0) && (index < this.RowCount) && (newRow.Length == this.RowCount))
            {
                for (int j = 0; j < newRow.Length; j++)
                    this._matrixElements[index, j] = newRow[j];

                return true;
            }
            else
                return false;
        }

        public bool SetColumn(double[] newColumn, int index)
        {
            if ((index >= 0) && (index < this.ColCount) && (newColumn.Length == this.ColCount))
            {
                for (int i = 0; i < newColumn.Length; i++)
                    this._matrixElements[i, index] = newColumn[i];

                return true;
            }
            else
                return false;
        }

        public static Matrix2D operator *(double alfa, Matrix2D m)
        {          
            Matrix2D result = new Matrix2D((ushort)m.RowCount, (ushort)m.ColCount);
            for (int i = 0; i < result.RowCount; i++)
                for (int j = 0; j < result.ColCount; j++)
                    result._matrixElements[i, j] *= alfa;
            return result;
        }

        public static Matrix2D operator *(Matrix2D m, double alfa)
        {
            return alfa * m;
        }

        public static Matrix2D operator *(Matrix2D m, Vector v)
        {
            if (m.ColCount == v.Length)
            {
                Matrix2D result = new Matrix2D(m.RowCount, 1);
                for (int i = 0; i < result.RowCount; i++)
                    for (int k = 0; k < v.Length; k++)
                        result._matrixElements[i, 0] += m._matrixElements[i, k] * v[k];

                return result;
            }
            else
                return null;
        }

        public static Matrix2D operator *(Vector v, Matrix2D m)
        {
            if (v.Length == m.RowCount)
            {
                Matrix2D result = new Matrix2D(1, m.ColCount);
                for (int j = 0; j < result.ColCount; j++)
                    for (int k = 0; k < v.Length; k++)
                        result._matrixElements[0, j] += m._matrixElements[k, j] * v[k];

                return result;
            }
            else
                return null;
        }

        public static Matrix2D operator *(Matrix2D leftMatrix, Matrix2D rightMatrix)
        {
            if (leftMatrix.ColCount == rightMatrix.RowCount)
            {
                Matrix2D result = new Matrix2D(leftMatrix.RowCount, rightMatrix.ColCount);
                for (int i = 0; i < result.RowCount; i++)
                    for (int j = 0; j < result.ColCount; j++)
                        for (int k = 0; k < leftMatrix.ColCount; k++)
                            result._matrixElements[i, j] += leftMatrix._matrixElements[i, k] * rightMatrix._matrixElements[k, j];

                return result;
            }
            else
                return null; //лучше бросить специальное исключение  
        }

        public static Matrix2D operator +(Matrix2D leftMatrix, Matrix2D rightMatrix)
        {
            if ((leftMatrix.RowCount == rightMatrix.RowCount) && (leftMatrix.ColCount == rightMatrix.ColCount))
            {
                Matrix2D result = new Matrix2D((ushort)leftMatrix.RowCount, (ushort)leftMatrix.ColCount);
                for (int i = 0; i < result.RowCount; i++)
                    for (int j = 0; j < result.ColCount; j++)
                        result._matrixElements[i, j] = leftMatrix._matrixElements[i, j] + rightMatrix._matrixElements[i, j];
                return result;
            }
            else
                return null; //лучше бросить специальное исключение  
        }

        public static bool operator ==(Matrix2D leftMatrix, Matrix2D rightMatrix)
        {
            if ((leftMatrix.RowCount == rightMatrix.RowCount) && (leftMatrix.ColCount == rightMatrix.ColCount))
            {
                for (int i = 0; i < leftMatrix.RowCount; i++)
                    for (int j = 0; j < leftMatrix.ColCount; j++)
                        if (leftMatrix._matrixElements[i, j] != rightMatrix._matrixElements[i, j])
                            return false;
            }
            else
                return false; //лучше бросить специальное исключение    

            return true;
        }

        public static bool operator !=(Matrix2D leftMatrix, Matrix2D rightMatrix)
        {
            return !(leftMatrix == rightMatrix);
        }

        public double[,] To2DArray() //проверить
        {
            double[,] res = new double[this.RowCount, this.ColCount];
            this._matrixElements.CopyTo(res, 0);                                               //???
            return res;
        }

        public Matrix2D Copy()
        {
            return new Matrix2D(this._matrixElements);
        }

        public static Matrix2D CreateMatrix(int rowcount, int colcount)
        {
            if ((rowcount > 0) && (colcount > 0) && (rowcount <= MAXCOUNTROWS) && (colcount <= MAXCOUNTCOLUMNS))
                return new Matrix2D(rowcount, colcount);
            else
                return null; //лучше бросить специальное исключение                    
        }

        public static Matrix2D CreateMatrix(double[,] matrixElements)
        {
            if ((matrixElements != null) && (matrixElements.GetLength(0) <= MAXCOUNTROWS) && (matrixElements.GetLength(1) <= MAXCOUNTCOLUMNS)) 
                return new Matrix2D(matrixElements);
            else
                return null;  //в случае некорректного двумерного массива лучше бросать исключение, так метод не будет немым
        }

        private Matrix2D(int rowcount, int colcount)
        {
            _matrixElements = new double[rowcount, colcount];
        }

        private Matrix2D(double[,] matrixElements)
            :this(matrixElements.GetLength(0), matrixElements.GetLength(1))
        {
            int rowcount = matrixElements.GetLength(0),
                colcount = matrixElements.GetLength(1);
            for(int i = 0; i < rowcount; i++)
                for(int j = 0; j < colcount; j++)
                    _matrixElements[i, j] = matrixElements[i, j];
        }
    }
}
