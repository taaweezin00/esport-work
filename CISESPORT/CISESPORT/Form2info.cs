using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace โปรแกรมสำหรับบันทึกข้อมูลนักศึกษา
{

    public partial class Form2info : Form
    {
        Form1 fgrid;
        public Form2info(Form1 fg)
        {
            InitializeComponent();
            this.fgrid = fg;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fgrid.dataGridView00.Rows.Add(textBox1.Text,textBox2.Text,textBox3.Text,textBox4.Text, textBox5.Text, textBox6.Text);
            decimal colsum = 0;
            for (int r = 0; r < fgrid.dataGridView00.Rows.Count; ++r)
            {
                //colsum += Convert.ToDecimal(fgrid.dataGridView00.Rows[r].Cells[5].Value);
            }
            //label8.Text = colsum.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
