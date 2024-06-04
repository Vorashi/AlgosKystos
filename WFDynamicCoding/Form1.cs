namespace WFDynamicCoding
{
    public partial class Form1 : Form
    {
        public int stepsCount = 1;
        public double[,] matrix = { };
        public List<double[,]> matrixList = new List<double[,]>();

        public Form1()
        {
            InitializeComponent();
            // matrixDataGridView.Rows.Add(20, 22, 25);
            // matrixDataGridView.Rows.Add(20, 18, 23);
            // matrixDataGridView.Rows.Add(20, 17, 15);
            // matrixDataGridView.Rows.Add(18, 16, 19);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            matrixDataGridView.Rows.Add();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (matrixDataGridView.RowCount > 1)
            {
                matrixDataGridView.Rows.RemoveAt(matrixDataGridView.RowCount - 1);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            matrixDataGridView.Columns.Add(matrixDataGridView.ColumnCount.ToString(), $"П{matrixDataGridView.ColumnCount + 1}");
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (matrixDataGridView.ColumnCount > 1)
            {
                matrixDataGridView.Columns.RemoveAt(matrixDataGridView.ColumnCount - 1);
            }
        }
        private void setParamsBtn_Click(object sender, EventArgs e)
        {
            if (matrixDataGridView.RowCount < financesNumeric.Value)
            {
                while (matrixDataGridView.RowCount < financesNumeric.Value)
                {
                    matrixDataGridView.Rows.Add();
                }
            }
            else
            {
                while (matrixDataGridView.RowCount > financesNumeric.Value)
                {
                    matrixDataGridView.Rows.RemoveAt(matrixDataGridView.RowCount - 1);
                }
            }

            if (matrixDataGridView.ColumnCount < factoriesNumeric.Value)
            {
                while (matrixDataGridView.ColumnCount < factoriesNumeric.Value)
                {
                    matrixDataGridView.Columns.Add(matrixDataGridView.ColumnCount.ToString(), $"П{matrixDataGridView.ColumnCount + 1}");
                }
            }
            else
            {
                while (matrixDataGridView.ColumnCount > factoriesNumeric.Value)
                {
                    matrixDataGridView.Columns.RemoveAt(matrixDataGridView.ColumnCount - 1);
                }
            }
        }
        private void ResultBtn_Click(object sender, EventArgs e)
        {
            investListBox.Items.Clear();

            matrix = SetupMatrix();
            stepsCount = matrix.GetLength(1);
            int financesCount = matrix.GetLength(0);
            GetResult(out List<double[,]> matrixList, out int optIndex, out double optValue, out List<List<StepInfo>> finalValues);

            List<int> investments = new List<int>();
            investments.Add(optIndex);

            for (int i = stepsCount - 2; i >= 0; i--)
            {
                int currentInvestment = investments.Last() - finalValues[i][investments.Last()].MaxIndex;
                investments.Add(currentInvestment);
            }

            investments.Reverse();

            for (int i = 0; i < stepsCount; i++)
            {
                investListBox.Items.Add($"Вложить {investments[i] + 1} в П{i + 1}");
            }

            investListBox.Items.Add($"Максимальная прибыль = {optValue}");
        }
        /// <summary>
        /// Подготовка процентной матрицы
        /// </summary>
        public double[,] SetupMatrix()
        {
            double[,] newMatrix = new double[matrixDataGridView.RowCount + 1, matrixDataGridView.ColumnCount];

            for (int j = 0; j < newMatrix.GetLength(1); j++)
                newMatrix[0, j] = 0;

            for (int i = 1; i < newMatrix.GetLength(0); i++)

                for (int j = 0; j < newMatrix.GetLength(1); j++)

                    if (!double.TryParse(matrixDataGridView.Rows[i - 1].Cells[j].Value.ToString()!, out newMatrix[i, j]))
                        newMatrix[i, j] = 0;

                    else
                        newMatrix[i, j] = Math.Round(newMatrix[i, j] / 100 * i, 2);

            SpikeLine();
            PrintR(newMatrix, "NewMatrix");

            return newMatrix;
        }
        public struct StepInfo(int maxIndex, double max) : IComparable<StepInfo>, IComparable<double>
        {
            public double Max { get; set; } = max;
            public int MaxIndex { get; set; } = maxIndex;

            public readonly dynamic this[int index]
            {
                get
                {
                    if (index == 0)
                        return MaxIndex;

                    else if (index == 1)
                        return Max;

                    else
                        throw new IndexOutOfRangeException();
                }
            }

            public readonly int CompareTo(double max) => Max.CompareTo(max);
            public readonly int CompareTo(StepInfo other) => Max.CompareTo(other.Max);
            public readonly override string ToString() => $"[{MaxIndex}] => {Max}";
        }
        public List<double[,]> GetResult(out List<double[,]> matrixList, out int optIndex, out double optValue, out List<List<StepInfo>> finalValues)
        {
            matrixList = new List<double[,]>();
            finalValues = new List<List<StepInfo>>();
            List<StepInfo> tempMaxValues = new List<StepInfo>();
            List<List<StepInfo>> maxValues = new List<List<StepInfo>>();

            int financesCount = matrix.GetLength(0),
                factoriesCount = matrix.GetLength(1);

            for (int k = 0; k < stepsCount; k++)
            {
                double[,] tempMatrix = new double[financesCount, financesCount];

                for (int i = 0; i < financesCount; i++)
                {
                    for (int j = 0; j < financesCount; j++)
                    {
                        if (i == j)
                        {
                            tempMatrix[i, j] = Math.Round(matrix[i, factoriesCount - 1 - k], 2); // Используем значения из последней матрицы
                        }
                    }
                }

                // Setting values from main diagonal down to last row
                for (int j = 0; j < financesCount; j++)
                {
                    for (int i = 0; i < financesCount; i++)
                    {
                        if (j < i)
                        {
                            tempMatrix[i, j] = Math.Round(matrix[j, factoriesCount - 1 - k], 2);
                        }
                    }
                }

                for (int j = 0; j < financesCount; j++)
                {
                    for (int i = 0; i < financesCount; i++)
                    {
                        if (j < i && tempMaxValues.Count > 0)
                        {
                            // Log(tempMaxValues.Count, tempMaxValues[(i - j) * k], true);
                            tempMatrix[i, j] = Math.Round(tempMatrix[i, j] + tempMaxValues[i - j].Max, 2);
                        }
                    }
                }

                double max;
                int maxIndex;

                // First matrix by default have main diagonal as max values
                for (int j = 0; j < financesCount; j++)
                {
                    maxIndex = j;
                    max = Math.Round(tempMatrix[j, j], 2);
                    tempMaxValues.Add(new StepInfo(maxIndex, max));
                }

                // Need to find maximums & add them to the cells in one column starting from main diagonal (with 0 index)
                for (int i = 1; i < financesCount; i++)
                {
                    max = double.MinValue;
                    maxIndex = 0;

                    for (int j = 0; j < financesCount; j++)
                    {
                        // Log(max, max > tempMatrix[i, j] ? ">" : "<", tempMatrix[i, j], ""); // Debugging line
                        if (tempMatrix[i, j] > max)
                        {
                            max = Math.Round(tempMatrix[i, j], 2);
                            maxIndex = j;
                        }
                    }

                    // Log(true); // Separate the logs for each iteration

                    // Updating the maximum values in the tempMaxValues list
                    if (tempMaxValues.Count > i)
                    {
                        if (max > tempMaxValues[i].Max)
                        {
                            tempMaxValues[i] = new StepInfo(maxIndex, max);
                        }
                    }
                    else
                    {
                        tempMaxValues.Add(new StepInfo(maxIndex, max));
                    }
                }

                PrintR(tempMatrix);
                matrixList.Add(tempMatrix);
                maxValues.Clear();
                maxValues.Add(tempMaxValues);
                finalValues.Add(tempMaxValues.Distinct().ToList());
            }

            optIndex = maxValues.Last().Max().MaxIndex;
            optValue = maxValues.Last().Max().Max;
            Print<dynamic>("Ответ: " + optIndex, optValue);
            Log();

            return matrixList;
        }
        public static void SpikeLine(char defaultValue = '-')
        {
            System.Text.StringBuilder sb = new();
            for (int i = 0; i < 40; i++)
            {
                sb.Append(defaultValue);
            }
            Log(Const.csCrLf + sb.ToString() + Const.csCrLf);
        }
        public static void Print<T>(params object[] args)
        {
            System.Text.StringBuilder sb = new();
            foreach (object arg in args)
            {
                if (arg is Array array)
                {
                    sb.Append('[');
                    foreach (object item in array)
                    {
                        if (item is Array subArray)
                        {
                            foreach (object subItem in subArray)
                            {
                                sb.Append($"{subItem}, ");
                            }
                        }
                        else
                        {
                            sb.Append($"{item}, ");
                        }
                    }
                    sb.Remove(sb.Length - 2, 2);
                    sb.Append(']');
                }
                else if (arg is List<T> list)
                {
                    sb.Append('[');
                    foreach (T item in list)
                    {
                        if (item is List<T> subArray)
                        {
                            foreach (T subItem in subArray)
                            {
                                sb.Append($"{subItem}, ");
                            }
                        }
                        else
                        {
                            sb.Append($"{item}, ");
                        }
                    }
                    sb.Remove(sb.Length - 2, 2);
                    sb.Append(']');
                }
                else
                {
                    sb.Append(arg.ToString() + ", ");
                }
            }

            Log(sb.ToString());
            Log();
            SpikeLine();
        }
        public static void PrintR<T>(T[,] matrix, string name = "Matrix")
        {
            System.Text.StringBuilder sb = new(name + " (\n");

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                sb.Append('\t');
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    sb.Append((matrix[i, j] + ", ").PadRight(7));
                }
                sb.Remove(sb.Length - 2, 2);
                sb.Append('\n');
            }
            sb.AppendLine(")");

            Log(sb.ToString());
            SpikeLine();
            Log(Const.csCrLf);
        }
        public static void Log(params object[] args)
        {
            if (args.Length == 0)
                System.Diagnostics.Debug.WriteLine("");
            else if (args[^1] is bool newValue && newValue)
                System.Diagnostics.Debug.WriteLine(string.Join(", ", args[..^1]));
            else
                System.Diagnostics.Debug.Write(string.Join(", ", args));
        }
    }
}
