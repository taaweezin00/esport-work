using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CISESPORT
{
    public partial class FormTeamInfo : Form
    {
        private Team _teams;
        public FormTeamInfo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           FormAllPlayer formAllPlayer= new FormAllPlayer();
           formAllPlayer.ShowDialog();
           if(formAllPlayer.DialogResult == DialogResult.OK)
            {
                Player PlayerInfo = formAllPlayer.GetselectedPlayer();
                this.textBoxName1.Text = PlayerInfo.Name;
                this.textBoxGname1.Text = PlayerInfo.Gname;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormAllPlayer formAllPlayer = new FormAllPlayer();
            formAllPlayer.ShowDialog();
            if (formAllPlayer.DialogResult == DialogResult.OK)
            {
                Player PlayerInfo = formAllPlayer.GetselectedPlayer();
                this.textBoxName2.Text = PlayerInfo.Name;
                this.textBoxGname2.Text = PlayerInfo.Gname;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormAllPlayer formAllPlayer = new FormAllPlayer();
            formAllPlayer.ShowDialog();
            if (formAllPlayer.DialogResult == DialogResult.OK)
            {
                Player PlayerInfo = formAllPlayer.GetselectedPlayer();
                this.textBoxName3.Text = PlayerInfo.Name;
                this.textBoxGname3.Text = PlayerInfo.Gname;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormAllPlayer formAllPlayer = new FormAllPlayer();
            formAllPlayer.ShowDialog();
            if (formAllPlayer.DialogResult == DialogResult.OK)
            {
                Player PlayerInfo = formAllPlayer.GetselectedPlayer();
                this.textBoxName4.Text = PlayerInfo.Name;
                this.textBoxGname4.Text = PlayerInfo.Gname;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormAllPlayer formAllPlayer = new FormAllPlayer();
            formAllPlayer.ShowDialog();
            if (formAllPlayer.DialogResult == DialogResult.OK)
            {
                Player PlayerInfo = formAllPlayer.GetselectedPlayer();
                this.textBoxName5.Text = PlayerInfo.Name;
                this.textBoxGname5.Text = PlayerInfo.Gname;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string team = textBoxTeam.Text;
            string name1 = textBoxName1.Text;
            string gname1 = textBoxGname1.Text;
            string name2 = textBoxName2.Text;
            string gname2 = textBoxGname2.Text;
            string name3 = textBoxName3.Text;
            string gname3 = textBoxGname3.Text;
            string name4 = textBoxName4.Text;
            string gname4 = textBoxGname4.Text;
            string name5 = textBoxName5.Text;
            string gname5 = textBoxGname5.Text;

            _teams = new Team(team, name1, gname1, name2, gname2, name3, gname3, name4, gname4, name5, gname5);
            this.DialogResult= DialogResult.OK;
        }
        public Team getTeam() { return _teams; }
    }
}
