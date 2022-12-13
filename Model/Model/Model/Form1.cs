using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Model
{
    public partial class Form1 : Form
    {
        public double s, a, step, result, k;
        public Form1()
        {
            InitializeComponent();
        }
        private void simulate_Click(object sender, EventArgs e)
        {
            s = Convert.ToInt16(way.Text.Replace(".", ","));
            a = Convert.ToInt16(acceleration.Text.Replace(".", ","));
            k = Convert.ToInt16(KolvoIt.Text.Replace(".", ","));
            step = Convert.ToDouble(stepModel.Text.Replace(".", ","));

            FileStream f = new FileStream("result.txt", FileMode.Create);
            StreamWriter wr = new StreamWriter(f);
            wr.WriteLine("Результат: ");

            chartRes.Series[0].Points.Clear();

            resultTable.Rows.Clear();

            for (int i = 0; i < k; i++)
             {
                result = Math.Round(Math.Sqrt(2*s/a), 4);

                wr.Write("Ускорение - ");
                wr.Write(a + " ");
                wr.Write("Время - ");
                wr.Write(result);
                wr.Write(Environment.NewLine);

                chartRes.Series[0].Points.AddXY(result, a);

                resultTable.Rows.Add(a, result);

                a = a + step;
            }
            wr.Close();
        }
    }
}
