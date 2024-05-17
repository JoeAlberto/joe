namespace Enrollment_System
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.IDNoTextBox = new System.Windows.Forms.TextBox();
            this.CourseLabel = new System.Windows.Forms.Label();
            this.YearLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.EDPCodeTextBox = new System.Windows.Forms.TextBox();
            this.SubjectDataGridView = new System.Windows.Forms.DataGridView();
            this.EDPCodeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubjectCodeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartTimeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndTimeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DaysColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.EncoderTextBox = new System.Windows.Forms.TextBox();
            this.TotalUnitsLabel = new System.Windows.Forms.TextBox();
            this.DatePicker = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SubjectDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Course";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(279, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Year";
            // 
            // NameLabel
            // 
            this.NameLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.NameLabel.Location = new System.Drawing.Point(111, 84);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(308, 27);
            this.NameLabel.TabIndex = 4;
            this.NameLabel.Click += new System.EventHandler(this.label5_Click);
            // 
            // IDNoTextBox
            // 
            this.IDNoTextBox.Location = new System.Drawing.Point(114, 37);
            this.IDNoTextBox.Name = "IDNoTextBox";
            this.IDNoTextBox.Size = new System.Drawing.Size(177, 22);
            this.IDNoTextBox.TabIndex = 7;
            this.IDNoTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IDNoTextBox_KeyPress);
            // 
            // CourseLabel
            // 
            this.CourseLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CourseLabel.Location = new System.Drawing.Point(111, 140);
            this.CourseLabel.Name = "CourseLabel";
            this.CourseLabel.Size = new System.Drawing.Size(103, 26);
            this.CourseLabel.TabIndex = 8;
            // 
            // YearLabel
            // 
            this.YearLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.YearLabel.Location = new System.Drawing.Point(321, 146);
            this.YearLabel.Name = "YearLabel";
            this.YearLabel.Size = new System.Drawing.Size(80, 26);
            this.YearLabel.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.NameLabel);
            this.groupBox1.Controls.Add(this.YearLabel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.CourseLabel);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.IDNoTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(58, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(882, 209);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student Information";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(55, 286);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 16);
            this.label8.TabIndex = 11;
            this.label8.Text = "EDP Code";
            // 
            // EDPCodeTextBox
            // 
            this.EDPCodeTextBox.Location = new System.Drawing.Point(132, 283);
            this.EDPCodeTextBox.Name = "EDPCodeTextBox";
            this.EDPCodeTextBox.Size = new System.Drawing.Size(173, 22);
            this.EDPCodeTextBox.TabIndex = 12;
            this.EDPCodeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EDPCodeTextBox_KeyPress);
            // 
            // SubjectDataGridView
            // 
            this.SubjectDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SubjectDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EDPCodeColumn,
            this.SubjectCodeColumn,
            this.StartTimeColumn,
            this.EndTimeColumn,
            this.DaysColumn,
            this.RoomColumn,
            this.UnitsColumn});
            this.SubjectDataGridView.Location = new System.Drawing.Point(44, 311);
            this.SubjectDataGridView.Name = "SubjectDataGridView";
            this.SubjectDataGridView.RowHeadersWidth = 51;
            this.SubjectDataGridView.RowTemplate.Height = 24;
            this.SubjectDataGridView.Size = new System.Drawing.Size(918, 150);
            this.SubjectDataGridView.TabIndex = 13;
            this.SubjectDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // EDPCodeColumn
            // 
            this.EDPCodeColumn.HeaderText = "EDP Code";
            this.EDPCodeColumn.MinimumWidth = 6;
            this.EDPCodeColumn.Name = "EDPCodeColumn";
            this.EDPCodeColumn.Width = 125;
            // 
            // SubjectCodeColumn
            // 
            this.SubjectCodeColumn.HeaderText = "Subject Code";
            this.SubjectCodeColumn.MinimumWidth = 6;
            this.SubjectCodeColumn.Name = "SubjectCodeColumn";
            this.SubjectCodeColumn.Width = 125;
            // 
            // StartTimeColumn
            // 
            this.StartTimeColumn.HeaderText = "Start Time";
            this.StartTimeColumn.MinimumWidth = 6;
            this.StartTimeColumn.Name = "StartTimeColumn";
            this.StartTimeColumn.Width = 125;
            // 
            // EndTimeColumn
            // 
            this.EndTimeColumn.HeaderText = "End Time";
            this.EndTimeColumn.MinimumWidth = 6;
            this.EndTimeColumn.Name = "EndTimeColumn";
            this.EndTimeColumn.Width = 125;
            // 
            // DaysColumn
            // 
            this.DaysColumn.HeaderText = "Days";
            this.DaysColumn.MinimumWidth = 6;
            this.DaysColumn.Name = "DaysColumn";
            this.DaysColumn.Width = 125;
            // 
            // RoomColumn
            // 
            this.RoomColumn.HeaderText = "Room";
            this.RoomColumn.MinimumWidth = 6;
            this.RoomColumn.Name = "RoomColumn";
            this.RoomColumn.Width = 125;
            // 
            // UnitsColumn
            // 
            this.UnitsColumn.HeaderText = "Units";
            this.UnitsColumn.MinimumWidth = 6;
            this.UnitsColumn.Name = "UnitsColumn";
            this.UnitsColumn.Width = 125;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(43, 495);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 16);
            this.label9.TabIndex = 14;
            this.label9.Text = "Encoded By:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(454, 504);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 16);
            this.label10.TabIndex = 15;
            this.label10.Text = "Date";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(766, 499);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 16);
            this.label11.TabIndex = 16;
            this.label11.Text = "Total Units";
            // 
            // EncoderTextBox
            // 
            this.EncoderTextBox.Location = new System.Drawing.Point(154, 493);
            this.EncoderTextBox.Name = "EncoderTextBox";
            this.EncoderTextBox.Size = new System.Drawing.Size(231, 22);
            this.EncoderTextBox.TabIndex = 17;
            // 
            // TotalUnitsLabel
            // 
            this.TotalUnitsLabel.Location = new System.Drawing.Point(862, 499);
            this.TotalUnitsLabel.Name = "TotalUnitsLabel";
            this.TotalUnitsLabel.Size = new System.Drawing.Size(100, 22);
            this.TotalUnitsLabel.TabIndex = 18;
            // 
            // DatePicker
            // 
            this.DatePicker.Location = new System.Drawing.Point(521, 499);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Size = new System.Drawing.Size(200, 22);
            this.DatePicker.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(298, 583);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "&Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(91, 583);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 23);
            this.BackButton.TabIndex = 21;
            this.BackButton.Text = "&Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(481, 583);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 22;
            this.button3.Text = "&Exit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(993, 688);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DatePicker);
            this.Controls.Add(this.TotalUnitsLabel);
            this.Controls.Add(this.EncoderTextBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.SubjectDataGridView);
            this.Controls.Add(this.EDPCodeTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SubjectDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox IDNoTextBox;
        private System.Windows.Forms.Label CourseLabel;
        private System.Windows.Forms.Label YearLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox EDPCodeTextBox;
        private System.Windows.Forms.DataGridView SubjectDataGridView;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox EncoderTextBox;
        private System.Windows.Forms.TextBox TotalUnitsLabel;
        private System.Windows.Forms.DateTimePicker DatePicker;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn EDPCodeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectCodeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartTimeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndTimeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DaysColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitsColumn;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button button3;
    }
}