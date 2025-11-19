namespace Forms.Views
{
    partial class AttendanceForm
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
            DateTime = new TextBox();
            NameLabel = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            IdLabel = new Label();
            textBox3 = new TextBox();
            TypeLabel = new Label();
            pictureBox1 = new PictureBox();
            dataGridView1 = new DataGridView();
            index = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            TimeStamp = new DataGridViewTextBoxColumn();
            type = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // DateTime
            // 
            DateTime.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DateTime.BackColor = Color.LimeGreen;
            DateTime.BorderStyle = BorderStyle.FixedSingle;
            DateTime.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DateTime.Location = new Point(12, 12);
            DateTime.Name = "DateTime";
            DateTime.Size = new Size(776, 43);
            DateTime.TabIndex = 0;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(12, 243);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(49, 20);
            NameLabel.TabIndex = 1;
            NameLabel.Text = "Name";
            //NameLabel.Click += this.label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 266);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(291, 27);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 329);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(291, 27);
            textBox2.TabIndex = 4;
            // 
            // IdLabel
            // 
            IdLabel.AutoSize = true;
            IdLabel.Location = new Point(12, 306);
            IdLabel.Name = "IdLabel";
            IdLabel.Size = new Size(82, 20);
            IdLabel.TabIndex = 3;
            IdLabel.Text = "ID Number";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(12, 390);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(291, 27);
            textBox3.TabIndex = 6;
            // 
            // TypeLabel
            // 
            TypeLabel.AutoSize = true;
            TypeLabel.Location = new Point(12, 367);
            TypeLabel.Name = "TypeLabel";
            TypeLabel.Size = new Size(40, 20);
            TypeLabel.TabIndex = 5;
            TypeLabel.Text = "Type";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Gray;
            pictureBox1.Location = new Point(12, 63);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(291, 167);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            //pictureBox1.Click += this.pictureBox1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { index, name, TimeStamp, type });
            dataGridView1.GridColor = SystemColors.ButtonHighlight;
            dataGridView1.Location = new Point(319, 67);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(468, 30);
            dataGridView1.TabIndex = 8;
            //dataGridView1.CellContentClick += this.dataGridView1_CellContentClick;
            // 
            // index
            // 
            index.Frozen = true;
            index.HeaderText = "#";
            index.MinimumWidth = 20;
            index.Name = "index";
            index.ReadOnly = true;
            index.Width = 40;
            // 
            // name
            // 
            name.Frozen = true;
            name.HeaderText = "Name";
            name.MinimumWidth = 100;
            name.Name = "name";
            name.ReadOnly = true;
            name.Width = 200;
            // 
            // TimeStamp
            // 
            TimeStamp.Frozen = true;
            TimeStamp.HeaderText = "Time Stamp";
            TimeStamp.MinimumWidth = 100;
            TimeStamp.Name = "TimeStamp";
            TimeStamp.ReadOnly = true;
            TimeStamp.Width = 150;
            // 
            // type
            // 
            type.Frozen = true;
            type.HeaderText = "Type";
            type.MinimumWidth = 40;
            type.Name = "type";
            type.ReadOnly = true;
            type.Width = 80;
            // 
            // AttendanceForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(pictureBox1);
            Controls.Add(textBox3);
            Controls.Add(TypeLabel);
            Controls.Add(textBox2);
            Controls.Add(IdLabel);
            Controls.Add(textBox1);
            Controls.Add(NameLabel);
            Controls.Add(DateTime);
            Name = "AttendanceForm";
            Text = "RFID-ATTENDANCE SYSTEM";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox DateTime;
        private Label NameLabel;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label IdLabel;
        private TextBox textBox3;
        private Label TypeLabel;
        private PictureBox pictureBox1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn index;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn TimeStamp;
        private DataGridViewTextBoxColumn type;
    }
}