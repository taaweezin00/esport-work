using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CISESPORT
{
    public partial class FormAllPlayer : Form
    {
        List<Player> listPlayer = new List<Player>();
        Player selectedPlayer;
        public FormAllPlayer()
        {
            InitializeComponent();
        }

        private void newPlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInfo formInfo = new FormInfo();
            formInfo.ShowDialog();

            if (formInfo.DialogResult == DialogResult.OK) {
                Player newPlayer = formInfo.getPlayer();
                //Add new Player to List
                this.listPlayer.Add(newPlayer);

                this.dataGridView1.DataSource = null;
                this.dataGridView1.DataSource = listPlayer;
                //Add list to Datagrid view
                formInfo.Close();
            }
        }

        private void saveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Save data from list to CSV file
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "TEXT|*.txt|CSV|*.csv";
            saveFileDialog.ShowDialog();
            if (saveFileDialog.FileName != "")
            {
                using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                {
                    foreach (Player item in listPlayer)
                    {
                        writer.WriteLine(String.Format("{0},{1},{2},{3}",
                            item.Name,
                            item.Lastname,
                            item.Major));
                    }
                }
            }
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog= new OpenFileDialog();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) { 
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                this.selectedPlayer =  (Player)row.DataBoundItem;

                this.tbName.Text = selectedPlayer.Name;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(tbName.Text, tbLastname.Text, tbStudentID.Text, tbMajor.Text);
            decimal colsum = 0;

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        private void iSave()
        {

        }
    }
}
