using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab4
{
    public partial class Form1 : Form
    {

        private Random random = new Random();

        private int[,] matrixValues;

        private int currentMin = 0;

        private int currentMax = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void generateArray_Click(object sender, EventArgs e)
        {
            int rowsCount = 0;
            int colsCount = 0;
            try 
            {
                GetUserInputs(ref rowsCount, ref colsCount);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            FillMatrix(rowsCount, colsCount);
            ShowMatrixInWindow(rowsCount, colsCount);
        }

        private void GetUserInputs(ref int rowsCount, ref int colsCount)
        {
            rowsCount = int.Parse(rowsField.Text);
            colsCount = int.Parse(colsField.Text);
            validateInputs(rowsCount, colsCount);
            currentMin = int.Parse(minField.Text);
            currentMax = int.Parse(maxField.Text);
        }

        private void validateInputs(int rowsCount, int colsCount)
        {
            if (rowsCount < 1 || colsCount < 1)
            {
                throw new ArgumentException("Rows and cols both must be greater than 0");
            }
        }

        private void FillMatrix(int rowsCount, int colsCount)
        {
            matrixValues = new int[rowsCount, colsCount];
            for (int rowI = 0; rowI < matrixValues.GetLength(0); rowI++)
            {
                for (int colI = 0; colI < matrixValues.GetLength(1); colI++)
                {
                    matrixValues[rowI, colI] = random.Next(currentMin, currentMax);
                }
            }
        }

        private void ShowMatrixInWindow(int rowsCount, int colsCount)
        {
            matrix.RowCount = rowsCount;
            matrix.ColumnCount = colsCount;
            for (int rowI = 0; rowI < matrixValues.GetLength(0); rowI++)
            {
                for (int colI = 0; colI < matrixValues.GetLength(1); colI++)
                {
                    matrix.Rows[rowI].Cells[colI].Style.BackColor = Color.White;
                    matrix.Rows[rowI].Cells[colI].Value = matrixValues[rowI, colI];
                }
            }
            matrix.Show();
        }

        private void calculations_Click(object sender, EventArgs e)
        {
            int sumOfRowsThatDoNotHaveNegativeNumbers = CountSumOfRowsThatDoNotHaveNegativeNumbers();
            int minSumDiagonalSumAmongParalelToMainOne = FindMinDiagonalSumAmongParalelToMainOne();
            MessageBox.Show("1 sub task: " + sumOfRowsThatDoNotHaveNegativeNumbers + "\n" +
                "2 sub task: " + minSumDiagonalSumAmongParalelToMainOne);
        }

        private int CountSumOfRowsThatDoNotHaveNegativeNumbers()
        {
            int count = 0;
            for (int rowI = 0; rowI < matrixValues.GetLength(0); rowI++)
            {
                int rowCount = 0;
                bool negativeNumberWasFound = false;
                for (int colI = 0; colI < matrixValues.GetLength(1); colI++)
                {
                    if (matrixValues[rowI, colI] < 0)
                    {
                        negativeNumberWasFound = true;
                        break;
                    }
                    else
                    {
                        rowCount += matrixValues[rowI, colI];
                    }
                }
                if(!negativeNumberWasFound)
                {
                    count += rowCount;
                }
            }
            return count;
        }

        private int FindMinDiagonalSumAmongParalelToMainOne()
        {
            const int FIXED_STEP = 2;

            int minSum = currentMax * matrixValues.GetLength(1);

            int rowIStarter = 0;
            int colIStarter = 0;
            int diagonalsParalelTomainCounter = matrixValues.GetLength(0);

            if(matrixValues.GetLength(0) % 2 == 0)
            {
                diagonalsParalelTomainCounter = matrixValues.GetLength(0) - 1;
                rowIStarter = 1;
            }

            for (int diagonalCounter = 0; diagonalCounter < diagonalsParalelTomainCounter; diagonalCounter++)
            {
                int currentDiagonalSum = 0;

                for(int colI = colIStarter, rowI = rowIStarter; colI != rowIStarter + 1; colI++, rowI--)
                {
                    currentDiagonalSum += matrixValues[rowI, colI];
                    matrix.Rows[rowI].Cells[colI].Style.BackColor = Color.Red;
                }

                if(currentDiagonalSum < minSum)
                {
                    minSum = currentDiagonalSum;
                }

                if (rowIStarter + FIXED_STEP <= matrixValues.GetLength(0) - 1)
                {
                    rowIStarter += FIXED_STEP;
                }
                else 
                {
                    colIStarter += FIXED_STEP;
                }
            }
            return minSum;
        }

    }
}
