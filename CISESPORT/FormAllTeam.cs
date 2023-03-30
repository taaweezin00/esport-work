﻿using System;
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
    public partial class FormAllTeam : Form
    {
        private List<Team> teamList = new List<Team>();
        Team selectedTeam;
        public FormAllTeam()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV|*.csv|TEXT|*.txt";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader reader = new StreamReader(openFileDialog.FileName))
                {
                    while (!reader.EndOfStream)
                    {
                        string[] line = reader.ReadLine().Split(',');
                        if (line.Length >= 11)
                        {
                            Team teams = new Team(
                                line[0], line[1], line[2], line[3], line[4], line[5], line[6], line[7], line[8], line[9], line[10]
                            );
                            teamList.Add(teams);
                        }
                    }
                }
                this.dataGridView1.DataSource = null;
                this.dataGridView1.DataSource = teamList;
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV|*.csv|TEXT|*.txt";
            saveFileDialog.ShowDialog();
            if (saveFileDialog.FileName != "")
            {
                using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                {
                    foreach (Team item in teamList)
                    {
                        writer.WriteLine(String.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10}",
                            item._Team, item.Name1, item.Gname1, item.Name2, item.Gname2, item.Name3, item.Gname3, item.Name4, item.Gname4, item.Name5, item.Gname5
                            ));
                    }
                }
            }
        }

        private void newTeamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTeamInfo formTeamInfo = new FormTeamInfo();
            formTeamInfo.ShowDialog();

            if (formTeamInfo.DialogResult == DialogResult.OK)
            {
                Team newTeam = formTeamInfo.getTeam();
                teamList.Add(newTeam);
                this.dataGridView1.DataSource = null;
                this.dataGridView1.DataSource = teamList;
                formTeamInfo.Close();
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void allplayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAllPlayer FormAllPlayer = new FormAllPlayer();
            FormAllPlayer.Show();
        }
    }
}
