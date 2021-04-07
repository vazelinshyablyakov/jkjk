using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace esfgsdfgsdfg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            dataGridView1.Rows[1].Cells[1].ReadOnly = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                {
                    Random r = new Random();

                    int i, j, m, n;          

                    m = Convert.ToInt16(textBox1.Text);

                    n = Convert.ToInt16(textBox2.Text);                 

                    dataGridView1.RowCount = m; dataGridView1.ColumnCount = n;                  
                    for (i = 0; i < m; i++)
                        for (j = 0; j < n; j++)
                   dataGridView1.Rows[i].Cells[j].Value = (r.Next(20) - 10).ToString();

                }




            }
        }

    }
}
