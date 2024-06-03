using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simplex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int constraintsCount = 0;
        int variablesCount = 0;
              
        void fillConstraintsGrid()//заполнение таблицы с коэффициентами ограничений
        {
            constraintsGridView.Rows.Clear();
            constraintsGridView.ColumnCount = variablesCount + 2;
            constraintsGridView.RowHeadersVisible = false;
            for (int i = 0; i < variablesCount + 2; i++)
            {
                constraintsGridView.Columns[i].Width = 50;
                constraintsGridView.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                if (i < variablesCount)
                {
                    constraintsGridView.Columns[i].Name = "x" + (i + 1).ToString();
                }
                else if (i == variablesCount)
                {
                    constraintsGridView.Columns[i].Name = "Знак";
                }

            }
            for (int i = 0; i < constraintsCount; i++)
            {
                string[] row = new string[variablesCount + 2];
                constraintsGridView.Rows.Add(row);
                constraintsGridView.Rows[i].Height = 20;
            }
        }
        void fillFunctionGrid()//заполнение таблицы с коэффициентами ограничений
        {
            functionGridView.Rows.Clear();
            functionGridView.ColumnCount = variablesCount + 1;
            functionGridView.RowHeadersVisible = false;
            for (int i = 0; i < variablesCount + 1; i++)
            {
                functionGridView.Columns[i].Width = 50;
                functionGridView.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                if (i < variablesCount)
                {
                    functionGridView.Columns[i].Name = "x" + (i + 1).ToString();
                }
                else
                {
                    functionGridView.Columns[i].Name = "C";
                }

            }
            string[] row = new string[variablesCount + 2];
            constraintsGridView.Rows.Add(row);
            constraintsGridView.Rows[0].Height = 20;

        }

        void Proceed()//расчёт ответа
        {
            Constraint[] constraints = new Constraint[constraintsCount];
            for (int i = 0; i < constraintsCount; i++)
            {
                double[] variables = new double[variablesCount];
                double b = Convert.ToDouble(constraintsGridView.Rows[i].Cells[variablesCount + 1].Value);
                string sign = Convert.ToString(constraintsGridView.Rows[i].Cells[variablesCount].Value);
                for (int j = 0; j < variablesCount; j++)
                {
                    variables[j] = Convert.ToDouble(constraintsGridView.Rows[i].Cells[j].Value);
                }
                constraints[i] = new Constraint(variables, b, sign);
            }
            double[] functionVariables = new double[variablesCount];
            for (int i = 0; i < variablesCount; i++)
            {
                functionVariables[i] = Convert.ToDouble(functionGridView.Rows[0].Cells[i].Value);
            }
            double c = Convert.ToDouble(functionGridView.Rows[0].Cells[variablesCount].Value);

            bool isExtrMax = extrComboBox.SelectedIndex == 0;

            Function function = new Function(functionVariables, c, isExtrMax);

            Simplex simplex = new Simplex(function, constraints);

            Tuple<List<SimplexSnap>, SimplexResult> result = simplex.GetResult();

            switch (result.Item2)
            {
                case SimplexResult.Found:
                    string extrStr = isExtrMax ? "max" : "min";
                    resultsLbl.Text = "Ответ: базисное решение оптимально, F" + extrStr + $" = {result.Item1.Last().fValue}";
                    break;
                case SimplexResult.Unbounded:
                    resultsLbl.Text = "Ответ: область допустимых решений неограниченна.";
                    break;
                case SimplexResult.NotYetFound:
                    resultsLbl.Text = "Ответ: базисное решение не оптимально.";
                    break;
            }

            ShowResultsGrid(result.Item1);

        }

        void ShowResultsGrid(List<SimplexSnap> snaps)//Заполнение таблицы с решением
        {
            resultsGridView.Rows.Clear();
            resultsGridView.ColumnCount = snaps.First().matrix.Length + 2;
            resultsGridView.RowHeadersVisible = false;
            resultsGridView.ColumnHeadersVisible = false;

            for (int i = 0; i < snaps.First().matrix.Length + 2; i++)
            {
                resultsGridView.Columns[i].Width = 50;
                resultsGridView.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            foreach (SimplexSnap snap in snaps)
            {
                string[] firstRow = new string[snaps.First().matrix.Length + 2];

                firstRow[0] = "Базис";
                firstRow[1] = "Свободный коэфициент";

                for (int i = 2; i < snaps.First().matrix.Length + 2; i++)
                {
                    firstRow[i] = $"x{i - 1}";
                }

                resultsGridView.Rows.Add(firstRow);

                for (int i = 0; i < snaps.First().C.Length; i++)
                {
                    string[] row = new string[snaps.First().matrix.Length + 2];
                    for (int j = 0; j < snaps.First().matrix.Length + 2; j++)
                    {
                       
                        if (j == 0)
                        {
                            row[j] = $"x{snap.C[i] + 1}";
                        }
                        
                        else if (j == 1)
                        {
                            row[j] = Round(snap.b[i]).ToString();
                        }
                        else
                        {
                            row[j] = Round(snap.matrix[j - 2][i]).ToString();
                        }
                    }
                    resultsGridView.Rows.Add(row);
                }
                string[] fRow = new string[snaps.First().matrix.Length + 2];
                fRow[0] = "F";
                fRow[1] = Round(snap.fValue).ToString();
                for (int i = 2; i < snaps.First().matrix.Length + 2; i++)
                {
                    fRow[i] = Round(snap.F[i - 2]).ToString();
                }
                resultsGridView.Rows.Add(fRow);

                string[] emptyRow = new string[snaps.First().matrix.Length + 2];
                resultsGridView.Rows.Add(emptyRow);
            }
        }

        double Round(double a)
        {
            return Math.Round(a, 2);
        }

        private void goBtn_Click(object sender, EventArgs e)
        {
            Proceed();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            nOfContraintsTextBox.Clear();
            nOfVariablesTextBox.Clear();
            resultsGridView.Columns.Clear();
            functionGridView.Columns.Clear();
            constraintsGridView.Columns.Clear();
            extrComboBox.SelectedIndex = -1;
            resultsLbl.ResetText();
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            try
            {
                constraintsCount = Convert.ToInt32(nOfContraintsTextBox.Text);
                variablesCount = Convert.ToInt32(nOfVariablesTextBox.Text);
                fillConstraintsGrid();
                fillFunctionGrid();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
    }
}
