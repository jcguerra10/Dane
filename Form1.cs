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
using System.Windows.Forms.DataVisualization.Charting;

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
            string[] lines = File.ReadAllLines("C:/Users/Playtech/source/repos/Dane/Data/file.csv");
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

        private void dataGridView1_CellContentClick(object send er, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string s = comboBox1.Text;

            dataGridView1.Rows.Clear();

            string[] lines = File.ReadAllLines("C:/Users/Playtech/source/repos/Dane/Data/file.csv");

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


        private void Form_Load(object sender, EventArgs e)
        {

            string[] lines = File.ReadAllLines("C:/Users/Playtech/source/repos/Dane/Data/file.csv");
            String datos = "";
            String[] series = {"Municipio", "Isla", "Area no mu"};
            int i1 = 0;
            int i2 = 0;
            int i3 = 0;
            foreach (var i in lines)
            {

                var valores = i.Split(',');
                if (valores[4] == "Municipio"){
                    
                    i1 = i1 + 1;
                }else if(valores[4] == "Isla"){
                
                    i2 = i2 + 1;
                }else{
                
                    i3 = i3 + 1;
                }
            }
            int[] points ={i1,i2,i3};

            chart1.Titles.Add("Departamentos");

            for(int i = 0; i < series.Length; i++){
                
                Series serie = chart1.Series.Add(series[i]);
                serie.Label = points[i].ToString();
                Object p = serie.Point.Add(points[i]);
            }
        }
    }
}
