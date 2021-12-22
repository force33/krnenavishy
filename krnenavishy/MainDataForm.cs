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

namespace krnenavishy
{
    public partial class MainDataForm : Form
    {
        public MainDataForm()
        {
            InitializeComponent();
        }
        public string connectionString = "Server=localhost;Database=kr;Trusted_Connection=True";
        public int firstItem = 3018;
        public int pageNumber;
        public int GenderIndex = 0;
        public void Query(string command) 
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command, connectionString);
            SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
            sqlConnection.Close();
        }
        public void QueryMax(string command, out int result)
        {
            //string command1 = "SELECT MAX(id) FROM Client";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);
            result = (int)sqlCommand.ExecuteScalar();
            sqlConnection.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            string command = "select * from Client";
            Query(command);

            string command1 = "SELECT MAX(id) FROM Client";
            int result;
            QueryMax(command1, out result);

            amountOfLabel.Text = result + " / " + result;
        }

        private void allDataButton_Click(object sender, EventArgs e)
        {
            string command = "select * from Client";
            Query(command);

            string command1 = "SELECT MAX(id) FROM Client";
            int result;
            QueryMax(command1, out result);

            amountOfLabel.Text = result + " / " + result;
        }

        private void backPageButton_Click(object sender, EventArgs e)
        {
            string command = "select * from Client where id >= 3018 and id <= " + firstItem.ToString() + "";
            Query(command);
        }

        private void nextPageButton_Click(object sender, EventArgs e)
        {
            string command = "select * from Client where id >=  and id <= 3117";
            Query(command);
        }

        private void searchInfoButton_Click(object sender, EventArgs e)
        {
            string command = "SELECT MAX(id) FROM Client";
            int result;
            QueryMax(command, out result);

            int temp = 3018 + Convert.ToInt32(amountTB.Text);
            string command1 = "select * from Client where id >= 3018 and id < " + temp + "";
            Query(command1);
            pageNumber = Convert.ToInt32(amountTB.Text) + 3017;
            amountOfLabel.Text = pageNumber + " / " + result;
        }

        private void mGenderButton_Click(object sender, EventArgs e)
        {
            GenderIndex = 1;

            string command = "select * from Client where GenderCode = 1";
            Query(command);

            string command1 = "SELECT MAX(id) FROM Client";
            int result;
            QueryMax(command1, out result);

            int total = result - dataGridView1.Rows.Count;
            amountOfLabel.Text = total + " / " + result;
        }

        private void wGenderButton_Click(object sender, EventArgs e)
        {
            GenderIndex = 2;

            string command = "select * from Client where GenderCode = 0";
            Query(command);

            string command1 = "SELECT MAX(id) FROM Client";
            int result;
            QueryMax(command1, out result);

            int total = result - dataGridView1.Rows.Count;
            amountOfLabel.Text = total + " / " + result;
        }

        private void searchTB_Click(object sender, EventArgs e)
        {
            searchTB.Text = "";
        }

        private void searchTB_KeyUp(object sender, KeyEventArgs e)
        {
            string param = searchTB.Text;
            int index = wordCB.SelectedIndex;
            if (index == 0) //ФИО
            {
                if (GenderIndex == 0)
                {
                    string command1 = "select * from Client where FirstName like '" + param + "%'";
                    Query(command1);

                    string command11 = "SELECT MAX(id) FROM Client";
                    int result1;
                    QueryMax(command11, out result1);

                    int total1 = result1 - dataGridView1.Rows.Count;
                    amountOfLabel.Text = total1 + " / " + result1;
                }
                else if (GenderIndex == 1)
                {
                    string command1 = "select * from Client where FirstName like '" + param + "%' and GenderCode = 1";
                    Query(command1);

                    string command11 = "SELECT MAX(id) FROM Client";
                    int result1;
                    QueryMax(command11, out result1);

                    int total1 = result1 - dataGridView1.Rows.Count;
                    amountOfLabel.Text = total1 + " / " + result1;
                }
                else if (GenderIndex == 2)
                {
                    string command1 = "select * from Client where FirstName like '" + param + "%' and GenderCode = 0";
                    Query(command1);

                    string command11 = "SELECT MAX(id) FROM Client";
                    int result1;
                    QueryMax(command11, out result1);

                    int total1 = result1 - dataGridView1.Rows.Count;
                    amountOfLabel.Text = total1 + " / " + result1;
                }
            }
            else if (index == 1) //почта
            {
                if (GenderIndex == 0)
                {
                    string command2 = "select * from Client where Email like '" + param + "%'";
                    Query(command2);

                    string command22 = "SELECT MAX(id) FROM Client";
                    int result2;
                    QueryMax(command22, out result2);

                    int total2 = result2 - dataGridView1.Rows.Count;
                    amountOfLabel.Text = total2 + " / " + result2;
                }
                else if (GenderIndex == 1)
                {
                    string command2 = "select * from Client where Email like '" + param + "%' and GenderCode = 1";
                    Query(command2);

                    string command22 = "SELECT MAX(id) FROM Client";
                    int result2;
                    QueryMax(command22, out result2);

                    int total2 = result2 - dataGridView1.Rows.Count;
                    amountOfLabel.Text = total2 + " / " + result2;
                }
                else if (GenderIndex == 2)
                {
                    string command2 = "select * from Client where Email like '" + param + "%' and GenderCode = 0";
                    Query(command2);

                    string command22 = "SELECT MAX(id) FROM Client";
                    int result2;
                    QueryMax(command22, out result2);

                    int total2 = result2 - dataGridView1.Rows.Count;
                    amountOfLabel.Text = total2 + " / " + result2;
                }

                //string command = "select * from Client where Email like '" + param + "%'";
                //Query(command);

                //string command1 = "SELECT MAX(id) FROM Client";
                //int result;
                //QueryMax(command1, out result);

                //int total = result - dataGridView1.Rows.Count;
                //amountOfLabel.Text = total + " / " + result;
            }
            else if (index == 2) //телефон
            {
                if (GenderIndex == 0)
                {
                    string command3 = "select * from Client where Phone like '" + param + "%'";
                    Query(command3);

                    string command33 = "SELECT MAX(id) FROM Client";
                    int result3;
                    QueryMax(command33, out result3);

                    int total3 = result3 - dataGridView1.Rows.Count;
                    amountOfLabel.Text = total3 + " / " + result3;
                }
                else if (GenderIndex == 1)
                {
                    string command3 = "select * from Client where Phone like '" + param + "%' and GenderCode = 1";
                    Query(command3);

                    string command33 = "SELECT MAX(id) FROM Client";
                    int result3;
                    QueryMax(command33, out result3);

                    int total3 = result3 - dataGridView1.Rows.Count;
                    amountOfLabel.Text = total3 + " / " + result3;
                }
                else if (GenderIndex == 2)
                {
                    string command3 = "select * from Client where Phone like '" + param + "%' and GenderCode = 0";
                    Query(command3);

                    string command33 = "SELECT MAX(id) FROM Client";
                    int result3;
                    QueryMax(command33, out result3);

                    int total3 = result3 - dataGridView1.Rows.Count;
                    amountOfLabel.Text = total3 + " / " + result3;
                }

                //string command = "select * from Client where Phone like '" + param + "%'";
                //Query(command);

                //string command1 = "SELECT MAX(id) FROM Client";
                //int result;
                //QueryMax(command1, out result);

                //int total = result - dataGridView1.Rows.Count;
                //amountOfLabel.Text = total + " / " + result;
            }
        }

        private void nullGenderButton_Click(object sender, EventArgs e)
        {
            GenderIndex = 0;

            string command = "select * from Client";
            Query(command);

            string command1 = "SELECT MAX(id) FROM Client";
            int result;
            QueryMax(command1, out result);

            amountOfLabel.Text = result + " / " + result;
        }

        private void surnameFilterButton_Click(object sender, EventArgs e)
        {
            string command = "select * from Client order by FirstName";
            Query(command);

            string command1 = "SELECT MAX(id) FROM Client";
            int result;
            QueryMax(command1, out result);

            int total = result - dataGridView1.Rows.Count;
            amountOfLabel.Text = total + " / " + total;
        }
        private void birthdayButton_Click(object sender, EventArgs e)
        {
            string command = "select * from Client where Birthday = GETDATE()";
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            string command = "select * from Client";

            int a = dataGridView1.CurrentRow.Index;
            dataGridView1.Rows.Remove(dataGridView1.Rows[a]);

            Query(command);
        }
    }
}
