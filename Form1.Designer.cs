namespace Enrollment_System
{
    partial class Form1
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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SubjectCodeTextBox = new System.Windows.Forms.TextBox();
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.UnitsTextBox = new System.Windows.Forms.TextBox();
            this.CurriculumYearTextBox = new System.Windows.Forms.TextBox();
            this.OfferingComboBox = new System.Windows.Forms.ComboBox();
            this.CourseCodeComboBox = new System.Windows.Forms.ComboBox();
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SubjectDataGridView = new System.Windows.Forms.DataGridView();
            this.SubjectCodeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescriptionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OfferingColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourseCodeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CurriculumColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nextButton = new System.Windows.Forms.Button();
            this.RequisiteTextBox = new System.Windows.Forms.TextBox();
            this.CoReqRB = new System.Windows.Forms.RadioButton();
            this.PreReqRB = new System.Windows.Forms.RadioButton();
            this.saveButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SubjectDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Subject Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(77, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(121, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Units";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(434, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Offering";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(425, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Category";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(401, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Course Code";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(390, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Curiculum Year";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(74, 312);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Subject Code";
            // 
            // SubjectCodeTextBox
            // 
            this.SubjectCodeTextBox.Location = new System.Drawing.Point(179, 69);
            this.SubjectCodeTextBox.Name = "SubjectCodeTextBox";
            this.SubjectCodeTextBox.Size = new System.Drawing.Size(100, 22);
            this.SubjectCodeTextBox.TabIndex = 8;
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Location = new System.Drawing.Point(179, 111);
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Size = new System.Drawing.Size(100, 22);
            this.DescriptionTextBox.TabIndex = 9;
            // 
            // UnitsTextBox
            // 
            this.UnitsTextBox.Location = new System.Drawing.Point(179, 150);
            this.UnitsTextBox.Name = "UnitsTextBox";
            this.UnitsTextBox.Size = new System.Drawing.Size(100, 22);
            this.UnitsTextBox.TabIndex = 10;
            // 
            // CurriculumYearTextBox
            // 
            this.CurriculumYearTextBox.Location = new System.Drawing.Point(507, 189);
            this.CurriculumYearTextBox.Name = "CurriculumYearTextBox";
            this.CurriculumYearTextBox.Size = new System.Drawing.Size(100, 22);
            this.CurriculumYearTextBox.TabIndex = 11;
            // 
            // OfferingComboBox
            // 
            this.OfferingComboBox.FormattingEnabled = true;
            this.OfferingComboBox.Items.AddRange(new object[] {
            "1st-Sem",
            "2nd-Sem"});
            this.OfferingComboBox.Location = new System.Drawing.Point(507, 65);
            this.OfferingComboBox.Name = "OfferingComboBox";
            this.OfferingComboBox.Size = new System.Drawing.Size(121, 24);
            this.OfferingComboBox.TabIndex = 12;
            // 
            // CourseCodeComboBox
            // 
            this.CourseCodeComboBox.FormattingEnabled = true;
            this.CourseCodeComboBox.Items.AddRange(new object[] {
            "BSIT",
            "BSIS",
            "BSCRIM",
            "NURSING",
            "HM",
            "MIDTECH",
            "ACT",
            "BEED",
            "BSBA",
            "BSED",
            "MIDWIFE",
            "TOURISM",
            "PSYCH",
            "COMPSCI",
            "ENGINEERING"});
            this.CourseCodeComboBox.Location = new System.Drawing.Point(507, 149);
            this.CourseCodeComboBox.Name = "CourseCodeComboBox";
            this.CourseCodeComboBox.Size = new System.Drawing.Size(121, 24);
            this.CourseCodeComboBox.TabIndex = 13;
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Items.AddRange(new object[] {
            "LEC",
            "LAB"});
            this.CategoryComboBox.Location = new System.Drawing.Point(507, 106);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(121, 24);
            this.CategoryComboBox.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.SubjectDataGridView);
            this.groupBox1.Controls.Add(this.nextButton);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.RequisiteTextBox);
            this.groupBox1.Controls.Add(this.CoReqRB);
            this.groupBox1.Controls.Add(this.PreReqRB);
            this.groupBox1.Controls.Add(this.saveButton);
            this.groupBox1.Controls.Add(this.clearButton);
            this.groupBox1.Controls.Add(this.OfferingComboBox);
            this.groupBox1.Controls.Add(this.CategoryComboBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.CourseCodeComboBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.CurriculumYearTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.UnitsTextBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.DescriptionTextBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.SubjectCodeTextBox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(36, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(982, 622);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(8, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(196, 27);
            this.label10.TabIndex = 19;
            this.label10.Text = "Subject Information";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(14, 242);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(232, 37);
            this.label9.TabIndex = 18;
            this.label9.Text = "Student Information";
            // 
            // SubjectDataGridView
            // 
            this.SubjectDataGridView.BackgroundColor = System.Drawing.Color.LightGray;
            this.SubjectDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SubjectDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SubjectCodeColumn,
            this.DescriptionColumn,
            this.UnitsColumn,
            this.OfferingColumn,
            this.CategoryColumn,
            this.CourseCodeColumn,
            this.CurriculumColumn});
            this.SubjectDataGridView.Location = new System.Drawing.Point(18, 337);
            this.SubjectDataGridView.Name = "SubjectDataGridView";
            this.SubjectDataGridView.RowHeadersWidth = 51;
            this.SubjectDataGridView.RowTemplate.Height = 24;
            this.SubjectDataGridView.Size = new System.Drawing.Size(945, 178);
            this.SubjectDataGridView.TabIndex = 11;
            // 
            // SubjectCodeColumn
            // 
            this.SubjectCodeColumn.HeaderText = "Subject Code";
            this.SubjectCodeColumn.MinimumWidth = 6;
            this.SubjectCodeColumn.Name = "SubjectCodeColumn";
            this.SubjectCodeColumn.ReadOnly = true;
            this.SubjectCodeColumn.Width = 125;
            // 
            // DescriptionColumn
            // 
            this.DescriptionColumn.HeaderText = "Description";
            this.DescriptionColumn.MinimumWidth = 6;
            this.DescriptionColumn.Name = "DescriptionColumn";
            this.DescriptionColumn.ReadOnly = true;
            this.DescriptionColumn.Width = 125;
            // 
            // UnitsColumn
            // 
            this.UnitsColumn.HeaderText = "Units";
            this.UnitsColumn.MinimumWidth = 6;
            this.UnitsColumn.Name = "UnitsColumn";
            this.UnitsColumn.ReadOnly = true;
            this.UnitsColumn.Width = 125;
            // 
            // OfferingColumn
            // 
            this.OfferingColumn.HeaderText = "Offering";
            this.OfferingColumn.MinimumWidth = 6;
            this.OfferingColumn.Name = "OfferingColumn";
            this.OfferingColumn.ReadOnly = true;
            this.OfferingColumn.Width = 125;
            // 
            // CategoryColumn
            // 
            this.CategoryColumn.HeaderText = "Category";
            this.CategoryColumn.MinimumWidth = 6;
            this.CategoryColumn.Name = "CategoryColumn";
            this.CategoryColumn.ReadOnly = true;
            this.CategoryColumn.Width = 125;
            // 
            // CourseCodeColumn
            // 
            this.CourseCodeColumn.HeaderText = "Course Code";
            this.CourseCodeColumn.MinimumWidth = 6;
            this.CourseCodeColumn.Name = "CourseCodeColumn";
            this.CourseCodeColumn.ReadOnly = true;
            this.CourseCodeColumn.Width = 125;
            // 
            // CurriculumColumn
            // 
            this.CurriculumColumn.HeaderText = "Curriculum";
            this.CurriculumColumn.MinimumWidth = 6;
            this.CurriculumColumn.Name = "CurriculumColumn";
            this.CurriculumColumn.ReadOnly = true;
            this.CurriculumColumn.Width = 125;
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(481, 555);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(75, 23);
            this.nextButton.TabIndex = 17;
            this.nextButton.Text = "&Next";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // RequisiteTextBox
            // 
            this.RequisiteTextBox.Location = new System.Drawing.Point(179, 309);
            this.RequisiteTextBox.Name = "RequisiteTextBox";
            this.RequisiteTextBox.Size = new System.Drawing.Size(100, 22);
            this.RequisiteTextBox.TabIndex = 8;
            this.RequisiteTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RequisiteTextBox_KeyPress);
            // 
            // CoReqRB
            // 
            this.CoReqRB.AutoSize = true;
            this.CoReqRB.Location = new System.Drawing.Point(481, 312);
            this.CoReqRB.Name = "CoReqRB";
            this.CoReqRB.Size = new System.Drawing.Size(106, 20);
            this.CoReqRB.TabIndex = 9;
            this.CoReqRB.TabStop = true;
            this.CoReqRB.Text = "Co-Requisite";
            this.CoReqRB.UseVisualStyleBackColor = true;
            // 
            // PreReqRB
            // 
            this.PreReqRB.AutoSize = true;
            this.PreReqRB.Location = new System.Drawing.Point(481, 277);
            this.PreReqRB.Name = "PreReqRB";
            this.PreReqRB.Size = new System.Drawing.Size(110, 20);
            this.PreReqRB.TabIndex = 10;
            this.PreReqRB.TabStop = true;
            this.PreReqRB.Text = "Pre-Requisite";
            this.PreReqRB.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(88, 555);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 16;
            this.saveButton.Text = "&Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(287, 555);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 15;
            this.clearButton.Text = "&Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1058, 757);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SubjectDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox SubjectCodeTextBox;
        private System.Windows.Forms.TextBox DescriptionTextBox;
        private System.Windows.Forms.TextBox UnitsTextBox;
        private System.Windows.Forms.TextBox CurriculumYearTextBox;
        private System.Windows.Forms.ComboBox OfferingComboBox;
        private System.Windows.Forms.ComboBox CourseCodeComboBox;
        private System.Windows.Forms.ComboBox CategoryComboBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.DataGridView SubjectDataGridView;
        private System.Windows.Forms.RadioButton PreReqRB;
        private System.Windows.Forms.RadioButton CoReqRB;
        private System.Windows.Forms.TextBox RequisiteTextBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectCodeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescriptionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitsColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn OfferingColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseCodeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CurriculumColumn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}

