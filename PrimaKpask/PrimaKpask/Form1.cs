using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static PrimaKpask.Form1;

namespace PrimaKpask
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void shapka(int n)
        {
            int rowCount = n; // количество строк
            int columnCount = n; // количество столбцов

            // Удаляет все элементы из таблицы
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            // Добавляет столбцы
            for (int i = 0; i < columnCount; i++)
            {
                dataGridView1.Columns.Add(Convert.ToString((char)('A' + i)), Convert.ToString((char)('A' + i)));
            }

            // Добавляет строки
            dataGridView1.Rows.Add(rowCount);

            // Заполняет заголовки строк
            // Заполняет заголовки строк буквами алфавита
            for (char i = 'A'; i < 'A' + rowCount; i++)
            {
                dataGridView1.Rows[i - 'A'].HeaderCell.Value = i.ToString();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            new Form2(this).ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int columnCount = dataGridView1.Columns.Count;

            Form3 form3 = new Form3(columnCount, this);
            form3.ShowDialog();
        }
        public void InsertData(char columnChar, char rowChar, int number)
        {
            var column = (int)columnChar - 'A'; // Преобразование буквы столбца в индекс
            var row = (int)rowChar - 'A'; // Преобразование буквы строки в индекс

            // Заполнение ячеек таблицы
            dataGridView1[column, row].Value = number;
            dataGridView1[row, column].Value = number;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<Edge> edges = new List<Edge>();
            for (int i = 0; i < dataGridView1.Columns.Count-1; i+=1)
            {
                for (int j = i+1; j < dataGridView1.Columns.Count; j += 1)
                {
                    string vertex1 = dataGridView1.Columns[i].HeaderText;
                    string vertex2 = dataGridView1.Columns[j].HeaderText;
                    int weight = Convert.ToInt32(dataGridView1.Rows[i].Cells[j].Value);
                    if (weight  != 0)
                    {
                        edges.Add(new Edge(vertex1, vertex2, weight));
                    }
                }                
            }
            // Вызов метода Краскала для поиска минимального пути
            KruskalAlgorithm kruskal = new KruskalAlgorithm();
            List<Edge> minimumSpanningTree = kruskal.FindMinimumSpanningTree(edges);
                        

            // Очистка ListBox перед выводом новых данных
            listBox1.Items.Clear();

            // Вывод результатов в ListBox
            foreach (var path in minimumSpanningTree)
            {
                listBox1.Items.Add($"({path.Source} - {path.Destination}): {path.Weight}");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            List<Edge> edges = new List<Edge>();
            for (int i = 0; i < dataGridView1.Columns.Count - 1; i += 1)
            {
                for (int j = i + 1; j < dataGridView1.Columns.Count; j += 1)
                {
                    string vertex1 = dataGridView1.Columns[i].HeaderText;
                    string vertex2 = dataGridView1.Columns[j].HeaderText;
                    int weight = Convert.ToInt32(dataGridView1.Rows[i].Cells[j].Value);
                    if (weight != 0)
                    {
                        edges.Add(new Edge(vertex1, vertex2, weight));
                    }        
                }
            }
            PrimaAlgorithm graph = new PrimaAlgorithm(edges.Count);

            foreach (var edge in edges)
            {
                graph.AddEdge((int)edge.Source - 65,(int)edge.Destination-65,edge.Weight);
            }

            List<Edge2> mst = graph.PrimMST();

            Console.WriteLine("Edges in MST:");
            foreach (var edge in mst)
            {
                listBox1.Items.Add($"({(char)(edge.Source+65)} - {(char)(edge.Destination+65)}): {edge.Weight}");
                Console.WriteLine($"{edge.Source} - {edge.Destination}: {edge.Weight}");
            }
        }

    }
    class KruskalAlgorithm
    {
        public List<Edge> FindMinimumSpanningTree(List<Edge> edges)
        {
            edges.Sort((a, b) => a.Weight.CompareTo(b.Weight));

            var disjointSet = new DisjointSet();
            var minimumSpanningTree = new List<Edge>();

            foreach (var edge in edges)
            {
                char root1 = disjointSet.Find(edge.Source);
                char root2 = disjointSet.Find(edge.Destination);

                if (root1 != root2)
                {
                    minimumSpanningTree.Add(edge);
                    disjointSet.Union(edge.Source, edge.Destination);
                }
            }

            return minimumSpanningTree;
        }
    }
    class DisjointSet
    {
        private Dictionary<char, char> parent;

        public DisjointSet()
        {
            parent = new Dictionary<char, char>();
            for (char c = 'A'; c <= 'Z'; c++)
            {
                parent[c] = c;
            }
        }

        public char Find(char x)
        {
            if (x != parent[x])
            {
                parent[x] = Find(parent[x]);
            }
            return parent[x];
        }

        public void Union(char x, char y)
        {
            char rootX = Find(x);
            char rootY = Find(y);

            if (rootX != rootY)
            {
                parent[rootX] = rootY;
            }
        }
    }
    // Класс для представления ребра графа
    public class Edge
    {
        public char Source { get; set; }
        public char Destination { get; set; }
        public int Weight { get; set; }

        public Edge(string source, string destination, int weight)
        {
            Source = (char)source[0];
            Destination = (char)destination[0];
            Weight = weight;
        }
        public Edge(char source, char destination, int weight)
        {
            Source = source;
            Destination = destination;
            Weight = weight;
        }
    }
    public class Edge2
    {
        public int Source { get; }
        public int Destination { get; }
        public int Weight { get; }

        public Edge2(int source, int destination, int weight)
        {
            Source = source;
            Destination = destination;
            Weight = weight;
        }
    }

    public class PrimaAlgorithm
    {
        private readonly int _verticesCount;
        private readonly List<Edge2> _edges;

        public PrimaAlgorithm(int verticesCount)
        {
            _verticesCount = verticesCount;
            _edges = new List<Edge2>();
        }

        public void AddEdge(int source, int destination, int weight)
        {
            _edges.Add(new Edge2(source, destination, weight));
        }

        public List<Edge2> PrimMST()
        {
            var inMST = new bool[_verticesCount];
            var minEdge = new Edge2[_verticesCount];
            var edgeQueue = new SortedSet<Edge2>(Comparer<Edge2>.Create((a, b) => a.Weight != b.Weight ? a.Weight - b.Weight : a.Source - b.Source));

            for (int i = 0; i < _verticesCount; i++)
            {
                minEdge[i] = new Edge2(-1, -1, int.MaxValue);
            }

            minEdge[0] = new Edge2(-1, 0, 0);
            edgeQueue.Add(minEdge[0]);

            while (edgeQueue.Count != 0)
            {
                var edge = edgeQueue.Min;
                edgeQueue.Remove(edge);

                int u = edge.Destination;
                inMST[u] = true;

                foreach (var e in _edges.Where(e => e.Source == u || e.Destination == u))
                {
                    int v = e.Source == u ? e.Destination : e.Source;
                    if (!inMST[v] && e.Weight < minEdge[v].Weight)
                    {
                        edgeQueue.Remove(minEdge[v]);
                        minEdge[v] = e;
                        edgeQueue.Add(minEdge[v]);
                    }
                }
            }

            var result = new List<Edge2>();
            for (int i = 1; i < _verticesCount; i++)
            {
                if (minEdge[i].Source != -1)
                    result.Add(minEdge[i]);
            }

            return result;
        }
    }
}

