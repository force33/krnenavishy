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
    public partial class EditForm : Form
    {
        public string connectionString = "Server=localhost;Database=kr;Trusted_Connection=True";
        public EditForm()
        {
            InitializeComponent();
        }

        int index;
        int type;
        string genderType;
        void QueryInsert()
        {
            string command = "insert into Client values " +
                "('" + FirstNameTextBox.Text + "', " +
                "'" + LastNameTextBox.Text + "', " +
                "'" + PatronymicTextBox.Text + "', " +
                "'" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "'," +
                "'" + dateTimePicker2.Value.ToString("yyyy-MM-dd") + "'," +
                "'" + EmailTextBox.Text + "'," +
                "'" + PhoneTextBox.Text + "'," +
                "'" + genderType + "'," +
                "'" + PhotoTextBox.Text + "')";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }

        void QueryUpdate() 
        {
            string command = "update Client set firstname = '" + FirstNameTextBox.Text + "', " +
                "lastname = '" + LastNameTextBox.Text + "', " +
                "Patronymic = '" + PatronymicTextBox.Text + "', " +
                "Birthday = '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "', " +
                "RegistrationDate = '" + dateTimePicker2.Value.ToString("yyyy-MM-dd") + "', " +
                "Email = '" + EmailTextBox.Text + "', " +
                "Phone = '" + PhoneTextBox.Text + "', " +
                "GenderCode = '" + genderType + "'," +
                "PhotoPath = '" + PhotoTextBox.Text + "' where id = '" + IDTextBox.Text + "'";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }
        void VisibleChange(bool all)
        {
            if (all)
            {
                editUserButton.Visible = false;
                newUserButton.Visible = false;
                IDTextBox.Visible = true;
                FirstNameTextBox.Visible = true;
                LastNameTextBox.Visible = true;
                PatronymicTextBox.Visible = true;
                dateTimePicker1.Visible = true;
                dateTimePicker2.Visible = true;
                EmailTextBox.Visible = true;
                PhoneTextBox.Visible = true;
                wRadioButton.Visible = true;
                mRadioButton.Visible = true;
                PhotoTextBox.Visible = true;
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
                label9.Visible = true;
                label10.Visible = true;
                cancelButton.Visible = true;
                saveButton.Visible = true;
            }
            else
            {
                IDTextBox.Visible = false;
                FirstNameTextBox.Visible = false;
                LastNameTextBox.Visible = false;
                PatronymicTextBox.Visible = false;
                dateTimePicker1.Visible = false;
                dateTimePicker2.Visible = false;
                EmailTextBox.Visible = false;
                PhoneTextBox.Visible = false;
                mRadioButton.Visible = false;
                wRadioButton.Visible = false;
                PhotoTextBox.Visible = false;
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
                label9.Visible = false;
                label10.Visible = false;
                cancelButton.Visible = false;
                saveButton.Visible = false;
                editUserButton.Visible = true;
                newUserButton.Visible = true;
            }
        }
        private void EditForm_Load(object sender, EventArgs e)
        {
            VisibleChange(false);

            if (MainDataForm.SelectedID != 0)
            {
                index = MainDataForm.SelectedID;
            }
            FirstNameTextBox.MaxLength = 50;
            LastNameTextBox.MaxLength = 50;
            PatronymicTextBox.MaxLength = 50;
        }

        private void editUserButton_Click(object sender, EventArgs e)
        {
            type = 1;

            string command = "select * from Client where id = " + index + "";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            if (sqlDataReader.HasRows)
            {
                while (sqlDataReader.Read())
                {
                    IDTextBox.Text = Convert.ToString(sqlDataReader.GetValue(0));
                    FirstNameTextBox.Text = Convert.ToString(sqlDataReader.GetValue(1));
                    LastNameTextBox.Text = Convert.ToString(sqlDataReader.GetValue(2));
                    PatronymicTextBox.Text = Convert.ToString(sqlDataReader.GetValue(3));
                    dateTimePicker1.Text = Convert.ToString(sqlDataReader.GetValue(4));
                    dateTimePicker2.Text = Convert.ToString(sqlDataReader.GetValue(5));
                    EmailTextBox.Text = Convert.ToString(sqlDataReader.GetValue(6));
                    PhoneTextBox.Text = Convert.ToString(sqlDataReader.GetValue(7));
                    genderType = Convert.ToString(sqlDataReader.GetValue(8));
                    PhotoTextBox.Text = Convert.ToString(sqlDataReader.GetValue(9));
                }
            }
            sqlConnection.Close();

            VisibleChange(true);

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            VisibleChange(false);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (mRadioButton.Checked)
            {
                genderType = "1";
            }
            else
            {
                genderType= "0";
            }

            if (type == 1)
            {
                QueryUpdate();
                MessageBox.Show("Данные успешно добавлены");
                VisibleChange(false);
            }
            else
            {
                QueryInsert();
                MessageBox.Show("Данные успешно добавлены");
                VisibleChange(false);
            }

            (Owner as MainDataForm).UpdateData();
        }

        private void newUserButton_Click(object sender, EventArgs e)
        {
            type = 0;
            VisibleChange(true);
        }

        private void FirstNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsDigit(e.KeyChar)))
            {
                if (e.KeyChar != (char)Keys.Back || e.KeyChar != (char)Keys.Subtract)
                {
                    e.Handled = true;
                }
            }
        }

        private void LastNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsDigit(e.KeyChar)))
            {
                if (e.KeyChar != (char)Keys.Back || e.KeyChar != (char)Keys.Subtract)
                {
                    e.Handled = true;
                }
            }
        }

        private void PatronymicTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsDigit(e.KeyChar)))
            {
                if (e.KeyChar != (char)Keys.Back || e.KeyChar != (char)Keys.Subtract)
                {
                    e.Handled = true;
                }
            }
        }
    }
}
