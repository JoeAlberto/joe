using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enrollment_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\ll\Documents\Joe.accdb";
        private void saveButton_Click(object sender, EventArgs e)
        {
            OleDbConnection thisConnection = new OleDbConnection(connectionString);
            string sql = "SELECT * FROM SUBJECTFILE";
            OleDbDataAdapter thisAdapter = new OleDbDataAdapter(sql, thisConnection);
            OleDbCommandBuilder thisBuilder = new OleDbCommandBuilder(thisAdapter);

            DataSet thisDataSet = new DataSet();
            thisAdapter.Fill(thisDataSet, "SubjectFile");

            DataRow thisRow = thisDataSet.Tables["SubjectFile"].NewRow();
            thisRow["SFSUBJCODE"] = SubjectCodeTextBox.Text;
            thisRow["SFSUBJDESC"] = DescriptionTextBox.Text;
            thisRow["SFSUBJUNITS"] = Convert.ToInt16(UnitsTextBox.Text);
            thisRow["SFSUBJCATEGORY"] = CategoryComboBox.Text.Substring(0, 3);
            thisRow["SFSUBJOFRNG"] = Convert.ToUInt16(OfferingComboBox.Text.Substring(0, 1));
            thisRow["SFSUBJCOURSECODE"] = CourseCodeComboBox.Text;
            thisRow["SFSUBJCURRIYEAR"] = CurriculumYearTextBox.Text;


            thisDataSet.Tables["SubjectFile"].Rows.Add(thisRow);
            thisAdapter.Update(thisDataSet, "SubjectFile");
            

            string categ = "";
            categ += PreReqRB.Checked ? "PR" : "CR";

            //requisites
            sql = "SELECT * FROM SUBJECTPREQFILE";
            thisAdapter = new OleDbDataAdapter(sql, thisConnection);
            thisBuilder = new OleDbCommandBuilder(thisAdapter);
            thisDataSet = new DataSet();
            thisAdapter.Fill(thisDataSet, "SubjectPreqFile");
            thisRow = thisDataSet.Tables["SubjectPreqFile"].NewRow();


            thisRow["SUBJCODE"] = SubjectCodeTextBox.Text;
            thisRow["SUBJPRECODE"] = RequisiteTextBox.Text;
            thisRow["SUBJCATEGORY"] = categ;

            thisDataSet.Tables["SubjectPreqFile"].Rows.Add(thisRow);
            thisAdapter.Update(thisDataSet, "SubjectPreqFile");



            MessageBox.Show("Entries Recorded");
        }


        private void KeyPressTextBox(object sender, KeyPressEventArgs e)
        {

        }
        private void nextButton_Click(object sender, EventArgs e)
        {
            Hide();
            Subject_Schedule_Entry subject_Schedule_Entry = new Subject_Schedule_Entry();
            subject_Schedule_Entry.ShowDialog();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            SubjectCodeTextBox.Text = " ";
            DescriptionTextBox.Text = " ";
            UnitsTextBox.Text = " ";
            CategoryComboBox.Text = " ";
            OfferingComboBox.Text = " ";
            CourseCodeComboBox.Text = " ";
            CurriculumYearTextBox.Text = " ";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void RequisiteTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                OleDbConnection thisConnection = new OleDbConnection(connectionString);
                thisConnection.Open();
                OleDbCommand thisCommand = thisConnection.CreateCommand();

                string sql = "SELECT * FROM SubjectFile";
                thisCommand.CommandText = sql;

                OleDbDataReader thisDataReader = thisCommand.ExecuteReader();


                bool found = false;
                string subjectCode = "";
                string description = "";
                string units = "";
                string category = "";

                while (thisDataReader.Read())
                {
                    // MessageBox.Show(thisDataReader["SFSUBJCODE"].ToString());
                    if (thisDataReader["SFSUBJCODE"].ToString().Trim().ToUpper() == RequisiteTextBox.Text.Trim().ToUpper())
                    {
                        found = true;
                        subjectCode = thisDataReader["SFSUBJCODE"].ToString();
                        description = thisDataReader["SFSUBJDESC"].ToString();
                        units = thisDataReader["SFSUBJUNITS"].ToString();
                        break;
                    }
                }
                thisDataReader.Close();
                //subjectpreqfilereader
                sql = "SELECT * FROM SUBJECTPREQFILE";
                thisCommand.CommandText = sql;
                OleDbDataReader anotherDataReader = thisCommand.ExecuteReader();

                while (anotherDataReader.Read())
                {
                    if (anotherDataReader["SUBJCODE"].ToString().Trim().ToUpper() == RequisiteTextBox.Text.Trim().ToUpper())
                    {
                        found = true;
                        category = anotherDataReader["SUBJPRECODE"].ToString();
                        break;
                    }
                }
                        int index;
                if (found == false)
                    MessageBox.Show("Subject Code Not Found");
                else
                {
                    index = SubjectDataGridView.Rows.Add();
                    SubjectDataGridView.Rows[index].Cells["SubjectCodeColumn"].Value = subjectCode;
                    SubjectDataGridView.Rows[index].Cells["DescriptionColumn"].Value = description;
                    SubjectDataGridView.Rows[index].Cells["UnitsColumn"].Value = units;
                    //SubjectDataGridView.Rows[index].Cells["PreRequisiteColumn"].Value = category;
                
            }
                
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
