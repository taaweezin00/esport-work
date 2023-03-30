namespace CISESPORT
{
    partial class FormAllPlayer
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
            openFileToolStripMenuItem = new ToolStripMenuItem();
            saveFileToolStripMenuItem = new ToolStripMenuItem();
            closeToolStripMenuItem = new ToolStripMenuItem();
            playerToolStripMenuItem = new ToolStripMenuItem();
            newPlayerToolStripMenuItem1 = new ToolStripMenuItem();
            dataGridView1 = new DataGridView();
            ColumnName = new DataGridViewTextBoxColumn();
            ColumnLname = new DataGridViewTextBoxColumn();
            ColumnID = new DataGridViewTextBoxColumn();
            ColumnField = new DataGridViewTextBoxColumn();
            ColumnGname = new DataGridViewTextBoxColumn();
            ColumnMail = new DataGridViewTextBoxColumn();
            ColumnTel = new DataGridViewTextBoxColumn();
            ColumnAge = new DataGridViewTextBoxColumn();
            textBoxGName = new TextBox();
            label5 = new Label();
            textBoxField = new TextBox();
            label4 = new Label();
            textBoxID = new TextBox();
            label3 = new Label();
            textBoxName = new TextBox();
            label1 = new Label();
            button1 = new Button();
            allPlayerToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, playerToolStripMenuItem, allPlayerToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1587, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openFileToolStripMenuItem, saveFileToolStripMenuItem, closeToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(54, 29);
            fileToolStripMenuItem.Text = "File";
            // 
            // openFileToolStripMenuItem
            // 
            openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            openFileToolStripMenuItem.Size = new Size(189, 34);
            openFileToolStripMenuItem.Text = "Open File";
            openFileToolStripMenuItem.Click += openFileToolStripMenuItem_Click;
            // 
            // saveFileToolStripMenuItem
            // 
            saveFileToolStripMenuItem.Name = "saveFileToolStripMenuItem";
            saveFileToolStripMenuItem.Size = new Size(189, 34);
            saveFileToolStripMenuItem.Text = "Save File";
            saveFileToolStripMenuItem.Click += saveFileToolStripMenuItem_Click;
            // 
            // closeToolStripMenuItem
            // 
            closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            closeToolStripMenuItem.Size = new Size(189, 34);
            closeToolStripMenuItem.Text = "Close";
            closeToolStripMenuItem.Click += closeToolStripMenuItem_Click;
            // 
            // playerToolStripMenuItem
            // 
            playerToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newPlayerToolStripMenuItem1 });
            playerToolStripMenuItem.Name = "playerToolStripMenuItem";
            playerToolStripMenuItem.Size = new Size(75, 29);
            playerToolStripMenuItem.Text = "Player";
            // 
            // newPlayerToolStripMenuItem1
            // 
            newPlayerToolStripMenuItem1.Name = "newPlayerToolStripMenuItem1";
            newPlayerToolStripMenuItem1.Size = new Size(195, 34);
            newPlayerToolStripMenuItem1.Text = "AddPlayer";
            newPlayerToolStripMenuItem1.Click += newPlayerToolStripMenuItem1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColumnName, ColumnLname, ColumnID, ColumnField, ColumnGname, ColumnMail, ColumnTel, ColumnAge });
            dataGridView1.Location = new Point(17, 45);
            dataGridView1.Margin = new Padding(4, 5, 4, 5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1241, 560);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // ColumnName
            // 
            ColumnName.DataPropertyName = "name";
            ColumnName.HeaderText = "Name";
            ColumnName.MinimumWidth = 8;
            ColumnName.Name = "ColumnName";
            ColumnName.ReadOnly = true;
            ColumnName.Width = 150;
            // 
            // ColumnLname
            // 
            ColumnLname.DataPropertyName = "lname";
            ColumnLname.HeaderText = "Lastname";
            ColumnLname.MinimumWidth = 8;
            ColumnLname.Name = "ColumnLname";
            ColumnLname.ReadOnly = true;
            ColumnLname.Width = 150;
            // 
            // ColumnID
            // 
            ColumnID.DataPropertyName = "id";
            ColumnID.HeaderText = "ID";
            ColumnID.MinimumWidth = 8;
            ColumnID.Name = "ColumnID";
            ColumnID.ReadOnly = true;
            ColumnID.Width = 150;
            // 
            // ColumnField
            // 
            ColumnField.DataPropertyName = "field";
            ColumnField.HeaderText = "Field";
            ColumnField.MinimumWidth = 8;
            ColumnField.Name = "ColumnField";
            ColumnField.ReadOnly = true;
            ColumnField.Width = 150;
            // 
            // ColumnGname
            // 
            ColumnGname.DataPropertyName = "gname";
            ColumnGname.HeaderText = "InGamename";
            ColumnGname.MinimumWidth = 8;
            ColumnGname.Name = "ColumnGname";
            ColumnGname.ReadOnly = true;
            ColumnGname.Width = 150;
            // 
            // ColumnMail
            // 
            ColumnMail.DataPropertyName = "mail";
            ColumnMail.HeaderText = "Email";
            ColumnMail.MinimumWidth = 8;
            ColumnMail.Name = "ColumnMail";
            ColumnMail.ReadOnly = true;
            ColumnMail.Width = 150;
            // 
            // ColumnTel
            // 
            ColumnTel.DataPropertyName = "tel";
            ColumnTel.HeaderText = "Telphon num.";
            ColumnTel.MinimumWidth = 8;
            ColumnTel.Name = "ColumnTel";
            ColumnTel.ReadOnly = true;
            ColumnTel.Width = 150;
            // 
            // ColumnAge
            // 
            ColumnAge.DataPropertyName = "age";
            ColumnAge.HeaderText = "Age";
            ColumnAge.MinimumWidth = 8;
            ColumnAge.Name = "ColumnAge";
            ColumnAge.ReadOnly = true;
            ColumnAge.Width = 150;
            // 
            // textBoxGName
            // 
            textBoxGName.Location = new Point(1395, 212);
            textBoxGName.Name = "textBoxGName";
            textBoxGName.Size = new Size(132, 31);
            textBoxGName.TabIndex = 22;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(1288, 212);
            label5.Name = "label5";
            label5.Size = new Size(73, 25);
            label5.TabIndex = 28;
            label5.Text = "ชื่อในเกม";
            // 
            // textBoxField
            // 
            textBoxField.Location = new Point(1395, 162);
            textBoxField.Name = "textBoxField";
            textBoxField.Size = new Size(132, 31);
            textBoxField.TabIndex = 20;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1288, 168);
            label4.Name = "label4";
            label4.Size = new Size(49, 25);
            label4.TabIndex = 27;
            label4.Text = "สาขา";
            // 
            // textBoxID
            // 
            textBoxID.Location = new Point(1395, 118);
            textBoxID.Name = "textBoxID";
            textBoxID.Size = new Size(132, 31);
            textBoxID.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1288, 118);
            label3.Name = "label3";
            label3.Size = new Size(101, 25);
            label3.TabIndex = 24;
            label3.Text = "รหัสนักศึกษา";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(1395, 66);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(132, 31);
            textBoxName.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1288, 66);
            label1.Name = "label1";
            label1.Size = new Size(33, 25);
            label1.TabIndex = 17;
            label1.Text = "ชื่อ";
            // 
            // button1
            // 
            button1.Location = new Point(1422, 255);
            button1.Name = "button1";
            button1.Size = new Size(105, 33);
            button1.TabIndex = 29;
            button1.Text = "ยืนยัน";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // allPlayerToolStripMenuItem
            // 
            allPlayerToolStripMenuItem.Name = "allPlayerToolStripMenuItem";
            allPlayerToolStripMenuItem.Size = new Size(96, 29);
            allPlayerToolStripMenuItem.Text = "Allplayer";
            // 
            // FormAllPlayer
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1587, 618);
            Controls.Add(button1);
            Controls.Add(textBoxGName);
            Controls.Add(label5);
            Controls.Add(textBoxField);
            Controls.Add(label4);
            Controls.Add(textBoxID);
            Controls.Add(label3);
            Controls.Add(textBoxName);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FormAllPlayer";
            Text = "FormAllPlayer";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private DataGridView dataGridView1;
        private ToolStripMenuItem openFileToolStripMenuItem;
        private ToolStripMenuItem saveFileToolStripMenuItem;
        private ToolStripMenuItem closeToolStripMenuItem;
        private ToolStripMenuItem playerToolStripMenuItem;
        private ToolStripMenuItem newPlayerToolStripMenuItem1;
        private TextBox textBoxGName;
        private Label label5;
        private TextBox textBoxField;
        private Label label4;
        private TextBox textBoxID;
        private Label label3;
        private TextBox textBoxName;
        private Label label1;
        private Button button1;
        private DataGridViewTextBoxColumn ColumnName;
        private DataGridViewTextBoxColumn ColumnLname;
        private DataGridViewTextBoxColumn ColumnID;
        private DataGridViewTextBoxColumn ColumnField;
        private DataGridViewTextBoxColumn ColumnGname;
        private DataGridViewTextBoxColumn ColumnMail;
        private DataGridViewTextBoxColumn ColumnTel;
        private DataGridViewTextBoxColumn ColumnAge;
        private ToolStripMenuItem allPlayerToolStripMenuItem;
    }
}