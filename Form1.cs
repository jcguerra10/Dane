using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dane
{
    public partial class Form1 : Form
    {
               
        

        public Form1()
        {
            InitializeComponent();
            Config();
        }

        public void Config()
        {
            string[] lines = File.ReadAllLines("D:/AUU/ProyectoIntegrador/Tarea Feb-8/Dane/Dane/Data/file.csv");
            ArrayList ar = new ArrayList();
            foreach ( var i in lines)
            {
                var valores = i.Split(',');
                string s = valores[2];

                if (ar.Count == 0)
                {
                    ar.Add(s);
                }
                else
                {
                    if (!ar.Contains(s))
                    {
                        ar.Add(s);
                    }
                }
            }
            foreach(string f in ar) {
                comboBox1.Items.Add(f);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string s = comboBox1.Text;

            string[] lines = File.ReadAllLines("D:/AUU/ProyectoIntegrador/Tarea Feb-8/Dane/Dane/Data/file.csv");

            foreach (var i in lines)
            {
                var valores = i.Split(',');
                if (valores[2] == s)
                {
                    int n = dataGridView1.Rows.Add();
                    dataGridView1.Rows[n].Cells[0].Value = valores[0];
                    dataGridView1.Rows[n].Cells[1].Value = valores[1];
                    dataGridView1.Rows[n].Cells[2].Value = valores[2];
                    dataGridView1.Rows[n].Cells[3].Value = valores[3];
                    dataGridView1.Rows[n].Cells[4].Value = valores[4];
                }
            }
            
        }
    }
}
