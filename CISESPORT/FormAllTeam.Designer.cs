namespace CISESPORT
{
    partial class FormAllTeam
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            closeToolStripMenuItem = new ToolStripMenuItem();
            teamToolStripMenuItem = new ToolStripMenuItem();
            newTeamToolStripMenuItem = new ToolStripMenuItem();
            allplayerToolStripMenuItem = new ToolStripMenuItem();
            dataGridView1 = new DataGridView();
            ColumnTeam = new DataGridViewTextBoxColumn();
            ColumnName_1 = new DataGridViewTextBoxColumn();
            ColumnGname_1 = new DataGridViewTextBoxColumn();
            ColumnName_2 = new DataGridViewTextBoxColumn();
            ColumnGname_2 = new DataGridViewTextBoxColumn();
            ColumnName_3 = new DataGridViewTextBoxColumn();
            ColumnGname_3 = new DataGridViewTextBoxColumn();
            ColumnName_4 = new DataGridViewTextBoxColumn();
            ColumnGname_4 = new DataGridViewTextBoxColumn();
            ColumnName_5 = new DataGridViewTextBoxColumn();
            ColumnGname_5 = new DataGridViewTextBoxColumn();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, teamToolStripMenuItem, allplayerToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(9, 3, 0, 3);
            menuStrip1.Size = new Size(1733, 35);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem, saveToolStripMenuItem, closeToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(54, 29);
            fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(158, 34);
            openToolStripMenuItem.Text = "Open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(158, 34);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // closeToolStripMenuItem
            // 
            closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            closeToolStripMenuItem.Size = new Size(158, 34);
            closeToolStripMenuItem.Text = "Close";
            closeToolStripMenuItem.Click += closeToolStripMenuItem_Click;
            // 
            // teamToolStripMenuItem
            // 
            teamToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newTeamToolStripMenuItem });
            teamToolStripMenuItem.Name = "teamToolStripMenuItem";
            teamToolStripMenuItem.Size = new Size(69, 29);
            teamToolStripMenuItem.Text = "Team";
            // 
            // newTeamToolStripMenuItem
            // 
            newTeamToolStripMenuItem.Name = "newTeamToolStripMenuItem";
            newTeamToolStripMenuItem.Size = new Size(195, 34);
            newTeamToolStripMenuItem.Text = "New Team";
            newTeamToolStripMenuItem.Click += newTeamToolStripMenuItem_Click;
            // 
            // allplayerToolStripMenuItem
            // 
            allplayerToolStripMenuItem.Name = "allplayerToolStripMenuItem";
            allplayerToolStripMenuItem.Size = new Size(96, 29);
            allplayerToolStripMenuItem.Text = "Allplayer";
            allplayerToolStripMenuItem.Click += allplayerToolStripMenuItem_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColumnTeam, ColumnName_1, ColumnGname_1, ColumnName_2, ColumnGname_2, ColumnName_3, ColumnGname_3, ColumnName_4, ColumnGname_4, ColumnName_5, ColumnGname_5 });
            dataGridView1.Location = new Point(17, 45);
            dataGridView1.Margin = new Padding(4, 5, 4, 5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1703, 685);
            dataGridView1.TabIndex = 1;
            // 
            // ColumnTeam
            // 
            ColumnTeam.DataPropertyName = "_Team";
            ColumnTeam.HeaderText = "Team";
            ColumnTeam.MinimumWidth = 8;
            ColumnTeam.Name = "ColumnTeam";
            ColumnTeam.ReadOnly = true;
            ColumnTeam.Width = 150;
            // 
            // ColumnName_1
            // 
            ColumnName_1.DataPropertyName = "name1";
            ColumnName_1.HeaderText = "Name_1";
            ColumnName_1.MinimumWidth = 8;
            ColumnName_1.Name = "ColumnName_1";
            ColumnName_1.ReadOnly = true;
            ColumnName_1.Width = 150;
            // 
            // ColumnGname_1
            // 
            ColumnGname_1.DataPropertyName = "gname1";
            ColumnGname_1.HeaderText = "Gname_1";
            ColumnGname_1.MinimumWidth = 8;
            ColumnGname_1.Name = "ColumnGname_1";
            ColumnGname_1.ReadOnly = true;
            ColumnGname_1.Width = 150;
            // 
            // ColumnName_2
            // 
            ColumnName_2.DataPropertyName = "name2";
            ColumnName_2.HeaderText = "Name_2";
            ColumnName_2.MinimumWidth = 8;
            ColumnName_2.Name = "ColumnName_2";
            ColumnName_2.ReadOnly = true;
            ColumnName_2.Width = 150;
            // 
            // ColumnGname_2
            // 
            ColumnGname_2.DataPropertyName = "gname2";
            ColumnGname_2.HeaderText = "Gname_2";
            ColumnGname_2.MinimumWidth = 8;
            ColumnGname_2.Name = "ColumnGname_2";
            ColumnGname_2.ReadOnly = true;
            ColumnGname_2.Width = 150;
            // 
            // ColumnName_3
            // 
            ColumnName_3.DataPropertyName = "name3";
            ColumnName_3.HeaderText = "Name_3";
            ColumnName_3.MinimumWidth = 8;
            ColumnName_3.Name = "ColumnName_3";
            ColumnName_3.ReadOnly = true;
            ColumnName_3.Width = 150;
            // 
            // ColumnGname_3
            // 
            ColumnGname_3.DataPropertyName = "gname3";
            ColumnGname_3.HeaderText = "Gname_3";
            ColumnGname_3.MinimumWidth = 8;
            ColumnGname_3.Name = "ColumnGname_3";
            ColumnGname_3.ReadOnly = true;
            ColumnGname_3.Width = 150;
            // 
            // ColumnName_4
            // 
            ColumnName_4.DataPropertyName = "name4";
            ColumnName_4.HeaderText = "Name_4";
            ColumnName_4.MinimumWidth = 8;
            ColumnName_4.Name = "ColumnName_4";
            ColumnName_4.ReadOnly = true;
            ColumnName_4.Width = 150;
            // 
            // ColumnGname_4
            // 
            ColumnGname_4.DataPropertyName = "gname4";
            ColumnGname_4.HeaderText = "Gname_4";
            ColumnGname_4.MinimumWidth = 8;
            ColumnGname_4.Name = "ColumnGname_4";
            ColumnGname_4.ReadOnly = true;
            ColumnGname_4.Width = 150;
            // 
            // ColumnName_5
            // 
            ColumnName_5.DataPropertyName = "name5";
            ColumnName_5.HeaderText = "Name_5";
            ColumnName_5.MinimumWidth = 8;
            ColumnName_5.Name = "ColumnName_5";
            ColumnName_5.ReadOnly = true;
            ColumnName_5.Width = 150;
            // 
            // ColumnGname_5
            // 
            ColumnGname_5.DataPropertyName = "gname5";
            ColumnGname_5.HeaderText = "Gname_5";
            ColumnGname_5.MinimumWidth = 8;
            ColumnGname_5.Name = "ColumnGname_5";
            ColumnGname_5.ReadOnly = true;
            ColumnGname_5.Width = 150;
            // 
            // FormAllTeam
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1733, 750);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormAllTeam";
            Text = "FormAllTeam";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem teamToolStripMenuItem;
        private ToolStripMenuItem closeToolStripMenuItem;
        private DataGridView dataGridView1;
        private ToolStripMenuItem newTeamToolStripMenuItem;
        private DataGridViewTextBoxColumn ColumnTeam;
        private DataGridViewTextBoxColumn ColumnName_1;
        private DataGridViewTextBoxColumn ColumnGname_1;
        private DataGridViewTextBoxColumn ColumnName_2;
        private DataGridViewTextBoxColumn ColumnGname_2;
        private DataGridViewTextBoxColumn ColumnName_3;
        private DataGridViewTextBoxColumn ColumnGname_3;
        private DataGridViewTextBoxColumn ColumnName_4;
        private DataGridViewTextBoxColumn ColumnGname_4;
        private DataGridViewTextBoxColumn ColumnName_5;
        private DataGridViewTextBoxColumn ColumnGname_5;
        private ToolStripMenuItem allplayerToolStripMenuItem;
    }
}