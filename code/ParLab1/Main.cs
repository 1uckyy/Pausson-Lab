using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Lab1
{
    public partial class Main : Form
    {
        //входные значения по умолчанию
        private int n = 10;
        private double lyambda = 3;

        //строки таблицы
        private List<Row> rows = new List<Row>();
        public class Row
        {
            public Int64 nm { get; set; }
            public double p { get; set; }
        }

        //вспомогательные
        private UInt64 s = 2;
        private UInt64 stepen2v40 = 1099511627776;
        private double alpha0 = 0.094947017729282379150390625e-13;
        private UInt64 kk = 762939453125;

        public Main()
        {
            InitializeComponent();
            dataGrid.AutoGenerateColumns = false;
        }

        //входные параметры
        private void paramsChanged(object sender, EventArgs e)
        {
            String str = ((NumericUpDown)sender).Value.ToString();
            if (sender.Equals(n_val))
                n = int.Parse(str);
            else if (sender.Equals(lyambda_val))
                lyambda = double.Parse(str);
        }

        //кнопка "выполнить"
        private void clickCalc(object sender, EventArgs e)
        {
            RebuildChart();
        }

        private void RebuildChart()
        {
            //массив: значение - количество
            Dictionary<Int64, int> keys = new Dictionary<Int64, int>();
            Series fx = chart.Series[0];
            fx.Points.Clear();
            rows.Clear();

            //первая итерация
            UInt64 index_t = (kk ^ ((UInt64)Environment.TickCount & UInt64.MaxValue)) % stepen2v40;
            double alpha = ((alpha0 * index_t) % stepen2v40) % 1;
            keys.Add(getNu(alpha), 1);

            //последующие
            for (int i = 1; i < n; i++)
            {
                index_t = (kk ^ s) % stepen2v40;
                alpha = ((alpha * index_t) % stepen2v40) % 1;
                Int64 nu = getNu(alpha);
                if (keys.ContainsKey(nu))
                {
                    keys[nu]++;
                }
                else
                {
                    keys.Add(nu, 1);
                }
            }

            double nn = n;
            //заполнение графика и таблицы
            foreach (KeyValuePair<Int64, int> entry in keys)
            {
                fx.Points.AddXY(entry.Key, entry.Value);
                rows.Add(new Row { nm = entry.Key, p = entry.Value / nn });
            }

            dataGrid.DataSource = null;
            dataGrid.DataSource = rows;
        }
        
        //n
        public Int64 getNu(double alp)
        {
            double a = alp;
            int k = 0;
            while (a > Math.Exp(-lyambda))
            {
                a *= a;
                k++;
            }
            return k;
        }
    }
}
