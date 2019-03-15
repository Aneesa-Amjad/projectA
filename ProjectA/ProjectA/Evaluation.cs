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

namespace ProjectA
{
    public partial class Evaluation : Form
    {
        public Evaluation()
        {
            InitializeComponent();
            string eval = "select * from evaluation";
            SqlConnection connection = new SqlConnection(conStr);
            SqlDataAdapter com = new SqlDataAdapter();
            com.SelectCommand = new SqlCommand(eval, connection);
            DataTable data = new DataTable();
            com.Fill(data);
            BindingSource n = new BindingSource();
            n.DataSource = data;
            evaluationdata.DataSource = n;
        }
        public string conStr = "Data Source=DESKTOP-CMKQCBQ;Initial Catalog=ProjectA;Integrated Security=True";
        private void cmdenter_Click(object sender, EventArgs e)
        {
            string Name = txtname.Text;
            string TotalMarks = txttotal.Text;
            string TotalWeightage = txtweightage.Text;
            SqlConnection connection = new SqlConnection(conStr);
            connection.Open();
            if (connection.State == ConnectionState.Open)
            {
                string q = "insert into Evaluation(Name,TotalMarks,TotalWeightage) values('" + txtname.Text + "','" + txttotal.Text + "','" + txtweightage.Text + "' )";
                SqlCommand cmd = new SqlCommand(q, connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Entered");
            }
            string eval = "select * from evaluation";
            SqlDataAdapter com = new SqlDataAdapter();
            com.SelectCommand = new SqlCommand(eval, connection);
            DataTable data = new DataTable();
            com.Fill(data);
            BindingSource n = new BindingSource();
            n.DataSource = data;
            evaluationdata.DataSource = n;
            txtname.Text = "";
            txttotal.Text = "";
            txtweightage.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main m = new Main();
            m.Show();
            this.Hide();
        }

        private void evaluationdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {

                SqlConnection connection = new SqlConnection(conStr);
                connection.Open();
                string q = "delete from Evaluation where Name = '" + evaluationdata.Rows[e.RowIndex].Cells[3].Value.ToString() + "' ";
                SqlCommand cmd = new SqlCommand(q, connection);
                cmd.ExecuteNonQuery();
                string pro = "select * from project";
                SqlConnection conn = new SqlConnection(conStr);
                SqlDataAdapter com = new SqlDataAdapter();
                com.SelectCommand = new SqlCommand(pro, conn);
                DataTable data = new DataTable();
                com.Fill(data);
                BindingSource n = new BindingSource();
                n.DataSource = data;
                evaluationdata.DataSource = n;
                MessageBox.Show("Delete");
            }
        }
    }
}
