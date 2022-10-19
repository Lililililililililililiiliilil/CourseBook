using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Coursebook
{
    public partial class Form1 : Form
    {

        SqlDataAdapter sqlDataAdapter, sqlDataAdapter2, sqlDataAdapter3;
        DataTable sTable, sTable2, sTable3;

        private void button2_Click(object sender, EventArgs e)
        {
            List<string> titles = new List<string>();


            foreach (DataGridViewRow row in Themes.SelectedRows)
            {
                titles.Add("'" + Convert.ToString(row.Cells["Title"].Value) + "'");

            }
            string combinedString = string.Join(",", titles);
            string search_q = '(' + combinedString + ')';

            SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-OCBBIGC\SQLEXPRESS; Initial Catalog = CourseBookV2; Integrated Security=True");
            sqlConnection.Open();

            string sql = "SELECT ID, Hard FROM" ;
            sql += "(SELECT ID, Hard, PREV FROM ";
            sql += "(SELECT  TOP 1 Task.ID AS ID, Hard = 'на 3', PREV = 0 FROM Task JOIN Paragraph ON Task.Paragraph_ID = Paragraph.ID WHERE Paragraph.Title IN " + search_q + " AND Task.Type = 'Задача на 3' ORDER BY NEWID()) a ";
            sql += "UNION ";
            sql += "SELECT ID, Hard, PREV FROM ";
            sql += "(SELECT  TOP 1 Task.ID, Hard = 'на 4', PREV = 1 FROM Task JOIN Paragraph ON Task.Paragraph_ID = Paragraph.ID WHERE Paragraph.Title IN " + search_q + " AND Task.Type = 'Задача на 4' ORDER BY NEWID()) b ";
            sql += "UNION ";
            sql += "SELECT ID, Hard, PREV FROM ";
            sql += "(SELECT  TOP 1 Task.ID, Hard = 'на 5', PREV = 2 FROM Task JOIN Paragraph ON Task.Paragraph_ID = Paragraph.ID WHERE Paragraph.Title IN " + search_q + " AND Task.Type = 'Задача на 5' ORDER BY NEWID()) c ";
            sql += "UNION ";
            sql += "SELECT ID, Hard,PREV FROM ";
            sql += "(SELECT  TOP 1 Task.ID, Hard = '*', PREV = 3 FROM Task JOIN Paragraph ON Task.Paragraph_ID = Paragraph.ID WHERE Paragraph.Title IN " + search_q + " AND Task.Type = 'Задача*' ORDER BY NEWID()) d ";
            sql += ") x ORDER BY PREV";

            sqlDataAdapter = new SqlDataAdapter(sql, sqlConnection);
            sTable = new DataTable();
            sqlDataAdapter.Fill(sTable);
            new SqlCommandBuilder(sqlDataAdapter);
            Test.DataSource = sTable;
            Test.Columns[0].Width = 35;
            Test.Columns[0].HeaderText = "№";
            Test.Columns[1].Width = 69;
            Test.Columns[1].HeaderText = "______";

            List<string> used = new List<string>();

            foreach (DataGridViewRow row in Test.Rows)
            {
                used.Add(Convert.ToString(row.Cells["ID"].Value));
            }

            used.RemoveAt(used.Count - 1);
            string used_str = '(' + string.Join(",", used) + ')';

            sql = "SELECT ID, Hard FROM ";
            sql += "(SELECT ID, Hard, PREV FROM ";
            sql += "(SELECT  TOP 1 Task.ID, Hard = 'на 3', PREV = 0 FROM Task JOIN Paragraph ON Task.Paragraph_ID = Paragraph.ID WHERE Paragraph.Title IN " + search_q + " AND Task.Type = 'Задача на 3' AND Task.ID NOT IN " + used_str + " ORDER BY NEWID()) a ";
            sql += "UNION ";
            sql += "SELECT * FROM ";
            sql += "(SELECT  TOP 1 Task.ID, Hard = 'на 4', PREV = 1 FROM Task JOIN Paragraph ON Task.Paragraph_ID = Paragraph.ID WHERE Paragraph.Title IN " + search_q + " AND Task.Type = 'Задача на 4' AND Task.ID NOT IN " + used_str + " ORDER BY NEWID()) a ";
            sql += "UNION ";
            sql += "SELECT * FROM ";
            sql += "(SELECT  TOP 1 Task.ID, Hard = 'на 5', PREV = 2 FROM Task JOIN Paragraph ON Task.Paragraph_ID = Paragraph.ID WHERE Paragraph.Title IN " + search_q + " AND Task.Type = 'Задача на 5' AND Task.ID NOT IN " + used_str + " ORDER BY NEWID()) a ";
            sql += "UNION ";
            sql += "SELECT * FROM ";
            sql += "(SELECT  TOP 1 Task.ID, Hard = '*', PREV = 3 FROM Task JOIN Paragraph ON Task.Paragraph_ID = Paragraph.ID WHERE Paragraph.Title IN " + search_q + " AND Task.Type = 'Задача*' AND Task.ID NOT IN " + used_str + " ORDER BY NEWID()) b ";
            sql += ") x ORDER BY PREV";



            sqlDataAdapter2 = new SqlDataAdapter(sql, sqlConnection);
            sTable2 = new DataTable();
            sqlDataAdapter2.Fill(sTable2);
            new SqlCommandBuilder(sqlDataAdapter2);
            Test2.DataSource = sTable2;
            Test2.Columns[0].Width = 35;
            Test2.Columns[0].HeaderText = "№";
            Test2.Columns[1].Width = 69;
            Test2.Columns[1].HeaderText = "______";

            used.Clear();


            foreach (DataGridViewRow row in Test2.Rows)
            {
                used.Add(Convert.ToString(row.Cells["ID"].Value));
            }



            used.RemoveAt(used.Count - 1);
            used_str = '(' + string.Join(",", used) + ')';

            sql = "SELECT ID, Hard FROM ";
            sql += "(SELECT ID, Hard, PREV FROM ";
            sql += "(SELECT  TOP 1 Task.ID, Hard = 'на 3', PREV = 0 FROM Task JOIN Paragraph ON Task.Paragraph_ID = Paragraph.ID WHERE Paragraph.Title IN " + search_q + " AND Task.Type = 'Задача на 3' AND Task.ID NOT IN " + used_str + " ORDER BY NEWID()) a ";
            sql += "UNION ";
            sql += "SELECT * FROM ";
            sql += "(SELECT  TOP 1 Task.ID, Hard = 'на 4', PREV = 1 FROM Task JOIN Paragraph ON Task.Paragraph_ID = Paragraph.ID WHERE Paragraph.Title IN " + search_q + " AND Task.Type = 'Задача на 4' AND Task.ID NOT IN " + used_str + " ORDER BY NEWID()) a ";
            sql += "UNION ";
            sql += "SELECT * FROM ";
            sql += "(SELECT  TOP 1 Task.ID, Hard = 'на 5', PREV = 2 FROM Task JOIN Paragraph ON Task.Paragraph_ID = Paragraph.ID WHERE Paragraph.Title IN " + search_q + " AND Task.Type = 'Задача на 5' AND Task.ID NOT IN " + used_str + " ORDER BY NEWID()) a ";
            sql += "UNION ";
            sql += "SELECT * FROM ";
            sql += "(SELECT  TOP 1 Task.ID, Hard = '*', PREV = 3 FROM Task JOIN Paragraph ON Task.Paragraph_ID = Paragraph.ID WHERE Paragraph.Title IN " + search_q + " AND Task.Type = 'Задача*' AND Task.ID NOT IN " + used_str + " ORDER BY NEWID()) b ";
            sql += ") x ORDER BY PREV";

            sqlDataAdapter3 = new SqlDataAdapter(sql, sqlConnection);
            sTable3 = new DataTable();
            sqlDataAdapter3.Fill(sTable3);
            new SqlCommandBuilder(sqlDataAdapter3);
            Test3.DataSource = sTable3;
            Test3.Columns[0].Width = 35;
            Test3.Columns[0].HeaderText = "№";
            Test3.Columns[1].Width = 69;
            Test3.Columns[1].HeaderText = "______";

            if (Test.Rows.Count < 5 || Test2.Rows.Count < 5 || Test3.Rows.Count < 5)
            {
                MessageBox.Show("В соседних вариантах совпадают задачи","Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var rand = new Random();
            var themes = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15};
            

            var new_t = themes.OrderBy(x => rand.Next()).Take(3).ToList();

            
      
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-OCBBIGC\SQLEXPRESS; Initial Catalog = CourseBookV2; Integrated Security=True");
            sqlConnection.Open();

            string sql = "SELECT * FROM ";
            sql += "(SELECT TOP 1  ID, Type FROM Task WHERE Paragraph_ID =" + Convert.ToString(new_t[0]) + " AND Type = 'Определение' ORDER BY NEWID()) a ";
            sql += "UNION SELECT * FROM ";
            sql += "(SELECT TOP 1  ID, Type FROM Task WHERE Paragraph_ID =" + Convert.ToString(new_t[1]) + " AND Type = 'Доказательство' ORDER BY NEWID()) b ";
            sql += "UNION SELECT * FROM ";
            sql += "(SELECT TOP 1 ID, CASE WHEN Type LIKE 'Задача%' THEN 'Задача' ELSE 'Задача' END AS Type FROM Task WHERE Paragraph_ID=" + Convert.ToString(new_t[2]) + " AND Type LIKE 'Задача на%' ORDER BY NEWID()) c ";
            sql += "ORDER BY Type DESC";

            sqlDataAdapter = new SqlDataAdapter(sql, sqlConnection);
            sTable = new DataTable();
            sqlDataAdapter.Fill(sTable);
            new SqlCommandBuilder(sqlDataAdapter);
            exam1.DataSource = sTable;
            exam1.Columns[0].Width = 35;
            exam1.Columns[0].HeaderText = "№";
            exam1.Columns[1].Width = 140;
            exam1.Columns[1].HeaderText = "______";


            new_t = themes.OrderBy(x => rand.Next()).Take(3).ToList();

            sql = "SELECT * FROM ";
            sql += "(SELECT TOP 1  ID, Type FROM Task WHERE Paragraph_ID =" + Convert.ToString(new_t[0]) + " AND Type = 'Определение' ORDER BY NEWID()) a ";
            sql += "UNION SELECT * FROM ";
            sql += "(SELECT TOP 1  ID, Type FROM Task WHERE Paragraph_ID =" + Convert.ToString(new_t[1]) + " AND Type = 'Доказательство' ORDER BY NEWID()) b ";
            sql += "UNION SELECT * FROM ";
            sql += "(SELECT TOP 1 ID,CASE WHEN Type LIKE 'Задача%' THEN 'Задача' ELSE 'Задача' END AS Type FROM Task WHERE Paragraph_ID=" + Convert.ToString(new_t[2]) + " AND Type LIKE 'Задача на%' ORDER BY NEWID()) c ";
            sql += "ORDER BY Type DESC";

            sqlDataAdapter2 = new SqlDataAdapter(sql, sqlConnection);
            sTable2 = new DataTable();
            sqlDataAdapter2.Fill(sTable2);
            new SqlCommandBuilder(sqlDataAdapter2);
            exam2.DataSource = sTable2;
            exam2.Columns[0].Width = 35;
            exam2.Columns[0].HeaderText = "№";
            exam2.Columns[1].Width = 140;
            exam2.Columns[1].HeaderText = "______";

            new_t = themes.OrderBy(x => rand.Next()).Take(3).ToList();

            sql = "SELECT * FROM ";
            sql += "(SELECT TOP 1  ID, Type FROM Task WHERE Paragraph_ID =" + Convert.ToString(new_t[0]) + " AND Type = 'Определение' ORDER BY NEWID()) a ";
            sql += "UNION SELECT * FROM ";
            sql += "(SELECT TOP 1  ID, Type FROM Task WHERE Paragraph_ID =" + Convert.ToString(new_t[1]) + " AND Type = 'Доказательство' ORDER BY NEWID()) b ";
            sql += "UNION SELECT * FROM ";
            sql += "(SELECT TOP 1 ID,CASE WHEN Type LIKE 'Задача%' THEN 'Задача' ELSE 'Задача' END AS Type FROM Task WHERE Paragraph_ID=" + Convert.ToString(new_t[2]) + " AND Type LIKE 'Задача на%' ORDER BY NEWID()) c ";
            sql += "ORDER BY Type DESC";

            sqlDataAdapter3 = new SqlDataAdapter(sql, sqlConnection);
            sTable3 = new DataTable();
            sqlDataAdapter3.Fill(sTable3);
            new SqlCommandBuilder(sqlDataAdapter3);
            exam3.DataSource = sTable3;
            exam3.Columns[0].Width = 35;
            exam3.Columns[0].HeaderText = "№";
            exam3.Columns[1].Width = 140;
            exam3.Columns[1].HeaderText = "______";

        }

        private void Colloc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-OCBBIGC\SQLEXPRESS; Initial Catalog = CourseBookV2; Integrated Security=True");
            sqlConnection.Open();

            sqlDataAdapter = new SqlDataAdapter("SELECT * FROM Paragraph", sqlConnection);
            sTable = new DataTable();
            sqlDataAdapter.Fill(sTable);
            new SqlCommandBuilder(sqlDataAdapter);
            Themes.DataSource = sTable;
            Themes.Columns[0].Visible = false;
            Themes.Columns[2].Visible = false;
            Themes.Columns[1].Width = 300;
            Themes.Columns[1].HeaderText = "Темы";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> titles = new List<string>();


            foreach (DataGridViewRow row in Themes.SelectedRows)
            {
                titles.Add("'" + Convert.ToString(row.Cells["Title"].Value) + "'");

            }
            string combinedString = string.Join(",", titles);
            string search_q = '(' + combinedString + ')';

            SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-OCBBIGC\SQLEXPRESS; Initial Catalog = CourseBookV2; Integrated Security=True");
            sqlConnection.Open();

            string sql = "SELECT * FROM ";
            sql += "(SELECT  TOP 2 Task.ID FROM Task JOIN Paragraph ON Task.Paragraph_ID = Paragraph.ID WHERE Paragraph.Title IN " + search_q +" AND Task.Type = 'Определение' ORDER BY NEWID()) a ";
            sql += "UNION SELECT * FROM ";
            sql += "(SELECT  TOP 1 Task.ID FROM Task JOIN Paragraph ON Task.Paragraph_ID = Paragraph.ID WHERE Paragraph.Title IN " + search_q + " AND Task.Type = 'Доказательство' ORDER BY NEWID()) b ";
            sql += "UNION SELECT * FROM ";
            sql += "(SELECT  TOP 1 Task.ID FROM Task JOIN Paragraph ON Task.Paragraph_ID = Paragraph.ID WHERE Paragraph.Title IN " + search_q + " AND Task.Type = 'Доказательство*' ORDER BY NEWID()) c ";
            

            sqlDataAdapter = new SqlDataAdapter(sql, sqlConnection);
            sTable = new DataTable();
            sqlDataAdapter.Fill(sTable);
            new SqlCommandBuilder(sqlDataAdapter);
            Colloc.DataSource = sTable;
            Colloc.Columns[0].Width = 104;
            Colloc.Columns[0].HeaderText = "№__________";

            List<string> used = new List<string>();

            foreach (DataGridViewRow row in Colloc.Rows)
            {
                used.Add(Convert.ToString(row.Cells["ID"].Value));
            }

            used.RemoveAt(used.Count - 1);
            string used_str = '(' + string.Join(",", used) + ')';

            sql = "SELECT * FROM ";
            sql += "(SELECT  TOP 2 Task.ID FROM Task JOIN Paragraph ON Task.Paragraph_ID = Paragraph.ID WHERE Paragraph.Title IN " + search_q + " AND Task.Type = 'Определение' AND Task.ID NOT IN " + used_str + " ORDER BY NEWID()) a ";
            sql += "UNION SELECT * FROM ";
            sql += "(SELECT  TOP 1 Task.ID FROM Task JOIN Paragraph ON Task.Paragraph_ID = Paragraph.ID WHERE Paragraph.Title IN " + search_q + " AND Task.Type = 'Доказательство' AND Task.ID NOT IN " + used_str + " ORDER BY NEWID()) b ";
            sql += "UNION SELECT * FROM ";
            sql += "(SELECT  TOP 1 Task.ID FROM Task JOIN Paragraph ON Task.Paragraph_ID = Paragraph.ID WHERE Paragraph.Title IN " + search_q + " AND Task.Type = 'Доказательство*' AND Task.ID NOT IN " + used_str + " ORDER BY NEWID()) c ";



            sqlDataAdapter2 = new SqlDataAdapter(sql, sqlConnection);
            sTable2 = new DataTable();
            sqlDataAdapter2.Fill(sTable2);
            new SqlCommandBuilder(sqlDataAdapter2);
            Colloc2.DataSource = sTable2;
            Colloc2.Columns[0].Width = 104;
            Colloc2.Columns[0].HeaderText = "№__________";

            used.Clear();
           

            foreach (DataGridViewRow row in Colloc2.Rows)
            {
                used.Add(Convert.ToString(row.Cells["ID"].Value));
            }

           



            used.RemoveAt(used.Count - 1);
            used_str = '(' + string.Join(",", used) + ')';

            sql = "SELECT * FROM ";
            sql += "(SELECT  TOP 2 Task.ID FROM Task JOIN Paragraph ON Task.Paragraph_ID = Paragraph.ID WHERE Paragraph.Title IN " + search_q + " AND Task.Type = 'Определение' AND Task.ID NOT IN " + used_str + " ORDER BY NEWID()) a ";
            sql += "UNION SELECT * FROM ";
            sql += "(SELECT  TOP 1 Task.ID FROM Task JOIN Paragraph ON Task.Paragraph_ID = Paragraph.ID WHERE Paragraph.Title IN " + search_q + " AND Task.Type = 'Доказательство' AND Task.ID NOT IN " + used_str + " ORDER BY NEWID()) b ";
            sql += "UNION SELECT * FROM ";
            sql += "(SELECT  TOP 1 Task.ID FROM Task JOIN Paragraph ON Task.Paragraph_ID = Paragraph.ID WHERE Paragraph.Title IN " + search_q + " AND Task.Type = 'Доказательство*' AND Task.ID NOT IN " + used_str + " ORDER BY NEWID()) c ";

            sqlDataAdapter3 = new SqlDataAdapter(sql, sqlConnection);
            sTable3 = new DataTable();
            sqlDataAdapter3.Fill(sTable3);
            new SqlCommandBuilder(sqlDataAdapter3);
            Colloc3.DataSource = sTable3;
            Colloc3.Columns[0].Width = 104;
            Colloc3.Columns[0].HeaderText = "№__________";
            if (Colloc.Rows.Count < 5 || Colloc2.Rows.Count < 5 || Colloc3.Rows.Count < 5)
            {
                MessageBox.Show("В соседних вариантах совпадают задачи", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
